
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
            this.btnCalculate = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.productController9 = new VendingMachineV3.ProductController();
            this.productController8 = new VendingMachineV3.ProductController();
            this.productController7 = new VendingMachineV3.ProductController();
            this.productController6 = new VendingMachineV3.ProductController();
            this.productController5 = new VendingMachineV3.ProductController();
            this.productController4 = new VendingMachineV3.ProductController();
            this.productController3 = new VendingMachineV3.ProductController();
            this.productController2 = new VendingMachineV3.ProductController();
            this.productController1 = new VendingMachineV3.ProductController();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Animated = true;
            this.btnCalculate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(82)))), ((int)(((byte)(215)))));
            this.btnCalculate.BorderRadius = 30;
            this.btnCalculate.BorderThickness = 5;
            this.btnCalculate.CheckedState.Parent = this.btnCalculate;
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.CustomImages.Parent = this.btnCalculate;
            this.btnCalculate.FillColor = System.Drawing.Color.White;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(82)))), ((int)(((byte)(215)))));
            this.btnCalculate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnCalculate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnCalculate.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.HoverState.Parent = this.btnCalculate;
            this.btnCalculate.Location = new System.Drawing.Point(685, 286);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.ShadowDecoration.Parent = this.btnCalculate;
            this.btnCalculate.Size = new System.Drawing.Size(293, 77);
            this.btnCalculate.TabIndex = 28;
            this.btnCalculate.Text = "Calculate";
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(82)))), ((int)(((byte)(215)))));
            this.guna2CircleButton1.BorderRadius = 30;
            this.guna2CircleButton1.BorderThickness = 5;
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(82)))), ((int)(((byte)(215)))));
            this.guna2CircleButton1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2CircleButton1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2CircleButton1.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Location = new System.Drawing.Point(555, 126);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(100, 100);
            this.guna2CircleButton1.TabIndex = 29;
            this.guna2CircleButton1.Text = "20 q";
            // 
            // productController9
            // 
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
            this.productController1.Location = new System.Drawing.Point(12, 59);
            this.productController1.MyProduct = null;
            this.productController1.Name = "productController1";
            this.productController1.OldValue = 0;
            this.productController1.Size = new System.Drawing.Size(175, 202);
            this.productController1.SummedPrice = 0D;
            this.productController1.TabIndex = 4;
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
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.Parent = this.txtPrice;
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.FocusedState.Parent = this.txtPrice;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.HoverState.Parent = this.txtPrice;
            this.txtPrice.IconRight = global::VendingMachineV3.Properties.Resources.icons8_cash_app_48;
            this.txtPrice.IconRightSize = new System.Drawing.Size(30, 30);
            this.txtPrice.Location = new System.Drawing.Point(657, 48);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.SelectedText = "";
            this.txtPrice.ShadowDecoration.Parent = this.txtPrice;
            this.txtPrice.Size = new System.Drawing.Size(301, 33);
            this.txtPrice.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1150, 662);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.btnCalculate);
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
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

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
        private Guna.UI2.WinForms.Guna2Button btnCalculate;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}

