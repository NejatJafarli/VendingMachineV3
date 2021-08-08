
namespace VendingMachineV3
{
    partial class Controller
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Radiobtn = new Guna.UI2.WinForms.Guna2RadioButton();
            this.SuspendLayout();
            // 
            // Radiobtn
            // 
            this.Radiobtn.Animated = true;
            this.Radiobtn.AutoSize = true;
            this.Radiobtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.Radiobtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(82)))), ((int)(((byte)(215)))));
            this.Radiobtn.CheckedState.BorderThickness = 0;
            this.Radiobtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(82)))), ((int)(((byte)(215)))));
            this.Radiobtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Radiobtn.CheckedState.InnerOffset = -4;
            this.Radiobtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Radiobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radiobtn.Location = new System.Drawing.Point(95, 73);
            this.Radiobtn.Name = "Radiobtn";
            this.Radiobtn.Size = new System.Drawing.Size(92, 24);
            this.Radiobtn.TabIndex = 29;
            this.Radiobtn.Text = "No Stock";
            this.Radiobtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Radiobtn.UncheckedState.BorderThickness = 2;
            this.Radiobtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Radiobtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // Controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Radiobtn);
            this.Name = "Controller";
            this.Size = new System.Drawing.Size(323, 248);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2RadioButton Radiobtn;
    }
}
