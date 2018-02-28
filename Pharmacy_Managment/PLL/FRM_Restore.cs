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
    public partial class FRM_Restore : Form
    {
        public FRM_Restore()
        {
            InitializeComponent();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = ofd.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                string path = txtPath.Text;
                ClassHelper.Restore(path);
                MessageBox.Show("تم استعادة النسخة الاحتياطية بنجاح");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
 
            }
        }
        
    }
}
