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
    public partial class NewMeal : Form
    {
        public NewMeal()
        {
            InitializeComponent();
        }

        public void AddNewMeal()
        {
            Meal newMeal = new Meal();
            try
            {
                for(int i=0;i<OrderScreen.meal.Count();i++)//foreach ile dönünce invalid operation exception aldık.
                { 
                    if (!(OrderScreen.meal[i].Name == txtMealName.Text))
                    {
                        newMeal.Name = txtMealName.Text;
                        newMeal.Price = Double.Parse(txtPriceofMeal.Text);
                        OrderScreen.meal.Add(newMeal);
                        MessageBox.Show("Done");
                        break;
                    }

                    if (OrderScreen.meal[i].Name == txtMealName.Text)
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
        private void btnOK_Click(object sender, EventArgs e)
        {
            AddNewMeal();
            
        }
    }
}
