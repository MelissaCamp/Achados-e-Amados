using AchadosEamados.BLL;
using AchadosEamados.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AchadosEamados.UI
{
    public partial class frmDeleteAnimalAdm : Form
    {
        AnimalDTO animalDTO = new AnimalDTO();
        AnimalBLL animalBLL = new AnimalBLL();

        string diretorio = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}\animais\";
        string diretorioImagens = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}";

        public frmDeleteAnimalAdm()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            FrmDeleteCatalogoAdm deleteCatalogo = new FrmDeleteCatalogoAdm();
            deleteCatalogo.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Digite um ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtId.Focus();

                return;
            }
            int id = Convert.ToInt32(txtId.Text.Trim());
            animalDTO = animalBLL.PesquisarId(id);
            if (animalDTO != null)
            {
                txtAnimal.Text = animalDTO.Nome.ToString();
                txtDescricao.Text = animalDTO.Descricao.ToString();
                txtIdade.Text = animalDTO.Idade.ToString();
                txtVacinas.Text = animalDTO.EhVacinado.ToString();
                cbTipoAnimal.Text = animalDTO.TpAnimal.ToString();
                txtRaca.Text = animalDTO.Raca.ToString();
                txtSexo.Text = animalDTO.Sexo.ToString();
                dtpCadastro.Text = animalDTO.DtaCadastro.ToString();
                pbAnimal.Text = animalDTO.UrlImgAnimal.ToString();
                CBCastrado.Text = animalDTO.EhCastrado.ToString();
                chekbVacinado.Text = animalDTO.EhVacinado.ToString();
                string nomeImg = $"{pbAnimal.Text}.jpg";

                if (!Directory.Exists(diretorio))
                {
                    Directory.CreateDirectory(diretorio);
                }
                string urlImagem = Path.Combine(diretorio, nomeImg);
                animalDTO.UrlImgAnimal = urlImagem;

                btnDeletar.Enabled = true;
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Tem certeza que deseja tirar o Pet do sistema?", "Excluir Funcionario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                int id = Convert.ToInt32((txtId.Text.Trim()));
                animalBLL.DeleteAnimal(id);
                LimparCampos();
                txtId.Focus();
                MessageBox.Show("Pet retirado do sistema com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void LimparCampos()
        {
            txtAnimal.Text = "";
            txtDescricao.Text = "";
            txtIdade.Text = "";
            txtVacinas.Text = "";
            cbTipoAnimal.Text = "";
            txtRaca.Text = "";
            txtSexo.Text = "";
            dtpCadastro.Text = "";
            pbAnimal.Text = "";
            CBCastrado.Checked = false;
            chekbVacinado.Checked = false;



        }

        private void frmDeleteAnimalAdm_Load(object sender, EventArgs e)
        {
            dtpCadastro.Format = DateTimePickerFormat.Custom;
            dtpCadastro.CustomFormat = "dd/MM/yyyy";
        }

        private void pbAnimal_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(diretorio))
            {
                Directory.CreateDirectory(diretorio);
            }
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = diretorioImagens;

            openFileDialog.Filter = "Arquivos de imagem|*.jpg;*.jpeg;*.png";
            openFileDialog.Title = "Escolha a imagem";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string nomeAquivoImagem = openFileDialog.FileName; pbAnimal.Image = Image.FromFile(nomeAquivoImagem);
            }
        }
    }
}
