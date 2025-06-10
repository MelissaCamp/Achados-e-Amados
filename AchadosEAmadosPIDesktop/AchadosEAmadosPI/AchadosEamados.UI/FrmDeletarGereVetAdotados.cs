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
    public partial class FrmDeletarGereVetAdotados : Form
    {

        AdotadoBLL adotadoBLL = new AdotadoBLL();
        AdotadoDTO adotadoDTO = new AdotadoDTO();
        public FrmDeletarGereVetAdotados()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            FrmGerenVetPrincipal principal = new FrmGerenVetPrincipal();
            principal.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Digite um Id", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtId.Focus();
                return;
            }
            int id = Convert.ToInt32(txtId.Text.Trim());
            adotadoDTO = adotadoBLL.PesquisarId(id);
            if (adotadoDTO != null)
            {
                txtAnimal.Text = adotadoDTO.IdAnimal.ToString();
                txtCliente.Text = adotadoDTO.IdCliente.ToString();

                btnDeletar.Enabled = true;
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Tem certeza que deseja deletar o animal adotado?", "Deletar Adotado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtId.Text.Trim());
                adotadoBLL.Deletar(id);
                LimparCampos();
                txtId.Focus();
                MessageBox.Show("Animal adotado deletado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void LimparCampos()
        {
            txtAnimal.Text = "";
            txtCliente.Text = "";
        }

        private void FrmDeletarGereVetAdotados_Load(object sender, EventArgs e)
        {
            dtpAdocao.Format = DateTimePickerFormat.Custom;
            dtpAdocao.CustomFormat = "dd/MM/yyyy";
        }
    }
}
