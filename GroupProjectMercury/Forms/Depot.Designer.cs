namespace GroupProjectMercury.Forms
{
    partial class Depot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Depot));
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbxSearchBy = new System.Windows.Forms.GroupBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new FlatButton.JFlatButton();
            this.cbPrice = new System.Windows.Forms.CheckBox();
            this.cbQuantity = new System.Windows.Forms.CheckBox();
            this.cbSpecifications = new System.Windows.Forms.CheckBox();
            this.cbBrand = new System.Windows.Forms.CheckBox();
            this.cbType = new System.Windows.Forms.CheckBox();
            this.cbProduct = new System.Windows.Forms.CheckBox();
            this.cbId = new System.Windows.Forms.CheckBox();
            this.tbxProductType = new JMaterialTextbox.JMaterialTextbox();
            this.tbxProductBrand = new JMaterialTextbox.JMaterialTextbox();
            this.bttAddProd = new FlatButton.JFlatButton();
            this.gbxEditProduct = new System.Windows.Forms.GroupBox();
            this.btnRestockProduct = new FlatButton.JFlatButton();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.btnSellUnits = new FlatButton.JFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxAddProduct = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.tbxProduct = new JMaterialTextbox.JMaterialTextbox();
            this.tbxShelfNumber = new JMaterialTextbox.JMaterialTextbox();
            this.tbxSpecifications = new JMaterialTextbox.JMaterialTextbox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.cbShelf = new System.Windows.Forms.CheckBox();
            this.gbxFilter = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new FlatButton.JFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDepot = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxSearchBy.SuspendLayout();
            this.gbxEditProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.gbxAddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.gbxFilter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.btnMinimize.Location = new System.Drawing.Point(1191, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(46, 40);
            this.btnMinimize.TabIndex = 19;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.btnClose.Location = new System.Drawing.Point(1237, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 40);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbxSearchBy
            // 
            this.gbxSearchBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(232)))));
            this.gbxSearchBy.Controls.Add(this.tbxSearch);
            this.gbxSearchBy.Controls.Add(this.btnSearch);
            this.gbxSearchBy.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            this.gbxSearchBy.Location = new System.Drawing.Point(779, 245);
            this.gbxSearchBy.Name = "gbxSearchBy";
            this.gbxSearchBy.Size = new System.Drawing.Size(478, 88);
            this.gbxSearchBy.TabIndex = 27;
            this.gbxSearchBy.TabStop = false;
            this.gbxSearchBy.Text = "Search by";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(16, 41);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(227, 28);
            this.tbxSearch.TabIndex = 26;
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
            this.btnSearch.Location = new System.Drawing.Point(250, 25);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnSearch.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnSearch.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnSearch.Size = new System.Drawing.Size(208, 53);
            this.btnSearch.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnSearch.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbPrice
            // 
            this.cbPrice.AutoSize = true;
            this.cbPrice.Location = new System.Drawing.Point(14, 199);
            this.cbPrice.Name = "cbPrice";
            this.cbPrice.Size = new System.Drawing.Size(73, 26);
            this.cbPrice.TabIndex = 46;
            this.cbPrice.Text = "Price";
            this.cbPrice.UseVisualStyleBackColor = true;
            this.cbPrice.CheckedChanged += new System.EventHandler(this.cbPrice_CheckedChanged);
            // 
            // cbQuantity
            // 
            this.cbQuantity.AutoSize = true;
            this.cbQuantity.Location = new System.Drawing.Point(14, 171);
            this.cbQuantity.Name = "cbQuantity";
            this.cbQuantity.Size = new System.Drawing.Size(106, 26);
            this.cbQuantity.TabIndex = 45;
            this.cbQuantity.Text = "Quantity";
            this.cbQuantity.UseVisualStyleBackColor = true;
            this.cbQuantity.CheckedChanged += new System.EventHandler(this.cbQuantity_CheckedChanged);
            // 
            // cbSpecifications
            // 
            this.cbSpecifications.AutoSize = true;
            this.cbSpecifications.Location = new System.Drawing.Point(14, 143);
            this.cbSpecifications.Name = "cbSpecifications";
            this.cbSpecifications.Size = new System.Drawing.Size(151, 26);
            this.cbSpecifications.TabIndex = 44;
            this.cbSpecifications.Text = "Specifications";
            this.cbSpecifications.UseVisualStyleBackColor = true;
            this.cbSpecifications.CheckedChanged += new System.EventHandler(this.cbSpecifications_CheckedChanged);
            // 
            // cbBrand
            // 
            this.cbBrand.AutoSize = true;
            this.cbBrand.Location = new System.Drawing.Point(14, 117);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(83, 26);
            this.cbBrand.TabIndex = 43;
            this.cbBrand.Text = "Brand";
            this.cbBrand.UseVisualStyleBackColor = true;
            this.cbBrand.CheckedChanged += new System.EventHandler(this.cbBrand_CheckedChanged);
            // 
            // cbType
            // 
            this.cbType.AutoSize = true;
            this.cbType.Location = new System.Drawing.Point(14, 90);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(73, 26);
            this.cbType.TabIndex = 42;
            this.cbType.Text = "Type";
            this.cbType.UseVisualStyleBackColor = true;
            this.cbType.CheckedChanged += new System.EventHandler(this.cbType_CheckedChanged);
            // 
            // cbProduct
            // 
            this.cbProduct.AutoSize = true;
            this.cbProduct.Location = new System.Drawing.Point(14, 62);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(97, 26);
            this.cbProduct.TabIndex = 41;
            this.cbProduct.Text = "Product";
            this.cbProduct.UseVisualStyleBackColor = true;
            this.cbProduct.CheckedChanged += new System.EventHandler(this.cbProduct_CheckedChanged);
            // 
            // cbId
            // 
            this.cbId.AutoSize = true;
            this.cbId.Location = new System.Drawing.Point(14, 34);
            this.cbId.Name = "cbId";
            this.cbId.Size = new System.Drawing.Size(51, 26);
            this.cbId.TabIndex = 40;
            this.cbId.Text = "Id";
            this.cbId.UseVisualStyleBackColor = true;
            this.cbId.CheckedChanged += new System.EventHandler(this.cbId_CheckedChanged);
            // 
            // tbxProductType
            // 
            this.tbxProductType.BackColor = System.Drawing.Color.Transparent;
            this.tbxProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbxProductType.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbxProductType.ForeColors = System.Drawing.Color.Black;
            this.tbxProductType.HintText = null;
            this.tbxProductType.IsPassword = false;
            this.tbxProductType.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxProductType.LineThickness = 2;
            this.tbxProductType.Location = new System.Drawing.Point(21, 76);
            this.tbxProductType.Margin = new System.Windows.Forms.Padding(4);
            this.tbxProductType.MaxLength = 32767;
            this.tbxProductType.Name = "tbxProductType";
            this.tbxProductType.OnFocusedColor = System.Drawing.Color.Black;
            this.tbxProductType.OnFocusedTextColor = System.Drawing.Color.Black;
            this.tbxProductType.ReadOnly = false;
            this.tbxProductType.Size = new System.Drawing.Size(247, 28);
            this.tbxProductType.TabIndex = 28;
            this.tbxProductType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxProductType.TextName = "Type";
            // 
            // tbxProductBrand
            // 
            this.tbxProductBrand.BackColor = System.Drawing.Color.Transparent;
            this.tbxProductBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbxProductBrand.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbxProductBrand.ForeColors = System.Drawing.Color.Black;
            this.tbxProductBrand.HintText = null;
            this.tbxProductBrand.IsPassword = false;
            this.tbxProductBrand.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxProductBrand.LineThickness = 2;
            this.tbxProductBrand.Location = new System.Drawing.Point(21, 122);
            this.tbxProductBrand.Margin = new System.Windows.Forms.Padding(5);
            this.tbxProductBrand.MaxLength = 32767;
            this.tbxProductBrand.Name = "tbxProductBrand";
            this.tbxProductBrand.OnFocusedColor = System.Drawing.Color.Black;
            this.tbxProductBrand.OnFocusedTextColor = System.Drawing.Color.Black;
            this.tbxProductBrand.ReadOnly = false;
            this.tbxProductBrand.Size = new System.Drawing.Size(247, 28);
            this.tbxProductBrand.TabIndex = 31;
            this.tbxProductBrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxProductBrand.TextName = "Brand";
            // 
            // bttAddProd
            // 
            this.bttAddProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttAddProd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttAddProd.ButtonText = "Add Product";
            this.bttAddProd.CausesValidation = false;
            this.bttAddProd.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("bttAddProd.ErrorImageLeft")));
            this.bttAddProd.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("bttAddProd.ErrorImageRight")));
            this.bttAddProd.FocusBackground = System.Drawing.Color.Gray;
            this.bttAddProd.FocusFontColor = System.Drawing.Color.White;
            this.bttAddProd.ForeColors = System.Drawing.Color.White;
            this.bttAddProd.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.bttAddProd.HoverFontColor = System.Drawing.Color.White;
            this.bttAddProd.ImageLeft = ((System.Drawing.Image)(resources.GetObject("bttAddProd.ImageLeft")));
            this.bttAddProd.ImageRight = null;
            this.bttAddProd.LeftPictureColor = System.Drawing.Color.Transparent;
            this.bttAddProd.Location = new System.Drawing.Point(277, 171);
            this.bttAddProd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttAddProd.Name = "bttAddProd";
            this.bttAddProd.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.bttAddProd.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.bttAddProd.RightPictureColor = System.Drawing.Color.Transparent;
            this.bttAddProd.Size = new System.Drawing.Size(230, 53);
            this.bttAddProd.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bttAddProd.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.bttAddProd.TabIndex = 32;
            this.bttAddProd.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // gbxEditProduct
            // 
            this.gbxEditProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(232)))));
            this.gbxEditProduct.Controls.Add(this.btnRestockProduct);
            this.gbxEditProduct.Controls.Add(this.nudAmount);
            this.gbxEditProduct.Controls.Add(this.btnSellUnits);
            this.gbxEditProduct.Controls.Add(this.label1);
            this.gbxEditProduct.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            this.gbxEditProduct.Location = new System.Drawing.Point(779, 99);
            this.gbxEditProduct.Name = "gbxEditProduct";
            this.gbxEditProduct.Size = new System.Drawing.Size(478, 140);
            this.gbxEditProduct.TabIndex = 34;
            this.gbxEditProduct.TabStop = false;
            this.gbxEditProduct.Text = "Edit Product";
            // 
            // btnRestockProduct
            // 
            this.btnRestockProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRestockProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRestockProduct.ButtonText = "Restock Product";
            this.btnRestockProduct.CausesValidation = false;
            this.btnRestockProduct.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnRestockProduct.ErrorImageLeft")));
            this.btnRestockProduct.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnRestockProduct.ErrorImageRight")));
            this.btnRestockProduct.FocusBackground = System.Drawing.Color.Gray;
            this.btnRestockProduct.FocusFontColor = System.Drawing.Color.White;
            this.btnRestockProduct.ForeColors = System.Drawing.Color.White;
            this.btnRestockProduct.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.btnRestockProduct.HoverFontColor = System.Drawing.Color.White;
            this.btnRestockProduct.ImageLeft = null;
            this.btnRestockProduct.ImageRight = null;
            this.btnRestockProduct.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnRestockProduct.Location = new System.Drawing.Point(226, 73);
            this.btnRestockProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRestockProduct.Name = "btnRestockProduct";
            this.btnRestockProduct.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnRestockProduct.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnRestockProduct.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnRestockProduct.Size = new System.Drawing.Size(238, 52);
            this.btnRestockProduct.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnRestockProduct.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnRestockProduct.TabIndex = 55;
            this.btnRestockProduct.Click += new System.EventHandler(this.btnRestockProduct_Click);
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(100, 33);
            this.nudAmount.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(120, 28);
            this.nudAmount.TabIndex = 20;
            // 
            // btnSellUnits
            // 
            this.btnSellUnits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSellUnits.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSellUnits.ButtonText = "Sell Units";
            this.btnSellUnits.CausesValidation = false;
            this.btnSellUnits.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnSellUnits.ErrorImageLeft")));
            this.btnSellUnits.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnSellUnits.ErrorImageRight")));
            this.btnSellUnits.FocusBackground = System.Drawing.Color.Gray;
            this.btnSellUnits.FocusFontColor = System.Drawing.Color.White;
            this.btnSellUnits.ForeColors = System.Drawing.Color.White;
            this.btnSellUnits.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.btnSellUnits.HoverFontColor = System.Drawing.Color.White;
            this.btnSellUnits.ImageLeft = null;
            this.btnSellUnits.ImageRight = null;
            this.btnSellUnits.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnSellUnits.Location = new System.Drawing.Point(226, 16);
            this.btnSellUnits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSellUnits.Name = "btnSellUnits";
            this.btnSellUnits.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnSellUnits.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnSellUnits.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnSellUnits.Size = new System.Drawing.Size(238, 49);
            this.btnSellUnits.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnSellUnits.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnSellUnits.TabIndex = 54;
            this.btnSellUnits.Click += new System.EventHandler(this.btnSellUnits_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Amount:";
            // 
            // gbxAddProduct
            // 
            this.gbxAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(232)))));
            this.gbxAddProduct.Controls.Add(this.label3);
            this.gbxAddProduct.Controls.Add(this.nudPrice);
            this.gbxAddProduct.Controls.Add(this.label2);
            this.gbxAddProduct.Controls.Add(this.nudQuantity);
            this.gbxAddProduct.Controls.Add(this.tbxProduct);
            this.gbxAddProduct.Controls.Add(this.tbxShelfNumber);
            this.gbxAddProduct.Controls.Add(this.tbxSpecifications);
            this.gbxAddProduct.Controls.Add(this.tbxProductType);
            this.gbxAddProduct.Controls.Add(this.tbxProductBrand);
            this.gbxAddProduct.Controls.Add(this.bttAddProd);
            this.gbxAddProduct.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            this.gbxAddProduct.Location = new System.Drawing.Point(258, 99);
            this.gbxAddProduct.Name = "gbxAddProduct";
            this.gbxAddProduct.Size = new System.Drawing.Size(515, 234);
            this.gbxAddProduct.TabIndex = 37;
            this.gbxAddProduct.TabStop = false;
            this.gbxAddProduct.Text = "Add product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 22);
            this.label3.TabIndex = 43;
            this.label3.Text = "Price";
            // 
            // nudPrice
            // 
            this.nudPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudPrice.Location = new System.Drawing.Point(299, 91);
            this.nudPrice.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(174, 28);
            this.nudPrice.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 41;
            this.label2.Text = "Quantity";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(299, 39);
            this.nudQuantity.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(174, 28);
            this.nudQuantity.TabIndex = 40;
            // 
            // tbxProduct
            // 
            this.tbxProduct.BackColor = System.Drawing.Color.Transparent;
            this.tbxProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbxProduct.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbxProduct.ForeColors = System.Drawing.Color.Black;
            this.tbxProduct.HintText = null;
            this.tbxProduct.IsPassword = false;
            this.tbxProduct.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxProduct.LineThickness = 2;
            this.tbxProduct.Location = new System.Drawing.Point(21, 40);
            this.tbxProduct.Margin = new System.Windows.Forms.Padding(4);
            this.tbxProduct.MaxLength = 32767;
            this.tbxProduct.Name = "tbxProduct";
            this.tbxProduct.OnFocusedColor = System.Drawing.Color.Black;
            this.tbxProduct.OnFocusedTextColor = System.Drawing.Color.Black;
            this.tbxProduct.ReadOnly = false;
            this.tbxProduct.Size = new System.Drawing.Size(247, 28);
            this.tbxProduct.TabIndex = 38;
            this.tbxProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxProduct.TextName = "Product";
            // 
            // tbxShelfNumber
            // 
            this.tbxShelfNumber.BackColor = System.Drawing.Color.Transparent;
            this.tbxShelfNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbxShelfNumber.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbxShelfNumber.ForeColors = System.Drawing.Color.Black;
            this.tbxShelfNumber.HintText = null;
            this.tbxShelfNumber.IsPassword = false;
            this.tbxShelfNumber.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxShelfNumber.LineThickness = 2;
            this.tbxShelfNumber.Location = new System.Drawing.Point(299, 127);
            this.tbxShelfNumber.Margin = new System.Windows.Forms.Padding(5);
            this.tbxShelfNumber.MaxLength = 32767;
            this.tbxShelfNumber.Name = "tbxShelfNumber";
            this.tbxShelfNumber.OnFocusedColor = System.Drawing.Color.Black;
            this.tbxShelfNumber.OnFocusedTextColor = System.Drawing.Color.Black;
            this.tbxShelfNumber.ReadOnly = false;
            this.tbxShelfNumber.Size = new System.Drawing.Size(174, 28);
            this.tbxShelfNumber.TabIndex = 37;
            this.tbxShelfNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxShelfNumber.TextName = "Shelf Number";
            // 
            // tbxSpecifications
            // 
            this.tbxSpecifications.BackColor = System.Drawing.Color.Transparent;
            this.tbxSpecifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbxSpecifications.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbxSpecifications.ForeColors = System.Drawing.Color.Black;
            this.tbxSpecifications.HintText = null;
            this.tbxSpecifications.IsPassword = false;
            this.tbxSpecifications.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxSpecifications.LineThickness = 2;
            this.tbxSpecifications.Location = new System.Drawing.Point(18, 160);
            this.tbxSpecifications.Margin = new System.Windows.Forms.Padding(5);
            this.tbxSpecifications.MaxLength = 32767;
            this.tbxSpecifications.Name = "tbxSpecifications";
            this.tbxSpecifications.OnFocusedColor = System.Drawing.Color.Black;
            this.tbxSpecifications.OnFocusedTextColor = System.Drawing.Color.Black;
            this.tbxSpecifications.ReadOnly = false;
            this.tbxSpecifications.Size = new System.Drawing.Size(250, 69);
            this.tbxSpecifications.TabIndex = 36;
            this.tbxSpecifications.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxSpecifications.TextName = "Specifications";
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(439, 347);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(818, 447);
            this.dgvProducts.TabIndex = 39;
            // 
            // cbShelf
            // 
            this.cbShelf.AutoSize = true;
            this.cbShelf.Location = new System.Drawing.Point(14, 227);
            this.cbShelf.Name = "cbShelf";
            this.cbShelf.Size = new System.Drawing.Size(149, 26);
            this.cbShelf.TabIndex = 47;
            this.cbShelf.Text = "Shelf number";
            this.cbShelf.UseVisualStyleBackColor = true;
            this.cbShelf.CheckedChanged += new System.EventHandler(this.cbShelf_CheckedChanged);
            // 
            // gbxFilter
            // 
            this.gbxFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(232)))));
            this.gbxFilter.Controls.Add(this.btnRefresh);
            this.gbxFilter.Controls.Add(this.cbShelf);
            this.gbxFilter.Controls.Add(this.cbProduct);
            this.gbxFilter.Controls.Add(this.cbId);
            this.gbxFilter.Controls.Add(this.cbPrice);
            this.gbxFilter.Controls.Add(this.cbType);
            this.gbxFilter.Controls.Add(this.cbBrand);
            this.gbxFilter.Controls.Add(this.cbQuantity);
            this.gbxFilter.Controls.Add(this.cbSpecifications);
            this.gbxFilter.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            this.gbxFilter.Location = new System.Drawing.Point(258, 347);
            this.gbxFilter.Name = "gbxFilter";
            this.gbxFilter.Size = new System.Drawing.Size(175, 447);
            this.gbxFilter.TabIndex = 48;
            this.gbxFilter.TabStop = false;
            this.gbxFilter.Text = "Filter info";
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
            this.btnRefresh.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.btnRefresh.HoverFontColor = System.Drawing.Color.White;
            this.btnRefresh.ImageLeft = null;
            this.btnRefresh.ImageRight = null;
            this.btnRefresh.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Location = new System.Drawing.Point(14, 273);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnRefresh.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnRefresh.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Size = new System.Drawing.Size(149, 53);
            this.btnRefresh.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnRefresh.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnRefresh.TabIndex = 48;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnDepot);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(255, 825);
            this.panel1.MinimumSize = new System.Drawing.Size(220, 761);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 825);
            this.panel1.TabIndex = 49;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(3, 754);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(193, 40);
            this.btnLogout.TabIndex = 35;
            this.btnLogout.Text = "X Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
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
            this.btnDepot.Click += new System.EventHandler(this.btnDepot_Click_1);
            // 
            // btnProfile
            // 
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(3, 318);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(249, 67);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click_1);
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
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click_1);
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
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(475, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 46);
            this.label4.TabIndex = 53;
            this.label4.Text = "Depot";
            // 
            // Depot
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1284, 825);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbxFilter);
            this.Controls.Add(this.gbxEditProduct);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.gbxAddProduct);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbxSearchBy);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Depot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depot";
            this.gbxSearchBy.ResumeLayout(false);
            this.gbxSearchBy.PerformLayout();
            this.gbxEditProduct.ResumeLayout(false);
            this.gbxEditProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.gbxAddProduct.ResumeLayout(false);
            this.gbxAddProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.gbxFilter.ResumeLayout(false);
            this.gbxFilter.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbxSearchBy;
        private System.Windows.Forms.TextBox tbxSearch;
        private FlatButton.JFlatButton btnSearch;
        private JMaterialTextbox.JMaterialTextbox tbxProductType;
        private JMaterialTextbox.JMaterialTextbox tbxProductBrand;
        private FlatButton.JFlatButton bttAddProd;
        private System.Windows.Forms.GroupBox gbxEditProduct;
        private System.Windows.Forms.GroupBox gbxAddProduct;
        private JMaterialTextbox.JMaterialTextbox tbxShelfNumber;
        private JMaterialTextbox.JMaterialTextbox tbxSpecifications;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProducts;
        private JMaterialTextbox.JMaterialTextbox tbxProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.CheckBox cbPrice;
        private System.Windows.Forms.CheckBox cbQuantity;
        private System.Windows.Forms.CheckBox cbSpecifications;
        private System.Windows.Forms.CheckBox cbBrand;
        private System.Windows.Forms.CheckBox cbType;
        private System.Windows.Forms.CheckBox cbProduct;
        private System.Windows.Forms.CheckBox cbId;
        private System.Windows.Forms.CheckBox cbShelf;
        private System.Windows.Forms.GroupBox gbxFilter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDepot;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label label4;
        private FlatButton.JFlatButton btnRefresh;
        private FlatButton.JFlatButton btnSellUnits;
        private FlatButton.JFlatButton btnRestockProduct;
    }
}