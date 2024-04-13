using System;
using System.Data;
using System.Linq;
using System.Windows;


namespace LabWork2
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
        Calculator calculator = new Calculator();
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text += "1";
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text += "2";
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text += "3";

        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text += "4";
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text += "5";
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text += "6";
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text += "7";
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text += "8";
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text += "9";
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text += "0";
        }

        private void ButtonClean_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = string.Empty;
        }

        private void ButtonClearOneSymbol_Click(object sender, RoutedEventArgs e)
        {
            if (ResultTextBlock.Text != "")

            {
                ResultTextBlock.Text = ResultTextBlock.Text.Substring(0, ResultTextBlock.Text.Length - 1);
            }
            
        }

        private void ButtonFractional_Click(object sender, RoutedEventArgs e)
        {
            if (ResultTextBlock.Text != "")
            
            {
                ResultTextBlock.Text += ResultTextBlock.Text.Contains(",") ? "" : ",";
            }
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (!ResultTextBlock.Text.Contains("+"))
            {
                if (ResultTextBlock.Text.Contains("-"))
                {
                    ResultTextBlock.Text = ResultTextBlock.Text.Replace("-", "");
                }
                ResultTextBlock.Text = ResultTextBlock.Text.Insert(0, "+");
            }
            else if (ResultTextBlock.Text.Contains("+"))
            {
                ResultTextBlock.Text = ResultTextBlock.Text.Replace("+", "-");
            }
        }

        private void ButtonDivision_Click(object sender, RoutedEventArgs e)
        {
            calculator.firstValue = Convert.ToDouble(ResultTextBlock.Text);
            ResultTextBlock.Text = "";
            calculator.operation = '/';

        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            calculator.firstValue = Convert.ToDouble(ResultTextBlock.Text);
            ResultTextBlock.Text = "";
            calculator.operation = '+';
        }

        private void ButtonMultiply_Click(object sender, RoutedEventArgs e)
        {
            calculator.firstValue = Convert.ToDouble(ResultTextBlock.Text);
            ResultTextBlock.Text = "";
            calculator.operation = '*';
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            calculator.firstValue = Convert.ToDouble(ResultTextBlock.Text);
            ResultTextBlock.Text = "";
            calculator.operation = '-';
        }

        private void ButtonEqually_Click(object sender, RoutedEventArgs e)
        {

            calculator.secondValue = Convert.ToDouble(ResultTextBlock.Text);
            ResultTextBlock.Text = Convert.ToString(calculator.PerformOperation());

        }


    }
}
 