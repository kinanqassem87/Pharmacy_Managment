using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Pharmacy_Managment.DAL;

namespace Pharmacy_Managment.BL
{
    class CLASS_CUSTOMER
    {
        public static DataTable SP_ENTRY_BY_COUNTRYID(int counrty_id) 
        {
            DataAccessLayer.Open();
            DataTable dt= DataAccessLayer.ExecuteTable("SP_ENTRY_BY_COUNTRYID", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@COUNTRY_ID", SqlDbType.Int, counrty_id));
            DataAccessLayer.Close();
            return dt;
        }
        public static int SP_ADD_NEW_CUSTOMER(string cu_name,string cu_address,string cu_mobile,byte[] cu_image,int city_id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_ADD_NEW_CUSTOMER", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@cu_name", SqlDbType.VarChar, cu_name),
                DataAccessLayer.CreateParameter("@cu_adrress", SqlDbType.VarChar, cu_address),
                DataAccessLayer.CreateParameter("@cu_mobile", SqlDbType.VarChar, cu_mobile),
                DataAccessLayer.CreateParameter("@cu_image", SqlDbType.Image, cu_image),
                DataAccessLayer.CreateParameter("@city_id", SqlDbType.Int, city_id));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable SP_CUSTOMER_DISPLAY() 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_CUSTOMER_DISPLAY", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
            
        }
        public static DataTable SP_CUSTOMER_SEARCH(string search) 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_CUSTOMER_SEARCH", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@SEARCH", SqlDbType.VarChar, search));
            DataAccessLayer.Close();
            return dt;
        }
        public static int SP_CUSTOMER_UPDATE(int cu_id,string cu_name, string cu_address, string cu_mobile, byte[] cu_image, int city_id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_CUSTOMER_UPDATE", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@CU_ID",SqlDbType.Int,cu_id),
                DataAccessLayer.CreateParameter("@CU_NAME", SqlDbType.VarChar, cu_name),
                DataAccessLayer.CreateParameter("@CU_ADDRESS", SqlDbType.VarChar, cu_address),
                DataAccessLayer.CreateParameter("@CU_MOBILE", SqlDbType.VarChar, cu_mobile),
                DataAccessLayer.CreateParameter("@CU_IMAGE", SqlDbType.Image, cu_image),
                DataAccessLayer.CreateParameter("@CITY_ID", SqlDbType.Int, city_id));
            DataAccessLayer.Close();
            return i;

        }
        public static int SP_CUSTOMER_DELETE(int cu_id)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_CUSTOMER_DELETE", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@CU_ID", SqlDbType.Int, cu_id));
            DataAccessLayer.Close();
            return i;
        }
    }
}
