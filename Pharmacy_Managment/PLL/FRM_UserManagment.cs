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
    public partial class FRM_UserManagment : Form
    {
        public FRM_UserManagment()
        {
            InitializeComponent();
            
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvUsers.DataSource= ClassUser.sp_user_display();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            dgvUsers.DataSource = ClassUser.sp_user_search(txtsearch.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new FRM_ADD_NewUser(false).ShowDialog();
        }
        public static DataGridViewRow row; 
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                row = dgvUsers.SelectedRows[0];
                new FRM_ADD_NewUser(true).ShowDialog();
            }
            else 
            {
                MessageBox.Show("يجب اختيار مستخدم ");
            }
            
        }

        private void FRM_UserManagment_Activated(object sender, EventArgs e)
        {
            btnDisplay_Click(null, null);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                row = dgvUsers.SelectedRows[0];
                ClassUser.sp_user_delete(int.Parse( row.Cells[0].Value.ToString()));
                MessageBox.Show("تم الحذف بنجاح");
            }
            else
            {
                MessageBox.Show("يجب اختيار مستخدم ");
            }
        }
    }
}
