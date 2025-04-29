using System.Xml.XPath;

namespace WinAppPractice01
{
    public partial class FrmMain : Form
    {
        string operation = string.Empty;
        bool DivideByZero = false;

        public FrmMain()
        {
            InitializeComponent();
        }

        public string RemoveLastChar(string fulltext)
        {
            string bkp = string.Empty;
            char[] text = fulltext.ToCharArray();
            for (int i = 0; i < text.Length - 1; i++)
            {
                bkp += text[i];
            }
            return bkp;
        }

        public void Calculations()
        {
            try
            {
                if (TxtResult.Text.Contains("+"))
                {
                    string[] splitted = TxtResult.Text.Split('+');
                    if (splitted[1] != "")
                    {
                        int rr = CalculResult("plus", int.Parse(splitted[0]), int.Parse(splitted[1]));
                        TxtResult.Text = Convert.ToString(rr);
                    }
                }

                if (TxtResult.Text.Contains("-"))
                {
                    string[] splitted = TxtResult.Text.Split('-');
                    if (splitted[1] != "")
                    {
                        int rr = CalculResult("minus", int.Parse(splitted[0]), int.Parse(splitted[1]));
                        TxtResult.Text = Convert.ToString(rr);
                    }
                }

                if (TxtResult.Text.Contains("*"))
                {
                    string[] splitted = TxtResult.Text.Split('*');
                    if (splitted[1] != "")
                    {
                        int rr = CalculResult("multiply", int.Parse(splitted[0]), int.Parse(splitted[1]));
                        TxtResult.Text = Convert.ToString(rr);
                    }
                }

                if (TxtResult.Text.Contains("/"))
                {
                    string[] splitted = TxtResult.Text.Split('/');
                    if (splitted[1] != "")
                    {
                        if (Convert.ToInt32(splitted[1]) != 0)
                        {
                            int rr = CalculResult("divide", int.Parse(splitted[0]), int.Parse(splitted[1]));
                            TxtResult.Text = Convert.ToString(rr);
                        }
                        else
                        {
                            MessageBox.Show("Cannot divide by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            DivideByZero = true;
                            TxtResult.Text = string.Empty;
                        }
                    }
                }
            }
            catch
            {

            }
        }

        public int CalculResult(string operation, int num1, int num2)
        {
            int CalcResult = 0;
            try
            {
                if (TxtResult.Text.Contains("+") || TxtResult.Text.Contains("-") || TxtResult.Text.Contains("*") || TxtResult.Text.Contains("/"))
                {
                    switch (operation)
                    {
                        case "plus":
                            CalcResult = num1 + num2;
                            break;
                        case "minus":
                            CalcResult = num1 - num2;
                            break;
                        case "multiply":
                            CalcResult = num1 * num2;
                            break;
                        case "divide":
                            CalcResult = num1 / num2; ;
                            break;
                        default:
                            break;
                    }
                }
                return CalcResult;
            }
            catch
            {
                return CalcResult;
            }
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

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            string bkp = string.Empty;
            if (TxtResult.Text != string.Empty)
            {
                if (TxtResult.Text[TxtResult.Text.Length - 1] != Convert.ToChar("+"))
                {
                    Calculations();
                    if (TxtResult.Text[TxtResult.Text.Length - 1] == Convert.ToChar("*") ||
                        TxtResult.Text[TxtResult.Text.Length - 1] == Convert.ToChar("-") ||
                        TxtResult.Text[TxtResult.Text.Length - 1] == Convert.ToChar("/"))
                    {
                        bkp = RemoveLastChar(TxtResult.Text);
                        TxtResult.Text = bkp + "+";
                    }
                    else
                    {
                        if (!DivideByZero)
                            TxtResult.Text += "+";
                    }
                }
            }
            operation = "plus";
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            string bkp = string.Empty;
            if (TxtResult.Text != string.Empty)
            {
                if (TxtResult.Text[TxtResult.Text.Length - 1] != Convert.ToChar("-"))
                {
                    Calculations();
                    if (TxtResult.Text[TxtResult.Text.Length - 1] == Convert.ToChar("*") ||
                        TxtResult.Text[TxtResult.Text.Length - 1] == Convert.ToChar("+") ||
                        TxtResult.Text[TxtResult.Text.Length - 1] == Convert.ToChar("/"))
                    {
                        bkp = RemoveLastChar(TxtResult.Text);
                        TxtResult.Text = bkp + "-";
                    }
                    else
                    {
                        if (!DivideByZero)
                            TxtResult.Text += "-";
                    }
                }
            }
            operation = "minus";
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            string bkp = string.Empty;
            if (TxtResult.Text != string.Empty)
            {
                if (TxtResult.Text[TxtResult.Text.Length - 1] != Convert.ToChar("*"))
                {
                    Calculations();
                    if (TxtResult.Text[TxtResult.Text.Length - 1] == Convert.ToChar("-") ||
                        TxtResult.Text[TxtResult.Text.Length - 1] == Convert.ToChar("+") ||
                        TxtResult.Text[TxtResult.Text.Length - 1] == Convert.ToChar("/"))
                    {
                        bkp = RemoveLastChar(TxtResult.Text);
                        TxtResult.Text = bkp + "*";
                    }
                    else
                    {
                        if (!DivideByZero)
                            TxtResult.Text += "*";
                    }
                }
            }
            operation = "multiply";
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            string bkp = string.Empty;
            if (TxtResult.Text != string.Empty)
            {
                if (TxtResult.Text[TxtResult.Text.Length - 1] != Convert.ToChar("/"))
                {
                    Calculations();
                    if (TxtResult.Text[TxtResult.Text.Length - 1] == Convert.ToChar("*") ||
                        TxtResult.Text[TxtResult.Text.Length - 1] == Convert.ToChar("+") ||
                        TxtResult.Text[TxtResult.Text.Length - 1] == Convert.ToChar("-"))
                    {
                        bkp = RemoveLastChar(TxtResult.Text);
                        TxtResult.Text = bkp + "/";
                    }
                    else
                    {
                        if (!DivideByZero)
                            TxtResult.Text += "/";
                    }
                }
            }
            operation = "divide";
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            Calculations();
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            TxtResult.Text = string.Empty; ;
        }

        private void BtnBackspace_Click(object sender, EventArgs e)
        {
            string bkp = RemoveLastChar(TxtResult.Text);
            TxtResult.Text = bkp;
        }
    }
}
