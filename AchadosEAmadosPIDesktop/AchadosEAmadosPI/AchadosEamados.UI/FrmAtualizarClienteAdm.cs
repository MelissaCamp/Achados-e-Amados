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
    public partial class FrmAtualizarClienteAdm : Form
    {
        ClienteDTO clienteDTO = new ClienteDTO();
        ClienteBLL clienteBLL = new ClienteBLL();
        string diretorio = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}\\cliente\";
        string diretorioImagens = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}";
        public FrmAtualizarClienteAdm()
        {
            InitializeComponent();
        }

        private void FrmAtualizarClienteAdm_Load(object sender, EventArgs e)
        {
            dtpNascimento.Format = DateTimePickerFormat.Custom;
            dtpNascimento.CustomFormat = "dd/MM/yyyy";
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                clienteDTO.IdCliente = Convert.ToInt32(txtId.Text.Trim());
                clienteDTO.DtaNascimento = Convert.ToDateTime(dtpNascimento.Text);
                clienteDTO.Nome = txtNome.Text.Trim();
                clienteDTO.CPF = maskCpf.Text.Trim();
                clienteDTO.Email = txtEmail.Text.Trim();
                clienteDTO.Senha = txtSenha.Text.Trim();
                clienteDTO.Telefone = maskTelefone.Text.Trim();
                clienteDTO.Endereco = txtEndereco.Text.Trim();
                clienteDTO.Nro = txtNumero.Text.Trim();
                clienteDTO.Bairro = txtBairro.Text.Trim();
                clienteDTO.Cidade = txtCidade.Text.Trim();
                clienteDTO.Estado = txtEstado.Text.Trim();

                string nomeImg = $"{txtNome.Text}.jpg";

                if (!Directory.Exists(diretorio))
                {
                    Directory.CreateDirectory(diretorio);
                }
                string urlImagem = Path.Combine(diretorio, nomeImg);
                clienteDTO.UrlImgCliente = urlImagem;

                Image imagem = pbAnimal.Image;
                imagem.Save(urlImagem);

                clienteBLL.Update(clienteDTO);
                MessageBox.Show($"Cliente {clienteDTO.Nome.ToUpper()} alterado com sucesso ", "Cliente atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool ValidaForm()
        {
            bool valida;
           
                if (string.IsNullOrEmpty(txtNome.Text))
                {
                    txtNome.BackColor = Color.Red;
                    MessageBox.Show("Digite o nome", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNome.BackColor = DefaultBackColor;
                    txtNome.Focus();
                    valida = false;
                }
                else if (string.IsNullOrEmpty(maskCpf.Text))
                {
                    maskCpf.BackColor = Color.Red;
                    MessageBox.Show("Digite o CPF", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    maskCpf.BackColor = DefaultBackColor;
                    maskCpf.Focus();
                    valida = false;
                }
                else if (string.IsNullOrEmpty(dtpNascimento.Text) || dtpNascimento.Text.Length < 10)
                {
                    dtpNascimento.BackColor = Color.Red;
                    MessageBox.Show("Digite a data de nascimento", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtpNascimento.BackColor = DefaultBackColor;
                    dtpNascimento.Focus();
                    valida = false;
                }
                else if (string.IsNullOrEmpty(txtSenha.Text))
                {
                    txtSenha.BackColor = Color.Red;
                    MessageBox.Show("Digite a senha", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSenha.BackColor = DefaultBackColor;
                    txtSenha.Focus();
                    valida = false;
                }
                else
                {
                    valida = true;
                }
                return valida;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Digite um ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtId.Focus();
                return;
            }
            int id = Convert.ToInt32(txtId.Text.Trim());
            clienteDTO = clienteBLL.PesquisarId(id);
            if (clienteDTO != null)
            {
                pbAnimal.ImageLocation = clienteDTO.UrlImgCliente;
                txtNome.Text = clienteDTO.Nome.ToString();
                dtpNascimento.Text = clienteDTO.DtaNascimento.ToString();
                maskCpf.Text = clienteDTO.CPF.ToString();
                txtEmail.Text = clienteDTO.Email.ToString();
                txtSenha.Text = clienteDTO.Senha.ToString();
                maskTelefone.Text = clienteDTO.Telefone.ToString();
                txtEndereco.Text = clienteDTO.Endereco.ToString();
                txtNumero.Text = clienteDTO.Nro.ToString();
                txtBairro.Text = clienteDTO.Bairro.ToString();
                txtCidade.Text = clienteDTO.Cidade.ToString();
                txtEstado.Text = clienteDTO.Estado.ToString();
            }
            HabilitaCampos();
        }
        public void HabilitaCampos()
        {
            txtNome.Enabled = true;
            dtpNascimento.Enabled = true;
            maskCpf.Enabled = true;
            txtEmail.Enabled = true;
            txtSenha.Enabled = true;
            maskTelefone.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtEstado.Enabled = true;
            pbAnimal.Enabled = true;
        }
        private void LimparForm()
        {
            txtNome.Text = "";
            dtpNascimento.Text = "";
            maskCpf.Text = "";
            txtEmail.Text = "";
            txtSenha.Text = "";
            maskTelefone.Text = "";
            txtEndereco.Text = "";
            txtNumero.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
            pbAnimal.ImageLocation = "";
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparForm();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmPrincipalAdm principalAdm = new frmPrincipalAdm();
            principalAdm.ShowDialog();
        }
    }
}

