using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Pharmacy_Managment.BL;

namespace Pharmacy_Managment.PLL
{
    public partial class FRM_AddNewCustomer : Form
    {
        bool isUpdate;
        public FRM_AddNewCustomer(bool _isUpdate)
        {
            InitializeComponent();
            this.isUpdate = _isUpdate;
            cmbCountry.DataSource = Class_COUNTRY.SP_COUNTRY_DISPLAY();
            cmbCountry.DisplayMember = "اسم الدولة";
            cmbCountry.ValueMember = "رقم الدولة";
            cmbCountry_SelectionChangeCommitted(null, null);
            if (isUpdate)
            {
                this.Text = "تعديل بيانات العميل";
                btnaddUpdate.Text = "تعديل";
                txtCuName.Text = FRM_CustomerManagment.row.Cells[1].Value.ToString();
                txtCuAddress.Text = FRM_CustomerManagment.row.Cells[2].Value.ToString();
                txtCuMobile.Text = FRM_CustomerManagment.row.Cells[3].Value.ToString();
                MemoryStream ms = new MemoryStream(FRM_CustomerManagment.row.Cells[4].Value as byte []);
                picCUImage.Image = Image.FromStream(ms);
                cmbCity.Text = FRM_CustomerManagment.row.Cells[5].Value.ToString();
                cmbCountry.Text = FRM_CustomerManagment.row.Cells[6].Value.ToString();
                
            }
            else 
            {
                this.Text = "اضافة عميل جديد";
                btnaddUpdate.Text = "اضافة";
            }

        }

        private void cmbCountry_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbCity.DataSource=CLASS_CUSTOMER.SP_ENTRY_BY_COUNTRYID(int.Parse(cmbCountry.SelectedValue.ToString()));
            cmbCity.DisplayMember = "City_Name";
            cmbCity.ValueMember = "City_ID";
        }

        private void picCUImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) 
            {
                picCUImage.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnaddUpdate_Click(object sender, EventArgs e)
        {
            MemoryStream ms=new MemoryStream();
            picCUImage.Image.Save(ms,picCUImage.Image.RawFormat);
            byte[] cu_image=ms.ToArray();
            if (txtCuName.Text == "")
            {
                MessageBox.Show("يجب ادخال اسم العميل");
                return;
            }

            if (isUpdate)
            {
                CLASS_CUSTOMER.SP_CUSTOMER_UPDATE(int.Parse( FRM_CustomerManagment.row.Cells[0].Value.ToString()), txtCuName.Text,
                    txtCuAddress.Text, txtCuMobile.Text, cu_image, int.Parse(cmbCity.SelectedValue.ToString()));
                MessageBox.Show("تمت عملية التعديل بنجاح");
            }
            else 
            {
                try
                {
                    CLASS_CUSTOMER.SP_ADD_NEW_CUSTOMER(txtCuName.Text, txtCuAddress.Text, txtCuMobile.Text, cu_image, int.Parse(cmbCity.SelectedValue.ToString()));
                    MessageBox.Show("تمت الاضافة بنجاح");
                    txtCuName.Text = txtCuAddress.Text = txtCuMobile.Text = "";
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
