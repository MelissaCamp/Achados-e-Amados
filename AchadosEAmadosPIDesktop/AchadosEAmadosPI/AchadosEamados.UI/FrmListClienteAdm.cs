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
    public partial class FrmListClienteAdm : Form
    {
        ClienteDTO clienteDTO = new ClienteDTO();
        ClienteBLL clienteBLL = new ClienteBLL();
        public FrmListClienteAdm()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            FrmListCatalogoAdm listFuncionarioAdm = new FrmListCatalogoAdm();
            listFuncionarioAdm.ShowDialog();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtPesquisar.Text != "")
            {
                ClienteDTO clienteDTO = clienteBLL.PesquisarId(Convert.ToInt32(txtPesquisar.Text));
                if (clienteDTO != null)
                {
                    List<ClienteDTO> lista = new List<ClienteDTO>();
                    lista.Add(clienteDTO);
                    DgTabela.DataSource = lista;
                }
                else
                {
                    MessageBox.Show("digite um id");
                    DgTabela.DataSource = null;
                }
            }
            else
            {
                DgTabela.DataSource = clienteBLL;
            }
        }

        private void FrmListClienteAdm_Load(object sender, EventArgs e)
        {

        }
    }
}
