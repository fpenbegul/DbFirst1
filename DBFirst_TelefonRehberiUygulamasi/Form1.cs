using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFirst_TelefonRehberiUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TelefonRehberiDbEntities db;

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new TelefonRehberiDbEntities();

            cmbAra.Items.Add("İle Başlayan");
            cmbAra.Items.Add("İle Biten");
            // veritabanında nchar olduğu için telde kaydı göstermiyor!
            cmbAra.Items.Add("İçeren");

            cmbAra.Text = "Lütfen Seçiniz...";
            cmbAra.SelectedIndex = 0;

            btnGuncelle.Enabled = false;
            btnAra.Enabled = db.Kisilers.ToList().Count > 0 ? true : false;

            KisileriDoldur(db.Kisilers.ToList());


        }

        private void KisileriDoldur(List<Kisiler> liste)
        {
            lstKisiler.Items.Clear();
            foreach (Kisiler item in liste)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.ID.ToString();
                lvi.SubItems.Add(item.Ad);
                lvi.SubItems.Add(item.Soyad);
                lvi.SubItems.Add(item.Telefon);
                lvi.Tag = item;

                lstKisiler.Items.Add(lvi);

            }

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text.Trim() == "" || txtTelefon.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen isim ve telefon kısımlarını boş bırakmayınız!");
            }
            else
            {
                Kisiler kisi = new Kisiler();
                kisi.Ad = txtAd.Text;
                kisi.Soyad = txtSoyad.Text;
                kisi.Telefon = txtTelefon.Text;
                db.Kisilers.Add(kisi);
                bool sonuc = db.SaveChanges() > 0;

                if (sonuc)
                {
                    KisileriDoldur(db.Kisilers.ToList());
                    Temizle(grpEkleme);
                    btnAra.Enabled = true;
                    MessageBox.Show("Kayıt İşlemi Başarıyla Yapıldı!");
                }
                else
                {
                    MessageBox.Show("Kişi ekleme esnasında bir hata oluştu!");
                }
            }
        }

        private void Temizle(GroupBox grp)
        {
            foreach (Control item in grp.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                else if (item is ComboBox)
                {
                    (item as ComboBox).SelectedIndex = -1;
                }
            }
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            switch (cmbAra.SelectedIndex)
            {

                default:
                    MessageBox.Show("Lütfen bir arama kriteri seçiniz!..");
                    break;
                case 0:
                    KisileriDoldur(db.Kisilers.Where(x => x.Ad.StartsWith(txtAra.Text) || x.Soyad.StartsWith(txtAra.Text) || x.Telefon.StartsWith(txtAra.Text)).ToList());
                    break;
                case 1:
                    KisileriDoldur(db.Kisilers.Where(x => x.Ad.EndsWith(txtAra.Text) || x.Soyad.EndsWith(txtAra.Text) || x.Telefon.EndsWith(txtAra.Text)).ToList());
                    break;
                case 2:
                    KisileriDoldur(db.Kisilers.Where(x => x.Ad.Contains(txtAra.Text) || x.Soyad.Contains(txtAra.Text) || x.Telefon.Contains(txtAra.Text)).ToList());
                    break;
            }
            Temizle(grpArama);
        }

        private void TsmYenile_Click(object sender, EventArgs e)
        {
            KisileriDoldur(db.Kisilers.ToList());
        }
        Kisiler guncellenecek;
        private void YsmGuncelle_Click(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItems.Count <= 0) return;

            guncellenecek = lstKisiler.SelectedItems[0].Tag as Kisiler;
            txtAd.Text = guncellenecek.Ad;
            txtSoyad.Text = guncellenecek.Soyad;
            txtTelefon.Text = guncellenecek.Telefon;
            btnGuncelle.Enabled = true;
            btnEkle.Enabled = btnAra.Enabled = false;




        }

        private void TsmSil_Click(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItems.Count <= 0) return;

            Kisiler seciliKisi = lstKisiler.SelectedItems[0].Tag as Kisiler;

            db.Kisilers.Remove(seciliKisi);
            bool sonuc = db.SaveChanges() > 0;

            if (sonuc)
            {
                KisileriDoldur(db.Kisilers.ToList());
                btnAra.Enabled = db.Kisilers.ToList().Count > 0 ? true : false;
                MessageBox.Show("Silme işlemi başarıyla gerçekleşti...");
            }
            else
            {
                MessageBox.Show("Silme işlemi esnasına bir hata meydana geldi...");
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text.Trim() == "" || txtTelefon.Text.Trim() == "")
                MessageBox.Show("Lütfen isi mve telefon kısmını doldurunuz!");
            else
            {
                guncellenecek.Ad = txtAd.Text;
                guncellenecek.Soyad = txtSoyad.Text;
                guncellenecek.Telefon = txtTelefon.Text;

                bool sonuc = db.SaveChanges() > 0;

                if (sonuc)
                {
                    Temizle(grpEkleme);
                    KisileriDoldur(db.Kisilers.ToList());

                    btnGuncelle.Enabled = false;
                    btnEkle.Enabled = btnAra.Enabled = true;
                    MessageBox.Show("Kişi bilgileri Güncellenmiştir...");
                }
                else
                {
                    MessageBox.Show("Güncelleme işlemi sırasında bir hata meydana geldi...");
                }

            }


        }
    }
}
