namespace Pharmacy_Managment.PLL
{
    partial class FRM_AddNewCustomer
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnaddUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCuName = new System.Windows.Forms.TextBox();
            this.txtCuAddress = new System.Windows.Forms.TextBox();
            this.txtCuMobile = new System.Windows.Forms.TextBox();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.picCUImage = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCUImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCity);
            this.groupBox1.Controls.Add(this.cmbCountry);
            this.groupBox1.Controls.Add(this.picCUImage);
            this.groupBox1.Controls.Add(this.txtCuMobile);
            this.groupBox1.Controls.Add(this.txtCuAddress);
            this.groupBox1.Controls.Add(this.txtCuName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 380);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات العميل";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(250, 404);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "خروج";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnaddUpdate
            // 
            this.btnaddUpdate.Location = new System.Drawing.Point(106, 404);
            this.btnaddUpdate.Name = "btnaddUpdate";
            this.btnaddUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnaddUpdate.TabIndex = 2;
            this.btnaddUpdate.UseVisualStyleBackColor = true;
            this.btnaddUpdate.Click += new System.EventHandler(this.btnaddUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم العميل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "العنوان";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "الموبايل";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "الصورة";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "اسم الدولة";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "اسم المدينة";
            // 
            // txtCuName
            // 
            this.txtCuName.Location = new System.Drawing.Point(6, 31);
            this.txtCuName.Name = "txtCuName";
            this.txtCuName.Size = new System.Drawing.Size(213, 20);
            this.txtCuName.TabIndex = 6;
            // 
            // txtCuAddress
            // 
            this.txtCuAddress.Location = new System.Drawing.Point(6, 57);
            this.txtCuAddress.Name = "txtCuAddress";
            this.txtCuAddress.Size = new System.Drawing.Size(213, 20);
            this.txtCuAddress.TabIndex = 7;
            // 
            // txtCuMobile
            // 
            this.txtCuMobile.Location = new System.Drawing.Point(6, 83);
            this.txtCuMobile.Name = "txtCuMobile";
            this.txtCuMobile.Size = new System.Drawing.Size(213, 20);
            this.txtCuMobile.TabIndex = 8;
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(6, 304);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(213, 21);
            this.cmbCountry.TabIndex = 10;
            this.cmbCountry.SelectionChangeCommitted += new System.EventHandler(this.cmbCountry_SelectionChangeCommitted);
            // 
            // cmbCity
            // 
            this.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(6, 337);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(213, 21);
            this.cmbCity.TabIndex = 11;
            // 
            // picCUImage
            // 
            this.picCUImage.Image = global::Pharmacy_Managment.Properties.Resources.x_man;
            this.picCUImage.Location = new System.Drawing.Point(6, 109);
            this.picCUImage.Name = "picCUImage";
            this.picCUImage.Size = new System.Drawing.Size(213, 189);
            this.picCUImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCUImage.TabIndex = 9;
            this.picCUImage.TabStop = false;
            this.picCUImage.Click += new System.EventHandler(this.picCUImage_Click);
            // 
            // FRM_AddNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 430);
            this.Controls.Add(this.btnaddUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_AddNewCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCUImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.PictureBox picCUImage;
        private System.Windows.Forms.TextBox txtCuMobile;
        private System.Windows.Forms.TextBox txtCuAddress;
        private System.Windows.Forms.TextBox txtCuName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnaddUpdate;
    }
}