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
    public partial class frmCadastro : Form
    {
        FuncionarioDTO funcionarioDTO = new FuncionarioDTO();
        FuncionarioBLL funcionarioBLL = new FuncionarioBLL();

        string diretorio = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}\funcionarios\";
        string diretorioImagens = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}";
        public frmCadastro()
        {
            InitializeComponent();
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

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            dtpNascimento.Format = DateTimePickerFormat.Custom;
            dtpNascimento.CustomFormat = "dd/MM/yyyy";

            cbTipoFuncionario.DisplayMember = "DescricaoTipoFuncionario";
            cbTipoFuncionario.DataSource = funcionarioBLL.GetTpFuncionarios();

            List<string> tpFuncionario = new List<string>
            {
                "Veterinário", "Gerente Geral", "Cuidador"
            };
            cbTipoFuncionario.DataSource = tpFuncionario;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                funcionarioDTO.Nome = txtNome.Text;
                funcionarioDTO.Senha = txtSenha.Text;
                funcionarioDTO.Email = txtEmail.Text;
                funcionarioDTO.Sexo = txtSexo.Text;
                funcionarioDTO.Cpf = maskCpf.Text;
                funcionarioDTO.Telefone = maskTelefone.Text;
                DateTime dataSelecionada = dtpNascimento.Value;
                funcionarioDTO.DtaNascimento = dataSelecionada;

                string nomeImg = $"{txtNome.Text}.jpg";

                if (!Directory.Exists(diretorio))
                {
                    Directory.CreateDirectory(diretorio);
                }


                string urlImagem = Path.Combine(diretorio, nomeImg);
                funcionarioDTO.UrlImgFuncionario = urlImagem;

               Image imagem = pbFuncionario.Image;
                imagem.Save(urlImagem);
                //adm
                if (cbTipoFuncionario.SelectedIndex == 0)
                {
                    funcionarioDTO.IdTpFuncionario = 1;
                }
                //cuidador
                else if (cbTipoFuncionario.SelectedIndex == 1)
                {
                    funcionarioDTO.IdTpFuncionario = 2;
                }
                //veterinario
                else if (cbTipoFuncionario.SelectedIndex == 2)
                {
                    funcionarioDTO.IdTpFuncionario = 3;
                }
                //gerente
                else if (cbTipoFuncionario.SelectedIndex == 3)
                {
                    funcionarioDTO.IdTpFuncionario = 4;
                }
                else
                {
                    funcionarioDTO.IdTpFuncionario = 2;
                }
                funcionarioBLL.CreateFuncionario(funcionarioDTO);
                MessageBox.Show($"Funcionario {txtNome.Text} " + $"Cadastrado com sucesso", "sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
        

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            FrmLogin login = new FrmLogin();
            login.ShowDialog();
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
                string nomeAquivoImagem = openFileDialog.FileName; pbFuncionario.Image = Image.FromFile(nomeAquivoImagem);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
    