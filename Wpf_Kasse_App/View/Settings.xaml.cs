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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_Kasse_App.View
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Button_ClickUser(object sender, RoutedEventArgs e)
        {

            MainOption cw = new MainOption();
            cw.ShowInTaskbar = false;
            cw.Owner = System.Windows.Application.Current.MainWindow;
            cw.Show();

        }
    }
}
