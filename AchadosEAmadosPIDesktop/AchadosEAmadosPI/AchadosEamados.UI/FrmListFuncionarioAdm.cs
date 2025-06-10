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
    public partial class FrmListFuncionarioAdm : Form
    {
        FuncionarioDTO funcionarioDTO = new FuncionarioDTO();
        FuncionarioBLL funcionarioBLL = new FuncionarioBLL();
        public FrmListFuncionarioAdm()
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
                FuncionarioDTO funcionarioDTO = funcionarioBLL.PesquisarId(Convert.ToInt32(txtPesquisar.Text));
                if (funcionarioDTO != null)
                {
                    List<FuncionarioDTO> lista = new List<FuncionarioDTO>();
                    lista.Add(funcionarioDTO);
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
                DgTabela.DataSource = funcionarioBLL;
            }
        }

        private void FrmListFuncionarioAdm_Load(object sender, EventArgs e)
        {

        }
    }
}
