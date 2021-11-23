namespace GroupProjectMercury
{
    partial class AddAnnouncement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAnnouncement));
            this.tbxMessage = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxTitle = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddAnnouncement = new FlatButton.JFlatButton();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxMessage
            // 
            this.tbxMessage.Location = new System.Drawing.Point(7, 124);
            this.tbxMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.Size = new System.Drawing.Size(487, 92);
            this.tbxMessage.TabIndex = 8;
            this.tbxMessage.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 26);
            this.label3.TabIndex = 57;
            this.label3.Text = "SCHEDULE FOR: ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.monthCalendar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(5, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 224);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(208, 13);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 58;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbxTitle);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnAddAnnouncement);
            this.groupBox2.Controls.Add(this.tbxMessage);
            this.groupBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 284);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CONTENT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 26);
            this.label2.TabIndex = 60;
            this.label2.Text = "MESSAGE: ";
            // 
            // tbxTitle
            // 
            this.tbxTitle.Location = new System.Drawing.Point(7, 61);
            this.tbxTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(487, 33);
            this.tbxTitle.TabIndex = 59;
            this.tbxTitle.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 26);
            this.label1.TabIndex = 58;
            this.label1.Text = "TITLE: ";
            // 
            // btnAddAnnouncement
            // 
            this.btnAddAnnouncement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddAnnouncement.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddAnnouncement.ButtonText = "Add";
            this.btnAddAnnouncement.CausesValidation = false;
            this.btnAddAnnouncement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAnnouncement.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnAddAnnouncement.ErrorImageLeft")));
            this.btnAddAnnouncement.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnAddAnnouncement.ErrorImageRight")));
            this.btnAddAnnouncement.FocusBackground = System.Drawing.Color.Empty;
            this.btnAddAnnouncement.FocusFontColor = System.Drawing.Color.Empty;
            this.btnAddAnnouncement.ForeColors = System.Drawing.Color.White;
            this.btnAddAnnouncement.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddAnnouncement.HoverFontColor = System.Drawing.Color.White;
            this.btnAddAnnouncement.ImageLeft = ((System.Drawing.Image)(resources.GetObject("btnAddAnnouncement.ImageLeft")));
            this.btnAddAnnouncement.ImageRight = null;
            this.btnAddAnnouncement.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnAddAnnouncement.Location = new System.Drawing.Point(252, 226);
            this.btnAddAnnouncement.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAddAnnouncement.Name = "btnAddAnnouncement";
            this.btnAddAnnouncement.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnAddAnnouncement.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnAddAnnouncement.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnAddAnnouncement.Size = new System.Drawing.Size(239, 44);
            this.btnAddAnnouncement.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnAddAnnouncement.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnAddAnnouncement.TabIndex = 21;
            this.btnAddAnnouncement.Click += new System.EventHandler(this.btnAddAnnouncement_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.btnMinimize.Location = new System.Drawing.Point(419, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(46, 40);
            this.btnMinimize.TabIndex = 62;
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
            this.btnClose.Location = new System.Drawing.Point(465, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 40);
            this.btnClose.TabIndex = 61;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddAnnouncement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(517, 559);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddAnnouncement";
            this.Text = "AddAnnouncement";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbxMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.GroupBox groupBox2;
        private FlatButton.JFlatButton btnAddAnnouncement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tbxTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
    }
}