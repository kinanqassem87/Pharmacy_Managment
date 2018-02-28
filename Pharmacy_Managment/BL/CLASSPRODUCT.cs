using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Pharmacy_Managment.DAL;

namespace Pharmacy_Managment.BL
{
    class CLASSPRODUCT
    {
        public static DataTable SP_FILLCATCMB()
        {
            DataAccessLayer.Open();
           DataTable dt = DataAccessLayer.ExecuteTable("SP_FILLCATCMB", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable SP_FILLAMCMB()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_FILLAMCMB", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable SP_FILLSNCMB()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_FILLSNCMB", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static int SP_ADDNEWPRODUCT(string p_name, string P_Description, byte[] P_Image,
            string buyPrice, string SelPrice,
           int Cat_ID, int Am_ID, int Sn_ID, string barcode)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_ADDNEWPRODUCT", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@P_name", SqlDbType.VarChar, p_name),
                DataAccessLayer.CreateParameter("@P_Description", SqlDbType.VarChar, P_Description),
                DataAccessLayer.CreateParameter("@P_Image", SqlDbType.Image, P_Image),
                DataAccessLayer.CreateParameter("@buyPrice", SqlDbType.VarChar, buyPrice),
                DataAccessLayer.CreateParameter("@SelPrice", SqlDbType.VarChar, SelPrice),
                DataAccessLayer.CreateParameter("@Cat_ID", SqlDbType.Int, Cat_ID),
                DataAccessLayer.CreateParameter("@Am_ID", SqlDbType.Int, Am_ID),
                DataAccessLayer.CreateParameter("@Sn_ID", SqlDbType.Int, Sn_ID),
                DataAccessLayer.CreateParameter("@barcode", SqlDbType.VarChar, barcode));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable SP_PRODECUTSELECT() 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_PRODECUTSELECT", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable SP_PRODUCTSEARCH(string search) 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_PRODUCTSEARCH", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@SEARCH", SqlDbType.VarChar, search));
            DataAccessLayer.Close();
            return dt;
        }
        public static byte[] SP_PRODUCTGETIMAGE(int id) 
        {
            DataAccessLayer.Open();
            byte[] arr =(byte[] ) DataAccessLayer.ExcuteScalar("SP_PRODUCTGETIMAGE", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ID",SqlDbType.BigInt,id));
            DataAccessLayer.Close();
            return arr;
        }
        public static DataTable SP_PRODUCTGETEXPIREDDATE(int id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_PRODUCTGETEXPIREDDATE", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ID", SqlDbType.BigInt, id));
            DataAccessLayer.Close();
            return dt;
        }
        public static int SP_ProducrDelete(int id)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_ProducrDelete", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ID", SqlDbType.BigInt, id));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable SP_GETSELECTEDPRODUCT(int id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_GETSELECTEDPRODUCT", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ID", SqlDbType.BigInt, id));
            DataAccessLayer.Close();
            return dt;
        }
        public static int SP_UPDATEPRODUCT(int ID,string p_name, string P_Description, byte[] P_Image,
           string buyPrice, string SelPrice,
          int Cat_ID, int Am_ID, int Sn_ID, string barcode)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_UPDATEPRODUCT", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ID", SqlDbType.BigInt, ID),
                DataAccessLayer.CreateParameter("@P_name", SqlDbType.VarChar, p_name),
                DataAccessLayer.CreateParameter("@P_Description", SqlDbType.VarChar, P_Description),
                DataAccessLayer.CreateParameter("@P_Image", SqlDbType.Image, P_Image),
                DataAccessLayer.CreateParameter("@buyPrice", SqlDbType.VarChar, buyPrice),
                DataAccessLayer.CreateParameter("@SelPrice", SqlDbType.VarChar, SelPrice),
                DataAccessLayer.CreateParameter("@Cat_ID", SqlDbType.Int, Cat_ID),
                DataAccessLayer.CreateParameter("@Am_ID", SqlDbType.Int, Am_ID),
                DataAccessLayer.CreateParameter("@Sn_ID", SqlDbType.Int, Sn_ID),
                DataAccessLayer.CreateParameter("@barcode", SqlDbType.VarChar, barcode));
            DataAccessLayer.Close();
            return i;
        }

    }
}
