using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SabzMarkett
{
    public class FormStyle:Form
    {
        public override Color BackColor 
        { get => base.BackColor;
            set => base.BackColor = Color.Honeydew; }
        public override Font Font 
        { get => base.Font;
            set => base.Font = new Font(this.Font.FontFamily, 12, this.Font.Style); }

    }
}