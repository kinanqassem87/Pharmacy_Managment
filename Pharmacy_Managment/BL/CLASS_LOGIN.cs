using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Pharmacy_Managment.DAL;

namespace Pharmacy_Managment.BL
{
    class CLASS_LOGIN
    {
        public static DataTable Splogin(string UName, string Pass)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_LOGIN", CommandType.StoredProcedure, 
                DataAccessLayer.CreateParameter("@UNAME", SqlDbType.VarChar, UName), 
                DataAccessLayer.CreateParameter("@UPASS", SqlDbType.VarChar, Pass));
            DataAccessLayer.Close();
            return dt;
        }

    }
}
