
namespace GroupProjectMercury.Forms
{
    partial class ManageShifts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageShifts));
            this.gbxDetails = new System.Windows.Forms.GroupBox();
            this.btnWriteToFile = new FlatButton.JFlatButton();
            this.RemoveBtn = new FlatButton.JFlatButton();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.lbxDepotworkers = new System.Windows.Forms.ListBox();
            this.rbtnDetailsEvening = new System.Windows.Forms.RadioButton();
            this.rbtnDetailsAfternoon = new System.Windows.Forms.RadioButton();
            this.rbtnDetailsMorning = new System.Windows.Forms.RadioButton();
            this.lbxShopworkers = new System.Windows.Forms.ListBox();
            this.lblDepotCount = new System.Windows.Forms.Label();
            this.lblShopCount = new System.Windows.Forms.Label();
            this.gbxAssign = new System.Windows.Forms.GroupBox();
            this.btnAssignShift = new FlatButton.JFlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnAssignMorning = new System.Windows.Forms.RadioButton();
            this.rbtnAssignAfternoon = new System.Windows.Forms.RadioButton();
            this.rbtnAssignEvening = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpAssign = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxAssignEmployee = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtnDepotworker = new System.Windows.Forms.RadioButton();
            this.rbtnShopworker = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.pbxBack = new System.Windows.Forms.PictureBox();
            this.gbxDetails.SuspendLayout();
            this.gbxAssign.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxDetails
            // 
            this.gbxDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(232)))));
            this.gbxDetails.Controls.Add(this.btnWriteToFile);
            this.gbxDetails.Controls.Add(this.RemoveBtn);
            this.gbxDetails.Controls.Add(this.lblTotalCount);
            this.gbxDetails.Controls.Add(this.lbxDepotworkers);
            this.gbxDetails.Controls.Add(this.rbtnDetailsEvening);
            this.gbxDetails.Controls.Add(this.rbtnDetailsAfternoon);
            this.gbxDetails.Controls.Add(this.rbtnDetailsMorning);
            this.gbxDetails.Controls.Add(this.lbxShopworkers);
            this.gbxDetails.Controls.Add(this.lblDepotCount);
            this.gbxDetails.Controls.Add(this.lblShopCount);
            this.gbxDetails.Location = new System.Drawing.Point(30, 95);
            this.gbxDetails.Name = "gbxDetails";
            this.gbxDetails.Size = new System.Drawing.Size(485, 427);
            this.gbxDetails.TabIndex = 0;
            this.gbxDetails.TabStop = false;
            this.gbxDetails.Text = "Details";
            // 
            // btnWriteToFile
            // 
            this.btnWriteToFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnWriteToFile.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnWriteToFile.ButtonText = "Save File";
            this.btnWriteToFile.CausesValidation = false;
            this.btnWriteToFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWriteToFile.ErrorImageLeft = null;
            this.btnWriteToFile.ErrorImageRight = null;
            this.btnWriteToFile.FocusBackground = System.Drawing.Color.Gray;
            this.btnWriteToFile.FocusFontColor = System.Drawing.Color.White;
            this.btnWriteToFile.ForeColors = System.Drawing.Color.White;
            this.btnWriteToFile.HoverBackground = System.Drawing.SystemColors.WindowFrame;
            this.btnWriteToFile.HoverFontColor = System.Drawing.Color.White;
            this.btnWriteToFile.ImageLeft = null;
            this.btnWriteToFile.ImageRight = null;
            this.btnWriteToFile.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnWriteToFile.Location = new System.Drawing.Point(24, 374);
            this.btnWriteToFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnWriteToFile.Name = "btnWriteToFile";
            this.btnWriteToFile.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnWriteToFile.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnWriteToFile.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnWriteToFile.Size = new System.Drawing.Size(139, 44);
            this.btnWriteToFile.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnWriteToFile.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnWriteToFile.TabIndex = 98;
            this.btnWriteToFile.Click += new System.EventHandler(this.btnWriteToFile_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RemoveBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RemoveBtn.ButtonText = "Remove shift";
            this.RemoveBtn.CausesValidation = false;
            this.RemoveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveBtn.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("RemoveBtn.ErrorImageLeft")));
            this.RemoveBtn.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("RemoveBtn.ErrorImageRight")));
            this.RemoveBtn.FocusBackground = System.Drawing.Color.Gray;
            this.RemoveBtn.FocusFontColor = System.Drawing.Color.Empty;
            this.RemoveBtn.ForeColors = System.Drawing.Color.White;
            this.RemoveBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RemoveBtn.HoverFontColor = System.Drawing.Color.White;
            this.RemoveBtn.ImageLeft = ((System.Drawing.Image)(resources.GetObject("RemoveBtn.ImageLeft")));
            this.RemoveBtn.ImageRight = null;
            this.RemoveBtn.LeftPictureColor = System.Drawing.Color.Transparent;
            this.RemoveBtn.Location = new System.Drawing.Point(232, 374);
            this.RemoveBtn.Margin = new System.Windows.Forms.Padding(6);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.RemoveBtn.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.RemoveBtn.RightPictureColor = System.Drawing.Color.Transparent;
            this.RemoveBtn.Size = new System.Drawing.Size(239, 44);
            this.RemoveBtn.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RemoveBtn.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.RemoveBtn.TabIndex = 134;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Location = new System.Drawing.Point(21, 63);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(116, 17);
            this.lblTotalCount.TabIndex = 7;
            this.lblTotalCount.Text = "Total employees:";
            // 
            // lbxDepotworkers
            // 
            this.lbxDepotworkers.FormattingEnabled = true;
            this.lbxDepotworkers.ItemHeight = 16;
            this.lbxDepotworkers.Location = new System.Drawing.Point(24, 251);
            this.lbxDepotworkers.Name = "lbxDepotworkers";
            this.lbxDepotworkers.Size = new System.Drawing.Size(317, 100);
            this.lbxDepotworkers.TabIndex = 6;
            // 
            // rbtnDetailsEvening
            // 
            this.rbtnDetailsEvening.AutoSize = true;
            this.rbtnDetailsEvening.Location = new System.Drawing.Point(232, 31);
            this.rbtnDetailsEvening.Name = "rbtnDetailsEvening";
            this.rbtnDetailsEvening.Size = new System.Drawing.Size(80, 21);
            this.rbtnDetailsEvening.TabIndex = 5;
            this.rbtnDetailsEvening.TabStop = true;
            this.rbtnDetailsEvening.Text = "Evening";
            this.rbtnDetailsEvening.UseVisualStyleBackColor = true;
            this.rbtnDetailsEvening.CheckedChanged += new System.EventHandler(this.rbtnDetailsEvening_CheckedChanged);
            // 
            // rbtnDetailsAfternoon
            // 
            this.rbtnDetailsAfternoon.AutoSize = true;
            this.rbtnDetailsAfternoon.Location = new System.Drawing.Point(127, 31);
            this.rbtnDetailsAfternoon.Name = "rbtnDetailsAfternoon";
            this.rbtnDetailsAfternoon.Size = new System.Drawing.Size(91, 21);
            this.rbtnDetailsAfternoon.TabIndex = 4;
            this.rbtnDetailsAfternoon.TabStop = true;
            this.rbtnDetailsAfternoon.Text = "Afternoon";
            this.rbtnDetailsAfternoon.UseVisualStyleBackColor = true;
            this.rbtnDetailsAfternoon.CheckedChanged += new System.EventHandler(this.rbtnDetailsAfternoon_CheckedChanged);
            // 
            // rbtnDetailsMorning
            // 
            this.rbtnDetailsMorning.AutoSize = true;
            this.rbtnDetailsMorning.Location = new System.Drawing.Point(24, 31);
            this.rbtnDetailsMorning.Name = "rbtnDetailsMorning";
            this.rbtnDetailsMorning.Size = new System.Drawing.Size(80, 21);
            this.rbtnDetailsMorning.TabIndex = 3;
            this.rbtnDetailsMorning.TabStop = true;
            this.rbtnDetailsMorning.Text = "Morning";
            this.rbtnDetailsMorning.UseVisualStyleBackColor = true;
            this.rbtnDetailsMorning.CheckedChanged += new System.EventHandler(this.rbtnDetailsMorning_CheckedChanged);
            // 
            // lbxShopworkers
            // 
            this.lbxShopworkers.FormattingEnabled = true;
            this.lbxShopworkers.ItemHeight = 16;
            this.lbxShopworkers.Location = new System.Drawing.Point(24, 104);
            this.lbxShopworkers.Name = "lbxShopworkers";
            this.lbxShopworkers.Size = new System.Drawing.Size(317, 100);
            this.lbxShopworkers.TabIndex = 2;
            // 
            // lblDepotCount
            // 
            this.lblDepotCount.AutoSize = true;
            this.lblDepotCount.Location = new System.Drawing.Point(21, 229);
            this.lblDepotCount.Name = "lblDepotCount";
            this.lblDepotCount.Size = new System.Drawing.Size(50, 17);
            this.lblDepotCount.TabIndex = 1;
            this.lblDepotCount.Text = "Depot:";
            // 
            // lblShopCount
            // 
            this.lblShopCount.AutoSize = true;
            this.lblShopCount.Location = new System.Drawing.Point(21, 84);
            this.lblShopCount.Name = "lblShopCount";
            this.lblShopCount.Size = new System.Drawing.Size(45, 17);
            this.lblShopCount.TabIndex = 0;
            this.lblShopCount.Text = "Shop:";
            // 
            // gbxAssign
            // 
            this.gbxAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(232)))));
            this.gbxAssign.Controls.Add(this.btnAssignShift);
            this.gbxAssign.Controls.Add(this.groupBox1);
            this.gbxAssign.Controls.Add(this.label6);
            this.gbxAssign.Controls.Add(this.dtpAssign);
            this.gbxAssign.Controls.Add(this.label5);
            this.gbxAssign.Controls.Add(this.cbxAssignEmployee);
            this.gbxAssign.Controls.Add(this.label4);
            this.gbxAssign.Controls.Add(this.label3);
            this.gbxAssign.Controls.Add(this.rbtnDepotworker);
            this.gbxAssign.Controls.Add(this.rbtnShopworker);
            this.gbxAssign.Location = new System.Drawing.Point(539, 95);
            this.gbxAssign.Name = "gbxAssign";
            this.gbxAssign.Size = new System.Drawing.Size(342, 427);
            this.gbxAssign.TabIndex = 1;
            this.gbxAssign.TabStop = false;
            this.gbxAssign.Text = "Assign shift";
            // 
            // btnAssignShift
            // 
            this.btnAssignShift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAssignShift.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAssignShift.ButtonText = "Assign shift";
            this.btnAssignShift.CausesValidation = false;
            this.btnAssignShift.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssignShift.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnAssignShift.ErrorImageLeft")));
            this.btnAssignShift.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnAssignShift.ErrorImageRight")));
            this.btnAssignShift.FocusBackground = System.Drawing.Color.Gray;
            this.btnAssignShift.FocusFontColor = System.Drawing.Color.Empty;
            this.btnAssignShift.ForeColors = System.Drawing.Color.White;
            this.btnAssignShift.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAssignShift.HoverFontColor = System.Drawing.Color.White;
            this.btnAssignShift.ImageLeft = ((System.Drawing.Image)(resources.GetObject("btnAssignShift.ImageLeft")));
            this.btnAssignShift.ImageRight = null;
            this.btnAssignShift.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnAssignShift.Location = new System.Drawing.Point(33, 304);
            this.btnAssignShift.Margin = new System.Windows.Forms.Padding(6);
            this.btnAssignShift.Name = "btnAssignShift";
            this.btnAssignShift.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnAssignShift.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnAssignShift.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnAssignShift.Size = new System.Drawing.Size(239, 44);
            this.btnAssignShift.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnAssignShift.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnAssignShift.TabIndex = 133;
            this.btnAssignShift.Click += new System.EventHandler(this.btnAssignShift_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnAssignMorning);
            this.groupBox1.Controls.Add(this.rbtnAssignAfternoon);
            this.groupBox1.Controls.Add(this.rbtnAssignEvening);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(13, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 105);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // rbtnAssignMorning
            // 
            this.rbtnAssignMorning.AutoSize = true;
            this.rbtnAssignMorning.Location = new System.Drawing.Point(20, 20);
            this.rbtnAssignMorning.Name = "rbtnAssignMorning";
            this.rbtnAssignMorning.Size = new System.Drawing.Size(80, 21);
            this.rbtnAssignMorning.TabIndex = 6;
            this.rbtnAssignMorning.TabStop = true;
            this.rbtnAssignMorning.Text = "Morning";
            this.rbtnAssignMorning.UseVisualStyleBackColor = true;
            // 
            // rbtnAssignAfternoon
            // 
            this.rbtnAssignAfternoon.AutoSize = true;
            this.rbtnAssignAfternoon.Location = new System.Drawing.Point(20, 51);
            this.rbtnAssignAfternoon.Name = "rbtnAssignAfternoon";
            this.rbtnAssignAfternoon.Size = new System.Drawing.Size(91, 21);
            this.rbtnAssignAfternoon.TabIndex = 7;
            this.rbtnAssignAfternoon.TabStop = true;
            this.rbtnAssignAfternoon.Text = "Afternoon";
            this.rbtnAssignAfternoon.UseVisualStyleBackColor = true;
            // 
            // rbtnAssignEvening
            // 
            this.rbtnAssignEvening.AutoSize = true;
            this.rbtnAssignEvening.Location = new System.Drawing.Point(20, 83);
            this.rbtnAssignEvening.Name = "rbtnAssignEvening";
            this.rbtnAssignEvening.Size = new System.Drawing.Size(80, 21);
            this.rbtnAssignEvening.TabIndex = 8;
            this.rbtnAssignEvening.TabStop = true;
            this.rbtnAssignEvening.Text = "Evening";
            this.rbtnAssignEvening.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Date:";
            // 
            // dtpAssign
            // 
            this.dtpAssign.Location = new System.Drawing.Point(108, 35);
            this.dtpAssign.Name = "dtpAssign";
            this.dtpAssign.Size = new System.Drawing.Size(200, 22);
            this.dtpAssign.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Select employee:";
            // 
            // cbxAssignEmployee
            // 
            this.cbxAssignEmployee.FormattingEnabled = true;
            this.cbxAssignEmployee.Location = new System.Drawing.Point(31, 261);
            this.cbxAssignEmployee.Name = "cbxAssignEmployee";
            this.cbxAssignEmployee.Size = new System.Drawing.Size(270, 24);
            this.cbxAssignEmployee.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Choose:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Choose timeslot:";
            // 
            // rbtnDepotworker
            // 
            this.rbtnDepotworker.AutoSize = true;
            this.rbtnDepotworker.Location = new System.Drawing.Point(195, 141);
            this.rbtnDepotworker.Name = "rbtnDepotworker";
            this.rbtnDepotworker.Size = new System.Drawing.Size(113, 21);
            this.rbtnDepotworker.TabIndex = 10;
            this.rbtnDepotworker.TabStop = true;
            this.rbtnDepotworker.Text = "Depot worker";
            this.rbtnDepotworker.UseVisualStyleBackColor = true;
            this.rbtnDepotworker.CheckedChanged += new System.EventHandler(this.rbtnDepotworker_CheckedChanged);
            // 
            // rbtnShopworker
            // 
            this.rbtnShopworker.AutoSize = true;
            this.rbtnShopworker.Location = new System.Drawing.Point(195, 114);
            this.rbtnShopworker.Name = "rbtnShopworker";
            this.rbtnShopworker.Size = new System.Drawing.Size(108, 21);
            this.rbtnShopworker.TabIndex = 9;
            this.rbtnShopworker.TabStop = true;
            this.rbtnShopworker.Text = "Shop worker";
            this.rbtnShopworker.UseVisualStyleBackColor = true;
            this.rbtnShopworker.CheckedChanged += new System.EventHandler(this.rbtnShopworker_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.label7.Location = new System.Drawing.Point(203, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(276, 46);
            this.label7.TabIndex = 17;
            this.label7.Text = "Manage shift";
            // 
            // pbxBack
            // 
            this.pbxBack.Image = ((System.Drawing.Image)(resources.GetObject("pbxBack.Image")));
            this.pbxBack.Location = new System.Drawing.Point(12, 12);
            this.pbxBack.Name = "pbxBack";
            this.pbxBack.Size = new System.Drawing.Size(64, 64);
            this.pbxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxBack.TabIndex = 97;
            this.pbxBack.TabStop = false;
            this.pbxBack.Click += new System.EventHandler(this.pbxBack_Click);
            // 
            // ManageShifts
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(917, 534);
            this.Controls.Add(this.pbxBack);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gbxAssign);
            this.Controls.Add(this.gbxDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageShifts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManageShifts";
            this.gbxDetails.ResumeLayout(false);
            this.gbxDetails.PerformLayout();
            this.gbxAssign.ResumeLayout(false);
            this.gbxAssign.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDetails;
        private System.Windows.Forms.Label lblShopCount;
        private System.Windows.Forms.GroupBox gbxAssign;
        private System.Windows.Forms.ListBox lbxDepotworkers;
        private System.Windows.Forms.RadioButton rbtnDetailsEvening;
        private System.Windows.Forms.RadioButton rbtnDetailsAfternoon;
        private System.Windows.Forms.RadioButton rbtnDetailsMorning;
        private System.Windows.Forms.ListBox lbxShopworkers;
        private System.Windows.Forms.Label lblDepotCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxAssignEmployee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtnDepotworker;
        private System.Windows.Forms.RadioButton rbtnShopworker;
        private System.Windows.Forms.RadioButton rbtnAssignEvening;
        private System.Windows.Forms.RadioButton rbtnAssignAfternoon;
        private System.Windows.Forms.RadioButton rbtnAssignMorning;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpAssign;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbxBack;
        private FlatButton.JFlatButton btnAssignShift;
        private System.Windows.Forms.Label lblTotalCount;
        private FlatButton.JFlatButton RemoveBtn;
        private FlatButton.JFlatButton btnWriteToFile;
    }
}