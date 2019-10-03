using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            db = new Northwind007Entities();

            dgvListe.DataSource = db.Customers.ToList(); // select * from custormers



        }


        Northwind007Entities db;

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                CustomerID = "AAAAA",
                CompanyName = "Adsız Yazılımcılar Derneği",
            };

            db.Customers.Add(customer); // insert into customers....
            db.SaveChanges();           // tüm değişiklileri database'e işler.
            dgvListe.DataSource = db.Customers.ToList();

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            Customer customer = db.Customers.Find("AAAAA");
            // find() methodu, primary key alır ve geriye o entity cinsinden satır döndürür.
            customer.ContactName = "Bill Gates";
            db.SaveChanges();
            dgvListe.DataSource = db.Customers.ToList();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            Customer customer = db.Customers.Find("AAAAA");
            db.Customers.Remove(customer);
            db.SaveChanges();
            dgvListe.DataSource = db.Customers.ToList();



        }
    }
}
