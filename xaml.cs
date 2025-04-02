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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private double firstNumber;
        private string znak;


        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            calc.Text += 1;
            calc.Focus();
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            calc.Text += 2;
            calc.Focus();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            calc.Text += 3;
            calc.Focus();
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            calc.Text += 4;
            calc.Focus();
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            calc.Text += 6;
            calc.Focus();
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            calc.Text += 7;
            calc.Focus();
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            calc.Text += 8;
            calc.Focus();
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            calc.Text += 9;
            calc.Focus();
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            calc.Text += 0;
            calc.Focus();
        }
        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            calc.Text += 5;
            calc.Focus();
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            calc.Text = "";
        }

        private void Rasdel_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(calc.Text, out firstNumber))
            {
                znak = "/";
                calc.Text = "";
            }
        }

        private void Ymnoj_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(calc.Text, out firstNumber))
            {
                znak = "*";
                calc.Text = "";
            }
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(calc.Text, out firstNumber))
            {
                znak = "-";
                calc.Text = "";
            }
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(calc.Text, out firstNumber))
            {
                znak = "+";
                calc.Text = "";
            }
        }

        private void Result_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(calc.Text, out double secondNumber))
            {
                double result = 0;

                switch (znak)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        break;
                    case "*":
                        result = firstNumber * secondNumber;
                        break;
                    case "/":
                        if (secondNumber != 0)
                            result = firstNumber / secondNumber;
                        else
                            calc.Text = "Error!";
                        break;
                }
                if (znak == "/" && secondNumber == 0)
                    return;

                calc.Text = result.ToString();
            }
        }
    }
}
