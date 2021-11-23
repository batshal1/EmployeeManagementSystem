namespace GroupProjectMercury
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.pDropDown = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnDepot = new System.Windows.Forms.Button();
            this.BtnProfile = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblWelcomeName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.flDays = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMonthAndYear = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNextMonth = new FlatButton.JFlatButton();
            this.btnToday = new FlatButton.JFlatButton();
            this.btnPrevMonth = new FlatButton.JFlatButton();
            this.btnAnnouncements = new FlatButton.JFlatButton();
            this.generateSchedulebtn = new FlatButton.JFlatButton();
            this.shiftsbttn = new FlatButton.JFlatButton();
            this.preferencesbttn = new FlatButton.JFlatButton();
            this.pDropDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.pDropDown.Dock = System.Windows.Forms.DockStyle.Left;
            this.pDropDown.Location = new System.Drawing.Point(0, 0);
            this.pDropDown.MaximumSize = new System.Drawing.Size(255, 825);
            this.pDropDown.MinimumSize = new System.Drawing.Size(220, 761);
            this.pDropDown.Name = "pDropDown";
            this.pDropDown.Size = new System.Drawing.Size(220, 825);
            this.pDropDown.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(0, 753);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(187, 50);
            this.btnLogOut.TabIndex = 34;
            this.btnLogOut.Text = "X Logout";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnDepot
            // 
            this.btnDepot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepot.FlatAppearance.BorderSize = 0;
            this.btnDepot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepot.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F);
            this.btnDepot.ForeColor = System.Drawing.Color.White;
            this.btnDepot.Image = ((System.Drawing.Image)(resources.GetObject("btnDepot.Image")));
            this.btnDepot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepot.Location = new System.Drawing.Point(3, 464);
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
            this.BtnProfile.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F);
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
            this.btnEmployee.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F);
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
            this.btnDashboard.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(3, 245);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(249, 67);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Schedule";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.MouseHover += new System.EventHandler(this.btnDashboard_MouseHover);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.btnClose.Location = new System.Drawing.Point(1237, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 40);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lblWelcomeName
            // 
            this.lblWelcomeName.AutoSize = true;
            this.lblWelcomeName.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcomeName.Font = new System.Drawing.Font("MS Reference Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.lblWelcomeName.Location = new System.Drawing.Point(682, 23);
            this.lblWelcomeName.Name = "lblWelcomeName";
            this.lblWelcomeName.Size = new System.Drawing.Size(155, 46);
            this.lblWelcomeName.TabIndex = 15;
            this.lblWelcomeName.Text = "Person";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(475, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 46);
            this.label3.TabIndex = 16;
            this.label3.Text = "Welcome";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(290, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 664);
            this.panel1.TabIndex = 20;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.flDays);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 60);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(947, 604);
            this.panel5.TabIndex = 1;
            // 
            // flDays
            // 
            this.flDays.BackColor = System.Drawing.Color.Transparent;
            this.flDays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flDays.Location = new System.Drawing.Point(0, 53);
            this.flDays.Name = "flDays";
            this.flDays.Size = new System.Drawing.Size(947, 551);
            this.flDays.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(947, 53);
            this.panel4.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(398, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 37);
            this.label4.TabIndex = 4;
            this.label4.Text = "Wednesday";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(660, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 37);
            this.label6.TabIndex = 6;
            this.label6.Text = "Friday";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(790, 6);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 37);
            this.label7.TabIndex = 7;
            this.label7.Text = "Saturday";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(529, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 37);
            this.label5.TabIndex = 5;
            this.label5.Text = "Thursday";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(267, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tuesday";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(137, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monday";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(4, 6);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 37);
            this.label8.TabIndex = 1;
            this.label8.Text = "Sunday";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblMonthAndYear);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(947, 60);
            this.panel2.TabIndex = 0;
            // 
            // lblMonthAndYear
            // 
            this.lblMonthAndYear.AutoSize = true;
            this.lblMonthAndYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblMonthAndYear.Location = new System.Drawing.Point(28, 7);
            this.lblMonthAndYear.Name = "lblMonthAndYear";
            this.lblMonthAndYear.Size = new System.Drawing.Size(268, 39);
            this.lblMonthAndYear.TabIndex = 1;
            this.lblMonthAndYear.Text = "November, 2020";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnNextMonth);
            this.panel3.Controls.Add(this.btnToday);
            this.panel3.Controls.Add(this.btnPrevMonth);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(719, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 60);
            this.panel3.TabIndex = 0;
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNextMonth.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNextMonth.ButtonText = ">";
            this.btnNextMonth.CausesValidation = false;
            this.btnNextMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextMonth.ErrorImageLeft = null;
            this.btnNextMonth.ErrorImageRight = null;
            this.btnNextMonth.FocusBackground = System.Drawing.Color.Gray;
            this.btnNextMonth.FocusFontColor = System.Drawing.Color.White;
            this.btnNextMonth.ForeColors = System.Drawing.Color.White;
            this.btnNextMonth.HoverBackground = System.Drawing.SystemColors.WindowFrame;
            this.btnNextMonth.HoverFontColor = System.Drawing.Color.White;
            this.btnNextMonth.ImageLeft = null;
            this.btnNextMonth.ImageRight = null;
            this.btnNextMonth.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnNextMonth.Location = new System.Drawing.Point(165, 7);
            this.btnNextMonth.Margin = new System.Windows.Forms.Padding(2);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnNextMonth.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnNextMonth.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnNextMonth.Size = new System.Drawing.Size(59, 42);
            this.btnNextMonth.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnNextMonth.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnNextMonth.TabIndex = 24;
            this.btnNextMonth.Click += new System.EventHandler(this.btnNextMonth_Click);
            // 
            // btnToday
            // 
            this.btnToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnToday.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnToday.ButtonText = "Today";
            this.btnToday.CausesValidation = false;
            this.btnToday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToday.ErrorImageLeft = null;
            this.btnToday.ErrorImageRight = null;
            this.btnToday.FocusBackground = System.Drawing.Color.Gray;
            this.btnToday.FocusFontColor = System.Drawing.Color.White;
            this.btnToday.ForeColors = System.Drawing.Color.White;
            this.btnToday.HoverBackground = System.Drawing.SystemColors.WindowFrame;
            this.btnToday.HoverFontColor = System.Drawing.Color.White;
            this.btnToday.ImageLeft = null;
            this.btnToday.ImageRight = null;
            this.btnToday.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnToday.Location = new System.Drawing.Point(66, 7);
            this.btnToday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnToday.Name = "btnToday";
            this.btnToday.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnToday.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnToday.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnToday.Size = new System.Drawing.Size(93, 42);
            this.btnToday.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnToday.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnToday.TabIndex = 23;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnPrevMonth
            // 
            this.btnPrevMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrevMonth.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrevMonth.ButtonText = "<";
            this.btnPrevMonth.CausesValidation = false;
            this.btnPrevMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevMonth.ErrorImageLeft = null;
            this.btnPrevMonth.ErrorImageRight = null;
            this.btnPrevMonth.FocusBackground = System.Drawing.Color.Gray;
            this.btnPrevMonth.FocusFontColor = System.Drawing.Color.White;
            this.btnPrevMonth.ForeColors = System.Drawing.Color.White;
            this.btnPrevMonth.HoverBackground = System.Drawing.SystemColors.WindowFrame;
            this.btnPrevMonth.HoverFontColor = System.Drawing.Color.White;
            this.btnPrevMonth.ImageLeft = null;
            this.btnPrevMonth.ImageRight = null;
            this.btnPrevMonth.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnPrevMonth.Location = new System.Drawing.Point(3, 7);
            this.btnPrevMonth.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrevMonth.Name = "btnPrevMonth";
            this.btnPrevMonth.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnPrevMonth.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnPrevMonth.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnPrevMonth.Size = new System.Drawing.Size(57, 42);
            this.btnPrevMonth.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnPrevMonth.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnPrevMonth.TabIndex = 22;
            this.btnPrevMonth.Click += new System.EventHandler(this.btnPrevMonth_Click);
            // 
            // btnAnnouncements
            // 
            this.btnAnnouncements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAnnouncements.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAnnouncements.ButtonText = "Announcements";
            this.btnAnnouncements.CausesValidation = false;
            this.btnAnnouncements.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnouncements.ErrorImageLeft = null;
            this.btnAnnouncements.ErrorImageRight = null;
            this.btnAnnouncements.FocusBackground = System.Drawing.Color.Gray;
            this.btnAnnouncements.FocusFontColor = System.Drawing.Color.White;
            this.btnAnnouncements.ForeColors = System.Drawing.Color.White;
            this.btnAnnouncements.HoverBackground = System.Drawing.SystemColors.WindowFrame;
            this.btnAnnouncements.HoverFontColor = System.Drawing.Color.White;
            this.btnAnnouncements.ImageLeft = null;
            this.btnAnnouncements.ImageRight = null;
            this.btnAnnouncements.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnAnnouncements.Location = new System.Drawing.Point(290, 759);
            this.btnAnnouncements.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnnouncements.Name = "btnAnnouncements";
            this.btnAnnouncements.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnAnnouncements.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnAnnouncements.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnAnnouncements.Size = new System.Drawing.Size(296, 53);
            this.btnAnnouncements.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnAnnouncements.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnAnnouncements.TabIndex = 21;
            this.btnAnnouncements.Click += new System.EventHandler(this.btnAnnouncements_Click);
            // 
            // generateSchedulebtn
            // 
            this.generateSchedulebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.generateSchedulebtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.generateSchedulebtn.ButtonText = "Generate schedule";
            this.generateSchedulebtn.CausesValidation = false;
            this.generateSchedulebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateSchedulebtn.ErrorImageLeft = null;
            this.generateSchedulebtn.ErrorImageRight = null;
            this.generateSchedulebtn.FocusBackground = System.Drawing.Color.Gray;
            this.generateSchedulebtn.FocusFontColor = System.Drawing.Color.White;
            this.generateSchedulebtn.ForeColors = System.Drawing.Color.White;
            this.generateSchedulebtn.HoverBackground = System.Drawing.SystemColors.WindowFrame;
            this.generateSchedulebtn.HoverFontColor = System.Drawing.Color.White;
            this.generateSchedulebtn.ImageLeft = null;
            this.generateSchedulebtn.ImageRight = null;
            this.generateSchedulebtn.LeftPictureColor = System.Drawing.Color.Transparent;
            this.generateSchedulebtn.Location = new System.Drawing.Point(939, 759);
            this.generateSchedulebtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.generateSchedulebtn.Name = "generateSchedulebtn";
            this.generateSchedulebtn.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.generateSchedulebtn.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.generateSchedulebtn.RightPictureColor = System.Drawing.Color.Transparent;
            this.generateSchedulebtn.Size = new System.Drawing.Size(298, 53);
            this.generateSchedulebtn.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.generateSchedulebtn.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.generateSchedulebtn.TabIndex = 22;
            this.generateSchedulebtn.Click += new System.EventHandler(this.generateSchedulebtn_Click);
            // 
            // shiftsbttn
            // 
            this.shiftsbttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.shiftsbttn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.shiftsbttn.ButtonText = "Shifts";
            this.shiftsbttn.CausesValidation = false;
            this.shiftsbttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shiftsbttn.ErrorImageLeft = null;
            this.shiftsbttn.ErrorImageRight = null;
            this.shiftsbttn.FocusBackground = System.Drawing.Color.Gray;
            this.shiftsbttn.FocusFontColor = System.Drawing.Color.White;
            this.shiftsbttn.ForeColors = System.Drawing.Color.White;
            this.shiftsbttn.HoverBackground = System.Drawing.SystemColors.WindowFrame;
            this.shiftsbttn.HoverFontColor = System.Drawing.Color.White;
            this.shiftsbttn.ImageLeft = null;
            this.shiftsbttn.ImageRight = null;
            this.shiftsbttn.LeftPictureColor = System.Drawing.Color.Transparent;
            this.shiftsbttn.Location = new System.Drawing.Point(607, 759);
            this.shiftsbttn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.shiftsbttn.Name = "shiftsbttn";
            this.shiftsbttn.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.shiftsbttn.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.shiftsbttn.RightPictureColor = System.Drawing.Color.Transparent;
            this.shiftsbttn.Size = new System.Drawing.Size(152, 53);
            this.shiftsbttn.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.shiftsbttn.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.shiftsbttn.TabIndex = 23;
            this.shiftsbttn.Click += new System.EventHandler(this.shiftsbttn_Click);
            // 
            // preferencesbttn
            // 
            this.preferencesbttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.preferencesbttn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.preferencesbttn.ButtonText = "Preferences";
            this.preferencesbttn.CausesValidation = false;
            this.preferencesbttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.preferencesbttn.ErrorImageLeft = null;
            this.preferencesbttn.ErrorImageRight = null;
            this.preferencesbttn.FocusBackground = System.Drawing.Color.Gray;
            this.preferencesbttn.FocusFontColor = System.Drawing.Color.White;
            this.preferencesbttn.ForeColors = System.Drawing.Color.White;
            this.preferencesbttn.HoverBackground = System.Drawing.SystemColors.WindowFrame;
            this.preferencesbttn.HoverFontColor = System.Drawing.Color.White;
            this.preferencesbttn.ImageLeft = null;
            this.preferencesbttn.ImageRight = null;
            this.preferencesbttn.LeftPictureColor = System.Drawing.Color.Transparent;
            this.preferencesbttn.Location = new System.Drawing.Point(767, 759);
            this.preferencesbttn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.preferencesbttn.Name = "preferencesbttn";
            this.preferencesbttn.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.preferencesbttn.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.preferencesbttn.RightPictureColor = System.Drawing.Color.Transparent;
            this.preferencesbttn.Size = new System.Drawing.Size(152, 53);
            this.preferencesbttn.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.preferencesbttn.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.preferencesbttn.TabIndex = 24;
            this.preferencesbttn.Click += new System.EventHandler(this.preferencesbttn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(232)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1284, 825);
            this.Controls.Add(this.preferencesbttn);
            this.Controls.Add(this.shiftsbttn);
            this.Controls.Add(this.generateSchedulebtn);
            this.Controls.Add(this.btnAnnouncements);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pDropDown);
            this.Controls.Add(this.lblWelcomeName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.pDropDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pDropDown;
        private System.Windows.Forms.Button btnDepot;
        private System.Windows.Forms.Button BtnProfile;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblWelcomeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.FlowLayoutPanel flDays;
        private System.Windows.Forms.Panel panel4;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMonthAndYear;
        private System.Windows.Forms.Panel panel3;
        private FlatButton.JFlatButton btnAnnouncements;
        private FlatButton.JFlatButton btnNextMonth;
        private FlatButton.JFlatButton btnToday;
        private FlatButton.JFlatButton btnPrevMonth;
        private FlatButton.JFlatButton generateSchedulebtn;
        private FlatButton.JFlatButton shiftsbttn;
        private FlatButton.JFlatButton preferencesbttn;
    }
}

