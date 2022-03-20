using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_Restaurant
{
    public enum Size { Small, Medium, Big };
    public class Order
    {
        public Menu SelectedMenu { get; set; }
        public Size Sizes { get; set; }
        public List<Extra> ExtraMaterial { get; set; }
        public int Number { get; set; }
        public decimal TotalAmount { get; set; }

        public void Calculate()
        {
            TotalAmount = 0;
            TotalAmount += SelectedMenu.Price;
            switch (Sizes)
            {
                case Size.Medium:
                    TotalAmount += TotalAmount * 0.20m;
                    break;
                case Size.Big:
                    TotalAmount += TotalAmount * 0.40m;
                    break;
            }
            foreach (Extra ext in ExtraMaterial)
            {
                TotalAmount += ext.Price;
            }
            TotalAmount *= Number;
        }
        public override string ToString()
        {
            if (ExtraMaterial.Count<1)
            {
                return string.Format("{0} Menu, x{1} Number, {2} Size, Total : {3}", SelectedMenu.MenuName, Number, Sizes.ToString(), TotalAmount.ToString("C2"));
            }
            else
            {
                string exMaterails = "";
                foreach (Extra ext in ExtraMaterial)
                {
                    exMaterails += ext.ExtraName + ",";
                }

                exMaterails = exMaterails.Trim (',');
                return string.Format("{0} Menu, x{1} Number, {2} Size, ({3}) Total : {4}", SelectedMenu.MenuName, Number, Sizes.ToString(), exMaterails, TotalAmount.ToString("C2"));

            }
        }




    }
}
