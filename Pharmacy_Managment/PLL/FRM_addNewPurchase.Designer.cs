namespace Pharmacy_Managment.PLL
{
    partial class FRM_addNewPurchase
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
            this.btnSupplier = new System.Windows.Forms.Button();
            this.txtSupID = new System.Windows.Forms.TextBox();
            this.txtSupName = new System.Windows.Forms.TextBox();
            this.txtSupMobile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateexpire = new System.Windows.Forms.DateTimePicker();
            this.txtProName = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtProID = new System.Windows.Forms.TextBox();
            this.btnproduct = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBuyerName = new System.Windows.Forms.TextBox();
            this.reqdate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnnewPruchase = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSupplier);
            this.groupBox1.Controls.Add(this.txtSupID);
            this.groupBox1.Controls.Add(this.txtSupName);
            this.groupBox1.Controls.Add(this.txtSupMobile);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(358, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(296, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات المورد";
            // 
            // btnSupplier
            // 
            this.btnSupplier.Enabled = false;
            this.btnSupplier.Location = new System.Drawing.Point(6, 32);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(58, 23);
            this.btnSupplier.TabIndex = 2;
            this.btnSupplier.Text = "----------------------";
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSupID
            // 
            this.txtSupID.Location = new System.Drawing.Point(70, 34);
            this.txtSupID.Name = "txtSupID";
            this.txtSupID.ReadOnly = true;
            this.txtSupID.Size = new System.Drawing.Size(140, 20);
            this.txtSupID.TabIndex = 4;
            // 
            // txtSupName
            // 
            this.txtSupName.Location = new System.Drawing.Point(6, 60);
            this.txtSupName.Name = "txtSupName";
            this.txtSupName.ReadOnly = true;
            this.txtSupName.Size = new System.Drawing.Size(204, 20);
            this.txtSupName.TabIndex = 5;
            // 
            // txtSupMobile
            // 
            this.txtSupMobile.Location = new System.Drawing.Point(6, 98);
            this.txtSupMobile.Name = "txtSupMobile";
            this.txtSupMobile.ReadOnly = true;
            this.txtSupMobile.Size = new System.Drawing.Size(204, 20);
            this.txtSupMobile.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "رقم المورد";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "اسم المورد";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "رقم الموبايل";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvProduct);
            this.groupBox2.Controls.Add(this.dateexpire);
            this.groupBox2.Controls.Add(this.txtProName);
            this.groupBox2.Controls.Add(this.txtQty);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.txtProID);
            this.groupBox2.Controls.Add(this.btnproduct);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(642, 195);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "المنتجات";
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.ColumnHeadersVisible = false;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvProduct.Location = new System.Drawing.Point(0, 52);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvProduct.Size = new System.Drawing.Size(636, 137);
            this.dgvProduct.TabIndex = 11;
            this.dgvProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 108;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 119;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 108;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 133;
            // 
            // dateexpire
            // 
            this.dateexpire.Location = new System.Drawing.Point(257, 32);
            this.dateexpire.Name = "dateexpire";
            this.dateexpire.ShowCheckBox = true;
            this.dateexpire.Size = new System.Drawing.Size(108, 20);
            this.dateexpire.TabIndex = 10;
            // 
            // txtProName
            // 
            this.txtProName.Location = new System.Drawing.Point(363, 32);
            this.txtProName.Name = "txtProName";
            this.txtProName.ReadOnly = true;
            this.txtProName.Size = new System.Drawing.Size(119, 20);
            this.txtProName.TabIndex = 9;
            this.txtProName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(8, 32);
            this.txtQty.MaxLength = 8;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(133, 20);
            this.txtQty.TabIndex = 8;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(140, 32);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(120, 20);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtProID
            // 
            this.txtProID.Location = new System.Drawing.Point(481, 32);
            this.txtProID.Name = "txtProID";
            this.txtProID.ReadOnly = true;
            this.txtProID.Size = new System.Drawing.Size(108, 20);
            this.txtProID.TabIndex = 6;
            this.txtProID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnproduct
            // 
            this.btnproduct.Enabled = false;
            this.btnproduct.Location = new System.Drawing.Point(591, 16);
            this.btnproduct.Name = "btnproduct";
            this.btnproduct.Size = new System.Drawing.Size(45, 36);
            this.btnproduct.TabIndex = 5;
            this.btnproduct.Text = "-----";
            this.btnproduct.UseVisualStyleBackColor = true;
            this.btnproduct.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(257, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 22);
            this.label10.TabIndex = 4;
            this.label10.Text = "تاريخ الصلاحية";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(363, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 22);
            this.label9.TabIndex = 3;
            this.label9.Text = "اسم المنتج";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(140, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "سعر المنتج";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "الكمية";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(481, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "رقم المنتج";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBuyerName);
            this.groupBox3.Controls.Add(this.reqdate);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(299, 80);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "بيانات الفاتورة";
            // 
            // txtBuyerName
            // 
            this.txtBuyerName.Location = new System.Drawing.Point(6, 56);
            this.txtBuyerName.Name = "txtBuyerName";
            this.txtBuyerName.ReadOnly = true;
            this.txtBuyerName.Size = new System.Drawing.Size(200, 20);
            this.txtBuyerName.TabIndex = 3;
            // 
            // reqdate
            // 
            this.reqdate.Location = new System.Drawing.Point(6, 30);
            this.reqdate.Name = "reqdate";
            this.reqdate.Size = new System.Drawing.Size(200, 20);
            this.reqdate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم المشتري";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "تاريخ الفاتورة";
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(14, 346);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "حذف الصف المحدد";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnnewPruchase
            // 
            this.btnnewPruchase.Location = new System.Drawing.Point(14, 375);
            this.btnnewPruchase.Name = "btnnewPruchase";
            this.btnnewPruchase.Size = new System.Drawing.Size(118, 23);
            this.btnnewPruchase.TabIndex = 3;
            this.btnnewPruchase.Text = "عملية شراء جديدة";
            this.btnnewPruchase.UseVisualStyleBackColor = true;
            this.btnnewPruchase.Click += new System.EventHandler(this.btnnewPruchase_Click);
            // 
            // btnsave
            // 
            this.btnsave.Enabled = false;
            this.btnsave.Location = new System.Drawing.Point(148, 375);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(116, 23);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "حفظ بيانات الفاتورة";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnprint
            // 
            this.btnprint.Enabled = false;
            this.btnprint.Location = new System.Drawing.Point(148, 346);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(116, 23);
            this.btnprint.TabIndex = 5;
            this.btnprint.Text = "طباعة الفاتورة";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(283, 361);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(72, 23);
            this.btncancel.TabIndex = 6;
            this.btncancel.Text = "خروج";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(395, 361);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 21);
            this.label11.TabIndex = 12;
            this.label11.Text = "الاجمالي :";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(478, 360);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(170, 20);
            this.txttotal.TabIndex = 12;
            // 
            // txtbarcode
            // 
            this.txtbarcode.Enabled = false;
            this.txtbarcode.Location = new System.Drawing.Point(18, 119);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(287, 20);
            this.txtbarcode.TabIndex = 13;
            this.txtbarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbarcode_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "مرر الباركود هنا .....";
            // 
            // FRM_addNewPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 408);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtbarcode);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnnewPruchase);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_addNewPurchase";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "فاتورة شراء جديدة";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.TextBox txtSupID;
        private System.Windows.Forms.TextBox txtSupName;
        private System.Windows.Forms.TextBox txtSupMobile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DateTimePicker dateexpire;
        private System.Windows.Forms.TextBox txtProName;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtProID;
        private System.Windows.Forms.Button btnproduct;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBuyerName;
        private System.Windows.Forms.DateTimePicker reqdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnnewPruchase;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtbarcode;
        private System.Windows.Forms.Label label12;
    }
}