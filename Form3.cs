using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburger_Restaurant
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            decimal endorsement = 0;
            decimal exMaterial = 0;
            int numberProc = 0;
            foreach (Order item in Form2.orders)
            {
                endorsement += item.TotalAmount;
                foreach (Extra ext in item.ExtraMaterial)
                {
                    exMaterial += ext.Price;
                }
                numberProc += item.Number;
                lstOrders.Items.Add(item);

            }
            lblTotalNumberofOrder.Text = lstOrders.Items.Count.ToString();
            lblEndor.Text = endorsement.ToString("C2");
            lblExtra.Text = exMaterial.ToString("C2");
            lblNumberOfProduct.Text = numberProc.ToString();

        }
    }
}
