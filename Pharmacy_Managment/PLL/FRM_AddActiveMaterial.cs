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
    public partial class FRM_AddActiveMaterial : Form
    {
        public FRM_AddActiveMaterial()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("يجب ادخال اسم المادة الفعالة");
                return;
            }
          int i=  CLASSACTIVEMATERIAL.SP_ADDACTIVEMATERIAL(txtName.Text, txtDiscreption.Text);
          MessageBox.Show("تم اضافة عدد " + i +"من المواد الفعالة");
          txtName.Text = txtDiscreption.Text = string.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
