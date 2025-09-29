using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.WebControls;



namespace SabzMarkett
{
    public class MyButton:Guna2Button
    {
        
        public MyButton() 
        {
           
            // ظاهر پایه
            this.FillColor = Color.SeaGreen;
            this.ForeColor = Color.White;

            // گوشه گرد
            this.BorderRadius = 8;
            base.Font = new Font(this.Font.FontFamily, 11, this.Font.Style);
            // Hover
            this.HoverState.FillColor = Color.MediumSeaGreen;

            // Pressed
            this.PressedColor = Color.DarkGreen;

            // Disabled
            this.DisabledState.FillColor = Color.LightGray;
            this.DisabledState.ForeColor = Color.DarkGray;

            // اندازه پیش‌فرض (اگه لازم داری)
            this.Size = new Size(120, 40);

        }
    }
}
