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
    public partial class frmDeleteClienteAdm : Form
    {
        ClienteDTO clienteDTO = new ClienteDTO();
        ClienteBLL clienteBLL = new ClienteBLL();
        public frmDeleteClienteAdm()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Hide();
            FrmDeleteCatalogoAdm deleteCatalogo = new FrmDeleteCatalogoAdm();
            deleteCatalogo.ShowDialog();
        }

        private void frmDeleteClienteAdm_Load(object sender, EventArgs e)
        {
            dtpNascimento.Format = DateTimePickerFormat.Custom;
            dtpNascimento.CustomFormat = "dd/MM/yyyy";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(button1.Text))
            {
                MessageBox.Show("Digite um ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button1.Focus();
                return;
            }
            int id = Convert.ToInt32(txtId.Text.Trim());
            clienteDTO = clienteBLL.PesquisarId(id);
            if (clienteDTO == null)
            {
                txtBairro.Text = clienteDTO.Bairro.ToString();
                txtCidade.Text = clienteDTO.Cidade.ToString();
                txtEmail.Text = clienteDTO.Email.ToString();
                txtEndereco.Text = clienteDTO.Endereco.ToString();
                txtEstado.Text = clienteDTO.Estado.ToString();
                txtNome.Text = clienteDTO.Nome.ToString();
                txtNumero.Text = clienteDTO.Nome.ToString();
                btnDeletar.Enabled = true;
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

            DialogResult resposta = MessageBox.Show("Tem certeza que deseja excluir o funcionario?", "Ecluir Funcionario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                int id = Convert.ToInt32((txtId.Text.Trim()));
                clienteBLL.DeletarCliente(id);
                LimparCampos();
                txtId.Focus();
                MessageBox.Show("Servico excluido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void LimparCampos()
        {
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtEmail.Text = "";
            txtEndereco.Text = "";
            txtEstado.Text = "";
            txtNome.Text = "";
            txtNumero.Text = "";

        }
    }
}
