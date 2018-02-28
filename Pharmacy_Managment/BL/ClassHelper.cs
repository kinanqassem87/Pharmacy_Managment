using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Pharmacy_Managment.DAL;

namespace Pharmacy_Managment.BL
{
    class ClassHelper
    {
        public static void Back_up(string Path)
        {
            DataAccessLayer.Open();
            string Query = string.Format("Backup Database Pharmacy_DB1 to Disk = '{0}'", Path);
            DataAccessLayer.ExecuteNonQuery(Query, CommandType.Text);
            DataAccessLayer.Close();
        
        }
        public static void Restore(string Path) 
        {
            DataAccessLayer.con = "Data Source=kinan-pc\\kinan_server; Initial Catalog=master;User ID=sa;Password=2016";
            DataAccessLayer.Open();
            string Query = string.Format("ALTER DATABASE Pharmacy_DB1 SET OFFLINE WITH ROLLBACK IMMEDIATE; Restore Database Pharmacy_DB1 from Disk = '{0}' WITH REPLACE", Path);
            DataAccessLayer.ExecuteNonQuery(Query, CommandType.Text);
            DataAccessLayer.Close();
        }
    }
}
