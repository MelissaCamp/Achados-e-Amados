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
    public partial class FrmListAnimalAdm : Form
    {
        AnimalDTO animalDTO = new AnimalDTO();
        AnimalBLL animalBLL = new AnimalBLL();
        public FrmListAnimalAdm()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            FrmListCatalogoAdm cadastroAnimal = new FrmListCatalogoAdm();
            cadastroAnimal.ShowDialog();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtPesquisar.Text != "")
            {
                AnimalDTO animalDTO = animalBLL.PesquisarId(Convert.ToInt32(txtPesquisar.Text));
                if (animalDTO != null)
                {
                    List<AnimalDTO> lista = new List<AnimalDTO>();
                    lista.Add(animalDTO);
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
                DgTabela.DataSource = animalDTO;
            }
        }

        private void FrmListAnimalAdm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
