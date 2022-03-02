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
    public partial class NewExtra : Form
    {
        public NewExtra()
        {
            InitializeComponent();
        }

        private void btnOKExtra_Click(object sender, EventArgs e)
        {
            Extra newExtra = new Extra();
            try
            {
                for (int i = 0; i < OrderScreen.sauces.Count(); i++)//foreach ile dönünce invalid operation exception aldık.
                {
                    if (!(OrderScreen.sauces[i].Name == txtExtraName.Text))
                    {
                        newExtra.Name = txtExtraName.Text;
                        newExtra.Price = Double.Parse(txtPriceofExtra.Text);
                        OrderScreen.sauces.Add(newExtra);
                        MessageBox.Show("Done");
                        break;
                    }

                    if (OrderScreen.meal[i].Name == txtExtraName.Text)
                    {
                        MessageBox.Show("Your Meal Name Already Taken", "Hold", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        break;
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Name or Price");
            }
            
            OrderScreen orderScreen = new OrderScreen();
            orderScreen.Show();
            this.Hide();
        }
    }
}
