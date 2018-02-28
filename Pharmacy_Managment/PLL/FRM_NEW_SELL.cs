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
    public partial class FRM_NEW_SELL : Form
    {
        public FRM_NEW_SELL()
        {
            InitializeComponent();
            txtsellerName.Text = Program.userFullName;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnCUSTOMER_Click(object sender, EventArgs e)
        {
            FRM_Search frm = new FRM_Search("customer");
            frm.ShowDialog();
            txtCuID.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtCUName.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtCUMobile.Text = frm.dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }

        private void btnnewOrder_Click(object sender, EventArgs e)
        {
            btnCUSTOMER.Enabled = btnproduct.Enabled = txtBarcode.Enabled = true;
            btnnewOrder.Enabled=btnDelete.Enabled = false;
            txtCuID.Text = txtCUName.Text = txtCUName.Text = txtProID.Text = txtProName.Text = txtPrice.Text = txtQty.Text = txttotal.Text=txtCUMobile.Text = "";
            dgvProduct.Rows.Clear();
            btnprint.Enabled = false;

        }
         float  totalQTY;
         
        private void btnproduct_Click(object sender, EventArgs e)
        {
            FRM_Search frm = new FRM_Search("Product");
            frm.ShowDialog();
            txtProID.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtProName.Text = frm.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtPrice.Text = frm.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            
            totalQTY = float.Parse(frm.dataGridView1.CurrentRow.Cells[7].Value.ToString());


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
                if (float.Parse(txtQty.Text) > totalQTY)
                {
                    MessageBox.Show("الكمية المطلوبة اكبر من الكمية الموجودة");
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
                dgvProduct.Rows.Add(txtProID.Text.ToString(), txtProName.Text.ToString(),
                    txtPrice.Text.ToString(), txtQty.Text.ToString());
                btnDelete.Enabled = true;
                txtProID.Text = txtProName.Text = txtPrice.Text = txtQty.Text = "";
                calordertotal();
                btnsave.Enabled = true;

            }

        }
        void calordertotal()
        {
            double total = 0;
            for (int i = 0; i < dgvProduct.Rows.Count; i++)
            {
                try
                {
                    total += double.Parse(dgvProduct.Rows[i].Cells[2].Value.ToString()) * double.Parse(dgvProduct.Rows[i].Cells[3].Value.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("البيانات المدخلة غير صحيحة قد تكون الاسعار ليست بصيغة رقمية");
                    return;
                }

            }
            txttotal.Text = total.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvProduct.Rows.Remove(dgvProduct.CurrentRow);
            calordertotal();
        }

        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProID.Text = dgvProduct.CurrentRow.Cells[0].Value.ToString();
            txtProName.Text = dgvProduct.CurrentRow.Cells[1].Value.ToString();
            txtPrice.Text = dgvProduct.CurrentRow.Cells[2].Value.ToString();
            txtQty.Text = dgvProduct.CurrentRow.Cells[3].Value.ToString();

            btnDelete_Click(null, null);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable order_det = new DataTable();
                order_det.Columns.Add("P_ID");
                order_det.Columns.Add("Qty");
                order_det.Columns.Add("P_Price");

                for (int i = 0; i < dgvProduct.Rows.Count; i++)
                {
                    order_det.Rows.Add(dgvProduct.Rows[i].Cells[0].Value,
                        dgvProduct.Rows[i].Cells[3].Value,
                        dgvProduct.Rows[i].Cells[2].Value);

                }

                ClassOrder.sp_order_insert(reqdate.Value, txttotal.Text,
                    int.Parse(txtCuID.Text), txtsellerName.Text, order_det);
                MessageBox.Show("تم حفظ الفاتورة بنجاح");
                btnprint.Enabled = btnnewOrder.Enabled = true;
                btnsave.Enabled=btnDelete.Enabled = false;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("البيانات المدخلة غير كافية");
            }

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (txtBarcode.Text != "")
                {
                    DataTable dt = ClassOrder.SP_GET_PRODUCT_BARCODE(txtBarcode.Text);

                    if (dt.Rows.Count == 0)
                        MessageBox.Show("هذا المنتج غير موجود في المستودع يرجى الذهاب الى (اضافة منتج جديد) لاضافته");

                    foreach (DataRow dr in dt.Rows)
                    {
                        txtProID.Text = dr[0].ToString();
                        txtProName.Text = dr[1].ToString();
                        txtPrice.Text = dr[2].ToString();
                        totalQTY = float.Parse( dr[3].ToString());


                    }
                    txtBarcode.Text = "";

                }

            }

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            RPT.RRM_Reports frm = new RPT.RRM_Reports();
            RPT.rpt_order_print rop = new RPT.rpt_order_print();
            rop.SetParameterValue("@order_id",ClassOrder.max_id_order());
            frm.crystalReportViewer1.ReportSource = rop;
            frm.ShowDialog();
        }
    }
}
