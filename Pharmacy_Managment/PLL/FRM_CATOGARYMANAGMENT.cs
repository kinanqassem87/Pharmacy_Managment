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
    public partial class FRM_CATOGARYMANAGMENT : Form
    {
        public FRM_CATOGARYMANAGMENT()
        {
            InitializeComponent();
            btnselectall_Click(null, null);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtsearch.Text == String.Empty) 
            {
                MessageBox.Show("يجب ادخال الكلمة المراد البحث عنها");
                return;
            }
            DataTable dt = CLASS_CATOGARY.SP_SEARCHCATEGORY(txtsearch.Text);
            dgvcatogaries.DataSource = dt;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnselectall_Click(object sender, EventArgs e)
        {
            DataTable dt = CLASS_CATOGARY.SP_SELECTALLCATEGORIES();
            dgvcatogaries.DataSource = dt;
        }

        private void dgvcatogaries_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtcatID.Text = dgvcatogaries.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtcatname.Text = dgvcatogaries.Rows[e.RowIndex].Cells[1].Value.ToString();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int i = CLASS_CATOGARY.SP_UPDATECATEGORY(int.Parse(txtcatID.Text), txtcatname.Text);
            MessageBox.Show("تم تعديل عدد "+i+"من الصفوف بنجاح ");
            btnselectall_Click(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = CLASS_CATOGARY.SP_DELETECATEGORY(int.Parse(txtcatID.Text));
            MessageBox.Show("تم حذف عدد  "+i+" من الصفوف بنجاح");
            btnselectall_Click(null, null);
                txtcatID.Text=txtcatname.Text=string.Empty;
        }
    }
}
