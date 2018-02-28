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
    public partial class FRM_ADDCATOGARY : Form
    {
        public FRM_ADDCATOGARY()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtCatogary.Text == string.Empty)
            {
                MessageBox.Show("يجب ادخال اسم الصنف");
                return;
            }
         int i =   CLASS_CATOGARY.SP_ADDNEWCATOGARY(txtCatogary.Text);
         MessageBox.Show(" تم اضافة عدد " +i+ "من الاصناف ");
         txtCatogary.Text = string.Empty;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
