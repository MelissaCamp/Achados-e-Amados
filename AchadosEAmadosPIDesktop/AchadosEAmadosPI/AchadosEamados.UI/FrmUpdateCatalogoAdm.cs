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
    public partial class FrmUpdateCatalogoAdm : Form
    {
        public FrmUpdateCatalogoAdm()
        {
            InitializeComponent();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmPrincipalAdm principal = new frmPrincipalAdm();
            principal.ShowDialog();
        }

        private void BtnCreateAnimal_Click(object sender, EventArgs e)
        {
            Hide();
            frmUpdateAnimalAdm updateAnimal = new frmUpdateAnimalAdm();
            updateAnimal.ShowDialog();
        }

        private void BtnUpdateFuncionario_Click(object sender, EventArgs e)
        {
            Hide();
            frmUpdateFuncionarioAdm updateFuncionario = new frmUpdateFuncionarioAdm();
            updateFuncionario.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Hide();
            FrmAtualizarClienteAdm updateCliente = new FrmAtualizarClienteAdm();
            updateCliente.ShowDialog();
        }
    }
}
