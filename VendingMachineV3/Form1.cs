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
    public partial class Form1 : Form
    {
        static public double GlobalPrice { get; set; } = 0;
        public List<ProductController> ProductControllers { get; set; } = new List<ProductController>();
        public Form1()
        {
            InitializeComponent();
            productController1.MyProduct = new Product("Cola", 1, 100, Properties.Resources.Coca_Cola_Can_icon);
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
                var temp = Convert.ToDouble(txtPrice.Text);
                lblOutedPrice.Text = (temp - GlobalPrice).ToString();
                lblEnteredPrice.Text = txtPrice.Text;
            }
            else
            {
                lblOutedPrice.Text = "";
                lblEnteredPrice.Text = "";
            }
            ///////////////////////Burda biseyler var
            for (int i = 0; i < ProductControllers.Count; i++)
                if (ProductControllers[i].IsChecked)
                {
                    txtPrice.Enabled = true;
                    guna2CircleButton1.Enabled = true;
                    guna2CircleButton2.Enabled = true;
                    guna2CircleButton3.Enabled = true;
                    guna2CircleButton4.Enabled = true;
                    guna2CircleButton5.Enabled = true;
                    guna2CircleButton6.Enabled = true;
                    break;
                }
                else
                {
                    txtPrice.Enabled = false;
                    guna2CircleButton1.Enabled = false;
                    guna2CircleButton2.Enabled = false;
                    guna2CircleButton3.Enabled = false;
                    guna2CircleButton4.Enabled = false;
                    guna2CircleButton5.Enabled = false;
                    guna2CircleButton6.Enabled = false;
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
    }
}
//PdfPTable table = new PdfPTable(3)
//{
//    HorizontalAlignment = Left,
//    WidthPercentage = 100,
//};

//PdfPCell cell = new PdfPCell(new iTextSharp.text.Phrase("Vending Machine Info"))
//{
//    Colspan = 3,
//    HorizontalAlignment = 1, //left=0, centre=1, right=2
//    MinimumHeight = 30f
//};
//table.AddCell(cell);
//table.AddCell("Product Name");
//table.AddCell("Product Price");
//table.AddCell("Product Quanity");

//table.AddCell("Fanta");
//table.AddCell("1.60");
//table.AddCell("3");
//string path = $@"C:\Users\{Environment.UserName}\Documents\PDF File.pdf";
//iTextSharp.text.Document doc = new iTextSharp.text.Document();
//PdfWriter.GetInstance(doc, new FileStream(path, FileMode.OpenOrCreate));
//doc.Open();
//doc.Add(table);
//doc.Close();


//Process.Start(path);