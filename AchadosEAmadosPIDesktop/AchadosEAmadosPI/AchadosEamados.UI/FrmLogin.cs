using AchadosEamados.BLL;
using AchadosEamados.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AchadosEamados.UI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string nome = txtUsuario.Text;
            string senha = txtSenha.Text;

            FuncionarioDTO funcionarioDTO = new FuncionarioDTO();
            FuncionarioBLL funcionarioBLL = new FuncionarioBLL();

            funcionarioDTO = funcionarioBLL.AutenticaFuncionario(nome, senha);

            if (funcionarioDTO != null)
            {
                if (funcionarioDTO.IdTpFuncionario == 1)
                {
                    MessageBox.Show($"Bem vindo(a) {funcionarioDTO.Nome}!");
                    Hide();
                    frmPrincipalAdm principalAdm = new frmPrincipalAdm();
                    principalAdm.ShowDialog();
                }
                else if (funcionarioDTO.IdTpFuncionario == 3)
                {
                    MessageBox.Show($"Bem vindo(a) {funcionarioDTO.Nome}!");
                    Hide();
                    FrmGerenVetPrincipal principalVet = new FrmGerenVetPrincipal();
                    principalVet.ShowDialog();
                }
                else if (funcionarioDTO.IdTpFuncionario == 2)
                {
                    MessageBox.Show($"Bem vindo(a) {funcionarioDTO.Nome}!");
                    Hide();
                    FrmPrincipalCuidador principalCuidador = new FrmPrincipalCuidador();
                    principalCuidador.ShowDialog();
                }
                else
                {
                    MessageBox.Show($"Bem vindo(a) {funcionarioDTO.Nome}!");
                    Hide();
                    FrmGerenVetPrincipal principalGeren = new FrmGerenVetPrincipal();
                    principalGeren.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show($"Não foi possível logar, verifique as informações.");
            }
        }
        

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            txtSenha.Text = "";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Hide();
            frmCadastro cadastro = new frmCadastro();
            cadastro.Show();
        }
    }
}
