using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Pharmacy_Managment.DAL;

namespace Pharmacy_Managment.BL
{
    class Class_CITY
    {
        public static int SP_CITY_INSERT(string city_name, int country_id)
        {
            DataAccessLayer.Open();
            int i =DataAccessLayer.ExecuteNonQuery("SP_CITY_INSERT", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@CITY_NAME", SqlDbType.VarChar,city_name),
                DataAccessLayer.CreateParameter("@COUNTRY_ID", SqlDbType.Int,country_id));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable SP_CITY_DISPLAY()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_CITY_DISPLAY", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable SP_CITY_SEARCH(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_CITY_SEARCH", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@SEARCH", SqlDbType.VarChar, search));
            DataAccessLayer.Close();
            return dt;
        }
        public static int SP_CITY_UPDATE(int city_id,string city_name,int counrty_id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_CITY_UPDATE", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@CITY_ID", SqlDbType.Int, city_id),
                DataAccessLayer.CreateParameter("@CITY_NAME", SqlDbType.VarChar, city_name),
                DataAccessLayer.CreateParameter("@COUNTRY_ID", SqlDbType.Int, counrty_id));
            DataAccessLayer.Close();
            return i;
        }
        public static int SP_CITY_DELETE(int city_id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_CITY_DELETE", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@CITY_ID", SqlDbType.Int, city_id));
            DataAccessLayer.Close();
            return i;
        }
    }
}
