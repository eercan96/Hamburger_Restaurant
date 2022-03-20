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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Form2.extras.Add(new Extra { ExtraName = txtName.Text, Price = nmrPrice.Value });
            Function.Clean(this.Controls);
            MessageBox.Show("Successfully added.");
        }
    }
}
