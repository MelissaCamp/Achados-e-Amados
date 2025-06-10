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
    public partial class FrmCadastroLogadoAnimalAdm : Form
    {
        AnimalDTO animalDTO = new AnimalDTO();
        AnimalBLL animalBLL = new AnimalBLL();
        FuncionarioDTO funcionario = new FuncionarioDTO();
        string diretorio = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}\\animal\";
        string diretorioImagens = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}";
        public FrmCadastroLogadoAnimalAdm()
        {
            InitializeComponent();
        }
       

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCriarCatalogo principalAdm = new FrmCriarCatalogo();
            principalAdm.ShowDialog();
        }

        private void FrmCadastroLogadoAnimalAdm_Load(object sender, EventArgs e)
        {
            dtpCadastro.Format = DateTimePickerFormat.Custom;
            dtpCadastro.CustomFormat = "dd/MM/yyyy";
        }
        private void LimparForm()
        {
            txtDescricao.Text = "";
            txtIdade.Text = "";
            txtNome.Text = "";
            dtpCadastro.Text = "";
            txtRaca.Text = "";
            txtSexo.Text = "";
            cbTipoAnimal.Text = "";
            chekbVacinado.Checked = false;
        }
        private bool ValidaForm()
        {
            bool valida;
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                txtNome.BackColor = Color.Red;
                MessageBox.Show("Digite o nome do animal", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.BackColor = DefaultBackColor;
                txtNome.Focus();
                valida = false;
            }
            else if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                txtDescricao.BackColor = Color.Red;
                MessageBox.Show("Digite a descrição do animal", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescricao.BackColor = DefaultBackColor;
                txtDescricao.Focus();
                valida = false;
            }
            else if (string.IsNullOrEmpty(txtIdade.Text))
            {
                txtIdade.BackColor = Color.Red;
                MessageBox.Show("Digite a idade do animal", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdade.BackColor = DefaultBackColor;
                txtIdade.Focus();
                valida = false;
            }
            
            else if (string.IsNullOrEmpty(txtRaca.Text))
            {
                txtRaca.BackColor = Color.Red;
                MessageBox.Show("Defina a raça do animal", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRaca.BackColor = DefaultBackColor;
                txtRaca.Focus();
                valida = false;
            }
            else if (string.IsNullOrEmpty(txtSexo.Text))
            {
                txtSexo.BackColor = Color.Red;
                MessageBox.Show("Defina o sexo do animal", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSexo.BackColor = DefaultBackColor;
                txtSexo.Focus();
                valida = false;
            }
            else if (string.IsNullOrEmpty(cbTipoAnimal.Text))
            {
                cbTipoAnimal.BackColor = Color.Red;
                MessageBox.Show("Defina o tipo do animal", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbTipoAnimal.BackColor = DefaultBackColor;
                cbTipoAnimal.Focus();
                valida = false;
            }
           
            else
            {
                valida = true;
            }
            return valida;


        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                animalDTO.Nome = txtNome.Text;
                animalDTO.Idade = txtIdade.Text;
                animalDTO.Descricao = txtDescricao.Text;
                animalDTO.Sexo = txtSexo.Text.ToString();
                animalDTO.Raca = txtRaca.Text.ToString();
                DateTime dataSelecionada = dtpCadastro.Value;
                animalDTO.DtaCadastro = dataSelecionada;
                animalDTO.EhCastrado = CBCastrado.Checked;
                animalDTO.EhVacinado = chekbVacinado.Checked;
                animalDTO.IdTpFuncionario = funcionario.IdFuncionario;

                if (chekbVacinado.Checked == false)
                {
                    animalDTO.EhVacinado = false;
                }
                else if (chekbVacinado.Checked == true)
                {
                    animalDTO.EhVacinado = true;
                }
                else if (CBCastrado.Checked == true)
                {
                    animalDTO.EhCastrado = true;
                }
                else if (CBCastrado.Checked == false)
                {
                    animalDTO.EhCastrado = false;
                }

                string animalImg = $"{txtNome.Text}.jpg";

                if (!Directory.Exists(diretorio))
                {
                    Directory.CreateDirectory(diretorio);
                }

                string urlImagem = Path.Combine(diretorio, animalImg);
                animalDTO.UrlImgAnimal = urlImagem;

                Image imagem = pbAnimal.Image;
                imagem.Save(urlImagem);

                if (cbTipoAnimal.SelectedIndex == 0)
                {
                    animalDTO.TpAnimal = 1;
                }
                else if(cbTipoAnimal.SelectedIndex == 1)
                {
                    animalDTO.TpAnimal = 2;
                }
                else if(cbTipoAnimal.SelectedIndex == 2)
                {
                    animalDTO.TpAnimal = 3;
                }

                animalBLL.CreateAnimal(animalDTO);
                MessageBox.Show($"Animal {txtNome.Text}" + $" Cadastrado com sucesso", "sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
        }

        private void pbAnimal_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(diretorio))
            {
                Directory.CreateDirectory(diretorio);
            }

            //abre caixa de dialogo para o usuario escolher a imagem
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = diretorioImagens;

            openFileDialog.Filter = "Arquivos de imagem|*.jpg;*.jpeg;*.png";
            openFileDialog.Title = "Escolha a imagem";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string nomeArquivoImagem = openFileDialog.FileName;
                pbAnimal.Image = Image.FromFile(nomeArquivoImagem);
            }
         
        }
    }
}
