namespace SabzMarketBuyer.UI
{
    public partial class FormStyle : Form
    {
        public FormStyle()
        {
            InitializeComponent();
            ApplyStyle();
        }


        protected void ApplyStyle()
        {
            this.BackColor = Color.Honeydew;
            this.Font = new Font(this.Font.FontFamily, 12, this.Font.Style);
        }
        public DialogResult ShowInfo(string massage)
        {
            return MessageBox.Show(massage);
        }
        public DialogResult ShowInfoError(string massage)
        {
            return MessageBox.Show(massage, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public DialogResult ShowInfoWarning(string massage)
        {
            return MessageBox.Show(massage, "هشدار", MessageBoxButtons.YesNo);
        }
    }
}
