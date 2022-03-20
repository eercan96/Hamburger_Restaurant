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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void ChildForm(Form childFrm)
        {
            this.Width = childFrm.Width ;
            this.Height = childFrm.Height ;

            bool status = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Text==childFrm.Text)
                {
                    status = true;
                    frm.Activate();
                }
                else
                {
                    frm.Close();
                }

            }
            if (status==false)
            {
                childFrm.MdiParent = this;
                childFrm.Show();
            }

        }

        private void createOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Form2());
        }

        private void orderInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Form3());
        }

        private void addHamburgerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChildForm(new Form4());
        }

        private void addExtraMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Form5());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
