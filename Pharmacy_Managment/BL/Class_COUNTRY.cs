using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Pharmacy_Managment.DAL;

namespace Pharmacy_Managment.BL
{
    class Class_COUNTRY
    {
        public static int SP_COUNTRY_INSERT(string country_name) 
        {
            DataAccessLayer.Open();
          int i=  DataAccessLayer.ExecuteNonQuery("SP_COUNTRY_INSERT", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@COUNTRY_NAME", SqlDbType.VarChar, country_name));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable SP_COUNTRY_DISPLAY()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_COUNTRY_DISPLAY", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable SP_COUNTRY_SEARCH(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_COUNTRY_SEARCH", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@SEARCH", SqlDbType.VarChar, search));
            DataAccessLayer.Close();
            return dt;
        }
        public static int SP_COUNTRY_UPDATE(int country_id, string country_name)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_COUNTRY_UPDATE", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@COUNRTY_ID", SqlDbType.Int, country_id),
                DataAccessLayer.CreateParameter("@COUNTRY_NAME", SqlDbType.VarChar, country_name));
            DataAccessLayer.Close();
            return i;
        }
        public static int SP_COUNTRY_DELETE(int country_id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_COUNTRY_DELETE", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@COUNRTY_ID", SqlDbType.Int, country_id));
            DataAccessLayer.Close();
            return i;
        }
    }
}
