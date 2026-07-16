namespace SearchFilterSortApp
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCity = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.cmbCustomerType = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSortName = new System.Windows.Forms.Button();
            this.btnSortCity = new System.Windows.Forms.Button();
            this.btnSortNewest = new System.Windows.Forms.Button();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.grpSearchFilterSort = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.grpSearchFilterSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(249, 12);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(559, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Search, Filter, and Sort Customer Records";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(55, 71);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(124, 22);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search Name:";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(186, 65);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(173, 28);
            this.txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(365, 63);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 30);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(133, 120);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(46, 22);
            this.lblCity.TabIndex = 1;
            this.lblCity.Text = "City:";
            // 
            // cmbCity
            // 
            this.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(197, 114);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(161, 30);
            this.cmbCity.TabIndex = 4;
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.AutoSize = true;
            this.lblCustomerType.Location = new System.Drawing.Point(55, 172);
            this.lblCustomerType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(138, 22);
            this.lblCustomerType.TabIndex = 1;
            this.lblCustomerType.Text = "Customer Type:";
            // 
            // cmbCustomerType
            // 
            this.cmbCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomerType.FormattingEnabled = true;
            this.cmbCustomerType.Location = new System.Drawing.Point(197, 164);
            this.cmbCustomerType.Name = "cmbCustomerType";
            this.cmbCustomerType.Size = new System.Drawing.Size(161, 30);
            this.cmbCustomerType.TabIndex = 4;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(7, 42);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(154, 31);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "Apply Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.Location = new System.Drawing.Point(167, 39);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(154, 34);
            this.btnClearFilters.TabIndex = 6;
            this.btnClearFilters.Text = "Clear Filters";
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(327, 42);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(94, 31);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSortName
            // 
            this.btnSortName.Location = new System.Drawing.Point(24, 97);
            this.btnSortName.Name = "btnSortName";
            this.btnSortName.Size = new System.Drawing.Size(137, 30);
            this.btnSortName.TabIndex = 8;
            this.btnSortName.Text = "Sort by Name";
            this.btnSortName.UseVisualStyleBackColor = true;
            this.btnSortName.Click += new System.EventHandler(this.btnSortName_Click);
            // 
            // btnSortCity
            // 
            this.btnSortCity.Location = new System.Drawing.Point(167, 97);
            this.btnSortCity.Name = "btnSortCity";
            this.btnSortCity.Size = new System.Drawing.Size(134, 29);
            this.btnSortCity.TabIndex = 9;
            this.btnSortCity.Text = "Sort by City";
            this.btnSortCity.UseVisualStyleBackColor = true;
            this.btnSortCity.Click += new System.EventHandler(this.btnSortCity_Click);
            // 
            // btnSortNewest
            // 
            this.btnSortNewest.Location = new System.Drawing.Point(307, 94);
            this.btnSortNewest.Name = "btnSortNewest";
            this.btnSortNewest.Size = new System.Drawing.Size(163, 33);
            this.btnSortNewest.TabIndex = 10;
            this.btnSortNewest.Text = "Sort Newest First";
            this.btnSortNewest.UseVisualStyleBackColor = true;
            this.btnSortNewest.Click += new System.EventHandler(this.btnSortNewest_Click);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(12, 281);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.Height = 24;
            this.dgvCustomers.Size = new System.Drawing.Size(920, 310);
            this.dgvCustomers.TabIndex = 11;
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Location = new System.Drawing.Point(35, 149);
            this.lblRecordCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(97, 22);
            this.lblRecordCount.TabIndex = 1;
            this.lblRecordCount.Text = "Records: 0";
            // 
            // grpSearchFilterSort
            // 
            this.grpSearchFilterSort.BackColor = System.Drawing.Color.MistyRose;
            this.grpSearchFilterSort.Controls.Add(this.btnClearFilters);
            this.grpSearchFilterSort.Controls.Add(this.lblRecordCount);
            this.grpSearchFilterSort.Controls.Add(this.btnSortNewest);
            this.grpSearchFilterSort.Controls.Add(this.btnFilter);
            this.grpSearchFilterSort.Controls.Add(this.btnSortCity);
            this.grpSearchFilterSort.Controls.Add(this.btnRefresh);
            this.grpSearchFilterSort.Controls.Add(this.btnSortName);
            this.grpSearchFilterSort.Location = new System.Drawing.Point(480, 63);
            this.grpSearchFilterSort.Name = "grpSearchFilterSort";
            this.grpSearchFilterSort.Size = new System.Drawing.Size(475, 204);
            this.grpSearchFilterSort.TabIndex = 12;
            this.grpSearchFilterSort.TabStop = false;
            this.grpSearchFilterSort.Text = "Customer Record Management";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.grpSearchFilterSort);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.cmbCustomerType);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblCustomerType);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Search, Filter, and Sort Records App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.grpSearchFilterSort.ResumeLayout(false);
            this.grpSearchFilterSort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label lblCustomerType;
        private System.Windows.Forms.ComboBox cmbCustomerType;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSortName;
        private System.Windows.Forms.Button btnSortCity;
        private System.Windows.Forms.Button btnSortNewest;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.GroupBox grpSearchFilterSort;
    }
}

