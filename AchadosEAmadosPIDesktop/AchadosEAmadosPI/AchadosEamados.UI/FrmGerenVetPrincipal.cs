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
    public partial class FrmGerenVetPrincipal : Form
    {
        public FrmGerenVetPrincipal()
        {
            InitializeComponent();
        }

        private void BtnTofrmCreate_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCadastroLogadoAnimalGereVet cadastroAnimal = new FrmCadastroLogadoAnimalGereVet();
            cadastroAnimal.ShowDialog();
        }

        private void BtnTofrmUpdate_Click(object sender, EventArgs e)
        {
            Hide();
            FrmUptdateAnimalGereVet updateAnimal = new FrmUptdateAnimalGereVet();
            updateAnimal.ShowDialog();
        }

        private void BtnTofrmListar_Click(object sender, EventArgs e)
        {
            Hide();
            FrmListarAnimalGereVet ListarAnimal = new FrmListarAnimalGereVet();
            ListarAnimal.ShowDialog();
        }

        private void BtnTofrmDelete_Click(object sender, EventArgs e)
        {
            Hide();
            FrmDeleteAnimalGereVet DeleteAnimal = new FrmDeleteAnimalGereVet();
            DeleteAnimal.ShowDialog();
        }

        private void criarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmListarGereVetAdotados listar = new FrmListarGereVetAdotados();
            listar.ShowDialog();
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmAtualizarGereVetAdotados atualizar = new FrmAtualizarGereVetAdotados();
            atualizar.ShowDialog();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmDeletarGereVetAdotados deletar = new FrmDeletarGereVetAdotados();
            deletar.ShowDialog();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCriarGereVetAdotados criar = new FrmCriarGereVetAdotados();
            criar.ShowDialog();
        }

        private void btnDeslogar_Click(object sender, EventArgs e)
        {
            Hide();
            FrmLogin login = new FrmLogin();
            login.ShowDialog();
        }

        private void adotadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
