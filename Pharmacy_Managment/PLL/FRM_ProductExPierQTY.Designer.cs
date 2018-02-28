namespace Pharmacy_Managment.PLL
{
    partial class FRM_ProductExPierQTY
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
            this.dgvProEXDate = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProEXDate)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProEXDate
            // 
            this.dgvProEXDate.AllowUserToAddRows = false;
            this.dgvProEXDate.AllowUserToDeleteRows = false;
            this.dgvProEXDate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProEXDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProEXDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProEXDate.Location = new System.Drawing.Point(0, 0);
            this.dgvProEXDate.MultiSelect = false;
            this.dgvProEXDate.Name = "dgvProEXDate";
            this.dgvProEXDate.ReadOnly = true;
            this.dgvProEXDate.RowHeadersVisible = false;
            this.dgvProEXDate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProEXDate.Size = new System.Drawing.Size(517, 253);
            this.dgvProEXDate.TabIndex = 0;
            // 
            // FRM_ProductExPierQTY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 253);
            this.Controls.Add(this.dgvProEXDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_ProductExPierQTY";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "عرض صلاحيات المنتج";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProEXDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvProEXDate;
    }
}