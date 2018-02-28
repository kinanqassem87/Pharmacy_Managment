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
    public partial class FRM_OrderManagment : Form
    {
        public FRM_OrderManagment()
        {
            InitializeComponent();
            btnDisplay_Click(null, null);
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvOrderAll.DataSource = ClassOrder.sp_order_select();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrintSelected_Click(object sender, EventArgs e)
        {
            RPT.RRM_Reports frm = new RPT.RRM_Reports();
            RPT.rpt_order_print rop = new RPT.rpt_order_print();
           rop.SetParameterValue("@order_id",dgvOrderAll.SelectedRows[0].Cells[0].Value);
            frm.crystalReportViewer1.ReportSource = rop;
            frm.ShowDialog();
        }
    }
}
