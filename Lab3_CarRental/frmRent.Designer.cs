
namespace Lab3_CarRental
{
    partial class frmRent
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
            this.rtbCarDisplay = new System.Windows.Forms.RichTextBox();
            this.btnRentCar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblLicense = new System.Windows.Forms.Label();
            this.lblInsurance = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtLicence = new System.Windows.Forms.TextBox();
            this.txtInsurance = new System.Windows.Forms.TextBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.nupRentDays = new System.Windows.Forms.NumericUpDown();
            this.pbCar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupRentDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbCarDisplay
            // 
            this.rtbCarDisplay.Location = new System.Drawing.Point(25, 48);
            this.rtbCarDisplay.Name = "rtbCarDisplay";
            this.rtbCarDisplay.Size = new System.Drawing.Size(392, 588);
            this.rtbCarDisplay.TabIndex = 0;
            this.rtbCarDisplay.Text = "";
            this.rtbCarDisplay.TextChanged += new System.EventHandler(this.rtbCarDisplay_TextChanged);
            // 
            // btnRentCar
            // 
            this.btnRentCar.Location = new System.Drawing.Point(46, 700);
            this.btnRentCar.Name = "btnRentCar";
            this.btnRentCar.Size = new System.Drawing.Size(75, 23);
            this.btnRentCar.TabIndex = 1;
            this.btnRentCar.Text = "Rent";
            this.btnRentCar.UseVisualStyleBackColor = true;
            this.btnRentCar.Click += new System.EventHandler(this.btnRentCar_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(188, 700);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(517, 62);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(517, 114);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(48, 13);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone #";
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.Location = new System.Drawing.Point(517, 177);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(47, 13);
            this.lblLicense.TabIndex = 5;
            this.lblLicense.Text = "License ";
            // 
            // lblInsurance
            // 
            this.lblInsurance.AutoSize = true;
            this.lblInsurance.Location = new System.Drawing.Point(517, 241);
            this.lblInsurance.Name = "lblInsurance";
            this.lblInsurance.Size = new System.Drawing.Size(54, 13);
            this.lblInsurance.TabIndex = 6;
            this.lblInsurance.Text = "Insurance";
            this.lblInsurance.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(520, 304);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(520, 365);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(68, 13);
            this.lblDays.TabIndex = 8;
            this.lblDays.Text = "Rent in Days";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(651, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 9;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(651, 114);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 10;
            // 
            // txtLicence
            // 
            this.txtLicence.Location = new System.Drawing.Point(651, 169);
            this.txtLicence.Name = "txtLicence";
            this.txtLicence.Size = new System.Drawing.Size(100, 20);
            this.txtLicence.TabIndex = 11;
            // 
            // txtInsurance
            // 
            this.txtInsurance.Location = new System.Drawing.Point(651, 241);
            this.txtInsurance.Name = "txtInsurance";
            this.txtInsurance.Size = new System.Drawing.Size(100, 20);
            this.txtInsurance.TabIndex = 12;
            // 
            // dtpTime
            // 
            this.dtpTime.Location = new System.Drawing.Point(651, 304);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(200, 20);
            this.dtpTime.TabIndex = 13;
            // 
            // nupRentDays
            // 
            this.nupRentDays.Location = new System.Drawing.Point(651, 358);
            this.nupRentDays.Name = "nupRentDays";
            this.nupRentDays.Size = new System.Drawing.Size(120, 20);
            this.nupRentDays.TabIndex = 14;
            // 
            // pbCar
            // 
            this.pbCar.Location = new System.Drawing.Point(502, 480);
            this.pbCar.Name = "pbCar";
            this.pbCar.Size = new System.Drawing.Size(416, 279);
            this.pbCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCar.TabIndex = 15;
            this.pbCar.TabStop = false;
            // 
            // frmRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 784);
            this.Controls.Add(this.pbCar);
            this.Controls.Add(this.nupRentDays);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.txtInsurance);
            this.Controls.Add(this.txtLicence);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblInsurance);
            this.Controls.Add(this.lblLicense);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRentCar);
            this.Controls.Add(this.rtbCarDisplay);
            this.Name = "frmRent";
            this.Text = "frmRent";
            this.Load += new System.EventHandler(this.frmRent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupRentDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbCarDisplay;
        private System.Windows.Forms.Button btnRentCar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.Label lblInsurance;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtLicence;
        private System.Windows.Forms.TextBox txtInsurance;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.NumericUpDown nupRentDays;
        private System.Windows.Forms.PictureBox pbCar;
    }
}