using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Pharmacy_Managment.BL;

namespace Pharmacy_Managment.PLL
{
    public partial class FRM_Login : Form
    {
        public FRM_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUName.Text == string.Empty)
            {
                MessageBox.Show("يجب ادخال اسم المستخدم");
                return;
            }
            if (txtUPass.Text == string.Empty)
            {
                MessageBox.Show("يجب ادخال كلمة المرور");
                return;
            }

            try
            {
                DataTable dt = CLASS_LOGIN.Splogin(txtUName.Text, txtUPass.Text);

                if (dt.Rows.Count > 0)
                {
                    FRM_MAIN.check = true;
                    FRM_MAIN.Per_ID =int.Parse( dt.Rows[0]["Per_ID"].ToString());
                    Program.userFullName = dt.Rows[0]["U_Full_Name"].ToString();
                    this.Close();
                }
                else
                    MessageBox.Show("اسم المستخدم أو كلمة المرور خاطئة");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("لا يمكن الاتصال بقاعدة البيانات الرجاء التحقق من الاعدادات و اعادة المحاولة");
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
