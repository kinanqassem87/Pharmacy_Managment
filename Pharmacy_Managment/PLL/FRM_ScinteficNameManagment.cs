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
    public partial class FRM_ScinteficNameManagment : Form
    {
        public FRM_ScinteficNameManagment()
        {
            InitializeComponent();
            btnselectall_Click(null, null);
        }

        private void btnselectall_Click(object sender, EventArgs e)
        {
           DataTable dt= CLASSSCINTAFEICNAME.SP_SELECTALLSCINTEFICNAME();
           dgvScinteficName.DataSource = dt;
        }

        private void dgvScinteficName_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtSID.Text = dgvScinteficName.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtSciname.Text = dgvScinteficName.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            DataTable dt = CLASSSCINTAFEICNAME.SP_SEARCHSCINTEFICNAME(txtsearch.Text);
            dgvScinteficName.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CLASSSCINTAFEICNAME.SP_DELETESCINTAFICNAME(int.Parse(txtSID.Text));
            MessageBox.Show("تمت عملية الحذف بنجاح");
            btnselectall_Click(null, null);
            txtSID.Text = txtSciname.Text = string.Empty;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CLASSSCINTAFEICNAME.SP_UPDATESCINTAFICNAME(int.Parse(txtSID.Text), txtSciname.Text);
            btnselectall_Click(null, null);
            MessageBox.Show("تم التعديل بنجاح");
            
        }
    }
}
