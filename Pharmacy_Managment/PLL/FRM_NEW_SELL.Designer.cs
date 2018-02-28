namespace Pharmacy_Managment.PLL
{
    partial class FRM_NEW_SELL
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
            this.btnCUSTOMER = new System.Windows.Forms.Button();
            this.txtCuID = new System.Windows.Forms.TextBox();
            this.txtCUName = new System.Windows.Forms.TextBox();
            this.txtCUMobile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.reqdate = new System.Windows.Forms.DateTimePicker();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtsellerName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtProName = new System.Windows.Forms.TextBox();
            this.btnnewOrder = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProID = new System.Windows.Forms.TextBox();
            this.btnproduct = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCUSTOMER);
            this.groupBox1.Controls.Add(this.txtCuID);
            this.groupBox1.Controls.Add(this.txtCUName);
            this.groupBox1.Controls.Add(this.txtCUMobile);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(372, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(314, 133);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات العميل";
            // 
            // btnCUSTOMER
            // 
            this.btnCUSTOMER.Enabled = false;
            this.btnCUSTOMER.Location = new System.Drawing.Point(13, 32);
            this.btnCUSTOMER.Name = "btnCUSTOMER";
            this.btnCUSTOMER.Size = new System.Drawing.Size(58, 23);
            this.btnCUSTOMER.TabIndex = 2;
            this.btnCUSTOMER.Text = "----------------------";
            this.btnCUSTOMER.UseVisualStyleBackColor = true;
            this.btnCUSTOMER.Click += new System.EventHandler(this.btnCUSTOMER_Click);
            // 
            // txtCuID
            // 
            this.txtCuID.Location = new System.Drawing.Point(77, 34);
            this.txtCuID.Name = "txtCuID";
            this.txtCuID.ReadOnly = true;
            this.txtCuID.Size = new System.Drawing.Size(140, 20);
            this.txtCuID.TabIndex = 4;
            // 
            // txtCUName
            // 
            this.txtCUName.Location = new System.Drawing.Point(13, 60);
            this.txtCUName.Name = "txtCUName";
            this.txtCUName.ReadOnly = true;
            this.txtCUName.Size = new System.Drawing.Size(204, 20);
            this.txtCUName.TabIndex = 5;
            // 
            // txtCUMobile
            // 
            this.txtCUMobile.Location = new System.Drawing.Point(13, 98);
            this.txtCUMobile.Name = "txtCUMobile";
            this.txtCUMobile.ReadOnly = true;
            this.txtCUMobile.Size = new System.Drawing.Size(204, 20);
            this.txtCUMobile.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "رقم العميل";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "اسم العميل";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "رقم الموبايل";
            // 
            // reqdate
            // 
            this.reqdate.Location = new System.Drawing.Point(34, 30);
            this.reqdate.Name = "reqdate";
            this.reqdate.Size = new System.Drawing.Size(200, 20);
            this.reqdate.TabIndex = 2;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(6, 32);
            this.txtQty.MaxLength = 8;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(157, 20);
            this.txtQty.TabIndex = 8;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // txtsellerName
            // 
            this.txtsellerName.Location = new System.Drawing.Point(34, 56);
            this.txtsellerName.Name = "txtsellerName";
            this.txtsellerName.ReadOnly = true;
            this.txtsellerName.Size = new System.Drawing.Size(200, 20);
            this.txtsellerName.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(162, 32);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(157, 20);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtsellerName);
            this.groupBox3.Controls.Add(this.reqdate);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(325, 80);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "بيانات الفاتورة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم البائع";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "تاريخ الفاتورة";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(409, 357);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 21);
            this.label11.TabIndex = 22;
            this.label11.Text = "الاجمالي :";
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(297, 357);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(72, 23);
            this.btncancel.TabIndex = 20;
            this.btncancel.Text = "خروج";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnprint
            // 
            this.btnprint.Enabled = false;
            this.btnprint.Location = new System.Drawing.Point(162, 342);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(116, 23);
            this.btnprint.TabIndex = 19;
            this.btnprint.Text = "طباعة الفاتورة";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnsave
            // 
            this.btnsave.Enabled = false;
            this.btnsave.Location = new System.Drawing.Point(162, 371);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(116, 23);
            this.btnsave.TabIndex = 18;
            this.btnsave.Text = "حفظ بيانات الفاتورة";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtProName
            // 
            this.txtProName.Location = new System.Drawing.Point(319, 32);
            this.txtProName.Name = "txtProName";
            this.txtProName.ReadOnly = true;
            this.txtProName.Size = new System.Drawing.Size(157, 20);
            this.txtProName.TabIndex = 9;
            this.txtProName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnnewOrder
            // 
            this.btnnewOrder.Location = new System.Drawing.Point(28, 371);
            this.btnnewOrder.Name = "btnnewOrder";
            this.btnnewOrder.Size = new System.Drawing.Size(118, 23);
            this.btnnewOrder.TabIndex = 17;
            this.btnnewOrder.Text = "عملية بيع جديدة";
            this.btnnewOrder.UseVisualStyleBackColor = true;
            this.btnnewOrder.Click += new System.EventHandler(this.btnnewOrder_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(28, 342);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "حذف الصف المحدد";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvProduct);
            this.groupBox2.Controls.Add(this.txtProName);
            this.groupBox2.Controls.Add(this.txtQty);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.txtProID);
            this.groupBox2.Controls.Add(this.btnproduct);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(674, 195);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "المنتجات";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
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
            this.Column4});
            this.dgvProduct.Location = new System.Drawing.Point(6, 52);
            this.dgvProduct.MultiSelect = false;
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(662, 137);
            this.dgvProduct.TabIndex = 10;
            this.dgvProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 157;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 157;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 157;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 157;
            // 
            // txtProID
            // 
            this.txtProID.Location = new System.Drawing.Point(475, 32);
            this.txtProID.Name = "txtProID";
            this.txtProID.ReadOnly = true;
            this.txtProID.Size = new System.Drawing.Size(157, 20);
            this.txtProID.TabIndex = 6;
            this.txtProID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnproduct
            // 
            this.btnproduct.Enabled = false;
            this.btnproduct.Location = new System.Drawing.Point(630, 16);
            this.btnproduct.Name = "btnproduct";
            this.btnproduct.Size = new System.Drawing.Size(44, 36);
            this.btnproduct.TabIndex = 5;
            this.btnproduct.Text = "-----";
            this.btnproduct.UseVisualStyleBackColor = true;
            this.btnproduct.Click += new System.EventHandler(this.btnproduct_Click);
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(319, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "اسم المنتج";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(162, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "سعر المنتج";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "الكمية";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(475, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "رقم المنتج";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(492, 356);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(170, 20);
            this.txttotal.TabIndex = 21;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Enabled = false;
            this.txtBarcode.Location = new System.Drawing.Point(18, 115);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(285, 20);
            this.txtBarcode.TabIndex = 23;
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "مرر الباركود هنا ...... ";
            // 
            // FRM_NEW_SELL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 400);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnnewOrder);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txttotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_NEW_SELL";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "فاتورة بيع جديدة";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCUSTOMER;
        private System.Windows.Forms.TextBox txtCuID;
        private System.Windows.Forms.TextBox txtCUName;
        private System.Windows.Forms.TextBox txtCUMobile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker reqdate;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtsellerName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtProName;
        private System.Windows.Forms.Button btnnewOrder;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtProID;
        private System.Windows.Forms.Button btnproduct;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label10;
    }
}