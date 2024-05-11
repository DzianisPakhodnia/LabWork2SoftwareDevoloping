using System;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string buttonNumber = ((Button)sender).Content.ToString();
            ResultTextBlock.Text += buttonNumber;
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





        private void ButtonOperation_Click(object sender, RoutedEventArgs e)
        {
            calculator.firstValue = Convert.ToDouble(ResultTextBlock.Text);
            ResultTextBlock.Text = "";
            calculator.operation = ((Button)sender).Content.ToString()[0];
        }
        private void ButtonEqually_Click(object sender, RoutedEventArgs e)
        {

            calculator.secondValue = Convert.ToDouble(ResultTextBlock.Text);
            ResultTextBlock.Text = Convert.ToString(calculator.PerformOperation());

        }


    }
}
 