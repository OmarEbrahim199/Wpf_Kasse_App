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
using System.Data.SqlClient;
using System.Data;
using Wpf_Kasse_App.DB;
using Microsoft.Win32;
using System.Configuration;
using System.IO;

namespace Wpf_Kasse_App.View
{
    /// <summary>
    /// Interaction logic for MainOption.xaml
    /// </summary>
    public partial class MainOption : Window
    {
      
        public MainOption()
        {
            InitializeComponent();
             MainOption_Load();
            //load();
        }
        private SqlDataAdapter adapter;
        private DataTable dt;
        private DataRow dr;

        private static BitmapImage LoadImage(byte[] imageData)
        {
            if (imageData == null || imageData.Length == 0) return null;
            var image = new BitmapImage();
            using (var mem = new MemoryStream(imageData))
            {
                mem.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = mem;
                image.EndInit();
            }
            image.Freeze();
            return image;
        }
        private void MainOption_Load()
        {

            string MyConString = ConfigurationManager.ConnectionStrings["conString"].ToString();
           // adapter = new SqlDataAdapter("Select Top 1 * From Options", adoClass.sqlcl);
           
            //Connection string to the server

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = MyConString;
            //This doe sthe task of fetching data from sql server
            adapter = new SqlDataAdapter();
            //Create the command object
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM Options";
            //Inline query or stored procedure
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            adapter.SelectCommand = command;
            //Open the connedction to sql server
            connection.Open();

            //Fill to datatable
           // DataTable dt = new DataTable();
            
            

            dt = new DataTable();
            try
            {
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dr = dt.Rows[0];
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        

                        textRestName.Text = dt.Rows[i]["RestName"].ToString();
                        textRestAddress1.Text = dt.Rows[i]["RestAddress1"].ToString();
                        textRestAddress2.Text = dt.Rows[i]["RestAddress2"].ToString();
                        textPhone.Text = dt.Rows[i]["Phone"].ToString();
                        textPrinter.Text = dt.Rows[i]["Printer"].ToString();
                        textReceiptLine1.Text = dt.Rows[i]["ReceiptLine1"].ToString();
                        textReceiptLine2.Text = dt.Rows[i]["ReceiptLine2"].ToString();

                        if (dt.Rows[i]["Logo"] != DBNull.Value)
                        {
                            Byte[] myImage = (Byte[])dt.Rows[i]["Logo"];
                           
                            pictureBox.Source = LoadImage(myImage);
                            // pictureBox.BackColor = Color.Red;
                        }

                    }
                }
                else
                {
                    dr = null;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Save new Data", " ? ", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                SaveData();
            }
        }

        
        private void SaveData()
        {
            if (textRestName.Text == String.Empty)
            {
                MessageBox.Show("Please Enter The Resturent Name");
                textRestName.Focus();
                return;
            }
            if (textPhone.Text == String.Empty)
            {
                MessageBox.Show("Please Enter The Resturent Name");
                textPhone.Focus();
                return;
            }

            if (dr == null)
            {
                dr = dt.NewRow();
                dataFillRow();
                dt.Rows.Add(dr);

            }
            else
            {
                dr.BeginEdit();
                dataFillRow();
                dr.EndEdit();
            }

            try
            {
                adoClass.CommandBuilder = new SqlCommandBuilder(adapter);
                adapter.Update(dt);
                MessageBox.Show("Data Has been updated");

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
        public byte[] getJPGFromImageControl(BitmapImage imageC)
        {
            MemoryStream memStream = new MemoryStream();
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(imageC));
            encoder.Save(memStream);
            return memStream.ToArray();
        }
        private void dataFillRow()
        {
            dr["RestName"] = textRestName.Text;
            dr["RestAddress1"] = textRestAddress1.Text;
            dr["RestAddress2"] = textRestAddress2.Text;
            dr["Phone"] = textPhone.Text;
            dr["Printer"] = textPrinter.Text;
            dr["ReceiptLine1"] = textReceiptLine1.Text;
            dr["ReceiptLine2"] = textReceiptLine2.Text;

            
            if (pictureBox.Source != null)
            {
                dr["Logo"] = getJPGFromImageControl(pictureBox.Source as BitmapImage);
            }
            
        }



      

        private void buttonUploadPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images|*.png";
            if (openFileDialog.ShowDialog() == true)
            {
                textLogo.Text = openFileDialog.FileName;
                //pictureBox.BackgroundImage = new Bitmap(textLogo.Text);
                Uri fileUri = new Uri(openFileDialog.FileName);
                pictureBox.Source = new BitmapImage(fileUri);
            }


           
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
