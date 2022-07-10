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
        private int num1;
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
            int num = Convert.ToInt32(btn.Content.ToString());
            // MessageBox.Show(num.ToString());
            if (operation.Length > 0)
            {
                string res = num.ToString();
                switch (operation)
                {
                    case "+":
                        res = (num1 + num).ToString();
                        break;
                    case "-":
                        res = (num1 - num).ToString();
                        break;
                    case "/":
                        if (num != 0)
                        {
                            res = (num1 / num).ToString();
                        }
                        else
                        {
                            res = "Division by zero error";
                        }
                        break;
                    case "x":
                        res = (num1 * num).ToString();
                        break;
                }
                operation = "";
                textblock.Text = res;
            }
            else
            {
                num1 = num;
                textblock.Text = num.ToString();
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
            num1 = 0;
            operation = "";
        }
        private void SqrtClick(object sender, RoutedEventArgs e)
        {
            textblock.Text = Math.Sqrt(num1).ToString();
        }
    }
}
