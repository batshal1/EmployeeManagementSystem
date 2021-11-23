namespace GroupProjectMercury.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbxUserName = new JMaterialTextbox.JMaterialTextbox();
            this.tbxPassword = new JMaterialTextbox.JMaterialTextbox();
            this.btnLogin = new FlatButton.JFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 45);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(946, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(50, 45);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(996, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 45);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 523);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1046, 101);
            this.panel2.TabIndex = 1;
            // 
            // tbxUserName
            // 
            this.tbxUserName.BackColor = System.Drawing.Color.Transparent;
            this.tbxUserName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbxUserName.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbxUserName.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.tbxUserName.HintText = null;
            this.tbxUserName.IsPassword = false;
            this.tbxUserName.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.tbxUserName.LineThickness = 2;
            this.tbxUserName.Location = new System.Drawing.Point(593, 174);
            this.tbxUserName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxUserName.MaxLength = 32767;
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.OnFocusedColor = System.Drawing.Color.Black;
            this.tbxUserName.OnFocusedTextColor = System.Drawing.Color.Black;
            this.tbxUserName.ReadOnly = false;
            this.tbxUserName.Size = new System.Drawing.Size(325, 28);
            this.tbxUserName.TabIndex = 2;
            this.tbxUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxUserName.TextName = "Username";
            // 
            // tbxPassword
            // 
            this.tbxPassword.BackColor = System.Drawing.Color.Transparent;
            this.tbxPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbxPassword.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbxPassword.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.tbxPassword.HintText = null;
            this.tbxPassword.IsPassword = true;
            this.tbxPassword.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.tbxPassword.LineThickness = 2;
            this.tbxPassword.Location = new System.Drawing.Point(593, 239);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPassword.MaxLength = 32767;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.OnFocusedColor = System.Drawing.Color.Black;
            this.tbxPassword.OnFocusedTextColor = System.Drawing.Color.Black;
            this.tbxPassword.ReadOnly = false;
            this.tbxPassword.Size = new System.Drawing.Size(325, 28);
            this.tbxPassword.TabIndex = 3;
            this.tbxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxPassword.TextName = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.ButtonText = "Log In";
            this.btnLogin.CausesValidation = false;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnLogin.ErrorImageLeft")));
            this.btnLogin.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnLogin.ErrorImageRight")));
            this.btnLogin.FocusBackground = System.Drawing.Color.Gray;
            this.btnLogin.FocusFontColor = System.Drawing.Color.White;
            this.btnLogin.ForeColors = System.Drawing.Color.White;
            this.btnLogin.HoverBackground = System.Drawing.SystemColors.WindowFrame;
            this.btnLogin.HoverFontColor = System.Drawing.Color.White;
            this.btnLogin.ImageLeft = ((System.Drawing.Image)(resources.GetObject("btnLogin.ImageLeft")));
            this.btnLogin.ImageRight = null;
            this.btnLogin.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnLogin.Location = new System.Drawing.Point(593, 320);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnLogin.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnLogin.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnLogin.Size = new System.Drawing.Size(325, 53);
            this.btnLogin.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnLogin.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 624);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(223)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1046, 624);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private JMaterialTextbox.JMaterialTextbox tbxUserName;
        private JMaterialTextbox.JMaterialTextbox tbxPassword;
        private FlatButton.JFlatButton btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}