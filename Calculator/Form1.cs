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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double number1 = 0, number2 = 0;
        char sign;

        private void plus_or_minus_button_Click(object sender, EventArgs e)
        {
            if (textBox.Text.StartsWith("-"))
                textBox.Text = textBox.Text.Remove(0, 1);
            else
                textBox.Text = "-" + textBox.Text;
        }

        private void zero_button_Click(object sender, EventArgs e)
        {
            if (!(textBox.Text.StartsWith("0") || textBox.Text.StartsWith("-0") || textBox.Text.StartsWith("0.") || textBox.Text.StartsWith("-0.")) || textBox.Text.Contains("."))
            {
                textBox.Text += "0";
            }
        }

        private void point_button_Click(object sender, EventArgs e)
        {
            if (!textBox.Text.Contains("."))
            {
                textBox.Text += ".";
            }
        }

        private void equal_button_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToInt32(textBox.Text);
            if (number2 == 0)
            {
                textBox.Text = "Devide by zero";
            }
            else
            {
                switch (sign)
                {
                    case '+':
                        textBox.Text = (number1 + number2).ToString();
                        break;
                    case '-':
                        textBox.Text = (number1 - number2).ToString();
                        break;
                    case '*':
                        textBox.Text = (number1 * number2).ToString();
                        break;
                    case '/':
                        textBox.Text = (number1 / number2).ToString();
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
            if (textBox.Text.StartsWith("0") && !textBox.Text.StartsWith("0."))
            {
                textBox.Text = textBox.Text.Remove(0);
                textBox.Text += "1";
            }
            else if (textBox.Text.StartsWith("-0") && !textBox.Text.StartsWith("-0."))
            {
                textBox.Text = textBox.Text.Remove(0);
                textBox.Text += "-1";
            }
            else
            {
                textBox.Text += "1";
            }
        }

        private void two_button_Click(object sender, EventArgs e)
        {
            if (textBox.Text.StartsWith("0") && !textBox.Text.StartsWith("0."))
            {
                textBox.Text = textBox.Text.Remove(0);
                textBox.Text += "2";
            }
            else if (textBox.Text.StartsWith("-0") && !textBox.Text.StartsWith("-0."))
            {
                textBox.Text = textBox.Text.Remove(0);
                textBox.Text += "-2";
            }
            else
            {
                textBox.Text += "2";
            }
        }

        private void three_button_Click(object sender, EventArgs e)
        {
            if (textBox.Text.StartsWith("0") && !textBox.Text.StartsWith("0."))
            {
                textBox.Text = textBox.Text.Remove(0);
                textBox.Text += "3";
            }
            else if (textBox.Text.StartsWith("-0") && !textBox.Text.StartsWith("-0."))
            {
                textBox.Text = textBox.Text.Remove(0);
                textBox.Text += "-3";
            }
            else
            {
                textBox.Text += "3";
            }
        }

        private void plus_button_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox.Text);
            sign = '+';
            textBox.Text = "0";
        }

        private void four_button_Click(object sender, EventArgs e)
        {
            if (textBox.Text.StartsWith("0") && !textBox.Text.StartsWith("0."))
            {
                textBox.Text = textBox.Text.Remove(0);
                textBox.Text += "4";
            }
            else if (textBox.Text.StartsWith("-0") && !textBox.Text.StartsWith("-0."))
            {
                textBox.Text = textBox.Text.Remove(0);
                textBox.Text += "-4";
            }
            else
            {
                textBox.Text += "1";
            }
        }

        private void five_button_Click(object sender, EventArgs e)
        {
            if (textBox.Text.StartsWith("0") && !textBox.Text.StartsWith("0."))
            {
                textBox.Text = textBox.Text.Remove(0);
                textBox.Text += "5";
            }
            else if (textBox.Text.StartsWith("-0") && !textBox.Text.StartsWith("-0."))
            {
                textBox.Text = textBox.Text.Remove(0);
                textBox.Text += "-5";
            }
            else
            {
                textBox.Text += "5";
            }
        }

        private void six_button_Click(object sender, EventArgs e)
        {
            if (textBox.Text.StartsWith("0") && !textBox.Text.StartsWith("0."))
            {
                textBox.Text = textBox.Text.Remove(0);
                textBox.Text += "6";
            }
            else if (textBox.Text.StartsWith("-0") && !textBox.Text.StartsWith("-0."))
            {
                textBox.Text = textBox.Text.Remove(0);
                textBox.Text += "-6";
            }
            else
            {
                textBox.Text += "6";
            }
        }

        private void minus_button_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox.Text);
            sign = '-';
            textBox.Text = "0";
        }

        private void seven_button_Click(object sender, EventArgs e)
        {
            if (textBox.Text.StartsWith("0") && !textBox.Text.StartsWith("0."))
            {
                textBox.Text = textBox.Text.Remove(0);
                textBox.Text += "7";
            }
            else if (textBox.Text.StartsWith("-0") && !textBox.Text.StartsWith("-0."))
            {
                textBox.Text = textBox.Text.Remove(0);
                textBox.Text += "-7";
            }
            else
            {
                textBox.Text += "7";
            }
        }

        private void eight_button_Click(object sender, EventArgs e)
        {
            if (textBox.Text.StartsWith("0") && !textBox.Text.StartsWith("0."))
            {
                textBox.Text = textBox.Text.Remove(0);
                textBox.Text += "8";
            }
            else if (textBox.Text.StartsWith("-0") && !textBox.Text.StartsWith("-0."))
            {
                textBox.Text = textBox.Text.Remove(0);
                textBox.Text += "-8";
            }
            else
            {
                textBox.Text += "8";
            }
        }

        private void nine_button_Click(object sender, EventArgs e)
        {
            if (textBox.Text.StartsWith("0") && !textBox.Text.StartsWith("0."))
            {
                textBox.Text = textBox.Text.Remove(0);
                textBox.Text += "9";
            }
            else if (textBox.Text.StartsWith("-0") && !textBox.Text.StartsWith("-0."))
            {
                textBox.Text = textBox.Text.Remove(0);
                textBox.Text += "-9";
            }
            else
            {
                textBox.Text += "9";
            }
        }

        private void multiplication_button_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox.Text);
            sign = '*';
            textBox.Text = "0";
        }

        private void delete_last_button_Click(object sender, EventArgs e)
        {
            string s = textBox.Text;
            if (s.Length == 2 && s.StartsWith("-"))
            {
                s = "0";
            } else if (s.Length > 1)
            {
                s = s.Substring(0, s.Length - 1);
            } else
            {
                s = "0";
            }
            textBox.Text = s;
        }

        private void division_button_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox.Text);
            sign = '/';
            textBox.Text = "0";
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }

        private void sqrt_x_button_Click(object sender, EventArgs e)
        {
            textBox.Text = Math.Sqrt(Convert.ToDouble(textBox.Text)).ToString();
        }

        private void clear_entry_button_Click(object sender, EventArgs e)
        {

        }

        private void percent_button_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToDouble(textBox.Text);
            if (number2 != 0)
            {
                switch (sign)
                {
                    case '+':
                        textBox.Text = (number1 + number2 * 0.01).ToString();
                        break;
                    case '-':
                        textBox.Text = (number1 - number2 * 0.01).ToString();
                        break;
                    case '*':
                        textBox.Text = (number1 * number2 * 0.01).ToString();
                        break;
                    case '/':
                        textBox.Text = (number1 / number2 * 0.01).ToString();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                textBox.Text = (Convert.ToDouble(textBox.Text) * 0.01).ToString();
            }
        }

        private void x_power_2_button_Click(object sender, EventArgs e)
        {
            textBox.Text = Math.Pow(Convert.ToDouble(textBox.Text), 2).ToString();
        }

        private void one_by_x_button_Click(object sender, EventArgs e)
        {
            textBox.Text = (1/Convert.ToDouble(textBox.Text)).ToString();
        }
    }
}
