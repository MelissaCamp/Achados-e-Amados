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
    public partial class FrmListCatalogoAdm : Form
    {
        public FrmListCatalogoAdm()
        {
            InitializeComponent();
        }

        private void BtnCreateAnimal_Click(object sender, EventArgs e)
        {
            Hide();
            FrmListAnimalAdm ListAnimal = new FrmListAnimalAdm();
            ListAnimal.ShowDialog();
        }

        private void BtnCreateFuncionario_Click(object sender, EventArgs e)
        {
            Hide();
            FrmListFuncionarioAdm listFuncionarioAdm = new FrmListFuncionarioAdm();
            listFuncionarioAdm.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Hide();
            FrmListClienteAdm listClienteAdm = new FrmListClienteAdm();
            listClienteAdm.ShowDialog();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmPrincipalAdm principalAdm = new frmPrincipalAdm();
            principalAdm.ShowDialog();
        }
    }
}
