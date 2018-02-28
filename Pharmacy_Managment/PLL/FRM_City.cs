using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Pharmacy_Managment.BL;
using System.Windows.Forms;

namespace Pharmacy_Managment.PLL
{
    public partial class FRM_City : Form
    {
        public FRM_City()
        {
            InitializeComponent();
            btnDisplay_Click(null, null);
            cmbCountry.DataSource = Class_COUNTRY.SP_COUNTRY_DISPLAY();
            cmbCountry.DisplayMember = "اسم الدولة";
            cmbCountry.ValueMember = "رقم الدولة";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCityName.Text == "")
                {
                    MessageBox.Show("يجب ادخال اسم المدينة");
                    return;
                }
                Class_CITY.SP_CITY_INSERT(txtCityName.Text, int.Parse(cmbCountry.SelectedValue.ToString()));
                MessageBox.Show("تمت عملية الاضافة بنجاح");
                txtCityName.Text = "";
                btnDisplay_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvCity.DataSource = Class_CITY.SP_CITY_DISPLAY();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            dgvCity.DataSource= Class_CITY.SP_CITY_SEARCH(txtsearch.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCityID.Text != "")
                {
                    Class_CITY.SP_CITY_UPDATE(int.Parse(txtCityID.Text), txtCityName.Text, int.Parse(cmbCountry.SelectedValue.ToString()));
                    MessageBox.Show("تم التعديل بنجاح");
                    txtCityName.Text = txtCityID.Text = "";
                    btnDisplay_Click(null, null);
                }
                else
                {
                    MessageBox.Show("لم يتم تحديد المدينة");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCity_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCityID.Text = dgvCity.SelectedRows[0].Cells[0].Value.ToString();
            txtCityName.Text = dgvCity.SelectedRows[0].Cells[1].Value.ToString();
            cmbCountry.Text = dgvCity.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCityID.Text != "")
                {
                    Class_CITY.SP_CITY_DELETE(int.Parse(txtCityID.Text));
                    MessageBox.Show("تم الحذف بنجاح");
                    txtCityID.Text = txtCityName.Text = "";
                    btnDisplay_Click(null, null);
                }
                else
                {
                    MessageBox.Show("يجب تحديد المدينة اولا");
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
