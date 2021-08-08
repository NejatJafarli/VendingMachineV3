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

            productController3.MyProduct = new Product("Albeni", 0.70, 100, Properties.Resources.albeni);
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