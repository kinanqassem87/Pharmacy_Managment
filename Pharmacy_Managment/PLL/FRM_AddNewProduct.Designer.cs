namespace Pharmacy_Managment.PLL
{
    partial class FRM_AddNewProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbAMName = new System.Windows.Forms.ComboBox();
            this.cmbSnName = new System.Windows.Forms.ComboBox();
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.picProImage = new System.Windows.Forms.PictureBox();
            this.txtBuyPrice = new System.Windows.Forms.TextBox();
            this.txtSellPrice = new System.Windows.Forms.TextBox();
            this.txtPDescription = new System.Windows.Forms.TextBox();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.cmbcatogary = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChoose);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.cmbAMName);
            this.groupBox1.Controls.Add(this.cmbSnName);
            this.groupBox1.Controls.Add(this.txtbarcode);
            this.groupBox1.Controls.Add(this.picProImage);
            this.groupBox1.Controls.Add(this.txtBuyPrice);
            this.groupBox1.Controls.Add(this.txtSellPrice);
            this.groupBox1.Controls.Add(this.txtPDescription);
            this.groupBox1.Controls.Add(this.txtproductname);
            this.groupBox1.Controls.Add(this.cmbcatogary);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 483);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات المنتج";
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(10, 413);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(294, 23);
            this.btnChoose.TabIndex = 20;
            this.btnChoose.Text = "اختر صورة المنتج";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(10, 453);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(248, 453);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "إضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbAMName
            // 
            this.cmbAMName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAMName.FormattingEnabled = true;
            this.cmbAMName.Location = new System.Drawing.Point(10, 207);
            this.cmbAMName.Name = "cmbAMName";
            this.cmbAMName.Size = new System.Drawing.Size(294, 21);
            this.cmbAMName.TabIndex = 17;
            // 
            // cmbSnName
            // 
            this.cmbSnName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSnName.FormattingEnabled = true;
            this.cmbSnName.Location = new System.Drawing.Point(10, 235);
            this.cmbSnName.Name = "cmbSnName";
            this.cmbSnName.Size = new System.Drawing.Size(294, 21);
            this.cmbSnName.TabIndex = 16;
            // 
            // txtbarcode
            // 
            this.txtbarcode.Location = new System.Drawing.Point(10, 262);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(294, 20);
            this.txtbarcode.TabIndex = 15;
            // 
            // picProImage
            // 
            this.picProImage.Image = global::Pharmacy_Managment.Properties.Resources.drug;
            this.picProImage.Location = new System.Drawing.Point(10, 288);
            this.picProImage.Name = "picProImage";
            this.picProImage.Size = new System.Drawing.Size(294, 119);
            this.picProImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProImage.TabIndex = 14;
            this.picProImage.TabStop = false;
            // 
            // txtBuyPrice
            // 
            this.txtBuyPrice.Location = new System.Drawing.Point(10, 155);
            this.txtBuyPrice.Name = "txtBuyPrice";
            this.txtBuyPrice.Size = new System.Drawing.Size(294, 20);
            this.txtBuyPrice.TabIndex = 13;
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.Location = new System.Drawing.Point(10, 181);
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.Size = new System.Drawing.Size(294, 20);
            this.txtSellPrice.TabIndex = 12;
            // 
            // txtPDescription
            // 
            this.txtPDescription.Location = new System.Drawing.Point(10, 89);
            this.txtPDescription.Multiline = true;
            this.txtPDescription.Name = "txtPDescription";
            this.txtPDescription.Size = new System.Drawing.Size(294, 60);
            this.txtPDescription.TabIndex = 11;
            // 
            // txtproductname
            // 
            this.txtproductname.Location = new System.Drawing.Point(10, 61);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(294, 20);
            this.txtproductname.TabIndex = 10;
            // 
            // cmbcatogary
            // 
            this.cmbcatogary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcatogary.FormattingEnabled = true;
            this.cmbcatogary.Location = new System.Drawing.Point(10, 33);
            this.cmbcatogary.Name = "cmbcatogary";
            this.cmbcatogary.Size = new System.Drawing.Size(294, 21);
            this.cmbcatogary.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(343, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "صورة المنتج";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(332, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "الباركود";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "الاسم العلمي";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "المادة الفعالة";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "السعر للجمهور";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "سعر الشراء";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "وصف المنتج";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم المنتج";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم الصنف";
            // 
            // FRM_AddNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 483);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_AddNewProduct";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "إضافة منتج جديد";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbAMName;
        private System.Windows.Forms.ComboBox cmbSnName;
        private System.Windows.Forms.TextBox txtbarcode;
        private System.Windows.Forms.PictureBox picProImage;
        private System.Windows.Forms.TextBox txtBuyPrice;
        private System.Windows.Forms.TextBox txtSellPrice;
        private System.Windows.Forms.TextBox txtPDescription;
        private System.Windows.Forms.TextBox txtproductname;
        private System.Windows.Forms.ComboBox cmbcatogary;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}