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
    public partial class FrmCriarCatalogo : Form
    {
        public FrmCriarCatalogo()
        {
            InitializeComponent();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmPrincipalAdm principal = new frmPrincipalAdm();
            principal.ShowDialog();
        }

        private void BtnCreateFuncionario_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCadastroLogadoFuncionarioAdm cadastroFuncionario = new FrmCadastroLogadoFuncionarioAdm();
            cadastroFuncionario.ShowDialog();
        }

        private void BtnCreateAnimal_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCadastroLogadoAnimalAdm cadastroAnimal = new FrmCadastroLogadoAnimalAdm();
            cadastroAnimal.ShowDialog();
        }
    }
}
