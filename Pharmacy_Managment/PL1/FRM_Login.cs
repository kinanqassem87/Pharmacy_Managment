using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Pharmacy_Managment.BL;

namespace Pharmacy_Managment.PL
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
            DataTable dt = CLASS_LOGIN.Splogin(txtUName.Text, txtUPass.Text);
            if (dt.Rows.Count > 0)
                MessageBox.Show("تم الدخول بنجاح");
            else
                MessageBox.Show("اسم المستخدم أو كلمة المرور خاطئة");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
