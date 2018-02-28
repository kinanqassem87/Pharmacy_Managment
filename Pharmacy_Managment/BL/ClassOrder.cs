using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Pharmacy_Managment.DAL;

namespace Pharmacy_Managment.BL
{
    class ClassOrder
    {
        public static int sp_order_insert(DateTime orderDate,string total,int cu_id,
            string sellerName, DataTable order_det) 
        {
            DataAccessLayer.Open();
           int i= DataAccessLayer.ExecuteNonQuery("sp_order_insert", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@order_date", SqlDbType.Date, orderDate),
                DataAccessLayer.CreateParameter("@total", SqlDbType.VarChar, total),
                DataAccessLayer.CreateParameter("@cu_id", SqlDbType.Int, cu_id),
                DataAccessLayer.CreateParameter("@seller_name", SqlDbType.VarChar, sellerName),
                DataAccessLayer.CreateParameter("@order_det", SqlDbType.Structured, order_det));
            DataAccessLayer.Close();
            return i;

        }
        public static DataTable sp_order_select() 
        {
            DataAccessLayer.Open();
            DataTable dt= DataAccessLayer.ExecuteTable("sp_order_select", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable SP_GET_PRODUCT_BARCODE(string barcode)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_GET_PRODUCT_BARCODE", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@BARCODE", SqlDbType.VarChar, barcode));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable SP_GET_PRODUCT_BARCODE_buy(string barcode)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_GET_PRODUCT_BARCODE_buy", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@BARCODE", SqlDbType.VarChar, barcode));
            DataAccessLayer.Close();
            return dt;
        }
        public static object max_id_order()
        {
            DataAccessLayer.Open();
            object o = DataAccessLayer.ExcuteScalar("select MAX(Order_ID) from tblOrders", CommandType.Text);
            DataAccessLayer.Close();
            return o;
        }
    }
}
