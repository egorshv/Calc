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
using System.Windows.Shapes;
using System.Data;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for PswManager.xaml
    /// </summary>
    public partial class PswManager : Window
    {
        public PswManager()
        {
            InitializeComponent();

            string connectionString = "SERVER=localhost;DATABASE=passwords;UID=root;PASSWORD=;";

            
        }
        private void AddNewPassword(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
