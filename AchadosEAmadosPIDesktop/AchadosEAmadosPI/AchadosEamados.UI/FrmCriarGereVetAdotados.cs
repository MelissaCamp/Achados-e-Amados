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
    public partial class FrmCriarGereVetAdotados : Form
    {
        AdotadoDTO adotadoDTO = new AdotadoDTO();
        AdotadoBLL adotadoBLL = new AdotadoBLL();
        public FrmCriarGereVetAdotados()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            FrmGerenVetPrincipal principal = new FrmGerenVetPrincipal();
            principal.ShowDialog();
        }

        private void FrmCriarGereVetAdotados_Load(object sender, EventArgs e)
        {
            dtpAdocao.Format = DateTimePickerFormat.Custom;
            dtpAdocao.CustomFormat = "dd/MM/yyyy";
        }
        private void LimparForm()
        {
            txtAnimal.Text = "";
            txtCliente.Text = "";
            dtpAdocao.Text = "";
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                adotadoDTO.IdAnimal = Convert.ToInt32(txtAnimal.Text);
                adotadoDTO.IdCliente = Convert.ToInt32(txtCliente.Text);
                DateTime dataselec = dtpAdocao.Value;
                adotadoDTO.DtaAdocao = dataselec;
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparForm();
        }
    }
}
