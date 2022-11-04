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
using Wpf_Kasse_App;
using Calendar = Wpf_Kasse_App.Uc.Calendar;
using System.Windows.Threading;
using System.Windows.Forms;
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
            startclock();

        }

        private void startclock()
        {
           DispatcherTimer timer =new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += tickevent;
            timer.Start();

            
        }

        private void tickevent(object sender, EventArgs e)
        {
            timerlabel.Text = DateTime.Now.ToString();
        }
        private void CloseApp_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }





        /*

        private void PointOfSall_Click(object sender, RoutedEventArgs e)
        {
            SalllOfPoint cw = new SalllOfPoint();
            cw.ShowInTaskbar = false;
            cw.Owner = System.Windows.Application.Current.MainWindow;
            cw.Show();
        }

        private void Calculator_Click(object sender, RoutedEventArgs e)
        {
           

        }

        private void PointOfSall_DpiChanged(object sender, System.Windows.DpiChangedEventArgs e)
        {

        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {
          

            
        }

        private void menuform_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        
        private void listView_Dashboard_Click(object sender, RoutedEventArgs e)
        {
            SalllOfPoint cw = new SalllOfPoint();
            cw.ShowInTaskbar = false;
            cw.Owner = System.Windows.Application.Current.MainWindow;
            cw.Show();


        }
        private void listView_Calculator_Click(object sender, RoutedEventArgs e)
        {
            CalculatorUC cw = new CalculatorUC();

            cw.ShowInTaskbar = true;
            cw.Owner = System.Windows.Application.Current.MainWindow;
            cw.Show();
        }
        private void listView_Calendar_Click(object sender, RoutedEventArgs e)
        {
            Calendar cw = new Calendar();

            cw.ShowInTaskbar = false;
            cw.Owner = System.Windows.Application.Current.MainWindow;
            cw.Show();
        }

        */
       
        /*
<Button x:Name="PointOfSall" Content="PointOfSall" HorizontalAlignment="Left" Margin="10,81,0,0" VerticalAlignment="Top" Click="PointOfSall_Click" Width="168" Height="56"/>
<Button x:Name="Calculator"  Content="calculator" HorizontalAlignment="Left" Margin="10,142,0,0" VerticalAlignment="Top" Click="Calculator_Click" Width="168" Height="59" AutomationProperties.IsOffscreenBehavior="Default"/>
<Button Content="Button" HorizontalAlignment="Left" Margin="10,217,0,0" VerticalAlignment="Top" Width="168" Height="55"/>


*/




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



/*
  <StackPanel  Background="#FF6088AB" >
            <Grid Height="150" Width="184" HorizontalAlignment="Left">
                <Grid.Background>
                    <LinearGradientBrush EndPoint="0.5,1" StartPoint="0.5,0">
                        <GradientStop Color="Black"/>
                        <GradientStop Color="White" Offset="1"/>
                    </LinearGradientBrush>
                </Grid.Background>
            </Grid>
            <ListView  x:Name="menuform" HorizontalAlignment="Left" Width="187" SelectionChanged="menuform_SelectionChanged"  >
                <ListViewItem   >

                    <StackPanel Orientation="Horizontal" PreviewMouseLeftButtonUp="listView_Dashboard_Click">
                        <materialDesign:PackIcon Kind="ViewDashboard" VerticalAlignment="Center" Margin="5"/>
                        <TextBlock x:Name="DashboardButtom" Text="Dashboard" VerticalAlignment="Center" Margin="5"/>
                    </StackPanel>
                </ListViewItem>
                <ListViewItem >
                    <StackPanel Orientation="Horizontal">
                        <materialDesign:PackIcon Kind="BoxVariant" VerticalAlignment="Center" Margin="5"/>
                        <TextBlock x:Name="ProductsButtom" Text="Products" VerticalAlignment="Center" Margin="5"/>
                    </StackPanel>
                </ListViewItem>
                <ListViewItem >
                    <StackPanel Orientation="Horizontal">
                        <materialDesign:PackIcon Kind="User" VerticalAlignment="Center" Margin="5"/>
                        <TextBlock x:Name="UsersButtom" Text="Users" VerticalAlignment="Center" Margin="5"/>
                    </StackPanel>
                </ListViewItem>
                <ListViewItem >
                    <StackPanel Orientation="Horizontal">
                        <materialDesign:PackIcon Kind="Settings" VerticalAlignment="Center" Margin="5"/>
                        <TextBlock x:Name="SettingsButtom" Text="Settings" VerticalAlignment="Center" Margin="5"/>
                    </StackPanel>
                </ListViewItem>

                <ListViewItem Width="185" PreviewMouseLeftButtonUp="listView_Calculator_Click" >
                    <StackPanel Orientation="Horizontal">
                        <materialDesign:PackIcon Kind="Calculator" VerticalAlignment="Center" Margin="5"/>
                        <TextBlock x:Name="CalculatorButtom" Text="Calculator" VerticalAlignment="Center" Margin="5"/>
                    </StackPanel>
                </ListViewItem>
                
                <ListViewItem Width="194" HorizontalAlignment="Left" PreviewMouseLeftButtonUp="listView_Calendar_Click" >
                    <StackPanel Orientation="Horizontal">
                        <materialDesign:PackIcon Kind="Calendar" VerticalAlignment="Center" Margin="5"/>
                        <TextBlock x:Name="CalendarButtom" Text="Calendar" VerticalAlignment="Center" Margin="5"/>
                    </StackPanel>
                </ListViewItem>

                


            </ListView>


        </StackPanel>







        <DockPanel x:Name="childpanelform" LastChildFill="False" Margin="183,0,0,0">
            <DockPanel.Background>
                <LinearGradientBrush EndPoint="0.5,1" StartPoint="0.5,0">
                    <GradientStop Color="Black"/>
                    <GradientStop Color="#FF6C8C78" Offset="1"/>
                </LinearGradientBrush>
            </DockPanel.Background>
            <Label x:Name="labelresultt" Content="Label" Width="202" Height="78" RenderTransformOrigin="10.55,0.23" Background="{x:Null}" DockPanel.Dock="Right"/>
            <WrapPanel x:Name="panelcc" Width="119" RenderTransformOrigin="2.7,0.53"/>
        </DockPanel>
        <StackPanel/>

  
  
 */
