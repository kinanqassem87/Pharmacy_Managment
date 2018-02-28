using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Pharmacy_Managment.DAL;
namespace Pharmacy_Managment.BL
{
    class CLASS_CATOGARY
    {
        /// <summary>
        /// add new catogary
        /// </summary>
        /// <param name="cat_name"></param>
        /// <returns></number of inserted rows>
        public static int SP_ADDNEWCATOGARY(string cat_name)
        {
            DataAccessLayer.Open();
         int count=DataAccessLayer.ExecuteNonQuery("SP_ADDNEWCATOGARY", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@CATOGARY_NAME", SqlDbType.VarChar, cat_name));
         DataAccessLayer.Close();
         return count;
        }
        public static DataTable SP_SELECTALLCATEGORIES()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SELECTALLCATEGORIES", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable SP_SEARCHCATEGORY(String search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SEARCHCATEGORY", CommandType.StoredProcedure,
            DataAccessLayer.CreateParameter("@SEARCH",SqlDbType.VarChar,search));
            DataAccessLayer.Close();
            return dt;

        }
        public static int SP_UPDATECATEGORY(int CAT_ID, string cat_name)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_UPDATECATEGORY", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@CAT_ID", SqlDbType.Int, CAT_ID),
                DataAccessLayer.CreateParameter("@CAT_NAME", SqlDbType.VarChar, cat_name));
            DataAccessLayer.Close();
            return i;
        }
        public static int SP_DELETECATEGORY(int cat_id) 
        {
            DataAccessLayer.Open();
           int i= DataAccessLayer.ExecuteNonQuery("SP_DELETECATEGORY", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@CAT_ID", SqlDbType.Int, cat_id));
            DataAccessLayer.Close();
            return i;
            

        }
    }
}
