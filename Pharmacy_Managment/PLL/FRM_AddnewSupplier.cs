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
    public partial class FRM_AddnewSupplier : Form
    {
        bool _check;
        public FRM_AddnewSupplier(bool check)
        {
            InitializeComponent();
            _check = check;
            if (_check)
            {
                this.Text = "اضافة مورد جديد";
                btnadd.Text = "اضافة";
            }
            else
            {
                this.Text = "تعديل بيانات المورد";
                btnadd.Text = "تعديل";
                DataTable dt = ClassSupllier.SP_SUPPLIERSELECTEDBYID(FRM_SupplierManagment.id);
                foreach (DataRow dr in dt.Rows) 
                {
                    txtname.Text = dr["Su_Name"].ToString();
                    txtmobile.Text = dr["Su_Mobile"].ToString();
                }
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (_check)
            {
                if (txtname.Text != "")
                {
                    ClassSupllier.SP_ADDNEWSUPPLIER(txtname.Text, txtmobile.Text);
                    MessageBox.Show("تم الاضافة بنجاح");
                    txtname.Text = txtmobile.Text = string.Empty;
                }
                else 
                {
                    MessageBox.Show("الرجاء ادخال الاسم");
                }

            }
            else 
            {
                ClassSupllier.SP_SUPPLIERUPDATE(FRM_SupplierManagment.id, txtname.Text, txtmobile.Text);
                MessageBox.Show("تم التعديل بنجاح");
                txtname.Text = txtmobile.Text = string.Empty;
                
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
