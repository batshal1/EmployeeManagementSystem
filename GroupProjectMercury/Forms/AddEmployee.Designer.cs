namespace GroupProjectMercury.Forms
{
    partial class AddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
            this.pDropDown = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnDepot = new System.Windows.Forms.Button();
            this.BtnProfile = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.tbxSurname = new JMaterialTextbox.JMaterialTextbox();
            this.tbxName = new JMaterialTextbox.JMaterialTextbox();
            this.btnAddEmployee = new FlatButton.JFlatButton();
            this.tbxBSNNr = new JMaterialTextbox.JMaterialTextbox();
            this.tbxDateOfBirth = new JMaterialTextbox.JMaterialTextbox();
            this.tbxStreet = new JMaterialTextbox.JMaterialTextbox();
            this.tbxZipcode = new JMaterialTextbox.JMaterialTextbox();
            this.tbxCity = new JMaterialTextbox.JMaterialTextbox();
            this.tbxEmail = new JMaterialTextbox.JMaterialTextbox();
            this.tbxPhoneNr = new JMaterialTextbox.JMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudSalary = new System.Windows.Forms.NumericUpDown();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxPosition = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblWelcomeName = new System.Windows.Forms.Label();
            this.pDropDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // pDropDown
            // 
            this.pDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.pDropDown.Controls.Add(this.btnLogOut);
            this.pDropDown.Controls.Add(this.btnDepot);
            this.pDropDown.Controls.Add(this.BtnProfile);
            this.pDropDown.Controls.Add(this.btnEmployee);
            this.pDropDown.Controls.Add(this.btnSchedule);
            this.pDropDown.Dock = System.Windows.Forms.DockStyle.Left;
            this.pDropDown.Location = new System.Drawing.Point(0, 0);
            this.pDropDown.MaximumSize = new System.Drawing.Size(255, 825);
            this.pDropDown.MinimumSize = new System.Drawing.Size(220, 761);
            this.pDropDown.Name = "pDropDown";
            this.pDropDown.Size = new System.Drawing.Size(220, 825);
            this.pDropDown.TabIndex = 1;
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(3, 763);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(182, 40);
            this.btnLogOut.TabIndex = 53;
            this.btnLogOut.Text = "X  Logout";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnDepot
            // 
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
            this.BtnProfile.FlatAppearance.BorderSize = 0;
            this.BtnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProfile.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProfile.ForeColor = System.Drawing.Color.White;
            this.BtnProfile.Image = ((System.Drawing.Image)(resources.GetObject("BtnProfile.Image")));
            this.BtnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProfile.Location = new System.Drawing.Point(3, 318);
            this.BtnProfile.Name = "BtnProfile";
            this.BtnProfile.Size = new System.Drawing.Size(252, 67);
            this.BtnProfile.TabIndex = 2;
            this.BtnProfile.Text = "Profile";
            this.BtnProfile.UseVisualStyleBackColor = true;
            this.BtnProfile.Click += new System.EventHandler(this.BtnProfile_Click);
            // 
            // btnEmployee
            // 
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
            // btnSchedule
            // 
            this.btnSchedule.FlatAppearance.BorderSize = 0;
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.ForeColor = System.Drawing.Color.White;
            this.btnSchedule.Image = ((System.Drawing.Image)(resources.GetObject("btnSchedule.Image")));
            this.btnSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchedule.Location = new System.Drawing.Point(3, 245);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(249, 67);
            this.btnSchedule.TabIndex = 1;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // tbxSurname
            // 
            this.tbxSurname.BackColor = System.Drawing.Color.Transparent;
            this.tbxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbxSurname.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbxSurname.ForeColors = System.Drawing.Color.Black;
            this.tbxSurname.HintText = null;
            this.tbxSurname.IsPassword = false;
            this.tbxSurname.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxSurname.LineThickness = 2;
            this.tbxSurname.Location = new System.Drawing.Point(598, 250);
            this.tbxSurname.Margin = new System.Windows.Forms.Padding(5);
            this.tbxSurname.MaxLength = 32767;
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.tbxSurname.OnFocusedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.tbxSurname.ReadOnly = false;
            this.tbxSurname.Size = new System.Drawing.Size(296, 28);
            this.tbxSurname.TabIndex = 37;
            this.tbxSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxSurname.TextName = "Surname";
            // 
            // tbxName
            // 
            this.tbxName.BackColor = System.Drawing.Color.Transparent;
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbxName.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbxName.ForeColors = System.Drawing.Color.Black;
            this.tbxName.HintText = null;
            this.tbxName.IsPassword = false;
            this.tbxName.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxName.LineThickness = 2;
            this.tbxName.Location = new System.Drawing.Point(598, 181);
            this.tbxName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxName.MaxLength = 32767;
            this.tbxName.Name = "tbxName";
            this.tbxName.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.tbxName.OnFocusedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.tbxName.ReadOnly = false;
            this.tbxName.Size = new System.Drawing.Size(296, 28);
            this.tbxName.TabIndex = 36;
            this.tbxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxName.TextName = "Name";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddEmployee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddEmployee.ButtonText = "Add Employee";
            this.btnAddEmployee.CausesValidation = false;
            this.btnAddEmployee.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnAddEmployee.ErrorImageLeft")));
            this.btnAddEmployee.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnAddEmployee.ErrorImageRight")));
            this.btnAddEmployee.FocusBackground = System.Drawing.Color.Gray;
            this.btnAddEmployee.FocusFontColor = System.Drawing.Color.White;
            this.btnAddEmployee.ForeColors = System.Drawing.Color.White;
            this.btnAddEmployee.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.btnAddEmployee.HoverFontColor = System.Drawing.Color.White;
            this.btnAddEmployee.ImageLeft = ((System.Drawing.Image)(resources.GetObject("btnAddEmployee.ImageLeft")));
            this.btnAddEmployee.ImageRight = null;
            this.btnAddEmployee.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnAddEmployee.Location = new System.Drawing.Point(986, 721);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnAddEmployee.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnAddEmployee.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnAddEmployee.Size = new System.Drawing.Size(249, 57);
            this.btnAddEmployee.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnAddEmployee.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnAddEmployee.TabIndex = 40;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // tbxBSNNr
            // 
            this.tbxBSNNr.BackColor = System.Drawing.Color.Transparent;
            this.tbxBSNNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbxBSNNr.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbxBSNNr.ForeColors = System.Drawing.Color.Black;
            this.tbxBSNNr.HintText = null;
            this.tbxBSNNr.IsPassword = false;
            this.tbxBSNNr.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxBSNNr.LineThickness = 2;
            this.tbxBSNNr.Location = new System.Drawing.Point(598, 321);
            this.tbxBSNNr.Margin = new System.Windows.Forms.Padding(5);
            this.tbxBSNNr.MaxLength = 32767;
            this.tbxBSNNr.Name = "tbxBSNNr";
            this.tbxBSNNr.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.tbxBSNNr.OnFocusedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.tbxBSNNr.ReadOnly = false;
            this.tbxBSNNr.Size = new System.Drawing.Size(296, 28);
            this.tbxBSNNr.TabIndex = 41;
            this.tbxBSNNr.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxBSNNr.TextName = "BSN Number";
            // 
            // tbxDateOfBirth
            // 
            this.tbxDateOfBirth.BackColor = System.Drawing.Color.Transparent;
            this.tbxDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbxDateOfBirth.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbxDateOfBirth.ForeColors = System.Drawing.Color.Black;
            this.tbxDateOfBirth.HintText = null;
            this.tbxDateOfBirth.IsPassword = false;
            this.tbxDateOfBirth.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxDateOfBirth.LineThickness = 2;
            this.tbxDateOfBirth.Location = new System.Drawing.Point(598, 391);
            this.tbxDateOfBirth.Margin = new System.Windows.Forms.Padding(5);
            this.tbxDateOfBirth.MaxLength = 32767;
            this.tbxDateOfBirth.Name = "tbxDateOfBirth";
            this.tbxDateOfBirth.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.tbxDateOfBirth.OnFocusedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.tbxDateOfBirth.ReadOnly = false;
            this.tbxDateOfBirth.Size = new System.Drawing.Size(296, 28);
            this.tbxDateOfBirth.TabIndex = 42;
            this.tbxDateOfBirth.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxDateOfBirth.TextName = "Date of birth";
            // 
            // tbxStreet
            // 
            this.tbxStreet.BackColor = System.Drawing.Color.Transparent;
            this.tbxStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbxStreet.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbxStreet.ForeColors = System.Drawing.Color.Black;
            this.tbxStreet.HintText = null;
            this.tbxStreet.IsPassword = false;
            this.tbxStreet.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxStreet.LineThickness = 2;
            this.tbxStreet.Location = new System.Drawing.Point(598, 610);
            this.tbxStreet.Margin = new System.Windows.Forms.Padding(5);
            this.tbxStreet.MaxLength = 32767;
            this.tbxStreet.Name = "tbxStreet";
            this.tbxStreet.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.tbxStreet.OnFocusedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.tbxStreet.ReadOnly = false;
            this.tbxStreet.Size = new System.Drawing.Size(296, 28);
            this.tbxStreet.TabIndex = 43;
            this.tbxStreet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxStreet.TextName = "Street";
            // 
            // tbxZipcode
            // 
            this.tbxZipcode.BackColor = System.Drawing.Color.Transparent;
            this.tbxZipcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbxZipcode.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbxZipcode.ForeColors = System.Drawing.Color.Black;
            this.tbxZipcode.HintText = null;
            this.tbxZipcode.IsPassword = false;
            this.tbxZipcode.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxZipcode.LineThickness = 2;
            this.tbxZipcode.Location = new System.Drawing.Point(598, 678);
            this.tbxZipcode.Margin = new System.Windows.Forms.Padding(5);
            this.tbxZipcode.MaxLength = 32767;
            this.tbxZipcode.Name = "tbxZipcode";
            this.tbxZipcode.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.tbxZipcode.OnFocusedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.tbxZipcode.ReadOnly = false;
            this.tbxZipcode.Size = new System.Drawing.Size(296, 28);
            this.tbxZipcode.TabIndex = 44;
            this.tbxZipcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxZipcode.TextName = "Zipcode";
            // 
            // tbxCity
            // 
            this.tbxCity.BackColor = System.Drawing.Color.Transparent;
            this.tbxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbxCity.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbxCity.ForeColors = System.Drawing.Color.Black;
            this.tbxCity.HintText = null;
            this.tbxCity.IsPassword = false;
            this.tbxCity.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxCity.LineThickness = 2;
            this.tbxCity.Location = new System.Drawing.Point(951, 107);
            this.tbxCity.Margin = new System.Windows.Forms.Padding(5);
            this.tbxCity.MaxLength = 32767;
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.tbxCity.OnFocusedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.tbxCity.ReadOnly = false;
            this.tbxCity.Size = new System.Drawing.Size(296, 28);
            this.tbxCity.TabIndex = 45;
            this.tbxCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxCity.TextName = "City";
            // 
            // tbxEmail
            // 
            this.tbxEmail.BackColor = System.Drawing.Color.Transparent;
            this.tbxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbxEmail.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbxEmail.ForeColors = System.Drawing.Color.Black;
            this.tbxEmail.HintText = null;
            this.tbxEmail.IsPassword = false;
            this.tbxEmail.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxEmail.LineThickness = 2;
            this.tbxEmail.Location = new System.Drawing.Point(598, 466);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(5);
            this.tbxEmail.MaxLength = 32767;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.tbxEmail.OnFocusedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.tbxEmail.ReadOnly = false;
            this.tbxEmail.Size = new System.Drawing.Size(296, 28);
            this.tbxEmail.TabIndex = 47;
            this.tbxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxEmail.TextName = "Email";
            // 
            // tbxPhoneNr
            // 
            this.tbxPhoneNr.BackColor = System.Drawing.Color.Transparent;
            this.tbxPhoneNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbxPhoneNr.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbxPhoneNr.ForeColors = System.Drawing.Color.Black;
            this.tbxPhoneNr.HintText = null;
            this.tbxPhoneNr.IsPassword = false;
            this.tbxPhoneNr.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxPhoneNr.LineThickness = 2;
            this.tbxPhoneNr.Location = new System.Drawing.Point(598, 537);
            this.tbxPhoneNr.Margin = new System.Windows.Forms.Padding(5);
            this.tbxPhoneNr.MaxLength = 32767;
            this.tbxPhoneNr.Name = "tbxPhoneNr";
            this.tbxPhoneNr.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.tbxPhoneNr.OnFocusedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.tbxPhoneNr.ReadOnly = false;
            this.tbxPhoneNr.Size = new System.Drawing.Size(296, 28);
            this.tbxPhoneNr.TabIndex = 48;
            this.tbxPhoneNr.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxPhoneNr.TextName = "Phone Number";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(353, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(957, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 55;
            this.label3.Text = "Salary";
            // 
            // nudSalary
            // 
            this.nudSalary.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudSalary.Location = new System.Drawing.Point(951, 187);
            this.nudSalary.Name = "nudSalary";
            this.nudSalary.Size = new System.Drawing.Size(296, 22);
            this.nudSalary.TabIndex = 54;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(598, 409);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(296, 22);
            this.dtpDateOfBirth.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(610, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 53;
            this.label2.Text = "Position";
            // 
            // cbxPosition
            // 
            this.cbxPosition.FormattingEnabled = true;
            this.cbxPosition.Items.AddRange(new object[] {
            "Shop worker",
            "Depot worker",
            "Administrator",
            "Manager"});
            this.cbxPosition.Location = new System.Drawing.Point(598, 124);
            this.cbxPosition.Name = "cbxPosition";
            this.cbxPosition.Size = new System.Drawing.Size(296, 24);
            this.cbxPosition.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(966, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 50;
            this.label1.Text = "Gender";
            // 
            // cbxGender
            // 
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cbxGender.Location = new System.Drawing.Point(951, 254);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(279, 24);
            this.cbxGender.TabIndex = 49;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.btnMinimize.Location = new System.Drawing.Point(1189, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(46, 40);
            this.btnMinimize.TabIndex = 52;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.btnClose.Location = new System.Drawing.Point(1235, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 40);
            this.btnClose.TabIndex = 51;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblWelcomeName
            // 
            this.lblWelcomeName.AutoSize = true;
            this.lblWelcomeName.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcomeName.Font = new System.Drawing.Font("MS Reference Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.lblWelcomeName.Location = new System.Drawing.Point(475, 23);
            this.lblWelcomeName.Name = "lblWelcomeName";
            this.lblWelcomeName.Size = new System.Drawing.Size(304, 46);
            this.lblWelcomeName.TabIndex = 56;
            this.lblWelcomeName.Text = "Add employee";
            // 
            // AddEmployee
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1284, 825);
            this.Controls.Add(this.lblWelcomeName);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.nudSalary);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pDropDown);
            this.Controls.Add(this.cbxPosition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxGender);
            this.Controls.Add(this.tbxDateOfBirth);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.tbxBSNNr);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxZipcode);
            this.Controls.Add(this.tbxSurname);
            this.Controls.Add(this.tbxPhoneNr);
            this.Controls.Add(this.tbxStreet);
            this.Controls.Add(this.tbxCity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEmployee";
            this.pDropDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pDropDown;
        private System.Windows.Forms.Button btnDepot;
        private System.Windows.Forms.Button BtnProfile;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnSchedule;
        private JMaterialTextbox.JMaterialTextbox tbxSurname;
        private JMaterialTextbox.JMaterialTextbox tbxName;
        private FlatButton.JFlatButton btnAddEmployee;
        private JMaterialTextbox.JMaterialTextbox tbxBSNNr;
        private JMaterialTextbox.JMaterialTextbox tbxDateOfBirth;
        private JMaterialTextbox.JMaterialTextbox tbxStreet;
        private JMaterialTextbox.JMaterialTextbox tbxZipcode;
        private JMaterialTextbox.JMaterialTextbox tbxCity;
        private JMaterialTextbox.JMaterialTextbox tbxEmail;
        private JMaterialTextbox.JMaterialTextbox tbxPhoneNr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxPosition;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudSalary;
        private System.Windows.Forms.Label lblWelcomeName;
    }
}