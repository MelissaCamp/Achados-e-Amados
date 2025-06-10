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
    public partial class frmUpdateFuncionarioAdm : Form
    {
        FuncionarioDTO funcionarioDTO = new FuncionarioDTO();
        FuncionarioBLL funcionarioBLL = new FuncionarioBLL();
        string diretorio = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}\\funcionarios\";
        string diretorioImagens = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}";
        public frmUpdateFuncionarioAdm()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            FrmUpdateCatalogoAdm updateFuncionario = new FrmUpdateCatalogoAdm();
            updateFuncionario.ShowDialog();
        }
        private void LimpaForm()
        {
            txtEmail.Text = "";
            txtNome.Text = "";
            txtSenha.Text = "";
            txtSexo.Text = "";
            maskCpf.Text = "";
            maskTelefone.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Digite um ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtId.Focus();
                return;
            }
            int id = Convert.ToInt32(txtId.Text.Trim());
            funcionarioDTO = funcionarioBLL.PesquisarId(id);
            if (funcionarioDTO != null)
            {
                pbFuncionario.Text = funcionarioDTO.UrlImgFuncionario.ToString();
                txtEmail.Text = funcionarioDTO.Email.ToString();
                txtNome.Text = funcionarioDTO.Nome.ToString();
                txtSenha.Text = funcionarioDTO.Senha.ToString();
                txtSexo.Text = funcionarioDTO.Sexo.ToString();
                maskCpf.Text = funcionarioDTO.Cpf.ToString();
                maskTelefone.Text = funcionarioDTO.Telefone.ToString();
                string tipo = funcionarioDTO.IdTpFuncionario.ToString();
                if (tipo == "1")
                {
                    cbTipoFuncionario.Text = "Administrador";
                }
                else if (tipo == "2")
                {
                    cbTipoFuncionario.Text = "Cuidador";
                }
                else if (tipo == "3")
                {
                    cbTipoFuncionario.Text = "Veterinario";
                }
                else if (tipo == "4")
                {
                    cbTipoFuncionario.Text = "Gerente Geral";
                }


            }
        }

        private void pbFuncionario_Click(object sender, EventArgs e)
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
                pbFuncionario.Image = Image.FromFile(nomeArquivoImagem);
            }
        }
        private bool ValidaForm()
        {
            bool valida;
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                txtNome.BackColor = Color.Red;
                MessageBox.Show("Digite seu nome", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.BackColor = DefaultBackColor;
                txtNome.Focus();
                valida = false;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.BackColor = Color.Red;
                MessageBox.Show("Digite seu email", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.BackColor = DefaultBackColor;
                txtEmail.Focus();
                valida = false;
            }
            else if (string.IsNullOrEmpty(txtSenha.Text))
            {
                txtSenha.BackColor = Color.Red;
                MessageBox.Show("Digite sua senha", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSenha.BackColor = DefaultBackColor;
                txtSenha.Focus();
                valida = false;
            }
            else if (string.IsNullOrEmpty(txtSexo.Text))
            {
                txtSexo.BackColor = Color.Red;
                MessageBox.Show("Digite seu sexo", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSexo.BackColor = DefaultBackColor;
                txtSexo.Focus();
                valida = false;
            }
            else if (string.IsNullOrEmpty(maskCpf.Text) || maskCpf.Text == "   .   .   -  ")
            {
                maskCpf.BackColor = Color.Red;
                MessageBox.Show("Digite seu CPF", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maskCpf.BackColor = DefaultBackColor;
                maskCpf.Focus();
                valida = false;
            }
            else if (string.IsNullOrEmpty(maskTelefone.Text) || maskTelefone.Text == "(  )       -    ")
            {
                maskTelefone.BackColor = Color.Red;
                MessageBox.Show("Digite seu telefone", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maskTelefone.BackColor = DefaultBackColor;
                maskTelefone.Focus();
                valida = false;
            }
            else if (string.IsNullOrEmpty(dtpNascimento.Text) || dtpNascimento.Text.Length < 10)
            {
                dtpNascimento.BackColor = Color.Red;
                MessageBox.Show("Digite sua data de nascimento", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpNascimento.BackColor = DefaultBackColor;
                dtpNascimento.Focus();
                valida = false;
            }
            else if (string.IsNullOrEmpty(cbTipoFuncionario.Text))
            {
                cbTipoFuncionario.BackColor = Color.Red;
                MessageBox.Show("Escolha seu tipo de funcionario", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbTipoFuncionario.BackColor = DefaultBackColor;
                cbTipoFuncionario.Focus();
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
                funcionarioDTO.IdFuncionario = Convert.ToInt32(txtId.Text.Trim());
                funcionarioDTO.Nome = txtNome.Text.Trim();
                funcionarioDTO.Senha = txtSenha.Text.Trim();
                funcionarioDTO.Cpf = maskCpf.Text.Trim();
                funcionarioDTO.Telefone = maskTelefone.Text.Trim();
                funcionarioDTO.DtaNascimento = Convert.ToDateTime(dtpNascimento.Text);
                funcionarioDTO.Email = txtEmail.Text.Trim();
                funcionarioDTO.Sexo = txtSexo.Text.Trim();

                string nomeImg = $"{txtNome.Text}.jpg";

                if (!Directory.Exists(diretorio))
                {
                    Directory.CreateDirectory(diretorio);
                }

                string urlImagem = Path.Combine(diretorio, nomeImg);
                funcionarioDTO.UrlImgFuncionario = urlImagem;

                if (cbTipoFuncionario.SelectedIndex == 0)
                {
                    funcionarioDTO.IdTpFuncionario = 1;
                }
                else if (cbTipoFuncionario.SelectedIndex == 1)
                {
                    funcionarioDTO.IdTpFuncionario = 2;
                }
                else if (cbTipoFuncionario.SelectedIndex == 2)
                {
                    funcionarioDTO.IdTpFuncionario = 3;
                }
                else if (cbTipoFuncionario.SelectedIndex == 3)
                {
                    funcionarioDTO.IdTpFuncionario = 4;
                }
                funcionarioBLL.UpdateFuncionario(funcionarioDTO);
                MessageBox.Show($"Funcionario {funcionarioDTO.Nome.ToUpper()} alterado com sucesso", "Usuario atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaForm();
        }

        private void frmUpdateFuncionarioAdm_Load(object sender, EventArgs e)
        {
            dtpNascimento.Format = DateTimePickerFormat.Custom;
            dtpNascimento.CustomFormat = "dd/MM/yyyy";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
