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
    public partial class FrmAtualizarAdotadosAdm : Form
    {
        AdotadoDTO adotadoDTO = new AdotadoDTO();
        AdotadoBLL adotadoBLL = new AdotadoBLL();
        public FrmAtualizarAdotadosAdm()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmPrincipalAdm principalAdm = new frmPrincipalAdm();
            principalAdm.ShowDialog();
        }

        private void FrmAtualizarAdotadosAdm_Load(object sender, EventArgs e)
        {
            dtpAdocao.Format = DateTimePickerFormat.Custom;
            dtpAdocao.CustomFormat = "dd/MM/yyyy";
            if (ValidaForm())
            {
                adotadoDTO.IdAdotado = Convert.ToInt32(txtId.Text.Trim());
                adotadoDTO.DtaAdocao = Convert.ToDateTime(dtpAdocao.Text);
                adotadoDTO.IdCliente = Convert.ToInt32(txtCliente.Text.Trim());
                adotadoDTO.IdAnimal = Convert.ToInt32(txtAnimal.Text.ToString().Trim());
            }
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
            adotadoDTO = adotadoBLL.PesquisarId(id);
            if (adotadoDTO != null)
            {
                txtAnimal.Text = adotadoDTO.IdAnimal.ToString();
                txtCliente.Text = adotadoDTO.IdCliente.ToString();
                dtpAdocao.Text = adotadoDTO.DtaAdocao.ToString();
            }
            HabilitaCampos();
        }
        public void HabilitaCampos()
        {
            txtAnimal.Enabled = true;
            txtCliente.Enabled = true;
            dtpAdocao.Enabled = true;
        }
        public bool ValidaForm()
        {
            bool valida;
            if (string.IsNullOrEmpty(txtAnimal.Text))
            {
                txtAnimal.BackColor = Color.Red;
                MessageBox.Show("Digite o nome do animal", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAnimal.BackColor = DefaultBackColor;
                txtAnimal.Focus();
                valida = false;
            }
            else if (string.IsNullOrEmpty(txtCliente.Text))
            {
                txtCliente.BackColor = Color.Red;
                MessageBox.Show("Digite o nome do cliente", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCliente.BackColor = DefaultBackColor;
                txtCliente.Focus();
                valida = false;
            }
            else if (string.IsNullOrEmpty(dtpAdocao.Text) || dtpAdocao.Text.Length < 10)
            {
                dtpAdocao.BackColor = Color.Red;
                MessageBox.Show("Digite a data de adoção", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpAdocao.BackColor = DefaultBackColor;
                dtpAdocao.Focus();
                valida = false;
            }
            else
            {
                valida = true;
            }
            return valida;
        }
        private void LimparForm()
        {
            txtAnimal.Text = "";
            txtCliente.Text = "";
            dtpAdocao.Text = "";
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparForm();
        }
    }
}
