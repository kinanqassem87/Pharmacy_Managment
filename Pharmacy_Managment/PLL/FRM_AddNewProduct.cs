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
    public partial class FRM_AddNewProduct : Form
    {
        bool _isupdate;
        public FRM_AddNewProduct(bool Isupdate)
        {
            InitializeComponent();
            this._isupdate = Isupdate;
            DataTable dtcat = CLASSPRODUCT.SP_FILLCATCMB();
            cmbcatogary.DataSource = dtcat;
            cmbcatogary.DisplayMember = "Cat_Name";
            cmbcatogary.ValueMember = "Cat_ID";

            DataTable dtam = CLASSPRODUCT.SP_FILLAMCMB();
            cmbAMName.DataSource = dtam;
            cmbAMName.DisplayMember = "Am_Name";
            cmbAMName.ValueMember = "Am_ID";

            DataTable dtsn = CLASSPRODUCT.SP_FILLSNCMB();
            cmbSnName.DataSource = dtsn;
            cmbSnName.DisplayMember = "Sn_Name";
            cmbSnName.ValueMember = "Sn_ID";

            if (_isupdate == true)
            {
                this.Text = "تعديل بيانات المنتج";
                btnAdd.Text = "تعديل ";
                  DataTable dt = CLASSPRODUCT.SP_GETSELECTEDPRODUCT(FRM_ProductManagment.id);
                  foreach (DataRow dr in dt.Rows)
                  {
                      cmbcatogary.Text = dr["Cat_Name"].ToString();
                      txtproductname.Text = dr["P_Name"].ToString();
                      txtPDescription.Text = dr["P_Description"].ToString();
                      txtBuyPrice.Text = dr["buyPrice"].ToString();
                      txtSellPrice.Text = dr["SelPrice"].ToString();
                      cmbAMName.Text = dr["Am_Name"].ToString();
                      cmbSnName.Text = dr["Sn_Name"].ToString();
                      txtbarcode.Text = dr["barcode"].ToString();
                      byte[] arr = (byte[])dr["P_Image"];
                      MemoryStream ms = new MemoryStream(arr);
                      picProImage.Image = Image.FromStream(ms);


                  }
            }

            else
            {
                this.Name = "اضافة منتج جديد";
                btnAdd.Name = "اضافة ";
            }
            
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "All Files|*.*|JPG|*.jpg|PNG|*.png";
                ofd.ShowDialog();
                picProImage.Image = Image.FromFile(ofd.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("لم يتم اختيار صورة");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                picProImage.Image.Save(ms, picProImage.Image.RawFormat);
                byte[] arr = ms.ToArray();
                if (_isupdate == false)
                {
                    if (txtproductname.Text!="" && txtBuyPrice.Text !="" && txtSellPrice.Text != "")
                    {

                        CLASSPRODUCT.SP_ADDNEWPRODUCT(txtproductname.Text, txtPDescription.Text, arr, txtBuyPrice.Text,
                            txtSellPrice.Text, (int)cmbcatogary.SelectedValue, (int)cmbAMName.SelectedValue, (int)cmbSnName.SelectedValue, txtbarcode.Text);
                        MessageBox.Show("تمت عملية اضافة المنتج بنجاح");
                    }
                    else
                    {
                        MessageBox.Show("المعلومات المدخلة غير كافية");
                        return;
                    }
                    // txtbarcode.Text = txtproductname.Text = txtBuyPrice.Text = txtPDescription.Text = txtSellPrice.Text = string.Empty;
                    foreach (Control item in groupBox1.Controls)
                    {
                        if (item is TextBox)
                            item.Text = string.Empty;
                    }
                }
                else
                {
                    CLASSPRODUCT.SP_UPDATEPRODUCT(FRM_ProductManagment.id, txtproductname.Text, txtPDescription.Text, arr, txtBuyPrice.Text,
                        txtSellPrice.Text, (int)cmbcatogary.SelectedValue, (int)cmbAMName.SelectedValue, (int)cmbSnName.SelectedValue, txtbarcode.Text);
                    MessageBox.Show("تمت عملية تعديل بيانات المنتج بنجاح");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("البيانات المدخلة غير كافية");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
