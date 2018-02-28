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
    public partial class FRM_CustomerManagment : Form
    {
        public FRM_CustomerManagment()
        {
            InitializeComponent();
            
        }

        public void display(DataTable dt)
   
        {
            dgvCustomer.DataSource = dt;
            dgvCustomer.Columns[4].Width = 100;
            foreach (DataGridViewColumn col in dgvCustomer.Columns)
            {
                if (col is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)col).ImageLayout = DataGridViewImageCellLayout.Stretch;
                }
            }
            foreach (DataGridViewRow dr in dgvCustomer.Rows)
            {
                dr.Height = 100;
            }

    
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            display( CLASS_CUSTOMER.SP_CUSTOMER_DISPLAY());
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            display( CLASS_CUSTOMER.SP_CUSTOMER_SEARCH(txtSearch.Text));
            

           
        }

        private void FRM_CustomerManagment_Activated(object sender, EventArgs e)
        {
            btnDisplay_Click(null, null);
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new FRM_AddNewCustomer(false).ShowDialog();
        }

        public static DataGridViewRow row = null;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count > 0)
                row = dgvCustomer.SelectedRows[0];
            else
                MessageBox.Show("يجب اختيار العميل");
            new FRM_AddNewCustomer(true).ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count > 0)
            {
                row = dgvCustomer.SelectedRows[0];
                CLASS_CUSTOMER.SP_CUSTOMER_DELETE(int.Parse(row.Cells[0].Value.ToString()));
                MessageBox.Show("تمت عملية الحذف بنجاح");
            }
            else
                MessageBox.Show("يجب اختيار العميل");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
