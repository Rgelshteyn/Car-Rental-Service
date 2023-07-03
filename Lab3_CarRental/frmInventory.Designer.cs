
namespace Lab3_CarRental
{
    partial class frmInventory
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
            this.lvInventory = new System.Windows.Forms.ListView();
            this.chCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chmanu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chmileage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCPD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAvailibility = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbldirecttions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvInventory
            // 
            this.lvInventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCategory,
            this.chmanu,
            this.chModel,
            this.chYear,
            this.chmileage,
            this.chCPD,
            this.chAvailibility});
            this.lvInventory.HideSelection = false;
            this.lvInventory.Location = new System.Drawing.Point(25, 124);
            this.lvInventory.Name = "lvInventory";
            this.lvInventory.Size = new System.Drawing.Size(914, 345);
            this.lvInventory.TabIndex = 0;
            this.lvInventory.UseCompatibleStateImageBehavior = false;
            this.lvInventory.View = System.Windows.Forms.View.Details;
            this.lvInventory.SelectedIndexChanged += new System.EventHandler(this.lvInventory_SelectedIndexChanged);
            // 
            // chCategory
            // 
            this.chCategory.Text = "Category";
            this.chCategory.Width = 90;
            // 
            // chmanu
            // 
            this.chmanu.Text = "Manufacturer";
            this.chmanu.Width = 80;
            // 
            // chModel
            // 
            this.chModel.Text = "Model";
            this.chModel.Width = 86;
            // 
            // chYear
            // 
            this.chYear.Text = "Year";
            this.chYear.Width = 78;
            // 
            // chmileage
            // 
            this.chmileage.Text = "Mileage";
            this.chmileage.Width = 100;
            // 
            // chCPD
            // 
            this.chCPD.Text = "Rental Cost Per Day";
            this.chCPD.Width = 131;
            // 
            // chAvailibility
            // 
            this.chAvailibility.Text = "Availibility";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(25, 81);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(129, 79);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(231, 27);
            this.btnRent.TabIndex = 2;
            this.btnRent.Text = "View Car Details (select car under Category)";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(387, 81);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(516, 86);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(119, 13);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Search by Car Category";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(641, 83);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(212, 20);
            this.txtSearch.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(875, 83);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseCompatibleTextRendering = true;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbldirecttions
            // 
            this.lbldirecttions.AutoSize = true;
            this.lbldirecttions.Location = new System.Drawing.Point(516, 56);
            this.lbldirecttions.Name = "lbldirecttions";
            this.lbldirecttions.Size = new System.Drawing.Size(504, 13);
            this.lbldirecttions.TabIndex = 7;
            this.lbldirecttions.Text = "To view all catagories again search with empty txt box || Also to search sepfic c" +
    "ategory must be lowercase";
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 820);
            this.Controls.Add(this.lbldirecttions);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lvInventory);
            this.Name = "frmInventory";
            this.Text = "frmInventory";
            this.Load += new System.EventHandler(this.frmInventory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvInventory;
        private System.Windows.Forms.ColumnHeader chCategory;
        private System.Windows.Forms.ColumnHeader chmanu;
        private System.Windows.Forms.ColumnHeader chModel;
        private System.Windows.Forms.ColumnHeader chYear;
        private System.Windows.Forms.ColumnHeader chmileage;
        private System.Windows.Forms.ColumnHeader chCPD;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ColumnHeader chAvailibility;
        private System.Windows.Forms.Label lbldirecttions;
    }
}