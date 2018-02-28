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
    public partial class FRM_ADD_NewUser : Form
    {
        bool isupdate;
        public FRM_ADD_NewUser(bool _isupdate)
        {
          
            InitializeComponent();
            cmbPermission.DataSource = ClassUser.sp_permission();
            cmbPermission.DisplayMember = "Per_Name";
            cmbPermission.ValueMember = "Per_ID";

            this.isupdate = _isupdate;
            if (isupdate)
            {
                this.Text = "تعديل بيانات المستخدم";
                btnAddUpdate.Text ="تعديل";
                txtusername.Text = FRM_UserManagment.row.Cells[1].Value.ToString();
               txtPassword.Text=txtREPassword.Text = FRM_UserManagment.row.Cells[2].Value.ToString();
               txtfullname.Text = FRM_UserManagment.row.Cells[3].Value.ToString();
               cmbPermission.Text = FRM_UserManagment.row.Cells[4].Value.ToString();


            }
            else  
            {
                this.Text = "اضافة مستخدم جديد";
                btnAddUpdate.Text = "اضافة";
            }
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtusername.Text == "")
                {
                    MessageBox.Show("يجب ادخال اسم المستخدم");
                    return;
                }
                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("يجب ادخال كلمة المرور");
                    return;
                }
                else if (txtREPassword.Text != txtPassword.Text)
                {
                    MessageBox.Show("كلمة المرور غير متطابقة");
                    return;
                }
                else if (txtfullname.Text == "")
                {
                    MessageBox.Show("يجب ادخال السم بالكامل");
                    return;
                }

                if (isupdate)
                {
                    ClassUser.sp_user_update(int.Parse(FRM_UserManagment.row.Cells[0].Value.ToString()), txtusername.Text, txtPassword.Text, txtfullname.Text, int.Parse(cmbPermission.SelectedValue.ToString()));
                    MessageBox.Show("تم التعديل بنجاح");
                    foreach (Control ctr in groupBox1.Controls)
                    {
                        if (ctr is TextBox)
                            ctr.Text = "";
                    }

                }
                else
                {
                    ClassUser.sp_user_insert(txtusername.Text, txtPassword.Text, txtfullname.Text, int.Parse(cmbPermission.SelectedValue.ToString()));
                    MessageBox.Show("تم الاضافة بنجاح");
                    foreach (Control ctr in groupBox1.Controls)
                    {
                        if (ctr is TextBox)
                            ctr.Text = "";
                    }
                   //or txtusername.Text = txtPassword.Text = txtREPassword.Text = txtfullname.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
