using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Final
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void tutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTutor tutor = new frmTutor();
            tutor.Show();
        }

        private void petToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPet pet = new frmPet();
            pet.Show();
        }

        private void veterinárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVet vet = new frmVet();
            vet.Show();

        }

        private void espécieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEspecie especie = new frmEspecie();
            especie.Show();

        }

        private void raçaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRaca raca = new frmRaca();
            raca.Show();

        }

        private void atendimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAtendimento atendimento = new frmAtendimento();
            atendimento.Show();
        }

        private void tutorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTutor tutor = new frmTutor();
            tutor.Show();

        }

        private void petToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPet pet = new frmPet();
            pet.Show();

        }

        private void tutorPetToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }
        private void marcacaoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMarca marca = new frmMarca();
            marca.Show();
        }

        private void atendimentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAtendimento atendimento = new frmAtendimento();
            atendimento.Show();

        }

        private void marcacaoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmMarca marca = new frmMarca();
            marca.Show();
        }

        private void marcaçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMarca frm = new frmMarca();
            frm.Show();
        }

        private void exameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExame exame = new frmExame();
            exame.Show();
        }
    }
}
