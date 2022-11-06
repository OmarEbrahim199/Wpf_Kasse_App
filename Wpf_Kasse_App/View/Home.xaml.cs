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
using Wpf_Kasse_App.Uc;

namespace Wpf_Kasse_App.View
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void ButtonCalander_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void ButtonCAL_Click(object sender, RoutedEventArgs e)
        {
            CalculatorUC cw = new CalculatorUC();
            cw.ShowInTaskbar = false;
            cw.Owner = System.Windows.Application.Current.MainWindow;
            cw.Show();
        }

        private void ButtonPOF_Click(object sender, RoutedEventArgs e)
        {
            SalllOfPoint cw = new SalllOfPoint();
            cw.ShowInTaskbar = false;
            cw.Owner = System.Windows.Application.Current.MainWindow;
            cw.Show();
        }

    }
}
