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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static List<Order> orders = new List<Order>();
        public static List<Order> availableOrders = new List<Order>();

        public static List<Menu> menus = new List<Menu>() {
            new Menu { MenuName = "McFish", Price = 20 },
            new Menu { MenuName = "Chicken Royal", Price = 37 },
            new Menu { MenuName = "Whooper", Price = 32 },
            new Menu { MenuName = "King Chicken", Price = 41 }
        };
        public static List<Extra> extras = new List<Extra>() {

            new Extra{ ExtraName = "Ketchup", Price = 2 },
            new Extra{ ExtraName = "Mayonnaise", Price = 3 },
            new Extra{ ExtraName = "Ranch", Price = 2 },
            new Extra{ ExtraName = "Garlic Mayonnaise", Price = 3 }
        };

        private void lstOrders_Load(object sender, EventArgs e)
        {
            foreach (Size item in Enum.GetValues(typeof(Size)))
            {
                flp_Sizes.Controls.Add(new RadioButton() { Text = item.ToString(), Tag = item });
            }
            foreach (Extra ex in extras)
            {
                flpExtra.Controls.Add(new CheckBox() { Text = ex.ExtraName, Tag = ex });
            }
            foreach (Menu item in menus)
            {
                cbMenus.Items.Add(item);
            }
            foreach (Order item in availableOrders)
            {
                lstOrder.Items.Add(item);
            }
            CalculateAmount();
            cbMenus.SelectedIndex = 0;
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            Order newOrder = new Order();
            newOrder.SelectedMenu = (Menu)cbMenus.SelectedItem;

            foreach (RadioButton item in flp_Sizes.Controls)
            {
                if (item.Checked)
                {
                    newOrder.Sizes = (Size)item.Tag;
                }
            }
            newOrder.ExtraMaterial = new List<Extra>();
            foreach (CheckBox item in flpExtra.Controls)
            {
                if (item.Checked)
                {
                    newOrder.ExtraMaterial.Add((Extra)item.Tag);
                }
            }
            newOrder.Number = Convert.ToInt32(nmrNumber.Value);
            newOrder.Calculate();
            availableOrders.Add(newOrder);
            orders.Add(newOrder);
            lstOrder.Items.Add(newOrder);
            CalculateAmount();
            Function.Clean(this.Controls);


        }

        private void btnCompleteOrder_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Total Order Fee : " + CalculateAmount().ToString("C2") + " Would you like to complete the purchase?", "Order Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr== System.Windows.Forms.DialogResult.Yes)
            {
                lstOrder.Items.Clear();
                availableOrders.Clear();
                CalculateAmount();
                MessageBox.Show("Order Complete!");
            }
            else
            {
                MessageBox.Show("It is cancelled!");
            }

        }
        public decimal CalculateAmount()
        {
            decimal totalAmoun = 0;
            for (int i = 0; i < lstOrder.Items.Count; i++)
            {
                Order incoming = (Order)lstOrder.Items[i];
                totalAmoun += incoming.TotalAmount;
            }
            lblTotalAmount.Text = totalAmoun.ToString("C2");
            return totalAmoun;

        }

    }
}
