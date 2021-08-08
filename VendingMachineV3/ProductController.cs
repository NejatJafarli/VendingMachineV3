using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachineV3
{
    public partial class ProductController : UserControl
    {
        public ProductController()
        {
            InitializeComponent();
        }
        public double SummedPrice { get; set; } = 0;
        public int OldValue { get; set; } = 0;
        void TxtChangePrice(ref Guna.UI2.WinForms.Guna2NumericUpDown Num, ref Guna.UI2.WinForms.Guna2TextBox Text2, double price)
        {
            var temp = (int)Num.Value;
            label1.Text = $"{MyProduct.ProductQuanity - temp}";
            if (temp == 0)
                Text2.Text = $"{1 * price}";
            else
                Text2.Text = $"{temp * price}";
            SummedPrice = temp * price;
            if (OldValue < temp)
                Form1.GlobalPrice += (temp - OldValue) * price;
            else
                Form1.GlobalPrice -= (OldValue - temp) * price;

            OldValue = temp;
        }
        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        }
        public Product MyProduct { get; set; }
        private void ProductUserControl_Load(object sender, EventArgs e)
        {

        }
        public void LoadProduct()
        {
            label1.Text = MyProduct.ProductQuanity.ToString();
            Checkbox.Text = MyProduct.ProductName;
            txtPrice.Text = MyProduct.ProductPrice.ToString();
            ProductQuanity.Maximum = MyProduct.ProductQuanity;
            guna2PictureBox1.Image = MyProduct.Image;
        }

        private void ProductController_Load(object sender, EventArgs e)
        {

        }

        private void ProductQuanity_ValueChanged(object sender, EventArgs e)
        {
            TxtChangePrice(ref ProductQuanity, ref txtPrice, MyProduct.ProductPrice);
        }
        public bool IsChecked { get; set; } = false;
        private void Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Checkbox.Checked)
            {
                IsChecked = true;
                ProductQuanity.Value = ProductQuanity.Minimum + 1;
                ProductQuanity.Enabled = true;
            }
            else
            {
                ProductQuanity.Value = ProductQuanity.Minimum;
                ProductQuanity.Enabled = false;
                IsChecked = false;
            }
        }
    }
}
