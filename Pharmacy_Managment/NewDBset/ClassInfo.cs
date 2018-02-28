using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Pharmacy_Managment.DAL;


namespace Pharmacy_Managment.NewDBset
{
    class ClassInfo
    {
        public static DataTable sp_select() 
        {
            DataAccessLayer.con = "Data Source=kinan-pc\\kinan_server;Initial Catalog=centralDB;User ID=sa;Password=2016";
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_select", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable sp_selectUser()
        {
            DataAccessLayer.con = "Data Source=kinan-pc\\kinan_server;Initial Catalog=centralDB;User ID=sa;Password=2016";
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_selectUser", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static int sp_insert1(string server_name) 
        {
            DataAccessLayer.con = "Data Source=kinan-pc\\kinan_server;Initial Catalog=centralDB;User ID=sa;Password=2016";
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_insert1", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("server_name", SqlDbType.VarChar, server_name));
            DataAccessLayer.Close();
            return i;
        }
    }
}
