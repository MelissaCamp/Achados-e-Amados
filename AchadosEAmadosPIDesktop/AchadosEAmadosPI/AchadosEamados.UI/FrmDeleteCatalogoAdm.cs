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
    public partial class FrmDeleteCatalogoAdm : Form
    {
        public FrmDeleteCatalogoAdm()
        {
            InitializeComponent();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmPrincipalAdm deleteCatalogo = new frmPrincipalAdm();
            deleteCatalogo.ShowDialog();
        }

        private void BtnCreateFuncionario_Click(object sender, EventArgs e)
        {
            Hide();
            frmDeleteFuncionarioAdm deleteFuncionario = new frmDeleteFuncionarioAdm();
            deleteFuncionario.ShowDialog();
        }

        private void BtnCreateAnimal_Click(object sender, EventArgs e)
        {
            Hide();
            frmDeleteAnimalAdm deleteAnimal = new frmDeleteAnimalAdm();
            deleteAnimal.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Hide();
            frmDeleteClienteAdm deleteCliente = new frmDeleteClienteAdm();
            deleteCliente.ShowDialog();
        }
    }
}
