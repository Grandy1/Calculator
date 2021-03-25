using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        double number1 = 0, number2 = 0;
        char sign;

        private void plus_or_minus_button_Click(object sender, EventArgs e)
        {
            if (workspace.Text.StartsWith("-"))
                workspace.Text = workspace.Text.Remove(0, 1);
            else
                workspace.Text = "-" + workspace.Text;
        }

        private void zero_button_Click(object sender, EventArgs e)
        {
            if (!(workspace.Text.StartsWith("0") || workspace.Text.StartsWith("-0") || workspace.Text.StartsWith("0.") || workspace.Text.StartsWith("-0.")) || workspace.Text.Contains("."))
            {
                workspace.Text += "0";
            }
        }

        private void point_button_Click(object sender, EventArgs e)
        {
            if (!workspace.Text.Contains("."))
            {
                workspace.Text += ".";
            }
        }

        private void equal_button_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToInt32(workspace.Text);
            if (number2 == 0)
            {
                workspace.Text = "Devide by zero";
            }
            else
            {
                switch (sign)
                {
                    case '+':
                        workspace.Text = (number1 + number2).ToString();
                        break;
                    case '-':
                        workspace.Text = (number1 - number2).ToString();
                        break;
                    case '*':
                        workspace.Text = (number1 * number2).ToString();
                        break;
                    case '/':
                        workspace.Text = (number1 / number2).ToString();
                        break;
                    default:
                        break;
                }
            }
            number1 = number2 = 0;
            sign = ' ';
        }

        private void one_button_Click(object sender, EventArgs e)
        {
            if (workspace.Text.StartsWith("0") && !workspace.Text.StartsWith("0."))
            {
                workspace.Text = workspace.Text.Remove(0);
                workspace.Text += "1";
            }
            else if (workspace.Text.StartsWith("-0") && !workspace.Text.StartsWith("-0."))
            {
                workspace.Text = workspace.Text.Remove(0);
                workspace.Text += "-1";
            }
            else
            {
                workspace.Text += "1";
            }
        }

        private void two_button_Click(object sender, EventArgs e)
        {
            if (workspace.Text.StartsWith("0") && !workspace.Text.StartsWith("0."))
            {
                workspace.Text = workspace.Text.Remove(0);
                workspace.Text += "2";
            }
            else if (workspace.Text.StartsWith("-0") && !workspace.Text.StartsWith("-0."))
            {
                workspace.Text = workspace.Text.Remove(0);
                workspace.Text += "-2";
            }
            else
            {
                workspace.Text += "2";
            }
        }

        private void three_button_Click(object sender, EventArgs e)
        {
            if (workspace.Text.StartsWith("0") && !workspace.Text.StartsWith("0."))
            {
                workspace.Text = workspace.Text.Remove(0);
                workspace.Text += "3";
            }
            else if (workspace.Text.StartsWith("-0") && !workspace.Text.StartsWith("-0."))
            {
                workspace.Text = workspace.Text.Remove(0);
                workspace.Text += "-3";
            }
            else
            {
                workspace.Text += "3";
            }
        }

        private void plus_button_Click(object sender, EventArgs e)
        {
            try
            {
                number1 = Convert.ToDouble(workspace.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            sign = workspace.Text.StartsWith("-") ? '-' : '+';
            //if (textBox.Text.StartsWith("-"))
            //{
            //    sign = '-';
            //}
            //else
            //{
            //    sign = '+';
            //}
            workspace.Text = "0";
        }

        private void four_button_Click(object sender, EventArgs e)
        {
            if (workspace.Text.StartsWith("0") && !workspace.Text.StartsWith("0."))
            {
                workspace.Text = workspace.Text.Remove(0);
                workspace.Text += "4";
            }
            else if (workspace.Text.StartsWith("-0") && !workspace.Text.StartsWith("-0."))
            {
                workspace.Text = workspace.Text.Remove(0);
                workspace.Text += "-4";
            }
            else
            {
                workspace.Text += "1";
            }
        }

        private void five_button_Click(object sender, EventArgs e)
        {
            if (workspace.Text.StartsWith("0") && !workspace.Text.StartsWith("0."))
            {
                workspace.Text = workspace.Text.Remove(0);
                workspace.Text += "5";
            }
            else if (workspace.Text.StartsWith("-0") && !workspace.Text.StartsWith("-0."))
            {
                workspace.Text = workspace.Text.Remove(0);
                workspace.Text += "-5";
            }
            else
            {
                workspace.Text += "5";
            }
        }

        private void six_button_Click(object sender, EventArgs e)
        {
            if (workspace.Text.StartsWith("0") && !workspace.Text.StartsWith("0."))
            {
                workspace.Text = workspace.Text.Remove(0);
                workspace.Text += "6";
            }
            else if (workspace.Text.StartsWith("-0") && !workspace.Text.StartsWith("-0."))
            {
                workspace.Text = workspace.Text.Remove(0);
                workspace.Text += "-6";
            }
            else
            {
                workspace.Text += "6";
            }
        }

        private void minus_button_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(workspace.Text);
            if (sign == '+' || sign == '-' || sign == '*' || sign == '/')
            {
                workspace.Text = "0";
                workspace.Text = "-" + workspace.Text;
            }
            sign = '-';
        }

        private void seven_button_Click(object sender, EventArgs e)
        {
            if (workspace.Text.StartsWith("0") && !workspace.Text.StartsWith("0."))
            {
                workspace.Text = workspace.Text.Remove(0);
                workspace.Text += "7";
            }
            else if (workspace.Text.StartsWith("-0") && !workspace.Text.StartsWith("-0."))
            {
                workspace.Text = workspace.Text.Remove(0);
                workspace.Text += "-7";
            }
            else
            {
                workspace.Text += "7";
            }
        }

        private void eight_button_Click(object sender, EventArgs e)
        {
            if (workspace.Text.StartsWith("0") && !workspace.Text.StartsWith("0."))
            {
                workspace.Text = workspace.Text.Remove(0);
                workspace.Text += "8";
            }
            else if (workspace.Text.StartsWith("-0") && !workspace.Text.StartsWith("-0."))
            {
                workspace.Text = workspace.Text.Remove(0);
                workspace.Text += "-8";
            }
            else
            {
                workspace.Text += "8";
            }
        }

        private void nine_button_Click(object sender, EventArgs e)
        {
            if (workspace.Text.StartsWith("0") && !workspace.Text.StartsWith("0."))
            {
                workspace.Text = workspace.Text.Remove(0);
                workspace.Text += "9";
            }
            else if (workspace.Text.StartsWith("-0") && !workspace.Text.StartsWith("-0."))
            {
                workspace.Text = workspace.Text.Remove(0);
                workspace.Text += "-9";
            }
            else
            {
                workspace.Text += "9";
            }
        }

        private void multiplication_button_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(workspace.Text);
            sign = '*';
            workspace.Text = "0";
        }

        private void delete_last_button_Click(object sender, EventArgs e)
        {
            string s = workspace.Text;
            if (s.Length == 2 && s.StartsWith("-") || s.Contains("Devide by zero") || s.Contains("Wronng Enter"))
            {
                s = "0";
            }
            else if (s.Length > 1)
            {
                s = s.Substring(0, s.Length - 1);
            }
            else
            {
                s = "0";
            }
            workspace.Text = s;
        }

        private void division_button_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(workspace.Text);
            sign = '/';
            workspace.Text = "0";
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            workspace.Text = "0";
        }

        private void sqrt_x_button_Click(object sender, EventArgs e)
        {
            workspace.Text = Math.Sqrt(Convert.ToDouble(workspace.Text)).ToString();
        }

        private void clear_entry_button_Click(object sender, EventArgs e)
        {

        }

        private void percent_button_Click(object sender, EventArgs e)
        {
            //number2 = Convert.ToDouble(textBox.Text);
            number2 = Convert.ToDouble(workspace.Text);
            if (number2 != 0)
            {
                workspace.Text = number2.ToString();
                switch (sign)
                {
                    case '+':
                        workspace.Text = (number1 + number2 * 0.01).ToString();
                        break;
                    case '-':
                        workspace.Text = (number1 - number2 * 0.01).ToString();
                        break;
                    case '*':
                        workspace.Text = (number1 * number2 * 0.01).ToString();
                        break;
                    case '/':
                        workspace.Text = (number1 / number2 * 0.01).ToString();
                        break;
                    default:
                        //textBox.Text = "Wronng Enter";
                        break;
                }
            }
            else
            {
                workspace.Text = (Convert.ToDouble(workspace.Text) * 0.01).ToString();
            }
        }

        private void x_power_2_button_Click(object sender, EventArgs e)
        {
            workspace.Text = Math.Pow(Convert.ToDouble(workspace.Text), 2).ToString();
        }

        private void one_by_x_button_Click(object sender, EventArgs e)
        {
            workspace.Text = (1/Convert.ToDouble(workspace.Text)).ToString();
        }
    }
}
