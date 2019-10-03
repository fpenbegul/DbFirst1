namespace Ornek2
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.dgvSonuclar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSonuclar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 13);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(103, 23);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Sorgu 1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(122, 13);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(103, 23);
            this.btn2.TabIndex = 0;
            this.btn2.Text = "Sorgu 2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(232, 13);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(103, 23);
            this.btn3.TabIndex = 0;
            this.btn3.Text = "Sorgu 3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(342, 13);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(103, 23);
            this.btn4.TabIndex = 0;
            this.btn4.Text = "Sorgu 4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(452, 13);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(103, 23);
            this.btn5.TabIndex = 0;
            this.btn5.Text = "Sorgu 5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(562, 14);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(103, 23);
            this.btn6.TabIndex = 0;
            this.btn6.Text = "Sorgu 6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // dgvSonuclar
            // 
            this.dgvSonuclar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSonuclar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSonuclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSonuclar.Location = new System.Drawing.Point(13, 43);
            this.dgvSonuclar.Name = "dgvSonuclar";
            this.dgvSonuclar.Size = new System.Drawing.Size(652, 395);
            this.dgvSonuclar.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.dgvSonuclar);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSonuclar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.DataGridView dgvSonuclar;
    }
}

