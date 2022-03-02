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
    public partial class Endorsement : MDIParent
    {
        public Endorsement()
        {
            InitializeComponent();
        }

        private void Endorsement_Load(object sender, EventArgs e)
        {
            int i = 0;
            double totalEndorsement = 0;
            foreach (Order order in OrderScreen.orders)
            {
                i++;
                lBOrderList.Items.Add(i.ToString()+". "+order+": "+order.OrderPrice.ToString());
                totalEndorsement+=order.OrderPrice;
            }
            lblEndorsementTotal.Text = totalEndorsement.ToString();
            foreach (Order order in OrderScreen.orders)
            {
                i++;
                lBOrderDate.Items.Add(i + ". " + order.OrderDate);
            }
        }
    }
}
