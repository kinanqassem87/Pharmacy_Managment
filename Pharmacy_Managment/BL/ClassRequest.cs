using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Pharmacy_Managment.DAL;

namespace Pharmacy_Managment.BL
{
    class ClassRequest
    {
        public static void sp_request_insert(DateTime reqDate,string total,int su_id,string buyerName,DataTable reqdet,DataTable expireddate) 
        {
            DataAccessLayer.Open();
            DataAccessLayer.ExecuteNonQuery("sp_request_insert", CommandType.StoredProcedure,
            DataAccessLayer.CreateParameter("@req_date", SqlDbType.Date, reqDate),
            DataAccessLayer.CreateParameter("@total", SqlDbType.VarChar, total),
            DataAccessLayer.CreateParameter("@su_id", SqlDbType.Int, su_id),
            DataAccessLayer.CreateParameter("@BuyerName", SqlDbType.VarChar, buyerName),
            DataAccessLayer.CreateParameter("@reqdet", SqlDbType.Structured, reqdet),
            DataAccessLayer.CreateParameter("@expiredDate", SqlDbType.Structured, expireddate));


            DataAccessLayer.Close();
        }
        public static DataTable SP_REQUESTDISPLAY() 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_REQUESTDISPLAY", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static object max_id()
        {
            DataAccessLayer.Open();
            object o = DataAccessLayer.ExcuteScalar("select max(Req_ID) from tblRequests", CommandType.Text);
            DataAccessLayer.Close();
            return o;
        }
    }
}
