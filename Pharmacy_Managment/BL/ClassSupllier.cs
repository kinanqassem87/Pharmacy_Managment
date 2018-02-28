using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Pharmacy_Managment.DAL;
using Pharmacy_Managment.NewDBset;
using System.Windows.Forms;

namespace Pharmacy_Managment.BL
{
    class ClassSupllier
    {
        public static int SP_ADDNEWSUPPLIER(string name, string mobile) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_ADDNEWSUPPLIER", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@SUPNAME", SqlDbType.VarChar, name),
                DataAccessLayer.CreateParameter("@SUPMOBILE", SqlDbType.VarChar, mobile));
            DataAccessLayer.Close();
            return i;

        }
        public static DataTable SP_SUPPLIERSELECT()
        {
            try
            {
               //information for this server
                DataTable dtuser = ClassInfo.sp_selectUser();
                //string server_name1 = "kinan-pc\\kinan_server";
                //string User_ID1 = "user1";
                //string Password1 = "2016";
                string server_name1 = Convert.ToString(dtuser.Rows[0].ItemArray[1]);
                string User_ID1 = Convert.ToString(dtuser.Rows[0].ItemArray[2]);
                string Password1 = Convert.ToString(dtuser.Rows[0].ItemArray[3]);

              //  MessageBox.Show(User_ID1);
                DataAccessLayer.con = "Data Source=" + server_name1 + ";Initial Catalog=Pharmacy_DB1;User ID=" + User_ID1 + ";Password=" + Password1;
                DataAccessLayer.Open();
                DataTable dt = DataAccessLayer.ExecuteTable("SP_SUPPLIERSELECT", CommandType.StoredProcedure);
                DataAccessLayer.Close();
               // ClassInfo.sp_insert1(server_name1);
                return dt;
                
                
            }
            catch (Exception ex)
            {
                //get information for anther servers
                DataTable dtt = ClassInfo.sp_select();
                    string server_name = Convert.ToString(dtt.Rows[0].ItemArray[1]);
                    string User_ID = Convert.ToString(dtt.Rows[0].ItemArray[2]);
                    string Password = Convert.ToString(dtt.Rows[0].ItemArray[3]);
                  //  MessageBox.Show(User_ID);

                DataAccessLayer.con = "Data Source=" + server_name + ";Initial Catalog=Pharmacy_DB1;User ID=" + User_ID + ";Password=" + Password;
              //  DataAccessLayer.con = "Data Source=pc-1;Initial Catalog=Pharmacy_DB1;User ID=sa;Password=2016";
                DataAccessLayer.Open();
                DataTable dt = DataAccessLayer.ExecuteTable("SP_SUPPLIERSELECT", CommandType.StoredProcedure);
                DataAccessLayer.Close();
               // ClassInfo.sp_insert1(server_name);
                
                return dt;
                
            }
                
           

        }
        public static DataTable SP_SUPPLIERSEARCH(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SUPPLIERSEARCH", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@SEARCH",SqlDbType.VarChar,search));
            DataAccessLayer.Close();
            return dt;

        }
        public static DataTable SP_SUPPLIERSELECTEDBYID(int id) 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SUPPLIERSELECTEDBYID", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ID", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return dt;
        }
        public static int SP_SUPPLIERUPDATE(int id,string name,string mobile) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_SUPPLIERUPDATE", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ID", SqlDbType.Int, id),
                DataAccessLayer.CreateParameter("@NAME", SqlDbType.VarChar,name),
                DataAccessLayer.CreateParameter("@MOBILE", SqlDbType.VarChar,mobile));
            DataAccessLayer.Close();
            return i;

        }
        public static int SP_SUPPLIERDELETE(int id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_SUPPLIERDELETE", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ID", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return i;
        }
        
        
    }
}
