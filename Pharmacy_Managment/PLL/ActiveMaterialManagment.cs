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
    public partial class ActiveMaterialManagment : Form
    {
        public ActiveMaterialManagment()
        {
            InitializeComponent();
            btnselectall_Click(null, null);
        }

        private void btnselectall_Click(object sender, EventArgs e)
        {
            DataTable dt = CLASSACTIVEMATERIAL.SP_SELECTALLACTIVEMATERIAL();
            dgvActiveMaterial.DataSource = dt;
        }

        private void dgvActiveMaterial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtAMID.Text = dgvActiveMaterial.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtAMName.Text = dgvActiveMaterial.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAMDiscreption.Text = dgvActiveMaterial.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            DataTable dt = CLASSACTIVEMATERIAL.SP_SELECTSEARCHACTIVEMATERIAL(txtsearch.Text);
            dgvActiveMaterial.DataSource = dt;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int i = CLASSACTIVEMATERIAL.SP_UPDATEACTIVEMATERIAL(int.Parse(txtAMID.Text), txtAMName.Text, txtAMDiscreption.Text);
            MessageBox.Show("تم تعديل البيانات بنجاح");
            btnselectall_Click(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = CLASSACTIVEMATERIAL.SP_DELETEACTIVEMATERIAL(int.Parse(txtAMID.Text));
            MessageBox.Show("تم حذف المادة بنجاح");
            btnselectall_Click(null, null);
        }
    }
}
