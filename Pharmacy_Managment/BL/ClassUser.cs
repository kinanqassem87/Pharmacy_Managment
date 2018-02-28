using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Pharmacy_Managment.DAL;

namespace Pharmacy_Managment.BL
{
    class ClassUser
    {
        public static int sp_user_insert(string u_name,string u_pass,string fullName,int Permission_id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_user_insert", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@user_name", SqlDbType.VarChar, u_name),
                DataAccessLayer.CreateParameter("@user_password", SqlDbType.VarChar, u_pass),
                DataAccessLayer.CreateParameter("@fullName", SqlDbType.VarChar, fullName),
                DataAccessLayer.CreateParameter("@Permission_ID", SqlDbType.Int, Permission_id));
            DataAccessLayer.Close();
            return i;
 
        }
        public static DataTable sp_permission() 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_permission", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable sp_user_display() 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_user_display", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable sp_user_search(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_user_search", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search",SqlDbType.VarChar,search));
            DataAccessLayer.Close();
            return dt;
        }
        public static int sp_user_update(int u_id, string u_name, string u_pass, string fullName, int Permission_id)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_user_update", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@u_id",SqlDbType.Int,u_id),
                DataAccessLayer.CreateParameter("@u_name", SqlDbType.VarChar, u_name),
                DataAccessLayer.CreateParameter("@u_pass", SqlDbType.VarChar, u_pass),
                DataAccessLayer.CreateParameter("@fullName", SqlDbType.VarChar, fullName),
                DataAccessLayer.CreateParameter("@per_id", SqlDbType.Int, Permission_id));
            DataAccessLayer.Close();
            return i;

        }
        public static int sp_user_delete(int u_id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_user_delete", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@u_id", SqlDbType.Int, u_id));
            DataAccessLayer.Close();
            return i;

        }
        
    }
}
