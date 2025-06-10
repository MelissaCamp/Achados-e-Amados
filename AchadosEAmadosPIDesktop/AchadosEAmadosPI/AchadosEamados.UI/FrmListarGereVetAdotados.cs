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
    public partial class FrmListarGereVetAdotados : Form
    {

        AdotadoDTO adotadoDTO = new AdotadoDTO();
        AdotadoBLL adotadoBLL = new AdotadoBLL();
        public FrmListarGereVetAdotados()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            Hide();
            FrmGerenVetPrincipal principal = new FrmGerenVetPrincipal();
            principal.ShowDialog();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtPesquisar.Text != "")
            {
                AdotadoDTO adotadoDTO = adotadoBLL.PesquisarId(Convert.ToInt32(txtPesquisar.Text));
                if (adotadoDTO != null)
                {
                    List<AdotadoDTO> Lista = new List<AdotadoDTO>();
                    Lista.Add(adotadoDTO);
                    DgTabela.DataSource = Lista;
                }
                else
                {
                    MessageBox.Show("Digite um id");
                    DgTabela.DataSource = null;
                }
            }
            else
            {
                DgTabela.DataSource = adotadoBLL;
            }
        }

        private void FrmListarGereVetAdotados_Load(object sender, EventArgs e)
        {

        }
    }
}
