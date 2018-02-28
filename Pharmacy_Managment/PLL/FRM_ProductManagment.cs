using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Pharmacy_Managment.BL;
using System.IO;
using CrystalDecisions.Shared;



namespace Pharmacy_Managment.PLL
{
    public partial class FRM_ProductManagment : Form
    {
        public FRM_ProductManagment()
        {
            InitializeComponent();
        }

        private void FRM_ProductManagment_Load(object sender, EventArgs e)
        {

        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            DataTable dt = CLASSPRODUCT.SP_PRODECUTSELECT();
            //  dgvproduct.DataSource = dt;//not recommanded here
            dgvproduct.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                dgvproduct.Rows.Add(dr[0], dr[1], dr[2], dr[3],
                    dr[4], dr[5], dr[6], dr[7], dr[8], dr[9]);
            }
        }

        private void FRM_ProductManagment_Activated(object sender, EventArgs e)
        {
            btnSelectAll_Click(null, null);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = CLASSPRODUCT.SP_PRODUCTSEARCH(txtSearch.Text);
            dgvproduct.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                dgvproduct.Rows.Add(dr[0], dr[1], dr[2], dr[3],
                    dr[4], dr[5], dr[6], dr[7], dr[8], dr[9]);
            }
        }

        private void btndisplayimage_Click(object sender, EventArgs e)
        {
            byte[] arr = CLASSPRODUCT.SP_PRODUCTGETIMAGE(int.Parse(dgvproduct.SelectedRows[0].Cells[0].Value.ToString()));
            MemoryStream ms = new MemoryStream(arr);
            FRM_PRODUCTIMAGE PI = new FRM_PRODUCTIMAGE();
            PI.PicImage.Image = Image.FromStream(ms);
            PI.ShowDialog();





        }

        private void btndisplayExpire_Click(object sender, EventArgs e)
        {
            DataTable dt = CLASSPRODUCT.SP_PRODUCTGETEXPIREDDATE(int.Parse(dgvproduct.SelectedRows[0].Cells[0].Value.ToString()));
            if (dt.Rows.Count > 0)
            {
                FRM_ProductExPierQTY frm = new FRM_ProductExPierQTY();
                frm.dgvProEXDate.DataSource = dt;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("لا توجد صلاحيات لهذا المنتج");
            }
        }
        public static int id;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            id = int.Parse(dgvproduct.SelectedRows[0].Cells[0].Value.ToString());
            DialogResult dr = MessageBox.Show(" هل تريد حذف المنتج المحدد", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                int i = CLASSPRODUCT.SP_ProducrDelete(id);
                MessageBox.Show("تم الحذف بنجاح");
            }
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            new FRM_AddNewProduct(false).ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            id = int.Parse(dgvproduct.SelectedRows[0].Cells[0].Value.ToString());
            new FRM_AddNewProduct(true).ShowDialog();

        }

        private void btnPrintAllProduct_Click(object sender, EventArgs e)
        {
            RPT.RRM_Reports frm = new RPT.RRM_Reports();
            RPT.rpt_AllProductN pr = new RPT.rpt_AllProductN();
            frm.crystalReportViewer1.ReportSource = pr;
            frm.ShowDialog();
        }

        private void btnPrintSelectedProduct_Click(object sender, EventArgs e)
        {
            RPT.RRM_Reports frm = new RPT.RRM_Reports();
            RPT.rpt_printSelectedProducrN PSP = new RPT.rpt_printSelectedProducrN();
            PSP.SetParameterValue("@P_ID", dgvproduct.SelectedRows[0].Cells[0].Value);
            frm.crystalReportViewer1.ReportSource = PSP;
            frm.ShowDialog();
        }

        private void btnSavetoExcel_Click(object sender, EventArgs e)
        {
            try
            {
                RPT.rpt_AllProductN report = new RPT.rpt_AllProductN();
                //choose destination for a report 
                DiskFileDestinationOptions destination = new DiskFileDestinationOptions();

                ExportOptions export = new ExportOptions();
                ExcelFormatOptions excelFormat = new ExcelFormatOptions();
               
                    FolderBrowserDialog fd = new FolderBrowserDialog();
                    fd.ShowDialog();
                    string df = fd.SelectedPath+"\\report.xls";

               // destination.DiskFileName = "D:\\report.xls";
                destination.DiskFileName = df ;
                export = report.ExportOptions;
                export.ExportDestinationType = ExportDestinationType.DiskFile;
                export.ExportFormatType = ExportFormatType.Excel;
                export.ExportDestinationOptions = destination;
                export.ExportFormatOptions = excelFormat;
                report.Export();
                MessageBox.Show("تم تصدير الملف بنجاح");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("لا يمكن الوصول الى قاعدة البيانات لتصدير الملف نحتاج الى الدخول في وضعية وثوقية الويندوز ");
           }


        }
    }
}
