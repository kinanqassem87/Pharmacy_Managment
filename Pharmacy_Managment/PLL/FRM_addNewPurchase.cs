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
    public partial class FRM_addNewPurchase : Form
    {
        public FRM_addNewPurchase()
        {
            InitializeComponent();
            txtBuyerName.Text = Program.userFullName;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_Search frm = new FRM_Search("Supplier");
            frm.ShowDialog();
            txtSupID.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtSupName.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSupMobile.Text = frm.dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRM_Search frm = new FRM_Search("Product");
            frm.ShowDialog();
            txtProID.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtProName.Text = frm.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtPrice.Text = frm.dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            char d = char.Parse(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != d)
            {
                e.Handled = true;

            }
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtProID.Text == "")
                {
                    MessageBox.Show("يجب اختيار منتج");
                    return;
                }
                if (txtQty.Text == "" || double.Parse(txtQty.Text) <= 0)
                {
                    MessageBox.Show("يجب ادخال كمية المنتج و تكون بالموجب");
                    return;
                }
                for (int i = 0; i < dgvProduct.Rows.Count; i++)
                {
                    if (txtProID.Text == dgvProduct.Rows[i].Cells[0].Value.ToString())
                    {
                        MessageBox.Show("هذا المنتج موجود");
                        return;

                    }
                }
                string date = "";
                if (dateexpire.Checked)
                    date = dateexpire.Text;
                dgvProduct.Rows.Add(txtProID.Text, txtProName.Text, date, txtPrice.Text, txtQty.Text);
                txtProID.Text = txtProName.Text = txtQty.Text = txtPrice.Text = "";
                btnDelete.Enabled = true;
                caltotal();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try 
            { 
                dgvProduct.Rows.Remove(dgvProduct.CurrentRow);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("لا يوجد صفوف يمكن حذفها");
            }
            caltotal();
            
        }

        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProID.Text = dgvProduct.CurrentRow.Cells[0].Value.ToString();
            txtProName.Text = dgvProduct.CurrentRow.Cells[1].Value.ToString();
            if (dgvProduct.CurrentRow.Cells[2].Value.ToString() == "")
            {
                dateexpire.Checked = false;
            }
            else
            {
                dateexpire.Text = dgvProduct.CurrentRow.Cells[2].Value.ToString();
            }
            txtPrice.Text = dgvProduct.CurrentRow.Cells[3].Value.ToString();
            txtQty.Text = dgvProduct.CurrentRow.Cells[4].Value.ToString();
            btnDelete_Click(null, null);

        }
        void caltotal()
        {
            double total = 0;
            for (int i = 0; i < dgvProduct.Rows.Count; i++)
            {
                try
                {
                    total += double.Parse(dgvProduct.Rows[i].Cells[3].Value.ToString()) * double.Parse(dgvProduct.Rows[i].Cells[4].Value.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("البيانات المدخلة غير صحيحة قد تكون الاسعار ليست بصيغة رقمية");
                    return;
                }
                
            }
            txttotal.Text = total.ToString();

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable reqdet = new DataTable();
                reqdet.Columns.Add("P_ID");
                reqdet.Columns.Add("Qty");
                reqdet.Columns.Add("P_Price");
                foreach (DataGridViewRow dr in dgvProduct.Rows)
                {
                    reqdet.Rows.Add(dr.Cells[0].Value, dr.Cells[4].Value, dr.Cells[3].Value);
                }

                DataTable dtexpired = new DataTable();
                dtexpired.Columns.Add("Ex_Date");
                dtexpired.Columns.Add("P_ID");
                dtexpired.Columns.Add("Qty");
                foreach (DataGridViewRow dr in dgvProduct.Rows)
                {
                    string expired;
                    if (dr.Cells[2].Value.ToString() == "")
                        expired = null;
                    else
                        expired = dr.Cells[2].Value.ToString();

                    dtexpired.Rows.Add(DateTime.Parse(expired), dr.Cells[0].Value, dr.Cells[4].Value);
                }



                ClassRequest.sp_request_insert(reqdate.Value.Date, txttotal.Text,
                    int.Parse(txtSupID.Text), txtBuyerName.Text, reqdet, dtexpired);
                MessageBox.Show("تم عملية الحفظ بنجاح");
                btnprint.Enabled = btnnewPruchase.Enabled = true;
                btnsave.Enabled = btnDelete.Enabled= false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("البيانات غير كافية لحفظ الفاتورة");
            }

        }

        private void btnnewPruchase_Click(object sender, EventArgs e)
        {
            btnsave.Enabled = btnSupplier.Enabled = btnproduct.Enabled=txtbarcode.Enabled = true;
            btnnewPruchase.Enabled = false;
            txtbarcode.Text = txtSupID.Text = txtSupMobile.Text = txtSupName.Text = txtProID.Text = txtProName.Text = txtPrice.Text = txtQty.Text = txttotal.Text = "";
            dgvProduct.Rows.Clear();
            btnprint.Enabled = false;

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (txtbarcode.Text != "")
                {
                    DataTable dt = ClassOrder.SP_GET_PRODUCT_BARCODE_buy(txtbarcode.Text);
                    if (dt.Rows.Count==0)
                        MessageBox.Show("هذا المنتج غير موجود في المستودع يرجى الذهاب الى (اضافة منتج جديد) لاضافته");

                    foreach (DataRow dr in dt.Rows)
                    {
                        txtProID.Text = dr[0].ToString();
                        txtProName.Text = dr[1].ToString();
                        txtPrice.Text = dr[2].ToString();


                    }
                    txtbarcode.Text = "";

                }

            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            RPT.RRM_Reports frm = new RPT.RRM_Reports();
            RPT.rpt_print_requset rpr = new RPT.rpt_print_requset();
            rpr.SetParameterValue("@req_id",ClassRequest.max_id() );
            frm.crystalReportViewer1.ReportSource = rpr;
            frm.ShowDialog();
        }
    }
}
