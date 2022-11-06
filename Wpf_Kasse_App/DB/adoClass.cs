using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Wpf_Kasse_App.DB
{
     public class adoClass
    {
        public static SqlConnection sqlcl;
        public static SqlCommandBuilder CommandBuilder;

        public static void swtConnection()
        {
            string MyConString = ConfigurationManager.ConnectionStrings["conString"].ToString();
            sqlcl = new SqlConnection();
            sqlcl.ConnectionString = MyConString;


        }


    }
}

/*
 
            //Connection string to the server
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString =MyConString;
            //This doe sthe task of fetching data from sql server
            SqlDataAdapter adp = new SqlDataAdapter();
            //Create the command object
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM Options";
            //Inline query or stored procedure
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            adp.SelectCommand = command;
            //Open the connedction to sql server
            connection.Open();

            //Fill to datatable
            DataTable dt = new DataTable();
            adp.Fill(dt);
            connection.Close();

            //GridView1.DataSource = dt;
            //GridView1.DataBind();*/