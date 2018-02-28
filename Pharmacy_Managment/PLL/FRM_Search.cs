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
    public partial class FRM_Search : Form
    {
        public FRM_Search(string _ch)
        {
            InitializeComponent();
            if (_ch == "Supplier") 
            {
                //DataTable dt = ClassSupllier.SP_SUPPLIERSELECT();
                //dataGridView1.DataSource = dt;
                this.Text = "بيانات الموردين";
                dataGridView1.DataSource = ClassSupllier.SP_SUPPLIERSELECT();
                

            }
            else if (_ch == "Product")
            {
                //DataTable dt = ClassSupllier.SP_SUPPLIERSELECT();
                //dataGridView1.DataSource = dt;
                this.Text = "المنتجات";
                dataGridView1.DataSource = CLASSPRODUCT.SP_PRODECUTSELECT();
                

            }
            else if (_ch == "customer")
            {
                this.Text = "بيانات العملاء";
                dataGridView1.DataSource = CLASS_CUSTOMER.SP_CUSTOMER_DISPLAY();
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }
    }
}
