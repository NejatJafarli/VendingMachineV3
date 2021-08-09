
namespace VendingMachineV3
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
            this.btnSavePDF = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton3 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton4 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton5 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton6 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEnteredPrice = new System.Windows.Forms.Label();
            this.lblOutedPrice = new System.Windows.Forms.Label();
            this.productController9 = new VendingMachineV3.ProductController();
            this.productController8 = new VendingMachineV3.ProductController();
            this.productController7 = new VendingMachineV3.ProductController();
            this.productController6 = new VendingMachineV3.ProductController();
            this.productController5 = new VendingMachineV3.ProductController();
            this.productController4 = new VendingMachineV3.ProductController();
            this.productController3 = new VendingMachineV3.ProductController();
            this.productController2 = new VendingMachineV3.ProductController();
            this.productController1 = new VendingMachineV3.ProductController();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSavePDF
            // 
            this.btnSavePDF.Animated = true;
            this.btnSavePDF.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(82)))), ((int)(((byte)(215)))));
            this.btnSavePDF.BorderRadius = 30;
            this.btnSavePDF.BorderThickness = 5;
            this.btnSavePDF.CheckedState.Parent = this.btnSavePDF;
            this.btnSavePDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSavePDF.CustomImages.Parent = this.btnSavePDF;
            this.btnSavePDF.FillColor = System.Drawing.Color.White;
            this.btnSavePDF.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnSavePDF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(82)))), ((int)(((byte)(215)))));
            this.btnSavePDF.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSavePDF.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSavePDF.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSavePDF.HoverState.Parent = this.btnSavePDF;
            this.btnSavePDF.Location = new System.Drawing.Point(549, 584);
            this.btnSavePDF.Name = "btnSavePDF";
            this.btnSavePDF.ShadowDecoration.Parent = this.btnSavePDF;
            this.btnSavePDF.Size = new System.Drawing.Size(360, 77);
            this.btnSavePDF.TabIndex = 28;
            this.btnSavePDF.Text = "Save PDF";
            this.btnSavePDF.Click += new System.EventHandler(this.btnSavePDF_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::VendingMachineV3.Properties.Resources.vending_machine_48px;
            this.guna2PictureBox1.Location = new System.Drawing.Point(14, -1);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(68, 65);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 34;
            this.guna2PictureBox1.TabStop = false;
            // 
            // txtPrice
            // 
            this.txtPrice.Animated = true;
            this.txtPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(82)))), ((int)(((byte)(215)))));
            this.txtPrice.BorderRadius = 5;
            this.txtPrice.BorderThickness = 3;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "0";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.Parent = this.txtPrice;
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.FocusedState.Parent = this.txtPrice;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.HoverState.Parent = this.txtPrice;
            this.txtPrice.IconRight = global::VendingMachineV3.Properties.Resources.icons8_cash_app_48;
            this.txtPrice.IconRightSize = new System.Drawing.Size(30, 30);
            this.txtPrice.Location = new System.Drawing.Point(549, 85);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionStart = 1;
            this.txtPrice.ShadowDecoration.Parent = this.txtPrice;
            this.txtPrice.Size = new System.Drawing.Size(360, 55);
            this.txtPrice.TabIndex = 27;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // guna2CircleButton2
            // 
            this.guna2CircleButton2.Animated = true;
            this.guna2CircleButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(82)))), ((int)(((byte)(215)))));
            this.guna2CircleButton2.BorderRadius = 30;
            this.guna2CircleButton2.BorderThickness = 5;
            this.guna2CircleButton2.CheckedState.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CircleButton2.CustomImages.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.FillColor = System.Drawing.Color.White;
            this.guna2CircleButton2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CircleButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(82)))), ((int)(((byte)(215)))));
            this.guna2CircleButton2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2CircleButton2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2CircleButton2.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton2.HoverState.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.Location = new System.Drawing.Point(679, 161);
            this.guna2CircleButton2.Margin = new System.Windows.Forms.Padding(15);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.ShadowDecoration.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.Size = new System.Drawing.Size(100, 100);
            this.guna2CircleButton2.TabIndex = 35;
            this.guna2CircleButton2.Text = "20 q";
            this.guna2CircleButton2.Click += new System.EventHandler(this.guna2CircleButton2_Click);
            // 
            // guna2CircleButton3
            // 
            this.guna2CircleButton3.Animated = true;
            this.guna2CircleButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(82)))), ((int)(((byte)(215)))));
            this.guna2CircleButton3.BorderRadius = 30;
            this.guna2CircleButton3.BorderThickness = 5;
            this.guna2CircleButton3.CheckedState.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CircleButton3.CustomImages.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.FillColor = System.Drawing.Color.White;
            this.guna2CircleButton3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CircleButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(82)))), ((int)(((byte)(215)))));
            this.guna2CircleButton3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2CircleButton3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2CircleButton3.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton3.HoverState.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.Location = new System.Drawing.Point(809, 161);
            this.guna2CircleButton3.Margin = new System.Windows.Forms.Padding(15);
            this.guna2CircleButton3.Name = "guna2CircleButton3";
            this.guna2CircleButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton3.ShadowDecoration.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.Size = new System.Drawing.Size(100, 100);
            this.guna2CircleButton3.TabIndex = 36;
            this.guna2CircleButton3.Text = "50 q";
            this.guna2CircleButton3.Click += new System.EventHandler(this.guna2CircleButton3_Click);
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.Animated = true;
            this.guna2CircleButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(82)))), ((int)(((byte)(215)))));
            this.guna2CircleButton1.BorderRadius = 30;
            this.guna2CircleButton1.BorderThickness = 5;
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(82)))), ((int)(((byte)(215)))));
            this.guna2CircleButton1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2CircleButton1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2CircleButton1.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Location = new System.Drawing.Point(549, 161);
            this.guna2CircleButton1.Margin = new System.Windows.Forms.Padding(15);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(100, 100);
            this.guna2CircleButton1.TabIndex = 37;
            this.guna2CircleButton1.Text = "10 q";
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // guna2CircleButton4
            // 
            this.guna2CircleButton4.Animated = true;
            this.guna2CircleButton4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(82)))), ((int)(((byte)(215)))));
            this.guna2CircleButton4.BorderRadius = 30;
            this.guna2CircleButton4.BorderThickness = 5;
            this.guna2CircleButton4.CheckedState.Parent = this.guna2CircleButton4;
            this.guna2CircleButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CircleButton4.CustomImages.Parent = this.guna2CircleButton4;
            this.guna2CircleButton4.FillColor = System.Drawing.Color.White;
            this.guna2CircleButton4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CircleButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(82)))), ((int)(((byte)(215)))));
            this.guna2CircleButton4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2CircleButton4.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2CircleButton4.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton4.HoverState.Parent = this.guna2CircleButton4;
            this.guna2CircleButton4.Location = new System.Drawing.Point(549, 291);
            this.guna2CircleButton4.Margin = new System.Windows.Forms.Padding(15);
            this.guna2CircleButton4.Name = "guna2CircleButton4";
            this.guna2CircleButton4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton4.ShadowDecoration.Parent = this.guna2CircleButton4;
            this.guna2CircleButton4.Size = new System.Drawing.Size(100, 100);
            this.guna2CircleButton4.TabIndex = 38;
            this.guna2CircleButton4.Text = "1 AZN";
            this.guna2CircleButton4.Click += new System.EventHandler(this.guna2CircleButton4_Click);
            // 
            // guna2CircleButton5
            // 
            this.guna2CircleButton5.Animated = true;
            this.guna2CircleButton5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(82)))), ((int)(((byte)(215)))));
            this.guna2CircleButton5.BorderRadius = 30;
            this.guna2CircleButton5.BorderThickness = 5;
            this.guna2CircleButton5.CheckedState.Parent = this.guna2CircleButton5;
            this.guna2CircleButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CircleButton5.CustomImages.Parent = this.guna2CircleButton5;
            this.guna2CircleButton5.FillColor = System.Drawing.Color.White;
            this.guna2CircleButton5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CircleButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(82)))), ((int)(((byte)(215)))));
            this.guna2CircleButton5.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2CircleButton5.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2CircleButton5.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton5.HoverState.Parent = this.guna2CircleButton5;
            this.guna2CircleButton5.Location = new System.Drawing.Point(679, 291);
            this.guna2CircleButton5.Margin = new System.Windows.Forms.Padding(15);
            this.guna2CircleButton5.Name = "guna2CircleButton5";
            this.guna2CircleButton5.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton5.ShadowDecoration.Parent = this.guna2CircleButton5;
            this.guna2CircleButton5.Size = new System.Drawing.Size(100, 100);
            this.guna2CircleButton5.TabIndex = 39;
            this.guna2CircleButton5.Text = "5 AZN";
            this.guna2CircleButton5.Click += new System.EventHandler(this.guna2CircleButton5_Click);
            // 
            // guna2CircleButton6
            // 
            this.guna2CircleButton6.Animated = true;
            this.guna2CircleButton6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(82)))), ((int)(((byte)(215)))));
            this.guna2CircleButton6.BorderRadius = 30;
            this.guna2CircleButton6.BorderThickness = 5;
            this.guna2CircleButton6.CheckedState.Parent = this.guna2CircleButton6;
            this.guna2CircleButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CircleButton6.CustomImages.Parent = this.guna2CircleButton6;
            this.guna2CircleButton6.FillColor = System.Drawing.Color.White;
            this.guna2CircleButton6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CircleButton6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(82)))), ((int)(((byte)(215)))));
            this.guna2CircleButton6.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2CircleButton6.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2CircleButton6.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton6.HoverState.Parent = this.guna2CircleButton6;
            this.guna2CircleButton6.Location = new System.Drawing.Point(809, 291);
            this.guna2CircleButton6.Margin = new System.Windows.Forms.Padding(15);
            this.guna2CircleButton6.Name = "guna2CircleButton6";
            this.guna2CircleButton6.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton6.ShadowDecoration.Parent = this.guna2CircleButton6;
            this.guna2CircleButton6.Size = new System.Drawing.Size(100, 100);
            this.guna2CircleButton6.TabIndex = 40;
            this.guna2CircleButton6.Text = "10 AZN";
            this.guna2CircleButton6.Click += new System.EventHandler(this.guna2CircleButton6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(544, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 29);
            this.label1.TabIndex = 41;
            this.label1.Text = "Daxil Edilmis Mebleg:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(544, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 29);
            this.label2.TabIndex = 42;
            this.label2.Text = "Qaliq:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnteredPrice
            // 
            this.lblEnteredPrice.AutoSize = true;
            this.lblEnteredPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnteredPrice.Location = new System.Drawing.Point(804, 430);
            this.lblEnteredPrice.Name = "lblEnteredPrice";
            this.lblEnteredPrice.Size = new System.Drawing.Size(27, 29);
            this.lblEnteredPrice.TabIndex = 43;
            this.lblEnteredPrice.Text = "0";
            this.lblEnteredPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutedPrice
            // 
            this.lblOutedPrice.AutoSize = true;
            this.lblOutedPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutedPrice.Location = new System.Drawing.Point(622, 478);
            this.lblOutedPrice.Name = "lblOutedPrice";
            this.lblOutedPrice.Size = new System.Drawing.Size(27, 29);
            this.lblOutedPrice.TabIndex = 44;
            this.lblOutedPrice.Text = "0";
            this.lblOutedPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productController9
            // 
            this.productController9.IsChecked = false;
            this.productController9.Location = new System.Drawing.Point(356, 459);
            this.productController9.MyProduct = null;
            this.productController9.Name = "productController9";
            this.productController9.OldValue = 0;
            this.productController9.Size = new System.Drawing.Size(175, 202);
            this.productController9.SummedPrice = 0D;
            this.productController9.TabIndex = 12;
            // 
            // productController8
            // 
            this.productController8.IsChecked = false;
            this.productController8.Location = new System.Drawing.Point(184, 459);
            this.productController8.MyProduct = null;
            this.productController8.Name = "productController8";
            this.productController8.OldValue = 0;
            this.productController8.Size = new System.Drawing.Size(175, 202);
            this.productController8.SummedPrice = 0D;
            this.productController8.TabIndex = 11;
            // 
            // productController7
            // 
            this.productController7.IsChecked = false;
            this.productController7.Location = new System.Drawing.Point(14, 459);
            this.productController7.MyProduct = null;
            this.productController7.Name = "productController7";
            this.productController7.OldValue = 0;
            this.productController7.Size = new System.Drawing.Size(175, 202);
            this.productController7.SummedPrice = 0D;
            this.productController7.TabIndex = 10;
            // 
            // productController6
            // 
            this.productController6.IsChecked = false;
            this.productController6.Location = new System.Drawing.Point(356, 257);
            this.productController6.MyProduct = null;
            this.productController6.Name = "productController6";
            this.productController6.OldValue = 0;
            this.productController6.Size = new System.Drawing.Size(175, 202);
            this.productController6.SummedPrice = 0D;
            this.productController6.TabIndex = 9;
            // 
            // productController5
            // 
            this.productController5.IsChecked = false;
            this.productController5.Location = new System.Drawing.Point(184, 257);
            this.productController5.MyProduct = null;
            this.productController5.Name = "productController5";
            this.productController5.OldValue = 0;
            this.productController5.Size = new System.Drawing.Size(175, 202);
            this.productController5.SummedPrice = 0D;
            this.productController5.TabIndex = 8;
            // 
            // productController4
            // 
            this.productController4.IsChecked = false;
            this.productController4.Location = new System.Drawing.Point(14, 257);
            this.productController4.MyProduct = null;
            this.productController4.Name = "productController4";
            this.productController4.OldValue = 0;
            this.productController4.Size = new System.Drawing.Size(175, 202);
            this.productController4.SummedPrice = 0D;
            this.productController4.TabIndex = 7;
            // 
            // productController3
            // 
            this.productController3.IsChecked = false;
            this.productController3.Location = new System.Drawing.Point(356, 59);
            this.productController3.MyProduct = null;
            this.productController3.Name = "productController3";
            this.productController3.OldValue = 0;
            this.productController3.Size = new System.Drawing.Size(175, 202);
            this.productController3.SummedPrice = 0D;
            this.productController3.TabIndex = 6;
            // 
            // productController2
            // 
            this.productController2.IsChecked = false;
            this.productController2.Location = new System.Drawing.Point(184, 59);
            this.productController2.MyProduct = null;
            this.productController2.Name = "productController2";
            this.productController2.OldValue = 0;
            this.productController2.Size = new System.Drawing.Size(175, 202);
            this.productController2.SummedPrice = 0D;
            this.productController2.TabIndex = 5;
            // 
            // productController1
            // 
            this.productController1.IsChecked = false;
            this.productController1.Location = new System.Drawing.Point(12, 59);
            this.productController1.MyProduct = null;
            this.productController1.Name = "productController1";
            this.productController1.OldValue = 0;
            this.productController1.Size = new System.Drawing.Size(175, 202);
            this.productController1.SummedPrice = 0D;
            this.productController1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(936, 702);
            this.Controls.Add(this.lblOutedPrice);
            this.Controls.Add(this.lblEnteredPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2CircleButton6);
            this.Controls.Add(this.guna2CircleButton5);
            this.Controls.Add(this.guna2CircleButton4);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.guna2CircleButton3);
            this.Controls.Add(this.guna2CircleButton2);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.btnSavePDF);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.productController9);
            this.Controls.Add(this.productController8);
            this.Controls.Add(this.productController7);
            this.Controls.Add(this.productController6);
            this.Controls.Add(this.productController5);
            this.Controls.Add(this.productController4);
            this.Controls.Add(this.productController3);
            this.Controls.Add(this.productController2);
            this.Controls.Add(this.productController1);
            this.MaximumSize = new System.Drawing.Size(952, 741);
            this.MinimumSize = new System.Drawing.Size(952, 741);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ProductController productController1;
        private ProductController productController2;
        private ProductController productController3;
        private ProductController productController4;
        private ProductController productController5;
        private ProductController productController6;
        private ProductController productController7;
        private ProductController productController8;
        private ProductController productController9;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2Button btnSavePDF;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton3;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton4;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton5;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEnteredPrice;
        private System.Windows.Forms.Label lblOutedPrice;
    }
}

