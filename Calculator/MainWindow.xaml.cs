using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        char sign;
        string num1;
        string num2;
        bool remember = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "9";
        }

        private void coma_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += ",";
        }

        private void backspace_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            else
            {
                textBox1.Text = "";
            }

            textBox1.Text = textBox1.Text;
        }

        private void CE_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var factorail = double.Parse(textBox1.Text);

                for (var i = 1; i < double.Parse(textBox1.Text); i++)
                    factorail *= i;

                textBox1.Text = factorail.ToString();
            }
            catch
            {
                MessageBox.Show("Введіть число!");
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (remember)
                Count();

            if(textBox1.Text.Length > 0)
            {
                sign = '+';
                num1 = textBox1.Text;
                textBox1.Text += "+";
                remember = true;
            }
            else
                MessageBox.Show("Введіть число!");

        }

        public void Count()
        {
            if (textBox1.Text.Length > 0)
            {
                int i = num1.Length + 1;
                while (i < textBox1.Text.Length)
                {
                    num2 += textBox1.Text[i];
                    i++;
                }
                if (sign == '+')
                    textBox1.Text = Convert.ToString(Convert.ToDouble(num1) + Convert.ToDouble(num2));
                if (sign == '-')
                    textBox1.Text = Convert.ToString(Convert.ToDouble(num1) - Convert.ToDouble(num2));
                if (sign == '*')
                    textBox1.Text = Convert.ToString(Convert.ToDouble(num1) * Convert.ToDouble(num2));
                if (sign == '/')
                        textBox1.Text = Convert.ToString(Convert.ToDouble(num1) / Convert.ToDouble(num2));
                if (sign == '^')
                    textBox1.Text = Convert.ToString(Math.Pow(double.Parse(num1), double.Parse(num2)));

                num2 = null;
            }
            else
                MessageBox.Show("Введіть число!");
        }

        private void subtrsction_Click(object sender, RoutedEventArgs e)
        {
            if (remember)
                Count();

            if (textBox1.Text.Length > 0)
            {
                sign = '-';
                num1 = textBox1.Text;
                textBox1.Text += "-";
                remember = true;
            }
            else
                MessageBox.Show("Введіть число!");
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            if (remember)
                Count();

            if (textBox1.Text.Length > 0)
            {
                sign = '*';
                num1 = textBox1.Text;
                textBox1.Text += "*";
                remember = true;
            }
            else
                MessageBox.Show("Введіть число!");
        }

        private void division_Click(object sender, RoutedEventArgs e)
        {
            if (remember)
                Count();

            if (textBox1.Text.Length > 0)
            {
                sign = '/';
                num1 = textBox1.Text;
                textBox1.Text += "/";
                remember = true;
            }
            else
                MessageBox.Show("Введіть число!");
        }

        private void equal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Count();
                remember = false;
            }
            catch
            {
                MessageBox.Show("Введіть число!");
            }
        }

        private void toSquare_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                textBox1.Text = Convert.ToString(Math.Pow(float.Parse(textBox1.Text), 2));
            }
            catch
            {
                MessageBox.Show("Введіть число!");
            }
        }

        private void toTheExtent_Click(object sender, RoutedEventArgs e)
        {
            if (remember)
                Count();

            if (textBox1.Text.Length > 0)
            {
                sign = '^';
                num1 = textBox1.Text;
                textBox1.Text += "^";
                remember = true;
            }
            else
                MessageBox.Show("Введіть число!");
        }

        private void fraction_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                textBox1.Text = Convert.ToString(1 / double.Parse(textBox1.Text));
            }
            catch
            {
                MessageBox.Show("Введіть число!");
            }
        }

        private void percent_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                textBox1.Text = Convert.ToString(double.Parse(textBox1.Text) / 100);
            }
            catch
            {
                MessageBox.Show("Введіть число!");
            }
        }

        private void root_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                textBox1.Text = Convert.ToString(Math.Sqrt(double.Parse(textBox1.Text)));
            }
            catch
            {
                MessageBox.Show("Введіть число!");
            }
        }
    }
}
