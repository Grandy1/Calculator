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
        // после того как получен ркзультат, если нажать любую цифру, то она будет дописывать в поле, нужно изменить на ввод нового числа
        double number1 = 0, number2 = 0;
        char sign = ' ';
        // убрать кнопку +/-, не нужна
        // добавить вместо нее кнопку "ANS", которая будет хранить в себе предыдущий ответ
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
            workspace.Text = "0";
        }

        private void click_number(char c)
        {
            if (workspace.Text.StartsWith("0") && !workspace.Text.StartsWith("0."))
            {
                workspace.Text = workspace.Text.Remove(0);
                workspace.Text += c;
            }
            else if (workspace.Text.StartsWith("-0") && !workspace.Text.StartsWith("-0."))
            {
                workspace.Text = workspace.Text.Remove(0);
                workspace.Text += ("-" + c);
            }
            else
                workspace.Text += c;
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
            if (number1 != 0)
            {
                switch (sign)
                {
                    case '+':
                        workspace.Text = (number1 + Math.Sqrt(Convert.ToDouble(workspace.Text))).ToString();
                        break;
                    case '-':
                        workspace.Text = (number1 - Math.Sqrt(Convert.ToDouble(workspace.Text))).ToString();
                        break;
                    case '*':
                        workspace.Text = (number1 * Math.Sqrt(Convert.ToDouble(workspace.Text))).ToString();
                        break;
                    case '/':
                        workspace.Text = (number1 / Math.Sqrt(Convert.ToDouble(workspace.Text))).ToString();
                        break;
                }
                //workspace.Text = number1 Math.Sqrt(Convert.ToDouble(workspace.Text)).ToString();
            }
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
            workspace.Text = Math.Pow(Convert.ToDouble(workspace.Text), 2).ToString();
        }

        private void one_by_x_button_Click(object sender, EventArgs e)
        {
            workspace.Text = (1/Convert.ToDouble(workspace.Text)).ToString();
        }
    }
}
