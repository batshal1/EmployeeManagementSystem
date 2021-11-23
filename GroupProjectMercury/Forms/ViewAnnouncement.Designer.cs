namespace GroupProjectMercury.Forms
{
    partial class ViewAnnouncement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAnnouncement));
            this.lbxAnnouncements = new System.Windows.Forms.ListBox();
            this.btnAddAnnouncement = new FlatButton.JFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEdit = new FlatButton.JFlatButton();
            this.SuspendLayout();
            // 
            // lbxAnnouncements
            // 
            this.lbxAnnouncements.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxAnnouncements.FormattingEnabled = true;
            this.lbxAnnouncements.ItemHeight = 22;
            this.lbxAnnouncements.Location = new System.Drawing.Point(12, 96);
            this.lbxAnnouncements.Name = "lbxAnnouncements";
            this.lbxAnnouncements.Size = new System.Drawing.Size(466, 246);
            this.lbxAnnouncements.TabIndex = 0;
            this.lbxAnnouncements.SelectedIndexChanged += new System.EventHandler(this.lbxAnnouncements_SelectedIndexChanged);
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
            this.btnAddAnnouncement.FocusBackground = System.Drawing.Color.Gray;
            this.btnAddAnnouncement.FocusFontColor = System.Drawing.Color.Empty;
            this.btnAddAnnouncement.ForeColors = System.Drawing.Color.White;
            this.btnAddAnnouncement.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddAnnouncement.HoverFontColor = System.Drawing.Color.White;
            this.btnAddAnnouncement.ImageLeft = ((System.Drawing.Image)(resources.GetObject("btnAddAnnouncement.ImageLeft")));
            this.btnAddAnnouncement.ImageRight = null;
            this.btnAddAnnouncement.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnAddAnnouncement.Location = new System.Drawing.Point(304, 371);
            this.btnAddAnnouncement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddAnnouncement.Name = "btnAddAnnouncement";
            this.btnAddAnnouncement.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnAddAnnouncement.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnAddAnnouncement.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnAddAnnouncement.Size = new System.Drawing.Size(174, 60);
            this.btnAddAnnouncement.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnAddAnnouncement.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnAddAnnouncement.TabIndex = 20;
            this.btnAddAnnouncement.Click += new System.EventHandler(this.btnAddAnnouncement_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(352, 40);
            this.label3.TabIndex = 58;
            this.label3.Text = "ANNOUNCEMENTS ";
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.btnMinimize.Location = new System.Drawing.Point(403, 6);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(46, 40);
            this.btnMinimize.TabIndex = 23;
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
            this.btnClose.Location = new System.Drawing.Point(449, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 40);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEdit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEdit.ButtonText = "Edit";
            this.btnEdit.CausesValidation = false;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnEdit.ErrorImageLeft")));
            this.btnEdit.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnEdit.ErrorImageRight")));
            this.btnEdit.FocusBackground = System.Drawing.Color.Gray;
            this.btnEdit.FocusFontColor = System.Drawing.Color.Empty;
            this.btnEdit.ForeColors = System.Drawing.Color.White;
            this.btnEdit.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEdit.HoverFontColor = System.Drawing.Color.White;
            this.btnEdit.ImageLeft = null;
            this.btnEdit.ImageRight = null;
            this.btnEdit.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnEdit.Location = new System.Drawing.Point(12, 371);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnEdit.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnEdit.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnEdit.Size = new System.Drawing.Size(238, 60);
            this.btnEdit.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnEdit.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnEdit.TabIndex = 59;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // ViewAnnouncement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(493, 465);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnAddAnnouncement);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbxAnnouncements);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewAnnouncement";
            this.Text = "ViewAnnouncement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxAnnouncements;
        private FlatButton.JFlatButton btnAddAnnouncement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private FlatButton.JFlatButton btnEdit;
    }
}