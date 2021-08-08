using Guna.UI2.WinForms;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachineV3
{
    public partial class Form1 : Form
    {
        static public double GlobalPrice { get; set; } = 0;
        public List<ProductController> ProductControllers { get; set; } = new List<ProductController>();
        public Form1()
        {
            InitializeComponent();
            productController1.MyProduct = new Product("Cola", 1, 150, Properties.Resources.Coca_Cola_Can_icon);
            productController1.LoadProduct();
            ProductControllers.Add(productController1);

            productController2.MyProduct = new Product("Lipton Ice Tea", 0.90, 100, Properties.Resources.lipton);
            productController2.LoadProduct();
            ProductControllers.Add(productController2);

            productController3.MyProduct = new Product("Albeni", 0.70, 100, Properties.Resources.ulker_albeni_40_gr_x_24_adet_7033370015091083262);
            productController3.LoadProduct();
            ProductControllers.Add(productController3);

            productController4.MyProduct = new Product("Fanta", 1, 100, Properties.Resources.uploads_fanta_fanta_PNG17);
            productController4.LoadProduct();
            ProductControllers.Add(productController4);

            productController5.MyProduct = new Product("Pepsi", 1, 100, Properties.Resources._96_966028_pepsi_transparent_pepsi_can_png_png_download);
            productController5.LoadProduct();
            ProductControllers.Add(productController5);

            productController6.MyProduct = new Product("Twix", 1, 100, Properties.Resources._167_1678649_mars_twix_chocolate_bar_5_pcs);
            productController6.LoadProduct();
            ProductControllers.Add(productController6);

            productController7.MyProduct = new Product("Snickers", 1, 100, Properties.Resources.snickers_PNG98761);
            productController7.LoadProduct();
            ProductControllers.Add(productController7);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                var temp = double.Parse(txtPrice.Text);
                var num1 = (int)GlobalPrice;
                var num2 = (int)((GlobalPrice - num1)*10);
                double numbertemp = (double)num2 / 10;
                double Number1 = (double)num1 + numbertemp;

                double num3 = temp - Number1;
                var num4 = (int)num3;
                var num5 = (int)((num3 - num4)*10);

                lblOutedPrice.Text = $"{(double)((double)num4+((double)num5/10))}";
                lblEnteredPrice.Text = txtPrice.Text;
            }
            else
            {
                lblOutedPrice.Text = "";
                lblEnteredPrice.Text = "";
            }
        }

        bool LookTxt(in Guna2TextBox txt)
        {
            if (!string.IsNullOrWhiteSpace(txt.Text))
                if (txt.Text[0] == '.' || txt.Text[0] == ',')
                {
                    txt.Clear();
                    return false;
                }
            return true;
        }


        void TxtTextChanged(ref Guna.UI2.WinForms.Guna2TextBox Text1)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(Text1.Text))
                {
                    var temp = Convert.ToDouble(Text1.Text);

                }
            }
            catch
            {
                Text1.Text = Text1.Text.Substring(0, Text1.Text.Length - 1); ;
                Text1.SelectionStart = Text1.Text.Length;
            }
        }
        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {

            }
            if (LookTxt(txtPrice))
            {
                txtPrice.Text = txtPrice.Text.Replace('.', ',');
                txtPrice.SelectionStart = txtPrice.Text.Length;
                TxtTextChanged(ref txtPrice);
            }
        }


        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPrice.Text))

                txtPrice.Text = $"{Convert.ToDouble(txtPrice.Text) + 0.20}";
            else
                txtPrice.Text = $"{0.2}";
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPrice.Text))
                txtPrice.Text = $"{Convert.ToDouble(txtPrice.Text) + 0.50}";
            else
                txtPrice.Text = $"{0.5}";

        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPrice.Text))
                txtPrice.Text = $"{Convert.ToDouble(txtPrice.Text) + 1}";
            else
                txtPrice.Text = $"{1}";

        }

        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPrice.Text))
                txtPrice.Text = $"{Convert.ToDouble(txtPrice.Text) + 5}";
            else
                txtPrice.Text = $"{5}";

        }

        private void guna2CircleButton6_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPrice.Text))
                txtPrice.Text = $"{Convert.ToDouble(txtPrice.Text) + 10}";
            else
                txtPrice.Text = $"{10}";
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPrice.Text))
                txtPrice.Text = $"{Convert.ToDouble(txtPrice.Text) + 0.10}";
            else
                txtPrice.Text = $"{0.10}";

        }

        private void btnSavePDF_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(lblOutedPrice.Text))
                if (lblOutedPrice.Text[0] != '-')
                {
                    PdfPTable table = new PdfPTable(3)
                    {
                        HorizontalAlignment = Left,
                        WidthPercentage = 100,
                    };

                    PdfPCell cell = new PdfPCell(new iTextSharp.text.Phrase("Vending Machine Info"))
                    {
                        Colspan = 3,
                        HorizontalAlignment = 1,
                        MinimumHeight = 30f
                    };
                    PdfPCell cell2 = new PdfPCell(new iTextSharp.text.Phrase($"Total:{GlobalPrice}$\nDaxil Edilen Mebleg:{txtPrice.Text}$\nQaliq:{lblOutedPrice.Text}$"))
                    {
                        Colspan = 3,
                        HorizontalAlignment = 2,
                        MinimumHeight = 30f
                    };
                    table.AddCell(cell);
                    table.AddCell("Product Name");
                    table.AddCell("Product Quanity");
                    table.AddCell("Product Price");
                    for (int i = 0; i < ProductControllers.Count; i++)
                    {
                        if (ProductControllers[i].IsChecked && ProductControllers[i].ProductQuanity.Value > 0)
                        {
                            table.AddCell(ProductControllers[i].MyProduct.ProductName);
                            table.AddCell(ProductControllers[i].ProductQuanity.Value.ToString());
                            table.AddCell($"{ProductControllers[i].SummedPrice}$");
                        }
                    }
                    table.AddCell(cell2);
                    string path = $@"C:\Users\{Environment.UserName}\Documents\PDF File.pdf";
                    iTextSharp.text.Document doc = new iTextSharp.text.Document();

                    PdfWriter.GetInstance(doc, new FileStream(path, FileMode.OpenOrCreate));
                    doc.Open();
                    doc.Add(table);
                    doc.Close();

                    Process.Start(path);
                }
                else
                {
                    MessageBox.Show("Your Entered Money Not Enough");
                }
        }
    }
}


