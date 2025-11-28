using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket
{
    public class MyTextBox:Guna2TextBox
    {
        public MyTextBox() 
        {
            this.FillColor = Color.PaleGreen;
            this.ForeColor = Color.DarkGreen;
            this.Font = new Font(this.Font.FontFamily, 11, this.Font.Style);

        }
    }
}
