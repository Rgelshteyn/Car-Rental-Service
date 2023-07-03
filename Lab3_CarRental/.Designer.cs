
namespace Lab3_CarRental
{
    partial class frmCar
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
            this.lblCat = new System.Windows.Forms.Label();
            this.ddlCat = new System.Windows.Forms.ComboBox();
            this.lblManufactur = new System.Windows.Forms.Label();
            this.txtManufactur = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.nupYear = new System.Windows.Forms.NumericUpDown();
            this.lblMileage = new System.Windows.Forms.Label();
            this.nupMileage = new System.Windows.Forms.NumericUpDown();
            this.lblCostPerDay = new System.Windows.Forms.Label();
            this.nupCPD = new System.Windows.Forms.NumericUpDown();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radRented = new System.Windows.Forms.RadioButton();
            this.radAvailible = new System.Windows.Forms.RadioButton();
            this.lblPicture = new System.Windows.Forms.Label();
            this.btnStore = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbcar = new System.Windows.Forms.PictureBox();
            this.rtbImageURL = new System.Windows.Forms.RichTextBox();
            this.lblhelp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMileage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCPD)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(36, 37);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(62, 13);
            this.lblCat.TabIndex = 0;
            this.lblCat.Text = "Type of Car";
            // 
            // ddlCat
            // 
            this.ddlCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlCat.FormattingEnabled = true;
            this.ddlCat.Items.AddRange(new object[] {
            "economy",
            "luxury",
            "sport",
            "suv",
            "van",
            "pickup"});
            this.ddlCat.Location = new System.Drawing.Point(39, 73);
            this.ddlCat.Name = "ddlCat";
            this.ddlCat.Size = new System.Drawing.Size(121, 21);
            this.ddlCat.TabIndex = 1;
            // 
            // lblManufactur
            // 
            this.lblManufactur.AutoSize = true;
            this.lblManufactur.Location = new System.Drawing.Point(36, 122);
            this.lblManufactur.Name = "lblManufactur";
            this.lblManufactur.Size = new System.Drawing.Size(89, 13);
            this.lblManufactur.TabIndex = 2;
            this.lblManufactur.Text = "Car Manufacturer";
            // 
            // txtManufactur
            // 
            this.txtManufactur.Location = new System.Drawing.Point(39, 165);
            this.txtManufactur.Name = "txtManufactur";
            this.txtManufactur.Size = new System.Drawing.Size(100, 20);
            this.txtManufactur.TabIndex = 3;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(36, 221);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 4;
            this.lblModel.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(39, 253);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 5;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(39, 324);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 6;
            this.lblYear.Text = "Year";
            // 
            // nupYear
            // 
            this.nupYear.Location = new System.Drawing.Point(39, 357);
            this.nupYear.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.nupYear.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.nupYear.Name = "nupYear";
            this.nupYear.Size = new System.Drawing.Size(120, 20);
            this.nupYear.TabIndex = 7;
            this.nupYear.Value = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.nupYear.ValueChanged += new System.EventHandler(this.nupYear_ValueChanged);
            // 
            // lblMileage
            // 
            this.lblMileage.AutoSize = true;
            this.lblMileage.Location = new System.Drawing.Point(39, 419);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(44, 13);
            this.lblMileage.TabIndex = 8;
            this.lblMileage.Text = "Mileage";
            // 
            // nupMileage
            // 
            this.nupMileage.Location = new System.Drawing.Point(39, 454);
            this.nupMileage.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nupMileage.Name = "nupMileage";
            this.nupMileage.Size = new System.Drawing.Size(120, 20);
            this.nupMileage.TabIndex = 9;
            // 
            // lblCostPerDay
            // 
            this.lblCostPerDay.AutoSize = true;
            this.lblCostPerDay.Location = new System.Drawing.Point(39, 519);
            this.lblCostPerDay.Name = "lblCostPerDay";
            this.lblCostPerDay.Size = new System.Drawing.Size(103, 13);
            this.lblCostPerDay.TabIndex = 10;
            this.lblCostPerDay.Text = "Rental Cost Per Day";
            // 
            // nupCPD
            // 
            this.nupCPD.Location = new System.Drawing.Point(39, 554);
            this.nupCPD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupCPD.Name = "nupCPD";
            this.nupCPD.Size = new System.Drawing.Size(120, 20);
            this.nupCPD.TabIndex = 11;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(247, 37);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Description";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(250, 73);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(264, 51);
            this.rtbDescription.TabIndex = 13;
            this.rtbDescription.Text = "";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(247, 155);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 14;
            this.lblLocation.Text = "Location";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(250, 192);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 20);
            this.txtLocation.TabIndex = 15;
            // 
            // lblAvailability
            // 
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.Location = new System.Drawing.Point(245, 270);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(52, 13);
            this.lblAvailability.TabIndex = 16;
            this.lblAvailability.Text = "Availibility";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radRented);
            this.groupBox1.Controls.Add(this.radAvailible);
            this.groupBox1.Location = new System.Drawing.Point(250, 304);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 73);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // radRented
            // 
            this.radRented.AutoSize = true;
            this.radRented.Location = new System.Drawing.Point(30, 42);
            this.radRented.Name = "radRented";
            this.radRented.Size = new System.Drawing.Size(60, 17);
            this.radRented.TabIndex = 1;
            this.radRented.TabStop = true;
            this.radRented.Text = "Rented";
            this.radRented.UseVisualStyleBackColor = true;
            // 
            // radAvailible
            // 
            this.radAvailible.AutoSize = true;
            this.radAvailible.Location = new System.Drawing.Point(30, 19);
            this.radAvailible.Name = "radAvailible";
            this.radAvailible.Size = new System.Drawing.Size(68, 17);
            this.radAvailible.TabIndex = 0;
            this.radAvailible.TabStop = true;
            this.radAvailible.Text = "Available";
            this.radAvailible.UseVisualStyleBackColor = true;
            // 
            // lblPicture
            // 
            this.lblPicture.AutoSize = true;
            this.lblPicture.Location = new System.Drawing.Point(247, 401);
            this.lblPicture.Name = "lblPicture";
            this.lblPicture.Size = new System.Drawing.Size(65, 13);
            this.lblPicture.TabIndex = 19;
            this.lblPicture.Text = "Picture URL";
            // 
            // btnStore
            // 
            this.btnStore.Location = new System.Drawing.Point(341, 668);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(75, 23);
            this.btnStore.TabIndex = 20;
            this.btnStore.Text = "Store";
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(161, 668);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(151, 23);
            this.btnView.TabIndex = 21;
            this.btnView.Text = "View All Cars (See Inventory)";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(458, 668);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbcar
            // 
            this.pbcar.Location = new System.Drawing.Point(439, 346);
            this.pbcar.Name = "pbcar";
            this.pbcar.Size = new System.Drawing.Size(297, 237);
            this.pbcar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbcar.TabIndex = 24;
            this.pbcar.TabStop = false;
            this.pbcar.Click += new System.EventHandler(this.pbcar_Click);
            // 
            // rtbImageURL
            // 
            this.rtbImageURL.Location = new System.Drawing.Point(201, 429);
            this.rtbImageURL.Name = "rtbImageURL";
            this.rtbImageURL.Size = new System.Drawing.Size(204, 145);
            this.rtbImageURL.TabIndex = 25;
            this.rtbImageURL.Text = "";
            // 
            // lblhelp
            // 
            this.lblhelp.AutoSize = true;
            this.lblhelp.Location = new System.Drawing.Point(9, 640);
            this.lblhelp.Name = "lblhelp";
            this.lblhelp.Size = new System.Drawing.Size(286, 13);
            this.lblhelp.TabIndex = 26;
            this.lblhelp.Text = "To see rental changes reopen inventory when renting a car";
            // 
            // frmCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(815, 743);
            this.Controls.Add(this.lblhelp);
            this.Controls.Add(this.rtbImageURL);
            this.Controls.Add(this.pbcar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.lblPicture);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAvailability);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.nupCPD);
            this.Controls.Add(this.lblCostPerDay);
            this.Controls.Add(this.nupMileage);
            this.Controls.Add(this.lblMileage);
            this.Controls.Add(this.nupYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtManufactur);
            this.Controls.Add(this.lblManufactur);
            this.Controls.Add(this.ddlCat);
            this.Controls.Add(this.lblCat);
            this.Name = "frmCar";
            this.Text = "Add Car";
            this.Load += new System.EventHandler(this.frmCar_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.nupYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMileage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCPD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.ComboBox ddlCat;
        private System.Windows.Forms.Label lblManufactur;
        private System.Windows.Forms.TextBox txtManufactur;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.NumericUpDown nupYear;
        private System.Windows.Forms.Label lblMileage;
        private System.Windows.Forms.NumericUpDown nupMileage;
        private System.Windows.Forms.Label lblCostPerDay;
        private System.Windows.Forms.NumericUpDown nupCPD;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radRented;
        private System.Windows.Forms.RadioButton radAvailible;
        private System.Windows.Forms.Label lblPicture;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pbcar;
        private System.Windows.Forms.RichTextBox rtbImageURL;
        private System.Windows.Forms.Label lblhelp;
    }
}

