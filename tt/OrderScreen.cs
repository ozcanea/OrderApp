using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tt
{

    public partial class OrderScreen : MDIParent
    {
        //message box method
        public void MessageB()
        {
            string text = "";
            int i = 0;
            foreach (Order o in listBox1.Items)
            {
                i++;
                orders.Add(o);
                text += i.ToString() + ". " + o.ToString() + "\n";
            }
            var result = MessageBox.Show(text, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                MDIParent confirmScreen = new MDIParent();
                confirmScreen.Show();
                this.Hide();
                this.listBox1.Items.Clear();
            }
        }
        //adding checkboxes to flowlayoutpanel
        public void AddtoGroupBox()
        {
            
            foreach (Extra extra in sauces)
            {
                CheckBox c = new CheckBox();
                c.Tag = extra;
                c.Text = extra.Name;
                c.AutoSize = true;
                this.Controls.Add(c);
                flowLayoutPanel1.Controls.Add(c);
            }
        }

        double totalPrice = 0;
        public static List<Extra> sauces = new List<Extra>()
        {
            new Extra("Mayo", 0.10 ),
            new Extra("Buffalo",0.10 ),
            new Extra("Range ", 0.10 ),
            new Extra("Hollandaise", 0.10 ),
            new Extra("Ketchup",0.10 ),
            new Extra("Barbeque", 0.10 ),
        };
        public static List<Order> orders = new List<Order>();
        
        public static List<Meal> meal = new List<Meal>()
        {
            new Meal("Extra Tasty", 10 ),
            new Meal("Better Than Margot Robbie",20),
            new Meal("Hotter Than My Ex",13),
            new Meal("That Make U Cry",18),
            new Meal("Chicky Chicks",16)

        };
        public OrderScreen()
        {
            InitializeComponent();
        }


        public void AddToListBox()
        {


        }

        private void OrderScreen_Load(object sender, EventArgs e)
        {
            foreach (Meal meal in meal)
            {
                comboBox1.Items.Add(meal);
            }
            comboBox1.SelectedIndex = 0;
            rBSmall.Checked = true;
            Sizee sizeS = new Sizee { SizeName = "Small", AdditionalCost = 0 };
            Sizee sizeR = new Sizee { SizeName = "Regular", AdditionalCost = 1 };
            Sizee sizeL = new Sizee { SizeName = "Large", AdditionalCost = 2 };
            rBSmall.Tag = sizeS;
            rBRegular.Tag = sizeR;
            rBLarge.Tag = sizeL;
            AddtoGroupBox();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            //create meal object
            Meal m = (Meal)comboBox1.SelectedItem;
            m.MealCount = Convert.ToInt16(numericUpDown1.Value);
            //add MealSize 
            if (rBSmall.Checked)
                m.MSize = (Sizee)rBSmall.Tag;

            if (rBRegular.Checked)
                m.MSize = (Sizee)rBRegular.Tag;

            if (rBLarge.Checked)
                m.MSize = (Sizee)rBLarge.Tag;

            totalPrice += Convert.ToDouble(numericUpDown1.Value) * m.TotalPrice;

            //define sauces
            foreach (CheckBox c in flowLayoutPanel1.Controls)
            {
                if (c.Checked)
                {
                    m.Extra = (Extra)c.Tag;
                    totalPrice += m.Extra.Price;
                    sauces.Add((Extra)c.Tag);
                }
            }
            lblPrice.Text = totalPrice.ToString();
            o.OrderPrice = totalPrice;
            o.OrderMeal = m;
            o.OrderDate = DateTime.Now;
            listBox1.Items.Add(o);
            //we hold data about extra in sauces list so everytime we have to delete items that we print 
            sauces.Clear();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {

            Reset.ResetForm(this.Controls);
            totalPrice = 0;
            lblPrice.Text = "";

        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {

                totalPrice = totalPrice - ((Order)listBox1.SelectedItem).OrderPrice;

                listBox1.Items.Remove(listBox1.SelectedItem);
                lblPrice.Text = totalPrice.ToString();

            }
            else
                MessageBox.Show("Please Selec An Item");


        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageB();

        }
    }
}
