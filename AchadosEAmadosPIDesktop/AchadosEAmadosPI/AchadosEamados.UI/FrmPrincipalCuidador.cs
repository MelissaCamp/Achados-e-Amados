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
    public partial class FrmPrincipalCuidador : Form
    {
        public FrmPrincipalCuidador()
        {
            InitializeComponent();
        }

        private void btnDeslogar_Click(object sender, EventArgs e)
        {
            Hide();
            FrmLogin login = new FrmLogin();
            login.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnTofrmUpdate_Click(object sender, EventArgs e)
        {
            Hide();
            FrmUpdateAnimalCuidador update = new FrmUpdateAnimalCuidador();
            update.ShowDialog();
        }

        private void BtnTofrmListar_Click(object sender, EventArgs e)
        {
            Hide();
            FrmListAnimalCuidador listar = new FrmListAnimalCuidador();
            listar.ShowDialog();
        }

        private void animalToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Hide();
            FrmUpdateAnimalCuidador update = new FrmUpdateAnimalCuidador();
            update.ShowDialog();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmListAnimalCuidador listar = new FrmListAnimalCuidador();
            listar.ShowDialog();
        }

        private void adotadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmListarAnimaisAdotadoCuidador adotado = new FrmListarAnimaisAdotadoCuidador();
            adotado.ShowDialog();
        }
    }
    }

