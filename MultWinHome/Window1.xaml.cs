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

namespace MultWinHome
{
    public partial class Windows1 : Window
    {
        public Windows1()
        {
            InitializeComponent();
        }
        private void Button_NextStep_Click(object sender, RoutedEventArgs e)
        {
            var window2 = new Window2(TextBox_Surname.Text, TextBox_Name.Text);
            window2.Show();
            Close();
        }
    }
}