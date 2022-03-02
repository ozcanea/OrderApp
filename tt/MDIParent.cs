using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tt
{
    public partial class MDIParent : Form
    {
        public MDIParent()
        {
            InitializeComponent();
        }

        //public void OpenScreen(class NewForm)
        //{
        //    NewForm nForm = new NewForm();
        //    this.Hide();
        //    nForm.Show();        // methodla yapamadım!




        private void endorsementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Endorsement endorsement = new Endorsement();
            endorsement.Show();
            this.Hide();
        }

        private void menuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMeal newMeal = new NewMeal();
            newMeal.Show();
            this.Hide();
        }

        private void sosEkleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            NewExtra newExtra = new NewExtra();
            newExtra.Show();
            this.Hide();
        }

        private void yeniSiparisToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OrderScreen screen = new OrderScreen();
            this.Hide();
            screen.Show();
        }
    }
}
