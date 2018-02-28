namespace Pharmacy_Managment.PLL
{
    partial class ActiveMaterialManagment
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
            this.btnDisplay = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvActiveMaterial = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAMDiscreption = new System.Windows.Forms.TextBox();
            this.txtAMName = new System.Windows.Forms.TextBox();
            this.txtAMID = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnselectall = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveMaterial)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(402, 7);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(184, 23);
            this.btnDisplay.TabIndex = 0;
            this.btnDisplay.Text = "عرض نتائج البحث";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvActiveMaterial);
            this.groupBox1.Location = new System.Drawing.Point(266, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 177);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المواد الفعالة";
            // 
            // dgvActiveMaterial
            // 
            this.dgvActiveMaterial.AllowUserToAddRows = false;
            this.dgvActiveMaterial.AllowUserToDeleteRows = false;
            this.dgvActiveMaterial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActiveMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActiveMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActiveMaterial.Location = new System.Drawing.Point(3, 16);
            this.dgvActiveMaterial.Name = "dgvActiveMaterial";
            this.dgvActiveMaterial.ReadOnly = true;
            this.dgvActiveMaterial.RowHeadersVisible = false;
            this.dgvActiveMaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActiveMaterial.Size = new System.Drawing.Size(490, 158);
            this.dgvActiveMaterial.TabIndex = 0;
            this.dgvActiveMaterial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActiveMaterial_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtAMDiscreption);
            this.groupBox2.Controls.Add(this.txtAMName);
            this.groupBox2.Controls.Add(this.txtAMID);
            this.groupBox2.Location = new System.Drawing.Point(12, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 174);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات المادة الفعالة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "الوصف";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "اسم المادة الفعالة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "معرف المادة الفعالة";
            // 
            // txtAMDiscreption
            // 
            this.txtAMDiscreption.Location = new System.Drawing.Point(6, 71);
            this.txtAMDiscreption.Multiline = true;
            this.txtAMDiscreption.Name = "txtAMDiscreption";
            this.txtAMDiscreption.Size = new System.Drawing.Size(122, 87);
            this.txtAMDiscreption.TabIndex = 5;
            // 
            // txtAMName
            // 
            this.txtAMName.Location = new System.Drawing.Point(6, 45);
            this.txtAMName.Name = "txtAMName";
            this.txtAMName.Size = new System.Drawing.Size(122, 20);
            this.txtAMName.TabIndex = 1;
            // 
            // txtAMID
            // 
            this.txtAMID.Location = new System.Drawing.Point(6, 19);
            this.txtAMID.Name = "txtAMID";
            this.txtAMID.ReadOnly = true;
            this.txtAMID.Size = new System.Drawing.Size(122, 20);
            this.txtAMID.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPrint);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.btnselectall);
            this.groupBox3.Location = new System.Drawing.Point(269, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(493, 61);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "العمليات على المادة الفعالة";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(6, 19);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(103, 23);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(239, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "حذف المادة الفعالة";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(121, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "تعديل المادة الفعالة";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnselectall
            // 
            this.btnselectall.Location = new System.Drawing.Point(366, 19);
            this.btnselectall.Name = "btnselectall";
            this.btnselectall.Size = new System.Drawing.Size(121, 23);
            this.btnselectall.TabIndex = 0;
            this.btnselectall.Text = "عرض كل المواد الفعالة";
            this.btnselectall.UseVisualStyleBackColor = true;
            this.btnselectall.Click += new System.EventHandler(this.btnselectall_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "الكلمة المراد البحث عنها";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(136, 7);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(235, 20);
            this.txtsearch.TabIndex = 4;
            // 
            // ActiveMaterialManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 295);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActiveMaterialManagment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ادارة المواد الفعالة";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveMaterial)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvActiveMaterial;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAMDiscreption;
        private System.Windows.Forms.TextBox txtAMName;
        private System.Windows.Forms.TextBox txtAMID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnselectall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsearch;
    }
}