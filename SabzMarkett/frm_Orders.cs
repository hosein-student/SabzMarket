using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SabzMarkett
{
    public partial class frm_Orders : FormStyle
    {
        public frm_Orders()
        {
            InitializeComponent();
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            frm_History frm_History = new frm_History();
            frm_History.ShowDialog();
        }
    }
}
