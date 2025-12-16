using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarketBuyer.UI
{
    public class MyButon : Button
    {
        protected override bool ShowFocusCues => false;
        protected override void OnMouseEnter(EventArgs e)
        {
            
        }
        protected override void OnGotFocus(EventArgs e)
        {
            
            Parent!.Select();
        }
    }
}
