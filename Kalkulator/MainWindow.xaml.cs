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

namespace Kalkulator
{
    public partial class MainWindow : Window
    {
        double number1 = 0;
        double number2 = 0;
        string operation = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 1;
                display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                display.Text = number2.ToString();
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                display.Text = number2.ToString();
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                display.Text = number2.ToString();
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                display.Text = number2.ToString();
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                display.Text = number2.ToString();
            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                display.Text = number2.ToString();
            }
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                display.Text = number2.ToString();
            }
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                display.Text = number2.ToString();
            }
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                display.Text = number2.ToString();
            }
        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10);
                display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10);
                display.Text = number2.ToString();
            }
        }

        private void buttonPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            display.Text = "0";
        }

        private void buttonMinus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            display.Text = "0";
        }

        private void buttonTimes_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            display.Text = "0";
        }

        private void buttonDivide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            display.Text = "0";
        }

        private void buttonEquals_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    display.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    display.Text = (number1 - number2).ToString();
                    break;
                case "*":
                    display.Text = (number1 * number2).ToString();
                    break;
                case "/":
                    display.Text = (number1 / number2).ToString();
                    break;
            }
        }

        private void buttonC_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            display.Text = "0";
        }
    }
}
