using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Pharmacy_Managment.PLL
{
    public partial class FRM_MAIN : Form
    {
        public FRM_MAIN()
        {
            InitializeComponent();
        }
        //check if the inter the valid user and password
        public static bool check = false;

        public static int Per_ID = 0;

        private void TsmLogin_Click(object sender, EventArgs e)
        {
            FRM_Login frm = new FRM_Login();
            frm.ShowDialog();
        }

        private void FRM_MAIN_Activated(object sender, EventArgs e)
        {
            if (Per_ID == 1)
            {
                TsmProducts.Enabled = TsmCustomers.Enabled = TsmSuppliers.Enabled = TsmUsers.Enabled =
                    TsmBackup.Enabled = TsmRestore.Enabled = TSMAbout.Enabled =
                    TsmCustomerManagment.Enabled = TsmAddCustomer.Enabled = TsmBuyManagment.Enabled = tsmCountries.Enabled = tsmCity.Enabled= check;
            }
            else if (Per_ID == 2)

            {
                TsmCustomerManagment.Enabled = TsmAddCustomer.Enabled = TsmBuyManagment.Enabled = tsmCountries.Enabled = tsmCity.Enabled = false;
               TsmCustomers.Enabled= TsmNewSell.Enabled=TSMAbout.Enabled = check;
            }
            else if (Per_ID == 0) 
            {
                TsmProducts.Enabled = TsmCustomers.Enabled = TsmSuppliers.Enabled = TsmUsers.Enabled = TsmBackup.Enabled = TsmRestore.Enabled =TSMAbout.Enabled = check;
            }
        }

        private void tsmfile_Click(object sender, EventArgs e)
        {

        }

        private void TsmAddType_Click(object sender, EventArgs e)
        {
            //FRM_ADDCATOGARY cat = new FRM_ADDCATOGARY();
            //cat.ShowDialog();
            new FRM_ADDCATOGARY().ShowDialog();
        }

        private void TsmTypeManagment_Click(object sender, EventArgs e)
        {
            FRM_CATOGARYMANAGMENT cat = new FRM_CATOGARYMANAGMENT();
            cat.ShowDialog();
        }

        private void TsmProducts_Click(object sender, EventArgs e)
        {

        }

        private void tsmAddActiveMaterial_Click(object sender, EventArgs e)
        {
            FRM_AddActiveMaterial tsm = new FRM_AddActiveMaterial();
            tsm.ShowDialog();
        }

        private void tsmActiveMateriakManag_Click(object sender, EventArgs e)
        {
            ActiveMaterialManagment amm = new ActiveMaterialManagment();
            amm.ShowDialog();
        }

        private void tsmScentificManag_Click(object sender, EventArgs e)
        {
            FRM_ScinteficNameManagment Sn = new FRM_ScinteficNameManagment();
            Sn.ShowDialog();
        }

        private void tsmAddScintafic_Click(object sender, EventArgs e)
        {
            FRM_AddScinteficName asn = new FRM_AddScinteficName();
            asn.ShowDialog();
        }

        private void TsmProductManagment_Click(object sender, EventArgs e)
        {
            FRM_ProductManagment PM = new FRM_ProductManagment();
            PM.ShowDialog();
        }

        private void TsmaddProduct_Click(object sender, EventArgs e)
        {
            FRM_AddNewProduct anp = new FRM_AddNewProduct(false);
            anp.ShowDialog();
        }

        private void TsmAddSupply_Click(object sender, EventArgs e)
        {
            new FRM_AddnewSupplier(true).ShowDialog();
        }

        private void TsmSuppliersManagment_Click(object sender, EventArgs e)
        {
            new FRM_SupplierManagment().ShowDialog();
        }

        private void TsmNewSell_Click(object sender, EventArgs e)
        {
            new FRM_addNewPurchase().ShowDialog();
        }

        private void TsmsellsManagment_Click(object sender, EventArgs e)
        {
            new FRM_Request_Managment().ShowDialog(); 
        }

        private void إدارةالبلدانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FRM_CountryManagment().ShowDialog();
        }

        private void ادارةالمدنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FRM_City().ShowDialog();
        }

        private void حولالبرنامجToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show(" This Program is Written : \n\n By : Eng. Kinan Qassem \n Mobile : 0933372016");
            new FRM_About().ShowDialog();
            
            
           
        }

        private void TsmAddCustomer_Click(object sender, EventArgs e)
        {
            new FRM_AddNewCustomer(false).ShowDialog();
        }

        private void TsmCustomerManagment_Click(object sender, EventArgs e)
        {
            new FRM_CustomerManagment().ShowDialog();
        }

        private void TsmNewBuy_Click(object sender, EventArgs e)
        {
            new FRM_NEW_SELL().ShowDialog();
        }

        private void TsmBuyManagment_Click(object sender, EventArgs e)
        {
            new FRM_OrderManagment().ShowDialog();
        }

        private void TsmNewUser_Click(object sender, EventArgs e)
        {
            FRM_ADD_NewUser frm = new FRM_ADD_NewUser(false);
            frm.ShowDialog();
            
        }

        private void TsmUsersManagment_Click(object sender, EventArgs e)
        {
            new FRM_UserManagment().ShowDialog();
        }

        private void TsmLogout_Click(object sender, EventArgs e)
        {
            if (check)
            {
                Per_ID = 0;
                TsmBackup.Enabled = TsmRestore.Enabled = TsmProducts.Enabled =
                    TsmCustomers.Enabled = TsmSuppliers.Enabled = TSMAbout.Enabled =
                    TsmUsers.Enabled =check= false;
                new FRM_Login().ShowDialog();
                
                

            }


        }

        private void TsmBackup_Click(object sender, EventArgs e)
        {
            new FRM_Backup().ShowDialog();
        }

        private void TsmRestore_Click(object sender, EventArgs e)
        {
            new FRM_Restore().ShowDialog();
        }
    }
}
