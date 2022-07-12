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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string num1;
        private string num2;
        private string operation = "";
        public MainWindow()
        {
            InitializeComponent();
        }
        /*
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello world");
        }
        */
        private void NumClick(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string num = btn.Content.ToString();
            // MessageBox.Show(num.ToString());
            if (operation.Length == 0)
            {
                num1 += num;
                textblock.Text = num1;
            }
            else
            {
                num2 += num;
                textblock.Text = num2;
            }
                

        }
        private void OperatorClick(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            operation = btn.Content.ToString();
        }
        private void Delete(object sender, RoutedEventArgs e)
        {
            textblock.Text = "";
            num1 = "";
            num2 = "";
            operation = "";
        }
        private void Execute(object sender, RoutedEventArgs e)
        {
            string res = "";
            int n1 = Convert.ToInt32(num1);
            int n2 = Convert.ToInt32(num2);
            switch (operation)
            {
                case "+":
                    res = (n1 + n2).ToString();
                    break;
                case "-":
                    res = (n1 - n2).ToString();
                    break;
                case "/":
                    if (n2 != 0)
                    {
                        res = (n1 / n2).ToString();
                    }
                    else
                    {
                        res = "Division by zero error";
                    }
                    break;
                case "x":
                    res = (n1 * n2).ToString();
                    break;
            }
            operation = "";
            textblock.Text = res;
            num1 = res;
            num2 = "";
        }
        private void SqrtClick(object sender, RoutedEventArgs e)
        {
            textblock.Text = Math.Sqrt(Convert.ToInt32(num1)).ToString();
            num1 = textblock.Text;
            num2 = "";
            operation = "";
        }
    }
}
