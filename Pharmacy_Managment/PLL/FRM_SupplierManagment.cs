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
    public partial class FRM_SupplierManagment : Form
    {
        public FRM_SupplierManagment()
        {
            InitializeComponent();
            btnDisplayAll_Click(null, null);
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            
                DataTable dt = ClassSupllier.SP_SUPPLIERSELECT();
                dgvsupplier.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = ClassSupllier.SP_SUPPLIERSEARCH(txtSearch.Text);
            dgvsupplier.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new FRM_AddnewSupplier(true).ShowDialog();
            btnDisplayAll_Click(null, null);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static int id;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            id =int.Parse( dgvsupplier.SelectedRows[0].Cells[0].Value.ToString());
            new FRM_AddnewSupplier(false).ShowDialog();
            //btnDisplayAll_Click(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            id = int.Parse(dgvsupplier.SelectedRows[0].Cells[0].Value.ToString());
            ClassSupllier.SP_SUPPLIERDELETE(id);
            MessageBox.Show("تم الحذف بنجاح");
            //btnDisplayAll_Click(null, null);
            
        }

        private void dgvsupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FRM_SupplierManagment_Activated(object sender, EventArgs e)
        {
            btnDisplayAll_Click(null, null);
        }
    }
}
