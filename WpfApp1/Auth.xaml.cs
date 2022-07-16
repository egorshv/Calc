﻿using System;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Auth.xaml
    /// </summary>
    public partial class Auth : Window
    {
        private string password = "123";
        public Auth()
        {
            InitializeComponent();
        }

        private void AcceptClick(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Text == password)
            {
                PswManager pswManager = new PswManager();
                pswManager.Show();
            }
            else
            {
                MessageBox.Show("Wrong password");
            }
        }
        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
