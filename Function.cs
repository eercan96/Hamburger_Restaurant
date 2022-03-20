using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburger_Restaurant
{
    public static class Function
    {
        public static void Clean(Control.ControlCollection collec)
        {
            foreach (Control item in collec)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
                else if (item is CheckBox)
                {
                    CheckBox chk = (CheckBox)item;
                    chk.Checked = false;
                }
                else if (item is RadioButton)
                {
                    RadioButton rb = (RadioButton)item;
                    if (rb.Text == "Kucuk")
                        rb.Checked = true;
                    else
                        rb.Checked = false;

                }
                else if (item is NumericUpDown)
                {
                    NumericUpDown nmr = (NumericUpDown)item;
                    nmr.Value = 1;
                }
                else if (item is GroupBox)
                {
                    GroupBox gb = (GroupBox)item;
                    Clean(gb.Controls);
                }
                else if (item is FlowLayoutPanel)
                {
                    FlowLayoutPanel flp = (FlowLayoutPanel)item;
                    Clean(flp.Controls);
                }
                else if (item is ComboBox)
                {
                    ComboBox cb = (ComboBox)item;
                    cb.SelectedIndex = 0;
                }
            }
        }

    }
}
