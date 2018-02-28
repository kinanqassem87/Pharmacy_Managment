namespace Pharmacy_Managment.PLL
{
    partial class FRM_ProductManagment
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
            this.dgvproduct = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btndisplayExpire = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSavetoExcel = new System.Windows.Forms.Button();
            this.btnPrintSelectedProduct = new System.Windows.Forms.Button();
            this.btnPrintAllProduct = new System.Windows.Forms.Button();
            this.btndisplayimage = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduct)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvproduct);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1133, 343);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المنتوجات";
            // 
            // dgvproduct
            // 
            this.dgvproduct.AllowUserToAddRows = false;
            this.dgvproduct.AllowUserToDeleteRows = false;
            this.dgvproduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvproduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvproduct.Location = new System.Drawing.Point(3, 16);
            this.dgvproduct.MultiSelect = false;
            this.dgvproduct.Name = "dgvproduct";
            this.dgvproduct.ReadOnly = true;
            this.dgvproduct.RowHeadersVisible = false;
            this.dgvproduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvproduct.Size = new System.Drawing.Size(1127, 324);
            this.dgvproduct.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "رقم المنتج";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "الصنف";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "اسم المنتج";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "المادة الفعالة";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "الاسم العلمي";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "سعر الشراء";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "السعر للجمهور";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "الكمية في المخزن";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "الباركود";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "الوصف";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btndisplayExpire);
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnSavetoExcel);
            this.groupBox2.Controls.Add(this.btnPrintSelectedProduct);
            this.groupBox2.Controls.Add(this.btnPrintAllProduct);
            this.groupBox2.Controls.Add(this.btndisplayimage);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnAddNewProduct);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnSelectAll);
            this.groupBox2.Location = new System.Drawing.Point(15, 387);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1123, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات";
            // 
            // btndisplayExpire
            // 
            this.btndisplayExpire.Location = new System.Drawing.Point(668, 58);
            this.btndisplayExpire.Name = "btndisplayExpire";
            this.btndisplayExpire.Size = new System.Drawing.Size(143, 23);
            this.btndisplayExpire.TabIndex = 9;
            this.btndisplayExpire.Text = "عرض صلاحيات المنتج";
            this.btndisplayExpire.UseVisualStyleBackColor = true;
            this.btndisplayExpire.Click += new System.EventHandler(this.btndisplayExpire_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(212, 58);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnSavetoExcel
            // 
            this.btnSavetoExcel.Location = new System.Drawing.Point(311, 58);
            this.btnSavetoExcel.Name = "btnSavetoExcel";
            this.btnSavetoExcel.Size = new System.Drawing.Size(188, 23);
            this.btnSavetoExcel.TabIndex = 7;
            this.btnSavetoExcel.Text = "حفظ قائمة المنتجات في ملف اكسل";
            this.btnSavetoExcel.UseVisualStyleBackColor = true;
            this.btnSavetoExcel.Click += new System.EventHandler(this.btnSavetoExcel_Click);
            // 
            // btnPrintSelectedProduct
            // 
            this.btnPrintSelectedProduct.Location = new System.Drawing.Point(505, 58);
            this.btnPrintSelectedProduct.Name = "btnPrintSelectedProduct";
            this.btnPrintSelectedProduct.Size = new System.Drawing.Size(136, 23);
            this.btnPrintSelectedProduct.TabIndex = 6;
            this.btnPrintSelectedProduct.Text = "طباعة المنتج المحدد";
            this.btnPrintSelectedProduct.UseVisualStyleBackColor = true;
            this.btnPrintSelectedProduct.Click += new System.EventHandler(this.btnPrintSelectedProduct_Click);
            // 
            // btnPrintAllProduct
            // 
            this.btnPrintAllProduct.Location = new System.Drawing.Point(212, 19);
            this.btnPrintAllProduct.Name = "btnPrintAllProduct";
            this.btnPrintAllProduct.Size = new System.Drawing.Size(145, 23);
            this.btnPrintAllProduct.TabIndex = 5;
            this.btnPrintAllProduct.Text = "طباعة كل المنتجات";
            this.btnPrintAllProduct.UseVisualStyleBackColor = true;
            this.btnPrintAllProduct.Click += new System.EventHandler(this.btnPrintAllProduct_Click);
            // 
            // btndisplayimage
            // 
            this.btndisplayimage.Location = new System.Drawing.Point(363, 19);
            this.btndisplayimage.Name = "btndisplayimage";
            this.btndisplayimage.Size = new System.Drawing.Size(136, 23);
            this.btndisplayimage.TabIndex = 4;
            this.btndisplayimage.Text = "عرض صورة المنتج المحدد";
            this.btndisplayimage.UseVisualStyleBackColor = true;
            this.btndisplayimage.Click += new System.EventHandler(this.btndisplayimage_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(505, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "حذف المنتج المحدد";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.Location = new System.Drawing.Point(740, 19);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(93, 23);
            this.btnAddNewProduct.TabIndex = 2;
            this.btnAddNewProduct.Text = "اضافة منتج جديد";
            this.btnAddNewProduct.UseVisualStyleBackColor = true;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(625, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "تعديل المنتج المحدد";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(848, 19);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(99, 23);
            this.btnSelectAll.TabIndex = 0;
            this.btnSelectAll.Text = "عرض كل المنتجات";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(445, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(335, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "الكلمة المراد البحث عنها";
            // 
            // FRM_ProductManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 489);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_ProductManagment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ادارة المنتوجات";
            this.Activated += new System.EventHandler(this.FRM_ProductManagment_Activated);
            this.Load += new System.EventHandler(this.FRM_ProductManagment_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduct)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvproduct;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSavetoExcel;
        private System.Windows.Forms.Button btnPrintSelectedProduct;
        private System.Windows.Forms.Button btnPrintAllProduct;
        private System.Windows.Forms.Button btndisplayimage;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddNewProduct;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Button btndisplayExpire;
    }
}