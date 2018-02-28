using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pharmacy_Managment.DAL;
using System.Data;

namespace Pharmacy_Managment.BL
{
    class CLASSACTIVEMATERIAL
    {
        public static int SP_ADDACTIVEMATERIAL(string AMNAME, string amdiscreption)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_ADDACTIVEMATERIAL", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@AMNAME", SqlDbType.VarChar, AMNAME),
                DataAccessLayer.CreateParameter("@AMDISCREPTION", SqlDbType.VarChar, amdiscreption));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable SP_SELECTALLACTIVEMATERIAL()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SELECTALLACTIVEMATERIAL", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;

        }
        public static DataTable SP_SELECTSEARCHACTIVEMATERIAL(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SELECTSEARCHACTIVEMATERIAL", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@SEARCH", SqlDbType.VarChar, search));
            DataAccessLayer.Close();
            return dt;
        }
        public static int SP_UPDATEACTIVEMATERIAL(int AM_ID, string AM_NAME, string am_descreption)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_UPDATEACTIVEMATERIAL", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@AM_ID", SqlDbType.Int, AM_ID),
                DataAccessLayer.CreateParameter("@AM_NAME", SqlDbType.VarChar, AM_NAME),
                DataAccessLayer.CreateParameter("@AM_DESCRIPTION", SqlDbType.VarChar, am_descreption));
            DataAccessLayer.Close();
            return i;
        }
        public static int SP_DELETEACTIVEMATERIAL(int am_id)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_DELETEACTIVEMATERIAL", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@AM_ID", SqlDbType.Int, am_id));
            DataAccessLayer.Close();
            return i;

        }
        
    }
}
