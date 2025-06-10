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
    public partial class frmPrincipalAdm : Form
    {
        public frmPrincipalAdm()
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

        private void BtnTofrmCreate_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCriarCatalogo criarCatalogo = new FrmCriarCatalogo();
            criarCatalogo.ShowDialog();
        }

        private void BtnTofrmUpdate_Click(object sender, EventArgs e)
        {
            Hide();
            FrmUpdateCatalogoAdm atualizarCatalogo = new FrmUpdateCatalogoAdm();
            atualizarCatalogo.ShowDialog();
        }

        private void BtnTofrmListar_Click(object sender, EventArgs e)
        {
            Hide();
            FrmListCatalogoAdm listCatalogo = new FrmListCatalogoAdm();
            listCatalogo.ShowDialog();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void animalToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            Hide();
            FrmCadastroLogadoAnimalAdm CadastrarAnimal = new FrmCadastroLogadoAnimalAdm();
            CadastrarAnimal.ShowDialog();
        }

        private void funcionarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCadastroLogadoFuncionarioAdm CadastrarFuncionario = new FrmCadastroLogadoFuncionarioAdm();
            CadastrarFuncionario.ShowDialog();
        }

        private void animalToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Hide();
            frmUpdateAnimalAdm AtualizarAnimal = new frmUpdateAnimalAdm();
            AtualizarAnimal.ShowDialog();
        }

        private void funcionarioToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Hide();
            frmUpdateFuncionarioAdm AtualizarFuncionario = new frmUpdateFuncionarioAdm();
            AtualizarFuncionario.ShowDialog();
        }

        private void animalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmListAnimalAdm ListarAnimal = new FrmListAnimalAdm();
            ListarAnimal.ShowDialog();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void funcionarioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Hide();
            FrmListFuncionarioAdm ListarFuncionario = new FrmListFuncionarioAdm();
            ListarFuncionario.ShowDialog();
        }

        private void animalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            frmDeleteAnimalAdm deleteAnimal = new frmDeleteAnimalAdm();
            deleteAnimal.ShowDialog();
        }

        private void BtnTofrmDelete_Click(object sender, EventArgs e)
        {
            Hide();
            FrmDeleteCatalogoAdm deleteCatalogo = new FrmDeleteCatalogoAdm();
            deleteCatalogo.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmListClienteAdm ListarCliente = new FrmListClienteAdm();
            ListarCliente.ShowDialog();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            frmDeleteFuncionarioAdm deleteFuncionario = new frmDeleteFuncionarioAdm();
            deleteFuncionario.ShowDialog();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCriarAdotadosAdm criar = new FrmCriarAdotadosAdm();
            criar.ShowDialog();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmListarAdotadosAdm listar = new FrmListarAdotadosAdm();
            listar.ShowDialog();
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmAtualizarAdotadosAdm atualizar = new FrmAtualizarAdotadosAdm();
            atualizar.ShowDialog();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmDeletarAdotadosAdm atualizar = new FrmDeletarAdotadosAdm();
            atualizar.ShowDialog();
        }

        private void aplicaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            FrmAtualizarClienteAdm atualizar = new FrmAtualizarClienteAdm();
            atualizar.ShowDialog();
        }
    }
}
