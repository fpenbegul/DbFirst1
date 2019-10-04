using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Northwind007Entities db = new Northwind007Entities();

        private void Btn1_Click(object sender, EventArgs e)
        {   // fiyatı 20 ile 50 arasında olan ürünlerin id,ürün adı, fiyatı, stok miktarı ve kategoriAdı'nı listeleyiniz...

            /*
              select ProductID,ProductName,UnitPrice,UnitsInStock,cat.CategoryName from Products p
                    join Categories cat on cat.CategoryID=p.CategoryID where UnitPrice between 20 and 50 order by UnitPrice desc

             */


            // LİNQ Sorguları:
            // 1. YoL  --> LİNQ to entities
            dgvSonuclar.DataSource = db.Products.Where(x => x.UnitPrice >= 20 && x.UnitPrice <= 50)
                .OrderByDescending(x => x.UnitPrice).Select(x => new
                {
                    x.ProductID,
                    x.ProductName,
                    x.UnitPrice,
                    x.UnitsInStock,
                    x.Category.CategoryName
                }).ToList();


            // 2.YoL  --> LİNQ to Objects
            var result = from p in db.Products
                         where p.UnitPrice >= 20 && p.UnitPrice <= 50
                         orderby p.UnitPrice descending
                         select new { p.ProductID, p.ProductName, p.UnitPrice, p.UnitsInStock, p.Category.CategoryName };

            dgvSonuclar.DataSource = result.ToList();



        }

        private void Btn2_Click(object sender, EventArgs e)
        { // Siparişler tablosundan MusteriSirketAdi,CalisanAdiSoyadi, SiparisId, SiparisTarihi ve KargoSirketAdi bilgilerinin ilk 100 adedini takma
          // isimleriyle birlikte listeleyiniz...
          /* select top 100
	            cs.CompanyName as MusteriSirketAdi,
	            emp.FirstName + ' ' +emp.LastName as CalisanAdiSoyadi,
	            o.OrderID,
	            o.OrderDate,
	            sh.CompanyName
            from Orders o 
            join Shippers sh on o.ShipVia=sh.ShipperID
            join Customers cs on cs.CustomerID=o.CustomerID
            join Employees emp on emp.EmployeeID=o.EmployeeID

          */

            // LinQ Sorguları
            // 1. YoL
            dgvSonuclar.DataSource = db.Orders.Select(x => new
            {
                MusteriSirketAdi = x.Customer.CompanyName,
                CalisanAdiSoyadi = x.Employee.FirstName + " " + x.Employee.LastName,
                SiparisId = x.OrderID,
                SiparisTarihi = x.OrderDate,
                KargoSirketi = x.Shipper.CompanyName
            }).Take(100).ToList();


            // 2. YoL

            var result = from x in db.Orders
                         select new
                         {
                             MusteriSirketAdi = x.Customer.CompanyName,
                             CalisanAdiSoyadi = x.Employee.FirstName + " " + x.Employee.LastName,
                             SiparisId = x.OrderID,
                             SiparisTarihi = x.OrderDate,
                             KargoSirketi = x.Shipper.CompanyName

                         };
            dgvSonuclar.DataSource = result.Take(100).ToList();


        }

        private void Btn3_Click(object sender, EventArgs e)
        {   // CompanyName içerisinde restaurant geçen müşterileri listeleyiniz...

            //  select * from Customers where CompanyName like '%restaurant%'

            // 1. YoL
            dgvSonuclar.DataSource = db.Customers.Where(x => x.CompanyName.Contains("restaurant")).ToList();

            // 2. YoL
            var result = from c in db.Customers where c.CompanyName.Contains("restaurant") select c;

            dgvSonuclar.DataSource = result.ToList();




        }

        private void Btn4_Click(object sender, EventArgs e)
        {   // Kategorisi Beverages olan ve ürün adı Kola, ÜrünFiyatı 5 stok adedi 500 olan bir ürün ekleyiniz.

            //  int kategoriID = db.Categories.Where(x => x.CategoryName == "Beverages").FirstOrDefault().CategoryID;
            //  single()
            //  SingleOrDefault()
            //  First()
            //  FirstOrDefault()

            int kategoriID = db.Categories.FirstOrDefault(x => x.CategoryName == "Beverages").CategoryID;


            //Product p = new Product()
            //{
            //    CategoryID = kategoriID,
            //    ProductName = "Kola1",
            //    UnitPrice = 5,
            //    UnitsInStock = 500

            //};
            //db.Products.Add(p);



            ////  2.YoL 
            //db.Products.Add(new Product() { CategoryID = kategoriID, ProductName = "Kola2", UnitPrice = 5, UnitsInStock = 500 });


            // 3.YoL
            db.Categories.FirstOrDefault(x => x.CategoryName == "Bavereges").Products.Add(new Product() { ProductName = "Kola 3 ", UnitPrice = 5, UnitsInStock = 500 });

            db.SaveChanges();
            dgvSonuclar.DataSource = db.Products.Where(x => x.CategoryID == kategoriID && x.ProductName.StartsWith("k")).ToList();



        }

        private void Btn5_Click(object sender, EventArgs e)
        {   //  Her kategorinin stoktaki toplam ürün sayısını veren sorguyu yazınız.
            dgvSonuclar.DataSource = db.Products.GroupBy(p => p.Category.CategoryName).Select(g => new
            {
                KategoriAdi = g.Key,
                //Test=g.Max(u => u.UnitPrice),
                ToplamStok = g.Sum(p => p.UnitsInStock)
            }).ToList();


            // 2. YoL
            var result = from p in db.Products
                         group p by p.Category.CategoryName into g
                         select new
                         {
                             Kategori = g.Key,
                             ToplamStok = g.Sum(p => p.UnitsInStock)
                         };
            dgvSonuclar.DataSource = result.ToList();





        }

        private void Btn6_Click(object sender, EventArgs e)
        { // Calisanaların isim soyisim doğumtarihi ve yaşlıların datediff kullanarak listeleyiniz..
            dgvSonuclar.DataSource = db.Employees.Select(emp => new
            {
                emp.FirstName,
                emp.LastName,
                emp.BirthDate,
                Yas = SqlFunctions.DateDiff("year", emp.BirthDate, DateTime.Now)
            }).ToList();



            // 2. YoL
            var result = from x in db.Employees
                         select new
                         {
                             x.FirstName,
                             x.LastName,
                             x.BirthDate,
                             Yas = SqlFunctions.DateDiff("year", x.BirthDate, DateTime.Now)

                         };
            dgvSonuclar.DataSource = result.ToList();



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
