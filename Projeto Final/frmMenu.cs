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
            frmPet tutor = new frmPet();
            tutor.Show();
        }

        private void veterinárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVet tutor = new frmVet();
            tutor.Show();

        }

        private void espécieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEspecie tutor = new frmEspecie();
            tutor.Show();

        }

        private void raçaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRaca tutor = new frmRaca();
            tutor.Show();

        }

        private void atendimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAtendimento tutor = new frmAtendimento();
            tutor.Show();
        }

        private void tutorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTutor tutor = new frmTutor();
            tutor.Show();

        }

        private void petToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPet tutor = new frmPet();
            tutor.Show();

        }

        private void tutorPetToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }
        private void marcacaoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMarca frm = new frmMarca();
            frm.Show();
        }

        private void atendimentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAtendimento frm = new frmAtendimento();
            frm.Show();

        }

        private void marcacaoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmMarca frm = new frmMarca();
            frm.Show();
        }

        private void marcaçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMarca frm = new frmMarca();
            frm.Show();
        }
    }
}
