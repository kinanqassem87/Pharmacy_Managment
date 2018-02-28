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
    public partial class FRM_Request_Managment : Form
    {
        public FRM_Request_Managment()
        {
            InitializeComponent();
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            FRM_Request_Managment_Load(null, null);
        }

        private void FRM_Request_Managment_Load(object sender, EventArgs e)
        {
            dgvReqMang.DataSource = ClassRequest.SP_REQUESTDISPLAY();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            RPT.RRM_Reports frm = new RPT.RRM_Reports();
            RPT.rpt_print_requset rpr = new RPT.rpt_print_requset();
            rpr.SetParameterValue("@req_id",dgvReqMang.SelectedRows[0].Cells[0].Value);
            frm.crystalReportViewer1.ReportSource = rpr;
            frm.ShowDialog();

        }
    }
}
