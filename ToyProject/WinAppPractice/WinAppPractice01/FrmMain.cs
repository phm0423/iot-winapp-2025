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

        private void FocusToEnd()
        {
            TxtResult.Focus();
            TxtResult.SelectionStart = TxtResult.Text.Length;
            TxtResult.SelectionLength = 0;
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
                        if (splitted[0].Contains('.') || splitted[1].Contains('.'))
                        {
                            float fr = CalculFloatResult("plus", float.Parse(splitted[0]), float.Parse(splitted[1]));
                            TxtResult.Text = fr.ToString("0.##########");
                        }
                        else
                        {
                            long rr = CalculIntResult("plus", long.Parse(splitted[0]), long.Parse(splitted[1]));
                            TxtResult.Text = Convert.ToString(rr);
                        }
                    }
                }

                if (TxtResult.Text.Contains("-"))
                {
                    string[] splitted = TxtResult.Text.Split('-');
                    if (splitted[1] != "")
                    {
                        if (splitted[0].Contains('.') || splitted[1].Contains('.'))
                        {
                            float fr = CalculFloatResult("minus", float.Parse(splitted[0]), float.Parse(splitted[1]));
                            TxtResult.Text = fr.ToString("0.##########");
                        }
                        else
                        {
                            long rr = CalculIntResult("minus", long.Parse(splitted[0]), long.Parse(splitted[1]));
                            TxtResult.Text = Convert.ToString(rr);
                        }
                    }
                }

                if (TxtResult.Text.Contains("*"))
                {
                    string[] splitted = TxtResult.Text.Split('*');
                    if (splitted[1] != "")
                    {
                        if (splitted[0].Contains('.') || splitted[1].Contains('.'))
                        {
                            float fr = CalculFloatResult("multiply", float.Parse(splitted[0]), float.Parse(splitted[1]));
                            TxtResult.Text = fr.ToString("0.##########");
                        }
                        else
                        {
                            long rr = CalculIntResult("multiply", long.Parse(splitted[0]), long.Parse(splitted[1]));
                            TxtResult.Text = Convert.ToString(rr);
                        }
                    }
                }

                if (TxtResult.Text.Contains("/"))
                {
                    string[] splitted = TxtResult.Text.Split('/');
                    if (splitted[1] != "")
                    {
                        if (!splitted[1].Contains('.'))
                        {
                            if (Convert.ToInt32(splitted[1]) != 0)
                            {
                                if (splitted[0].Contains('.') || splitted[1].Contains('.'))
                                {
                                    float fr = CalculFloatResult("divide", float.Parse(splitted[0]), float.Parse(splitted[1]));
                                    TxtResult.Text = fr.ToString("0.##########");
                                }
                                else
                                {
                                    long rr = CalculIntResult("divide", long.Parse(splitted[0]), long.Parse(splitted[1]));
                                    TxtResult.Text = Convert.ToString(rr);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Cannot divide by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                DivideByZero = true;
                                TxtResult.Text = string.Empty;
                            }
                        }
                        else
                        {
                            if (float.Parse(splitted[1]) != 0)
                            {
                                if (splitted[0].Contains('.') || splitted[1].Contains('.'))
                                {
                                    float fr = CalculFloatResult("divide", float.Parse(splitted[0]), float.Parse(splitted[1]));
                                    TxtResult.Text = fr.ToString("0.##########");
                                }
                                else
                                {
                                    long rr = CalculIntResult("divide", long.Parse(splitted[0]), long.Parse(splitted[1]));
                                    TxtResult.Text = Convert.ToString(rr);
                                }
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
            }
            catch
            {

            }
        }

        public long CalculIntResult(string operation, long num1, long num2)
        {
            long CalcResult = 0;
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

        public float CalculFloatResult(string operation, float num1, float num2)
        {
            float CalcResult = 0;
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
            FocusToEnd();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "1";
            FocusToEnd();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "2";
            FocusToEnd();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "3";
            FocusToEnd();
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "4";
            FocusToEnd();
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "5";
            FocusToEnd();
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "6";
            FocusToEnd();
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "7";
            FocusToEnd();
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "8";
            FocusToEnd();
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "9";
            FocusToEnd();
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
            FocusToEnd();
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
            FocusToEnd();
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
            FocusToEnd();
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
            FocusToEnd();
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            Calculations();
            FocusToEnd();
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            TxtResult.Text = string.Empty; ;
            FocusToEnd();
        }

        private void BtnBackspace_Click(object sender, EventArgs e)
        {
            string bkp = RemoveLastChar(TxtResult.Text);
            TxtResult.Text = bkp;
            FocusToEnd();
        }

        private void BtnPoint_Click(object sender, EventArgs e)
        {
            int counter = 0;
            if (TxtResult.Text != "")
            {
                if (TxtResult.Text[TxtResult.Text.Length - 1] != '.')
                {
                    char[] signs = { '+', '-', '*', '/' };
                    foreach (char c in signs)
                    {
                        if (TxtResult.Text.Contains(c))
                        {
                            string[] SingSplitted = TxtResult.Text.Split(c);
                            counter++;
                            if (!SingSplitted[1].Contains('.'))
                                TxtResult.Text += ".";
                        }
                    }
                    if (counter == 0)
                    {
                        if (!TxtResult.Text.Contains('.'))
                            TxtResult.Text += ".";
                    }
                }
            }
            else
            {
                TxtResult.Text += "0.";
            }
            FocusToEnd();
        }

        private void TxtResult_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnEqual_Click(sender, e);
            }
        }
    }
}
