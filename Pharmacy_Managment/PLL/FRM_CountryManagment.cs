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
    public partial class FRM_CountryManagment : Form
    {
        public FRM_CountryManagment()
        {
            InitializeComponent();
            btnDisplay_Click(null, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcountName.Text == "")
                {
                    MessageBox.Show("الرجاء ادخال اسم الدولة");
                    return;
                }
                 Class_COUNTRY.SP_COUNTRY_INSERT(txtcountName.Text);
                 MessageBox.Show("تم الاضافة بنجاح");
                 txtcountName.Text = "";
                 btnDisplay_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvcountry.DataSource= Class_COUNTRY.SP_COUNTRY_DISPLAY();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            dgvcountry.DataSource= Class_COUNTRY.SP_COUNTRY_SEARCH(txtsearch.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCountID.Text != "")
                {
                    Class_COUNTRY.SP_COUNTRY_UPDATE(int.Parse(txtCountID.Text), txtcountName.Text);
                    MessageBox.Show("تم التعديل بنجاح");
                    btnDisplay_Click(null, null);
                }
                else 
                {
                    MessageBox.Show("لم يتم تحديد البلد");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void dgvcountry_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCountID.Text = dgvcountry.SelectedRows[0].Cells[0].Value.ToString();
            txtcountName.Text = dgvcountry.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCountID.Text != "")
                {
                    Class_COUNTRY.SP_COUNTRY_DELETE(int.Parse(txtCountID.Text));
                    txtCountID.Text = txtcountName.Text = "";
                    btnDisplay_Click(null, null);
                    MessageBox.Show("تم الحذف بنجاح");
                }
                else 
                {
                    MessageBox.Show("لم يتم تحديد البلد");
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
