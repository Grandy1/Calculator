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
        double number1 = 0.0, number2 = 0.0;
        char sign = ' ';
        double ANS = 0.0;
        int status = 1;
        // status == 1 -> Ждем ввод первого числа
        // status == 2 -> Ждем ввод второго числа
        // status == 3 -> На экране результат
        private void ANS_button_Click(object sender, EventArgs e)
        {
            workspace.Clear();
            workspace.Text += ANS.ToString();
        }

        private void zero_button_Click(object sender, EventArgs e)
        {
            if (!(workspace.Text.StartsWith("0") || workspace.Text.StartsWith("-0") || workspace.Text.StartsWith("0.") || workspace.Text.StartsWith("-0.")) || workspace.Text.Contains("."))
                workspace.Text += "0";
        }

        private void point_button_Click(object sender, EventArgs e)
        {
            if (!workspace.Text.Contains("."))
                workspace.Text += ".";
        }

        private void equal_button_Click(object sender, EventArgs e)
        {
            if (sign != ' ')
                number2 = Convert.ToDouble(workspace.Text);
            if (number2 == 0 && sign == '/')
                workspace.Text = "Devide by zero";
            else
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
                }
            number1 = number2 = 0;
            sign = ' ';
            status = 3;
            if (workspace.Text.Equals("Devide by zero"))
            {
                ANS = 0.0;
            }
            else
            {
                ANS = Convert.ToDouble(workspace.Text);
            }
        }

        private void plus_button_Click(object sender, EventArgs e)
        {
            try
            {
                number1 = number1 == 0 ? Convert.ToDouble(workspace.Text) : number1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            sign = '+';
            status = 2;
            workspace.Text = "0";
        }

        private void click_number(char c)
        {
            if (status == 3) {
                status = 1;
                workspace.Clear();
            }
            if (workspace.Text.StartsWith("0") && !workspace.Text.StartsWith("0."))
            {
                workspace.Clear();
                workspace.Text += c;
            }
            else if (workspace.Text.StartsWith("-0") && !workspace.Text.StartsWith("-0."))
            {
                workspace.Clear(); 
                workspace.Text += ("-" + c);
            }
            else
            {
                workspace.Text += c;
            }
        }
        private void one_button_Click(object sender, EventArgs e)
        {
            click_number('1');
        }
        private void two_button_Click(object sender, EventArgs e)
        {
            click_number('2');
        }
        private void three_button_Click(object sender, EventArgs e)
        {
            click_number('3');
        }
        private void four_button_Click(object sender, EventArgs e)
        {
            click_number('4');
        }
        private void five_button_Click(object sender, EventArgs e)
        {
            click_number('5');
        }
        private void six_button_Click(object sender, EventArgs e)
        {
            click_number('6');
        }
        private void seven_button_Click(object sender, EventArgs e)
        {
            click_number('7');
        }
        private void eight_button_Click(object sender, EventArgs e)
        {
            click_number('8');
        }
        private void nine_button_Click(object sender, EventArgs e)
        {
            click_number('9');
        }

        private void minus_button_Click(object sender, EventArgs e)
        {
            if (workspace.Text == "0" && sign == ' ')
                workspace.Text = "-" + workspace.Text;
            else if (number1 != 0 && sign != ' ')
                workspace.Text = "-" + workspace.Text;
            else
            {
                try
                {
                    number1 = number1 == 0 ? Convert.ToDouble(workspace.Text) : number1;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                status = 2;
                workspace.Text = "0";
                sign = '-';
            }
        }

        private void multiplication_button_Click(object sender, EventArgs e)
        {
            try
            {
                number1 = number1 == 0 ? Convert.ToDouble(workspace.Text) : number1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            status = 2;
            sign = '*';
            workspace.Text = "0";
        }

        private void delete_last_button_Click(object sender, EventArgs e)
        {
            string s = workspace.Text;
            if (s.Length == 2 && s.StartsWith("-") || s.Contains("Devide by zero") || s.Contains("NaN"))
            {
                s = "0";
                number1 = number2 = 0;
                sign = ' ';
            }
            else if (s.Length > 1)
                s = s.Substring(0, s.Length - 1);
            else
            {
                s = "0";
                number1 = number2 = 0;
                sign = ' ';
            }
            workspace.Text = s;
        }

        private void division_button_Click(object sender, EventArgs e)
        {
            try
            {
                number1 = number1 == 0 ? Convert.ToDouble(workspace.Text) : number1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            status = 2;
            sign = '/';
            workspace.Text = "0";
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            workspace.Text = "0";
            number1 = number2 = 0;
            sign = ' ';
        }
        //изменить механику работы кнопки sqrt
        //при нажатии на кнопку будет выводить на экран строчку sqrt() и ждать ввода числа
        private void sqrt_x_button_Click(object sender, EventArgs e)
        {
            if (status == 1 || status == 2) status = 3;
            ANS = Math.Sqrt(Convert.ToDouble(workspace.Text));
            workspace.Text = ANS.ToString();
        }

        private void clear_entry_button_Click(object sender, EventArgs e)
        {
            workspace.Text = "0";
        }

        private void percent_button_Click(object sender, EventArgs e)
        {
            try
            {
                number2 = Convert.ToDouble(workspace.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            if (number2 != 0 && sign != ' ')
            {
                switch (sign)
                {
                    case '+':
                        workspace.Text = (number1 + number1 * number2 * 0.01).ToString();
                        break;
                    case '-':
                        workspace.Text = (number1 - number1 * number2 * 0.01).ToString();
                        break;
                    case '*':
                        workspace.Text = (number1 * number2 * 0.01).ToString();
                        break;
                    case '/':
                        workspace.Text = (number1 / (number2 * 0.01)).ToString();
                        break;
                }
            }
            else
                workspace.Text = (Convert.ToDouble(workspace.Text) * 0.01).ToString();
        }
        
        private void x_power_2_button_Click(object sender, EventArgs e)
        {
            if (status == 1 || status == 2) status = 3;
            ANS = Math.Pow(Convert.ToDouble(workspace.Text), 2);
            workspace.Text = ANS.ToString();
        }

        private void one_by_x_button_Click(object sender, EventArgs e)
        {
            if (status == 1 || status == 2) status = 3;
            ANS = (1 / Convert.ToDouble(workspace.Text));
            workspace.Text = ANS.ToString();
        }
    }
}
