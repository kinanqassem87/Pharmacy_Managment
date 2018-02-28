using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Pharmacy_Managment.PLL;

namespace Pharmacy_Managment.DAL
{
    
    class DataAccessLayer
    {
        
       // public static string server_name =  "kinan-pc\\kinan_server";
        //public static string server_name = "kinan-pc";
        //public static string server_name = "pc-1";
       // public static string User_Name = "sa";
       // public static string User_Name = "test";
        // public static string User_Name = "user1";
       // public static string Password = "2016";
       // public static string DataBase_Name = "Pharmacy_DB1";
       // public static string con = " Data Source=" + server_name + "; Initial Catalog=" + DataBase_Name + ";User ID=" + User_Name + ";Password=" + Password;
       
       // public static string con = " Data Source=pc-1;Initial Catalog=Pharmacy_DB1;User ID=sa;Password=2016";
        //public static string con = " Data Source=kinan-pc\\kinan_server;Initial Catalog=Pharmacy_DB1;User ID=sa;Password=2016";
       //or this without password (integrated secuirty)
        public static string con = "Server= Admin; Database= PharmacyManagment; Integrated Security=True;";


        public static SqlConnection cn;
        //open the connection 
        public static void Open()
        {
           
                cn = new SqlConnection(con);
                cn.Open();
        }
        //close the connection 
        public static void Close()
        {
           
                cn = new SqlConnection(con);
                cn.Close();
            
        }
        //return one value
        public static object ExcuteScalar(string query, CommandType type, params SqlParameter[] arr)
        {

            
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddRange(arr);
                cmd.CommandType = type;
                object o = cmd.ExecuteScalar();
                return o;
            
        }
        //delete,Update,insert return number of effect rows
        public static int ExecuteNonQuery(string query, CommandType type, params SqlParameter[] arr)
        {

            
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = type;
                cmd.Parameters.AddRange(arr);
                int n = cmd.ExecuteNonQuery();
                return n;
          
        }
        //return table
        public static DataTable ExecuteTable(string query, CommandType type, params SqlParameter[] arr)
        {

           
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = type;
                cmd.Parameters.AddRange(arr);
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
                
           
        }
        //create parameter to use above function return parameter
        public static SqlParameter CreateParameter(string name, SqlDbType type, object value)
        {
            SqlParameter pr = new SqlParameter();
            pr.ParameterName = name;
            pr.SqlDbType = type;
            pr.SqlValue = value;
            return pr;
        }
    
    
    

    }
}
