namespace DBFirst_TelefonRehberiUygulamasi
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
            this.components = new System.ComponentModel.Container();
            this.grpEkleme = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpArama = new System.Windows.Forms.GroupBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.cmbAra = new System.Windows.Forms.ComboBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.grpRehber = new System.Windows.Forms.GroupBox();
            this.lstKisiler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.context = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmSil = new System.Windows.Forms.ToolStripMenuItem();
            this.ysmGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmYenile = new System.Windows.Forms.ToolStripMenuItem();
            this.grpEkleme.SuspendLayout();
            this.grpArama.SuspendLayout();
            this.grpRehber.SuspendLayout();
            this.context.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEkleme
            // 
            this.grpEkleme.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grpEkleme.Controls.Add(this.btnEkle);
            this.grpEkleme.Controls.Add(this.txtTelefon);
            this.grpEkleme.Controls.Add(this.txtSoyad);
            this.grpEkleme.Controls.Add(this.txtAd);
            this.grpEkleme.Controls.Add(this.label3);
            this.grpEkleme.Controls.Add(this.label2);
            this.grpEkleme.Controls.Add(this.label1);
            this.grpEkleme.Location = new System.Drawing.Point(13, 13);
            this.grpEkleme.Name = "grpEkleme";
            this.grpEkleme.Size = new System.Drawing.Size(301, 179);
            this.grpEkleme.TabIndex = 0;
            this.grpEkleme.TabStop = false;
            this.grpEkleme.Text = "Kişi Ekleme Paneli";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(67, 115);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(214, 31);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Rehbere Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(67, 89);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(214, 20);
            this.txtTelefon.TabIndex = 3;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(67, 57);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(214, 20);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(67, 25);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(214, 20);
            this.txtAd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telefonu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyadı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı :";
            // 
            // grpArama
            // 
            this.grpArama.Controls.Add(this.btnAra);
            this.grpArama.Controls.Add(this.cmbAra);
            this.grpArama.Controls.Add(this.txtAra);
            this.grpArama.Controls.Add(this.lbl1);
            this.grpArama.Location = new System.Drawing.Point(321, 13);
            this.grpArama.Name = "grpArama";
            this.grpArama.Size = new System.Drawing.Size(267, 109);
            this.grpArama.TabIndex = 1;
            this.grpArama.TabStop = false;
            this.grpArama.Text = "Kişi Arama Paneli";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(6, 28);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(48, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Kişi Ara :";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(61, 24);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(185, 20);
            this.txtAra.TabIndex = 1;
            // 
            // cmbAra
            // 
            this.cmbAra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAra.FormattingEnabled = true;
            this.cmbAra.Location = new System.Drawing.Point(9, 50);
            this.cmbAra.Name = "cmbAra";
            this.cmbAra.Size = new System.Drawing.Size(237, 21);
            this.cmbAra.TabIndex = 2;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(119, 78);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(127, 23);
            this.btnAra.TabIndex = 3;
            this.btnAra.Text = "Arama Yap";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(321, 128);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(267, 64);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelleme Yap";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // grpRehber
            // 
            this.grpRehber.Controls.Add(this.lstKisiler);
            this.grpRehber.Location = new System.Drawing.Point(13, 199);
            this.grpRehber.Name = "grpRehber";
            this.grpRehber.Size = new System.Drawing.Size(575, 239);
            this.grpRehber.TabIndex = 4;
            this.grpRehber.TabStop = false;
            this.grpRehber.Text = "REHBER";
            // 
            // lstKisiler
            // 
            this.lstKisiler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstKisiler.ContextMenuStrip = this.context;
            this.lstKisiler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstKisiler.FullRowSelect = true;
            this.lstKisiler.GridLines = true;
            this.lstKisiler.Location = new System.Drawing.Point(3, 16);
            this.lstKisiler.Name = "lstKisiler";
            this.lstKisiler.Size = new System.Drawing.Size(569, 220);
            this.lstKisiler.TabIndex = 0;
            this.lstKisiler.UseCompatibleStateImageBehavior = false;
            this.lstKisiler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "AD";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SOYAD";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "TELEFON";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 150;
            // 
            // context
            // 
            this.context.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSil,
            this.ysmGuncelle,
            this.tsmYenile});
            this.context.Name = "context";
            this.context.Size = new System.Drawing.Size(132, 70);
            // 
            // tsmSil
            // 
            this.tsmSil.Name = "tsmSil";
            this.tsmSil.Size = new System.Drawing.Size(180, 22);
            this.tsmSil.Text = "SİL";
            this.tsmSil.Click += new System.EventHandler(this.TsmSil_Click);
            // 
            // ysmGuncelle
            // 
            this.ysmGuncelle.Name = "ysmGuncelle";
            this.ysmGuncelle.Size = new System.Drawing.Size(180, 22);
            this.ysmGuncelle.Text = "GÜNCELLE";
            this.ysmGuncelle.Click += new System.EventHandler(this.YsmGuncelle_Click);
            // 
            // tsmYenile
            // 
            this.tsmYenile.Name = "tsmYenile";
            this.tsmYenile.Size = new System.Drawing.Size(180, 22);
            this.tsmYenile.Text = "YENİLE";
            this.tsmYenile.Click += new System.EventHandler(this.TsmYenile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 450);
            this.Controls.Add(this.grpRehber);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.grpArama);
            this.Controls.Add(this.grpEkleme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpEkleme.ResumeLayout(false);
            this.grpEkleme.PerformLayout();
            this.grpArama.ResumeLayout(false);
            this.grpArama.PerformLayout();
            this.grpRehber.ResumeLayout(false);
            this.context.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEkleme;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpArama;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ComboBox cmbAra;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.GroupBox grpRehber;
        private System.Windows.Forms.ListView lstKisiler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenuStrip context;
        private System.Windows.Forms.ToolStripMenuItem tsmSil;
        private System.Windows.Forms.ToolStripMenuItem ysmGuncelle;
        private System.Windows.Forms.ToolStripMenuItem tsmYenile;
    }
}

