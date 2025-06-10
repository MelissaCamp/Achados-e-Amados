using AchadosEamados.BLL;
using AchadosEamados.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AchadosEamados.UI
{
    public partial class frmDeleteFuncionarioAdm : Form
    {
        FuncionarioDTO funcionarioDTO = new FuncionarioDTO();
        FuncionarioBLL funcionarioBLL = new FuncionarioBLL();
        string diretorio = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}\\funcionarios\";
        string diretorioImagens = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}";
        public frmDeleteFuncionarioAdm()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            FrmDeleteCatalogoAdm deleteCatalogo = new FrmDeleteCatalogoAdm();
            deleteCatalogo.ShowDialog();
        }

        private void frmDeleteFuncionarioAdm_Load(object sender, EventArgs e)
        {
            dtpNascimento.Format = DateTimePickerFormat.Custom;
            dtpNascimento.CustomFormat = "dd/MM/yyyy";
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Tem certeza que deseja deletar o funcionario?", "Deletar Funcionario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                int id = Convert.ToInt32((txtId.Text.Trim()));
                funcionarioBLL.DeletarFuncionario(id);
                LimparCampos();
                txtId.Focus();
                MessageBox.Show("funcionario deletado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void LimparCampos()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtSenha.Text = "";
            maskCpf.Text = "";
            maskTelefone.Text = "";
            txtSexo.Text = "";
            pbFuncionario.Text = "";
            cbTipoFuncionario.Text = "";
            txtId.Text = "";
            dtpNascimento.Text = "";
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
                pbFuncionario.ImageLocation = funcionarioDTO.UrlImgFuncionario;
                txtNome.Text = funcionarioDTO.Nome.ToString();
                txtEmail.Text = funcionarioDTO.Email.ToString();
                txtSenha.Text = funcionarioDTO.Senha.ToString();
                maskCpf.Text = funcionarioDTO.Cpf.ToString();
                maskTelefone.Text = funcionarioDTO.Telefone.ToString();
                txtSexo.Text = funcionarioDTO.Sexo.ToString();
                dtpNascimento.Text = funcionarioDTO.DtaNascimento.ToString();

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
                btnDeletar.Enabled = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
