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
    public partial class FRM_AddScinteficName : Form
    {
        public FRM_AddScinteficName()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (TXTName.Text == string.Empty)
            {
                MessageBox.Show("الاسم العلمي غير موجود");
                return;
            }
            CLASSSCINTAFEICNAME.SP_ADDSCINTEFICNAME(TXTName.Text);
          MessageBox.Show("تم اضافة الاسم العلمي بنجاح");
          TXTName.Text = string.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
