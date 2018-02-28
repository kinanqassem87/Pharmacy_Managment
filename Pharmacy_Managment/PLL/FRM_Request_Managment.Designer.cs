namespace Pharmacy_Managment.PLL
{
    partial class FRM_Request_Managment
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
            this.dgvReqMang = new System.Windows.Forms.DataGridView();
            this.btndisplay = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReqMang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvReqMang);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "عرض كل فواتير الشراء";
            // 
            // dgvReqMang
            // 
            this.dgvReqMang.AllowUserToAddRows = false;
            this.dgvReqMang.AllowUserToDeleteRows = false;
            this.dgvReqMang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReqMang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReqMang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReqMang.Location = new System.Drawing.Point(3, 16);
            this.dgvReqMang.MultiSelect = false;
            this.dgvReqMang.Name = "dgvReqMang";
            this.dgvReqMang.ReadOnly = true;
            this.dgvReqMang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReqMang.Size = new System.Drawing.Size(642, 247);
            this.dgvReqMang.TabIndex = 0;
            // 
            // btndisplay
            // 
            this.btndisplay.Location = new System.Drawing.Point(15, 284);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(164, 23);
            this.btndisplay.TabIndex = 1;
            this.btndisplay.Text = "عرض كل الفواتير";
            this.btndisplay.UseVisualStyleBackColor = true;
            this.btndisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(185, 284);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(163, 23);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "طباعة الفاتورة المحددة";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(575, 284);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 3;
            this.btncancel.Text = "خروج";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // FRM_Request_Managment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 312);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btndisplay);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Request_Managment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ادارة المشتريات";
            this.Load += new System.EventHandler(this.FRM_Request_Managment_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReqMang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvReqMang;
        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btncancel;
    }
}