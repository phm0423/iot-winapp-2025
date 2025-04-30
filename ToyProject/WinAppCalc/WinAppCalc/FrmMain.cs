namespace WinAppCalc
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "0";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "9";
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            TxtResult.Clear();
        }

        private void BtnBS_Click(object sender, EventArgs e)
        {
            String text = RemoveLastchar(TxtResult.Text);
            TxtResult.Text = text;
        }
        private string RemoveLastchar(string text)
        {
            if (text.Length > 0)
            {
                return text.Substring(0, text.Length - 1);
            }
            return text;
        }
    }
}
