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
    public partial class frmUpdateAnimalAdm : Form
    {
        AnimalDTO animalDTO = new AnimalDTO();
        AnimalBLL animalBLL = new AnimalBLL();
        string diretorio = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}\\animal\";
        string diretorioImagens = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}";
        public frmUpdateAnimalAdm()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            FrmUpdateCatalogoAdm updateAnimal = new FrmUpdateCatalogoAdm();
            updateAnimal.ShowDialog();
        }

        private void frmUpdateAnimalAdm_Load(object sender, EventArgs e)
        {
            dtpCadastro.Format = DateTimePickerFormat.Custom;
            dtpCadastro.CustomFormat = "dd/MM/yyyy";
        }
        public bool ValidaForm()
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
                MessageBox.Show("Escreva a raça do animal", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else if (string.IsNullOrEmpty(dtpCadastro.Text) || dtpCadastro.Text.Length < 10)
            {
                dtpCadastro.BackColor = Color.Red;
                MessageBox.Show("Digite a data de cadastro" +
                    "", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpCadastro.BackColor = DefaultBackColor;
                dtpCadastro.Focus();
                valida = false;
            }
            else
            {
                valida = true;
            }
            return valida;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                animalDTO.IdAnimal = Convert.ToInt32(txtId.Text.Trim());
                animalDTO.Nome = txtNome.Text.Trim();
                animalDTO.Raca = txtRaca.Text.Trim();
                animalDTO.Idade = txtIdade.Text.Trim();
                animalDTO.Sexo = txtSexo.Text.Trim();
                animalDTO.Descricao = txtDescricao.Text.Trim();
                animalDTO.DtaCadastro = Convert.ToDateTime(dtpCadastro.Text);
                CBCastrado.Checked = animalDTO.EhCastrado;
                chekbVacinado.Checked = animalDTO.EhVacinado;

                if (animalDTO.EhVacinado == false)
                {
                    chekbVacinado.Checked = false;
                }
                else if (animalDTO.EhVacinado == true)
                {
                    chekbVacinado.Checked = true;
                }
                if (animalDTO.EhCastrado == false)
                {
                    CBCastrado.Checked = false;
                }
                else if (animalDTO.EhCastrado == true)
                {
                    CBCastrado.Checked = true;
                }


                string nomeImg = $"{txtNome.Text}.jpg";
                if (!Directory.Exists(diretorio))
                {
                    Directory.CreateDirectory(diretorio);
                }
                string urlImagem = Path.Combine(diretorio, nomeImg);
                animalDTO.UrlImgAnimal = urlImagem;
                Image imagem = pbAnimal.Image;
                imagem.Save(urlImagem);

                if (cbTipoAnimal.SelectedIndex == 0)
                {
                    animalDTO.TpAnimal = 1;
                }
                else if (cbTipoAnimal.SelectedIndex == 1)
                {
                    animalDTO.TpAnimal = 2;
                }
                else if (cbTipoAnimal.SelectedIndex == 2)
                {
                    animalDTO.TpAnimal = 3;
                }
                animalBLL.UpdateAnimal(animalDTO);
                MessageBox.Show($"Animal {animalDTO.Nome.ToUpper()} alterado com sucesso ", "Animal atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Digite um nome ou um Id", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtId.Focus();
                return;
            }

            int id = Convert.ToInt32(txtId.Text.Trim());
            animalDTO = animalBLL.PesquisarId(id);
            if (animalDTO != null)
            {
                txtIdade.Text = animalDTO.Idade.ToString();
                txtNome.Text = animalDTO.Nome.ToString();
                txtDescricao.Text = animalDTO.Descricao.ToString();
                txtRaca.Text = animalDTO.Raca.ToString();
                txtSexo.Text = animalDTO.Sexo.ToString();
                pbAnimal.ImageLocation = animalDTO.UrlImgAnimal;
                dtpCadastro.Text = animalDTO.DtaCadastro.ToString();
                CBCastrado.Checked = animalDTO.EhCastrado;
                chekbVacinado.Checked = animalDTO.EhVacinado;

                if (animalDTO.EhVacinado == false)
                {
                    chekbVacinado.Checked = false;
                }
                else if (animalDTO.EhVacinado == true)
                {
                    chekbVacinado.Checked = true;
                }
                if (animalDTO.EhCastrado == false)
                {
                    CBCastrado.Checked = false;
                }
                else if (animalDTO.EhCastrado == true)
                {
                    CBCastrado.Checked = true;
                }

                string tipo = animalDTO.TpAnimal.ToString();

                if (tipo == "1")
                {
                    cbTipoAnimal.Text = "Cachorro";
                }
                else if (tipo == "2")
                {
                    cbTipoAnimal.Text = "Gato";
                }
                else if (tipo == "3")
                {
                    cbTipoAnimal.Text = "Outro";
                }
            }



            HabilitaCampos();
        }
    
        public void HabilitaCampos()
        {
            pbAnimal.Enabled = true;
            txtRaca.Enabled = true;
            txtNome.Enabled = true;
            txtIdade.Enabled = true;
            txtDescricao.Enabled = true;
            txtSexo.Enabled = true;
            dtpCadastro.Enabled = true;
            CBCastrado.Enabled = true;
            chekbVacinado.Enabled = true;
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
                string nomeArquivoImagem = openFileDialog.FileName;
                pbAnimal.Image = Image.FromFile(nomeArquivoImagem);
            }
        }
        private void LimparForm()
        {
            pbAnimal.ImageLocation = "";
            txtRaca.Text = "";
            txtNome.Text = "";
            txtIdade.Text = "";
            txtDescricao.Text = "";
            txtSexo.Text = "";
            dtpCadastro.Text = "";
            CBCastrado.Text = "";
            chekbVacinado.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Digite um nome", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtId.Focus();
                return;
            }
            int id= Convert.ToInt32(txtId.Text.Trim());
            animalDTO = animalBLL.PesquisarId(id);
            if (animalDTO != null)
            {
                txtIdade.Text = animalDTO.Idade.ToString();
                txtNome.Text = animalDTO.Nome.ToString();
                txtDescricao.Text = animalDTO.Descricao.ToString();
                txtRaca.Text = animalDTO.Raca.ToString();
                txtSexo.Text = animalDTO.Sexo.ToString();
                pbAnimal.ImageLocation = animalDTO.UrlImgAnimal;
                dtpCadastro.Text = animalDTO.DtaCadastro.ToString();
                CBCastrado.Checked = animalDTO.EhCastrado;
                chekbVacinado.Checked = animalDTO.EhVacinado;

                if (animalDTO.EhVacinado == false)
                {
                    chekbVacinado.Checked = false;
                }
                else if (animalDTO.EhVacinado == true)
                {
                    chekbVacinado.Checked = true;
                }
                if (animalDTO.EhCastrado == false)
                {
                    CBCastrado.Checked = false;
                }
                else if (animalDTO.EhCastrado == true)
                {
                    CBCastrado.Checked = true;
                }

                string tipo = animalDTO.TpAnimal.ToString();

                if (tipo == "1")
                {
                    cbTipoAnimal.Text = "Cachorro";
                }
                else if (tipo == "2")
                {
                    cbTipoAnimal.Text = "Gato";
                }
                else if (tipo == "3")
                {
                    cbTipoAnimal.Text = "Outro";
                }
            }
            HabilitaCampos();
        }
    }
}

