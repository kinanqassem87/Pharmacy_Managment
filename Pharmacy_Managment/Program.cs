using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Pharmacy_Managment
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static string userFullName;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PLL.FRM_MAIN());
        }
    }
}
