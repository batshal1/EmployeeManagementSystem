namespace GroupProjectMercury.Forms
{
    partial class ViewEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEmployee));
            this.pDropDown = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnDepot = new System.Windows.Forms.Button();
            this.BtnProfile = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new FlatButton.JFlatButton();
            this.btnManageEmployee = new FlatButton.JFlatButton();
            this.btnAddEmployee = new FlatButton.JFlatButton();
            this.btnViewStatistics = new FlatButton.JFlatButton();
            this.btnRefresh = new FlatButton.JFlatButton();
            this.cbId = new System.Windows.Forms.CheckBox();
            this.cbFirstname = new System.Windows.Forms.CheckBox();
            this.cbBSN = new System.Windows.Forms.CheckBox();
            this.cbSalary = new System.Windows.Forms.CheckBox();
            this.cbStartdate = new System.Windows.Forms.CheckBox();
            this.cbEmail = new System.Windows.Forms.CheckBox();
            this.cbStreet = new System.Windows.Forms.CheckBox();
            this.cbGender = new System.Windows.Forms.CheckBox();
            this.cbBirthdate = new System.Windows.Forms.CheckBox();
            this.cbPosition = new System.Windows.Forms.CheckBox();
            this.cbPhonenr = new System.Windows.Forms.CheckBox();
            this.cbCity = new System.Windows.Forms.CheckBox();
            this.cbZipcode = new System.Windows.Forms.CheckBox();
            this.cbLastname = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbDepartment = new System.Windows.Forms.CheckBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnViewArchivedEmp = new FlatButton.JFlatButton();
            this.pDropDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pDropDown
            // 
            this.pDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.pDropDown.Controls.Add(this.btnLogOut);
            this.pDropDown.Controls.Add(this.btnDepot);
            this.pDropDown.Controls.Add(this.BtnProfile);
            this.pDropDown.Controls.Add(this.btnEmployee);
            this.pDropDown.Controls.Add(this.btnDashboard);
            this.pDropDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pDropDown.Dock = System.Windows.Forms.DockStyle.Left;
            this.pDropDown.Location = new System.Drawing.Point(0, 0);
            this.pDropDown.MaximumSize = new System.Drawing.Size(255, 825);
            this.pDropDown.MinimumSize = new System.Drawing.Size(220, 761);
            this.pDropDown.Name = "pDropDown";
            this.pDropDown.Size = new System.Drawing.Size(220, 825);
            this.pDropDown.TabIndex = 2;
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(-13, 756);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(216, 40);
            this.btnLogOut.TabIndex = 35;
            this.btnLogOut.Text = "X Log out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnDepot
            // 
            this.btnDepot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepot.FlatAppearance.BorderSize = 0;
            this.btnDepot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepot.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepot.ForeColor = System.Drawing.Color.White;
            this.btnDepot.Image = ((System.Drawing.Image)(resources.GetObject("btnDepot.Image")));
            this.btnDepot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepot.Location = new System.Drawing.Point(0, 464);
            this.btnDepot.Name = "btnDepot";
            this.btnDepot.Size = new System.Drawing.Size(252, 67);
            this.btnDepot.TabIndex = 4;
            this.btnDepot.Text = "Depot";
            this.btnDepot.UseVisualStyleBackColor = true;
            this.btnDepot.Click += new System.EventHandler(this.btnDepot_Click);
            // 
            // BtnProfile
            // 
            this.BtnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProfile.FlatAppearance.BorderSize = 0;
            this.BtnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProfile.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProfile.ForeColor = System.Drawing.Color.White;
            this.BtnProfile.Image = ((System.Drawing.Image)(resources.GetObject("BtnProfile.Image")));
            this.BtnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProfile.Location = new System.Drawing.Point(3, 318);
            this.BtnProfile.Name = "BtnProfile";
            this.BtnProfile.Size = new System.Drawing.Size(249, 67);
            this.BtnProfile.TabIndex = 2;
            this.BtnProfile.Text = "Profile";
            this.BtnProfile.UseVisualStyleBackColor = true;
            this.BtnProfile.Click += new System.EventHandler(this.BtnProfile_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(3, 391);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(249, 67);
            this.btnEmployee.TabIndex = 3;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(3, 245);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(249, 67);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Schedule";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(483, 256);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.RowTemplate.Height = 24;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(789, 452);
            this.dgvEmployees.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(232)))));
            this.groupBox1.Controls.Add(this.tbxSearch);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(258, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 101);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search by:";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(15, 43);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(312, 28);
            this.tbxSearch.TabIndex = 30;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.ButtonText = "Search";
            this.btnSearch.CausesValidation = false;
            this.btnSearch.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnSearch.ErrorImageLeft")));
            this.btnSearch.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnSearch.ErrorImageRight")));
            this.btnSearch.FocusBackground = System.Drawing.Color.Gray;
            this.btnSearch.FocusFontColor = System.Drawing.Color.White;
            this.btnSearch.ForeColors = System.Drawing.Color.White;
            this.btnSearch.HoverBackground = System.Drawing.Color.Silver;
            this.btnSearch.HoverFontColor = System.Drawing.Color.White;
            this.btnSearch.ImageLeft = ((System.Drawing.Image)(resources.GetObject("btnSearch.ImageLeft")));
            this.btnSearch.ImageRight = null;
            this.btnSearch.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnSearch.Location = new System.Drawing.Point(355, 29);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnSearch.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnSearch.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnSearch.Size = new System.Drawing.Size(222, 53);
            this.btnSearch.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnSearch.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnManageEmployee
            // 
            this.btnManageEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnManageEmployee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnManageEmployee.ButtonText = "Manage Employee";
            this.btnManageEmployee.CausesValidation = false;
            this.btnManageEmployee.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnManageEmployee.ErrorImageLeft")));
            this.btnManageEmployee.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnManageEmployee.ErrorImageRight")));
            this.btnManageEmployee.FocusBackground = System.Drawing.Color.Gray;
            this.btnManageEmployee.FocusFontColor = System.Drawing.Color.White;
            this.btnManageEmployee.ForeColors = System.Drawing.Color.White;
            this.btnManageEmployee.HoverBackground = System.Drawing.Color.Silver;
            this.btnManageEmployee.HoverFontColor = System.Drawing.Color.White;
            this.btnManageEmployee.ImageLeft = ((System.Drawing.Image)(resources.GetObject("btnManageEmployee.ImageLeft")));
            this.btnManageEmployee.ImageRight = null;
            this.btnManageEmployee.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnManageEmployee.Location = new System.Drawing.Point(927, 743);
            this.btnManageEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnManageEmployee.Name = "btnManageEmployee";
            this.btnManageEmployee.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnManageEmployee.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnManageEmployee.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnManageEmployee.Size = new System.Drawing.Size(344, 53);
            this.btnManageEmployee.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnManageEmployee.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnManageEmployee.TabIndex = 29;
            this.btnManageEmployee.Click += new System.EventHandler(this.btnManageEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddEmployee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddEmployee.ButtonText = "Add New Employee";
            this.btnAddEmployee.CausesValidation = false;
            this.btnAddEmployee.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnAddEmployee.ErrorImageLeft")));
            this.btnAddEmployee.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnAddEmployee.ErrorImageRight")));
            this.btnAddEmployee.FocusBackground = System.Drawing.Color.Gray;
            this.btnAddEmployee.FocusFontColor = System.Drawing.Color.White;
            this.btnAddEmployee.ForeColors = System.Drawing.Color.White;
            this.btnAddEmployee.HoverBackground = System.Drawing.Color.Silver;
            this.btnAddEmployee.HoverFontColor = System.Drawing.Color.White;
            this.btnAddEmployee.ImageLeft = ((System.Drawing.Image)(resources.GetObject("btnAddEmployee.ImageLeft")));
            this.btnAddEmployee.ImageRight = null;
            this.btnAddEmployee.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnAddEmployee.Location = new System.Drawing.Point(491, 743);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnAddEmployee.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnAddEmployee.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnAddEmployee.Size = new System.Drawing.Size(344, 53);
            this.btnAddEmployee.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnAddEmployee.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnAddEmployee.TabIndex = 30;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnViewStatistics
            // 
            this.btnViewStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewStatistics.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewStatistics.ButtonText = "View Statistics";
            this.btnViewStatistics.CausesValidation = false;
            this.btnViewStatistics.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnViewStatistics.ErrorImageLeft")));
            this.btnViewStatistics.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnViewStatistics.ErrorImageRight")));
            this.btnViewStatistics.FocusBackground = System.Drawing.Color.Gray;
            this.btnViewStatistics.FocusFontColor = System.Drawing.Color.White;
            this.btnViewStatistics.ForeColors = System.Drawing.Color.White;
            this.btnViewStatistics.HoverBackground = System.Drawing.Color.Silver;
            this.btnViewStatistics.HoverFontColor = System.Drawing.Color.White;
            this.btnViewStatistics.ImageLeft = null;
            this.btnViewStatistics.ImageRight = null;
            this.btnViewStatistics.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnViewStatistics.Location = new System.Drawing.Point(927, 120);
            this.btnViewStatistics.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewStatistics.Name = "btnViewStatistics";
            this.btnViewStatistics.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnViewStatistics.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnViewStatistics.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnViewStatistics.Size = new System.Drawing.Size(347, 53);
            this.btnViewStatistics.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnViewStatistics.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnViewStatistics.TabIndex = 31;
            this.btnViewStatistics.Click += new System.EventHandler(this.btnViewStatistics_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRefresh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRefresh.ButtonText = "Refresh";
            this.btnRefresh.CausesValidation = false;
            this.btnRefresh.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ErrorImageLeft")));
            this.btnRefresh.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ErrorImageRight")));
            this.btnRefresh.FocusBackground = System.Drawing.Color.Gray;
            this.btnRefresh.FocusFontColor = System.Drawing.Color.White;
            this.btnRefresh.ForeColors = System.Drawing.Color.White;
            this.btnRefresh.HoverBackground = System.Drawing.Color.Silver;
            this.btnRefresh.HoverFontColor = System.Drawing.Color.White;
            this.btnRefresh.ImageLeft = null;
            this.btnRefresh.ImageRight = null;
            this.btnRefresh.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Location = new System.Drawing.Point(15, 449);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnRefresh.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnRefresh.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Size = new System.Drawing.Size(179, 58);
            this.btnRefresh.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnRefresh.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnRefresh.TabIndex = 34;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cbId
            // 
            this.cbId.AutoSize = true;
            this.cbId.Location = new System.Drawing.Point(24, 32);
            this.cbId.Name = "cbId";
            this.cbId.Size = new System.Drawing.Size(51, 26);
            this.cbId.TabIndex = 35;
            this.cbId.Text = "Id";
            this.cbId.UseVisualStyleBackColor = true;
            this.cbId.CheckedChanged += new System.EventHandler(this.cbId_CheckedChanged);
            // 
            // cbFirstname
            // 
            this.cbFirstname.AutoSize = true;
            this.cbFirstname.Location = new System.Drawing.Point(24, 59);
            this.cbFirstname.Name = "cbFirstname";
            this.cbFirstname.Size = new System.Drawing.Size(118, 26);
            this.cbFirstname.TabIndex = 36;
            this.cbFirstname.Text = "Firstname";
            this.cbFirstname.UseVisualStyleBackColor = true;
            this.cbFirstname.CheckedChanged += new System.EventHandler(this.cbFirstname_CheckedChanged);
            // 
            // cbBSN
            // 
            this.cbBSN.AutoSize = true;
            this.cbBSN.Location = new System.Drawing.Point(24, 381);
            this.cbBSN.Name = "cbBSN";
            this.cbBSN.Size = new System.Drawing.Size(69, 26);
            this.cbBSN.TabIndex = 37;
            this.cbBSN.Text = "BSN";
            this.cbBSN.UseVisualStyleBackColor = true;
            this.cbBSN.CheckedChanged += new System.EventHandler(this.cbBSN_CheckedChanged);
            // 
            // cbSalary
            // 
            this.cbSalary.AutoSize = true;
            this.cbSalary.Location = new System.Drawing.Point(24, 354);
            this.cbSalary.Name = "cbSalary";
            this.cbSalary.Size = new System.Drawing.Size(86, 26);
            this.cbSalary.TabIndex = 38;
            this.cbSalary.Text = "Salary";
            this.cbSalary.UseVisualStyleBackColor = true;
            this.cbSalary.CheckedChanged += new System.EventHandler(this.cbSalary_CheckedChanged);
            // 
            // cbStartdate
            // 
            this.cbStartdate.AutoSize = true;
            this.cbStartdate.Location = new System.Drawing.Point(24, 300);
            this.cbStartdate.Name = "cbStartdate";
            this.cbStartdate.Size = new System.Drawing.Size(113, 26);
            this.cbStartdate.TabIndex = 39;
            this.cbStartdate.Text = "Startdate";
            this.cbStartdate.UseVisualStyleBackColor = true;
            this.cbStartdate.CheckedChanged += new System.EventHandler(this.cbStartdate_CheckedChanged);
            // 
            // cbEmail
            // 
            this.cbEmail.AutoSize = true;
            this.cbEmail.Location = new System.Drawing.Point(24, 273);
            this.cbEmail.Name = "cbEmail";
            this.cbEmail.Size = new System.Drawing.Size(80, 26);
            this.cbEmail.TabIndex = 40;
            this.cbEmail.Text = "Email";
            this.cbEmail.UseVisualStyleBackColor = true;
            this.cbEmail.CheckedChanged += new System.EventHandler(this.cbEmail_CheckedChanged);
            // 
            // cbStreet
            // 
            this.cbStreet.AutoSize = true;
            this.cbStreet.Location = new System.Drawing.Point(24, 167);
            this.cbStreet.Name = "cbStreet";
            this.cbStreet.Size = new System.Drawing.Size(85, 26);
            this.cbStreet.TabIndex = 41;
            this.cbStreet.Text = "Street";
            this.cbStreet.UseVisualStyleBackColor = true;
            this.cbStreet.CheckedChanged += new System.EventHandler(this.cbStreet_CheckedChanged);
            // 
            // cbGender
            // 
            this.cbGender.AutoSize = true;
            this.cbGender.Location = new System.Drawing.Point(24, 140);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(94, 26);
            this.cbGender.TabIndex = 42;
            this.cbGender.Text = "Gender";
            this.cbGender.UseVisualStyleBackColor = true;
            this.cbGender.CheckedChanged += new System.EventHandler(this.cbGender_CheckedChanged);
            // 
            // cbBirthdate
            // 
            this.cbBirthdate.AutoSize = true;
            this.cbBirthdate.Location = new System.Drawing.Point(24, 113);
            this.cbBirthdate.Name = "cbBirthdate";
            this.cbBirthdate.Size = new System.Drawing.Size(112, 26);
            this.cbBirthdate.TabIndex = 43;
            this.cbBirthdate.Text = "Birthdate";
            this.cbBirthdate.UseVisualStyleBackColor = true;
            this.cbBirthdate.CheckedChanged += new System.EventHandler(this.cbBirthdate_CheckedChanged);
            // 
            // cbPosition
            // 
            this.cbPosition.AutoSize = true;
            this.cbPosition.Location = new System.Drawing.Point(24, 327);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(99, 26);
            this.cbPosition.TabIndex = 44;
            this.cbPosition.Text = "Position";
            this.cbPosition.UseVisualStyleBackColor = true;
            this.cbPosition.CheckedChanged += new System.EventHandler(this.cbPosition_CheckedChanged);
            // 
            // cbPhonenr
            // 
            this.cbPhonenr.AutoSize = true;
            this.cbPhonenr.Location = new System.Drawing.Point(24, 248);
            this.cbPhonenr.Name = "cbPhonenr";
            this.cbPhonenr.Size = new System.Drawing.Size(157, 26);
            this.cbPhonenr.TabIndex = 45;
            this.cbPhonenr.Text = "Phone number";
            this.cbPhonenr.UseVisualStyleBackColor = true;
            this.cbPhonenr.CheckedChanged += new System.EventHandler(this.cbPhonenr_CheckedChanged);
            // 
            // cbCity
            // 
            this.cbCity.AutoSize = true;
            this.cbCity.Location = new System.Drawing.Point(24, 221);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(66, 26);
            this.cbCity.TabIndex = 46;
            this.cbCity.Text = "City";
            this.cbCity.UseVisualStyleBackColor = true;
            this.cbCity.CheckedChanged += new System.EventHandler(this.cbCity_CheckedChanged);
            // 
            // cbZipcode
            // 
            this.cbZipcode.AutoSize = true;
            this.cbZipcode.Location = new System.Drawing.Point(24, 194);
            this.cbZipcode.Name = "cbZipcode";
            this.cbZipcode.Size = new System.Drawing.Size(100, 26);
            this.cbZipcode.TabIndex = 47;
            this.cbZipcode.Text = "Zipcode";
            this.cbZipcode.UseVisualStyleBackColor = true;
            this.cbZipcode.CheckedChanged += new System.EventHandler(this.cbZipcode_CheckedChanged);
            // 
            // cbLastname
            // 
            this.cbLastname.AutoSize = true;
            this.cbLastname.Location = new System.Drawing.Point(24, 86);
            this.cbLastname.Name = "cbLastname";
            this.cbLastname.Size = new System.Drawing.Size(115, 26);
            this.cbLastname.TabIndex = 48;
            this.cbLastname.Text = "Lastname";
            this.cbLastname.UseVisualStyleBackColor = true;
            this.cbLastname.CheckedChanged += new System.EventHandler(this.cbLastname_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(232)))));
            this.groupBox2.Controls.Add(this.cbDepartment);
            this.groupBox2.Controls.Add(this.cbLastname);
            this.groupBox2.Controls.Add(this.cbId);
            this.groupBox2.Controls.Add(this.cbZipcode);
            this.groupBox2.Controls.Add(this.cbFirstname);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.cbCity);
            this.groupBox2.Controls.Add(this.cbBSN);
            this.groupBox2.Controls.Add(this.cbPhonenr);
            this.groupBox2.Controls.Add(this.cbSalary);
            this.groupBox2.Controls.Add(this.cbPosition);
            this.groupBox2.Controls.Add(this.cbStartdate);
            this.groupBox2.Controls.Add(this.cbBirthdate);
            this.groupBox2.Controls.Add(this.cbEmail);
            this.groupBox2.Controls.Add(this.cbGender);
            this.groupBox2.Controls.Add(this.cbStreet);
            this.groupBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(258, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 516);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter info";
            // 
            // cbDepartment
            // 
            this.cbDepartment.AutoSize = true;
            this.cbDepartment.Location = new System.Drawing.Point(24, 408);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(135, 26);
            this.cbDepartment.TabIndex = 49;
            this.cbDepartment.Text = "Department";
            this.cbDepartment.UseVisualStyleBackColor = true;
            this.cbDepartment.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.btnMinimize.Location = new System.Drawing.Point(1191, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(46, 40);
            this.btnMinimize.TabIndex = 51;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.btnClose.Location = new System.Drawing.Point(1228, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 40);
            this.btnClose.TabIndex = 50;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(475, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 46);
            this.label3.TabIndex = 52;
            this.label3.Text = "Employees";
            // 
            // btnViewArchivedEmp
            // 
            this.btnViewArchivedEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewArchivedEmp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewArchivedEmp.ButtonText = "View Archived Employees";
            this.btnViewArchivedEmp.CausesValidation = false;
            this.btnViewArchivedEmp.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnViewArchivedEmp.ErrorImageLeft")));
            this.btnViewArchivedEmp.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnViewArchivedEmp.ErrorImageRight")));
            this.btnViewArchivedEmp.FocusBackground = System.Drawing.Color.Gray;
            this.btnViewArchivedEmp.FocusFontColor = System.Drawing.Color.White;
            this.btnViewArchivedEmp.ForeColors = System.Drawing.Color.White;
            this.btnViewArchivedEmp.HoverBackground = System.Drawing.Color.Silver;
            this.btnViewArchivedEmp.HoverFontColor = System.Drawing.Color.White;
            this.btnViewArchivedEmp.ImageLeft = null;
            this.btnViewArchivedEmp.ImageRight = null;
            this.btnViewArchivedEmp.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnViewArchivedEmp.Location = new System.Drawing.Point(927, 181);
            this.btnViewArchivedEmp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewArchivedEmp.Name = "btnViewArchivedEmp";
            this.btnViewArchivedEmp.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnViewArchivedEmp.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnViewArchivedEmp.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnViewArchivedEmp.Size = new System.Drawing.Size(347, 53);
            this.btnViewArchivedEmp.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnViewArchivedEmp.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnViewArchivedEmp.TabIndex = 53;
            this.btnViewArchivedEmp.Click += new System.EventHandler(this.btnViewArchivedEmp_Click);
            // 
            // ViewEmployee
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1284, 825);
            this.Controls.Add(this.btnViewArchivedEmp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pDropDown);
            this.Controls.Add(this.btnViewStatistics);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnManageEmployee);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvEmployees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewEmployee";
            this.pDropDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pDropDown;
        private System.Windows.Forms.Button btnDepot;
        private System.Windows.Forms.Button BtnProfile;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.GroupBox groupBox1;
        private FlatButton.JFlatButton btnSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private FlatButton.JFlatButton btnManageEmployee;
        private FlatButton.JFlatButton btnAddEmployee;
        private FlatButton.JFlatButton btnViewStatistics;
        private FlatButton.JFlatButton btnRefresh;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.CheckBox cbId;
        private System.Windows.Forms.CheckBox cbFirstname;
        private System.Windows.Forms.CheckBox cbBSN;
        private System.Windows.Forms.CheckBox cbSalary;
        private System.Windows.Forms.CheckBox cbStartdate;
        private System.Windows.Forms.CheckBox cbEmail;
        private System.Windows.Forms.CheckBox cbStreet;
        private System.Windows.Forms.CheckBox cbGender;
        private System.Windows.Forms.CheckBox cbBirthdate;
        private System.Windows.Forms.CheckBox cbPosition;
        private System.Windows.Forms.CheckBox cbPhonenr;
        private System.Windows.Forms.CheckBox cbCity;
        private System.Windows.Forms.CheckBox cbZipcode;
        private System.Windows.Forms.CheckBox cbLastname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private FlatButton.JFlatButton btnViewArchivedEmp;
        private System.Windows.Forms.CheckBox cbDepartment;
    }
}