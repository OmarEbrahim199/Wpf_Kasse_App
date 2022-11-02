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
using Wpf_Kasse_App.View;
using System.Windows.Forms;
using Wpf_Kasse_App;
using Calendar = Wpf_Kasse_App.Uc.Calendar;
using System.Windows.Threading;
//using Button = System.Windows.Controls.Button;

namespace Wpf_Kasse_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private Button currentButton;
        //string content = (sender as Button).Content.ToString();



        public MainWindow()
        {
            InitializeComponent();





        }

        private void PointOfSall_Click(object sender, RoutedEventArgs e)
        {
            SalllOfPoint cw = new SalllOfPoint();
            cw.ShowInTaskbar = false;
            cw.Owner = System.Windows.Application.Current.MainWindow;
            cw.Show();
        }

        private void Calculator_Click(object sender, RoutedEventArgs e)
        {
            CalculatorUC cw = new CalculatorUC();

            cw.ShowInTaskbar = false;
            cw.Owner = System.Windows.Application.Current.MainWindow;
            cw.Show();

        }




        /*
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CalculatorUC cw = new CalculatorUC();
          
            cw.ShowInTaskbar = false;
            cw.Owner = System.Windows.Application.Current.MainWindow;
            cw.Show();

        }
        */
        /*
        private void PointOfSall_Click(object sender, RoutedEventArgs e)
        {
            SalllOfPoint cw = new SalllOfPoint();
            cw.ShowInTaskbar = false;
            cw.Owner = System.Windows.Application.Current.MainWindow;
            cw.Show();
        }



        private void OpenChildform(Form cform, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = cform;
            //ActiveButton(btnSender);
            cform.TopLevel = false;
            cform.FormBorderStyle = FormBorderStyle.None;
            cform.Dock = DockStyle.Fill;
            //MainPanel.Children.Add(cform);
            //panelMainForm.Controls.Add(cform);
            //panelMainForm.Tag = cform;
            cform.BringToFront();
            cform.Show();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Calendar cw = new Calendar();
            
            cw.ShowInTaskbar = false;
            cw.Owner = System.Windows.Application.Current.MainWindow;
            cw.Show();
        }
    }
        */

    }
}
