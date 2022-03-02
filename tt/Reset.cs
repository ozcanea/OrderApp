using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace tt
{
    public class Reset
    {
        public static void ResetForm(Control.ControlCollection control)
        {
            foreach (Control c in control)
            {
                if (c is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)c;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = 0;
                }

                if (c is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)c;
                    checkBox.Checked = false;
                }

                if (c is ListBox)
                {
                    ListBox listBox = (ListBox)c;
                    listBox.Items.Clear();
                }
                if(c is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)c;
                    radioButton.Checked = false;
                }

            }
        }
    }
}
