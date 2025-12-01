using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SabzMarket
{
    public class FormStyle:Form
    {
        public FormStyle()
        {
            InitializeForm();
        }

        private void InitializeForm()
        { 
        }

        public override Color BackColor
        {
            get => base.BackColor;
            set => base.BackColor = Color.Honeydew;
        }
        public override Font Font
        {
            get => base.Font;
            set => base.Font = new Font(this.Font.FontFamily, 12, this.Font.Style);
        }
        public DialogResult ShowInfo(string massage)
        {
            return MessageBox.Show(massage);
        }
        public DialogResult ShowInfoError(string massage)
        {
            return MessageBox.Show(massage,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}