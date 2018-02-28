using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Pharmacy_Managment.DAL;

namespace Pharmacy_Managment.BL
{
    class CLASSSCINTAFEICNAME
    {
        public static int SP_ADDSCINTEFICNAME(string Sn_Name) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_ADDSCINTEFICNAME", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@SNAME", SqlDbType.VarChar, Sn_Name));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable SP_SELECTALLSCINTEFICNAME()
        {
            DataAccessLayer.Open();
           DataTable dt =  DataAccessLayer.ExecuteTable("SP_SELECTALLSCINTEFICNAME", CommandType.StoredProcedure);
           DataAccessLayer.Close();
           return dt;
            
        }
        public static DataTable SP_SEARCHSCINTEFICNAME(string txtsearch) 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SEARCHSCINTEFICNAME", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@SEARCH", SqlDbType.VarChar, txtsearch));
            DataAccessLayer.Close();
            return dt;
        }
        public static int SP_DELETESCINTAFICNAME(int sn_id) 
        {
            DataAccessLayer.Open();
            int i= DataAccessLayer.ExecuteNonQuery("SP_DELETESCINTAFICNAME", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@SN_ID", SqlDbType.Int, sn_id));
            DataAccessLayer.Close();
            return i;
        }
        public static int SP_UPDATESCINTAFICNAME(int sn_id, string sn_name) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_UPDATESCINTAFICNAME", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@SN_ID", SqlDbType.Int, sn_id),
                DataAccessLayer.CreateParameter("@SN_NAME", SqlDbType.VarChar, sn_name));
            DataAccessLayer.Close();
            return i;
        }

    }
}
