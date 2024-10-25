namespace LINQ_Proje1
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
            this.Sayilar_All = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Negative = new System.Windows.Forms.Button();
            this.Positive = new System.Windows.Forms.Button();
            this.Cift = new System.Windows.Forms.Button();
            this.Tek = new System.Windows.Forms.Button();
            this.max_number = new System.Windows.Forms.Button();
            this.Min_Number = new System.Windows.Forms.Button();
            this.kac_tane = new System.Windows.Forms.Button();
            this.Alfabetik = new System.Windows.Forms.Button();
            this.Tersten = new System.Windows.Forms.Button();
            this.Uzunluk = new System.Windows.Forms.Button();
            this.e_harfi = new System.Windows.Forms.Button();
            this.a_harfi = new System.Windows.Forms.Button();
            this.tumSiparisGetir = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.Button();
            this.Top5 = new System.Windows.Forms.Button();
            this.son5 = new System.Windows.Forms.Button();
            this.yanWang = new System.Windows.Forms.Button();
            this.siparisSayisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Sayilar_All
            // 
            this.Sayilar_All.Location = new System.Drawing.Point(12, 12);
            this.Sayilar_All.Name = "Sayilar_All";
            this.Sayilar_All.Size = new System.Drawing.Size(81, 38);
            this.Sayilar_All.TabIndex = 0;
            this.Sayilar_All.Text = "Tüm Sayılar";
            this.Sayilar_All.UseVisualStyleBackColor = true;
            this.Sayilar_All.Click += new System.EventHandler(this.Sayilar_All_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(2, 236);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 147);
            this.listBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(138, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(468, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // Negative
            // 
            this.Negative.Location = new System.Drawing.Point(99, 12);
            this.Negative.Name = "Negative";
            this.Negative.Size = new System.Drawing.Size(81, 38);
            this.Negative.TabIndex = 3;
            this.Negative.Text = "Negatif";
            this.Negative.UseVisualStyleBackColor = true;
            this.Negative.Click += new System.EventHandler(this.Negative_Click);
            // 
            // Positive
            // 
            this.Positive.Location = new System.Drawing.Point(186, 12);
            this.Positive.Name = "Positive";
            this.Positive.Size = new System.Drawing.Size(81, 38);
            this.Positive.TabIndex = 4;
            this.Positive.Text = "Pozitif";
            this.Positive.UseVisualStyleBackColor = true;
            this.Positive.Click += new System.EventHandler(this.Positive_Click);
            // 
            // Cift
            // 
            this.Cift.Location = new System.Drawing.Point(273, 12);
            this.Cift.Name = "Cift";
            this.Cift.Size = new System.Drawing.Size(81, 38);
            this.Cift.TabIndex = 5;
            this.Cift.Text = "Çift";
            this.Cift.UseVisualStyleBackColor = true;
            this.Cift.Click += new System.EventHandler(this.Cift_Click);
            // 
            // Tek
            // 
            this.Tek.Location = new System.Drawing.Point(360, 12);
            this.Tek.Name = "Tek";
            this.Tek.Size = new System.Drawing.Size(81, 38);
            this.Tek.TabIndex = 6;
            this.Tek.Text = "Tek";
            this.Tek.UseVisualStyleBackColor = true;
            this.Tek.Click += new System.EventHandler(this.Tek_Click);
            // 
            // max_number
            // 
            this.max_number.Location = new System.Drawing.Point(447, 12);
            this.max_number.Name = "max_number";
            this.max_number.Size = new System.Drawing.Size(81, 38);
            this.max_number.TabIndex = 7;
            this.max_number.Text = "En Büyük";
            this.max_number.UseVisualStyleBackColor = true;
            this.max_number.Click += new System.EventHandler(this.max_number_Click);
            // 
            // Min_Number
            // 
            this.Min_Number.Location = new System.Drawing.Point(534, 12);
            this.Min_Number.Name = "Min_Number";
            this.Min_Number.Size = new System.Drawing.Size(81, 38);
            this.Min_Number.TabIndex = 8;
            this.Min_Number.Text = "En Küçük";
            this.Min_Number.UseVisualStyleBackColor = true;
            this.Min_Number.Click += new System.EventHandler(this.Min_Number_Click);
            // 
            // kac_tane
            // 
            this.kac_tane.Location = new System.Drawing.Point(621, 12);
            this.kac_tane.Name = "kac_tane";
            this.kac_tane.Size = new System.Drawing.Size(81, 38);
            this.kac_tane.TabIndex = 9;
            this.kac_tane.Text = "Kaç Tane";
            this.kac_tane.UseVisualStyleBackColor = true;
            this.kac_tane.Click += new System.EventHandler(this.kac_tane_Click);
            // 
            // Alfabetik
            // 
            this.Alfabetik.Location = new System.Drawing.Point(99, 71);
            this.Alfabetik.Name = "Alfabetik";
            this.Alfabetik.Size = new System.Drawing.Size(81, 38);
            this.Alfabetik.TabIndex = 10;
            this.Alfabetik.Text = "Alfabetik";
            this.Alfabetik.UseVisualStyleBackColor = true;
            this.Alfabetik.Click += new System.EventHandler(this.Alfabetik_Click);
            // 
            // Tersten
            // 
            this.Tersten.Location = new System.Drawing.Point(186, 71);
            this.Tersten.Name = "Tersten";
            this.Tersten.Size = new System.Drawing.Size(81, 38);
            this.Tersten.TabIndex = 11;
            this.Tersten.Text = "Ters Alfabetik";
            this.Tersten.UseVisualStyleBackColor = true;
            this.Tersten.Click += new System.EventHandler(this.Tersten_Click);
            // 
            // Uzunluk
            // 
            this.Uzunluk.Location = new System.Drawing.Point(273, 71);
            this.Uzunluk.Name = "Uzunluk";
            this.Uzunluk.Size = new System.Drawing.Size(81, 38);
            this.Uzunluk.TabIndex = 12;
            this.Uzunluk.Text = "Uzunluk";
            this.Uzunluk.UseVisualStyleBackColor = true;
            this.Uzunluk.Click += new System.EventHandler(this.Uzunluk_Click);
            // 
            // e_harfi
            // 
            this.e_harfi.Location = new System.Drawing.Point(360, 71);
            this.e_harfi.Name = "e_harfi";
            this.e_harfi.Size = new System.Drawing.Size(81, 53);
            this.e_harfi.TabIndex = 13;
            this.e_harfi.Text = "E harfi Bulunan İsimler";
            this.e_harfi.UseVisualStyleBackColor = true;
            this.e_harfi.Click += new System.EventHandler(this.e_harfi_Click);
            // 
            // a_harfi
            // 
            this.a_harfi.Location = new System.Drawing.Point(447, 64);
            this.a_harfi.Name = "a_harfi";
            this.a_harfi.Size = new System.Drawing.Size(81, 60);
            this.a_harfi.TabIndex = 14;
            this.a_harfi.Text = "A harfi ile Başlayan";
            this.a_harfi.UseVisualStyleBackColor = true;
            this.a_harfi.Click += new System.EventHandler(this.a_harfi_Click);
            // 
            // tumSiparisGetir
            // 
            this.tumSiparisGetir.Location = new System.Drawing.Point(99, 146);
            this.tumSiparisGetir.Name = "tumSiparisGetir";
            this.tumSiparisGetir.Size = new System.Drawing.Size(81, 38);
            this.tumSiparisGetir.TabIndex = 15;
            this.tumSiparisGetir.Text = "Tüm Siparişler";
            this.tumSiparisGetir.UseVisualStyleBackColor = true;
            this.tumSiparisGetir.Click += new System.EventHandler(this.tumSiparisGetir_Click);
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(198, 146);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(81, 38);
            this.Date.TabIndex = 16;
            this.Date.Text = "Tarih";
            this.Date.UseVisualStyleBackColor = true;
            this.Date.Click += new System.EventHandler(this.Date_Click);
            // 
            // Top5
            // 
            this.Top5.Location = new System.Drawing.Point(296, 146);
            this.Top5.Name = "Top5";
            this.Top5.Size = new System.Drawing.Size(81, 38);
            this.Top5.TabIndex = 17;
            this.Top5.Text = "Top5";
            this.Top5.UseVisualStyleBackColor = true;
            this.Top5.Click += new System.EventHandler(this.Top5_Click);
            // 
            // son5
            // 
            this.son5.Location = new System.Drawing.Point(394, 146);
            this.son5.Name = "son5";
            this.son5.Size = new System.Drawing.Size(81, 38);
            this.son5.TabIndex = 18;
            this.son5.Text = "Son5";
            this.son5.UseVisualStyleBackColor = true;
            this.son5.Click += new System.EventHandler(this.son5_Click);
            // 
            // yanWang
            // 
            this.yanWang.Location = new System.Drawing.Point(481, 146);
            this.yanWang.Name = "yanWang";
            this.yanWang.Size = new System.Drawing.Size(81, 38);
            this.yanWang.TabIndex = 19;
            this.yanWang.Text = "Yang Wang";
            this.yanWang.UseVisualStyleBackColor = true;
            this.yanWang.Click += new System.EventHandler(this.yanWang_Click);
            // 
            // siparisSayisi
            // 
            this.siparisSayisi.Location = new System.Drawing.Point(568, 146);
            this.siparisSayisi.Name = "siparisSayisi";
            this.siparisSayisi.Size = new System.Drawing.Size(81, 38);
            this.siparisSayisi.TabIndex = 20;
            this.siparisSayisi.Text = "Sipariş Sayısı";
            this.siparisSayisi.UseVisualStyleBackColor = true;
            this.siparisSayisi.Click += new System.EventHandler(this.siparisSayisi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.siparisSayisi);
            this.Controls.Add(this.yanWang);
            this.Controls.Add(this.son5);
            this.Controls.Add(this.Top5);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.tumSiparisGetir);
            this.Controls.Add(this.a_harfi);
            this.Controls.Add(this.e_harfi);
            this.Controls.Add(this.Uzunluk);
            this.Controls.Add(this.Tersten);
            this.Controls.Add(this.Alfabetik);
            this.Controls.Add(this.kac_tane);
            this.Controls.Add(this.Min_Number);
            this.Controls.Add(this.max_number);
            this.Controls.Add(this.Tek);
            this.Controls.Add(this.Cift);
            this.Controls.Add(this.Positive);
            this.Controls.Add(this.Negative);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Sayilar_All);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Sayilar_All;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Negative;
        private System.Windows.Forms.Button Positive;
        private System.Windows.Forms.Button Cift;
        private System.Windows.Forms.Button Tek;
        private System.Windows.Forms.Button max_number;
        private System.Windows.Forms.Button Min_Number;
        private System.Windows.Forms.Button kac_tane;
        private System.Windows.Forms.Button Alfabetik;
        private System.Windows.Forms.Button Tersten;
        private System.Windows.Forms.Button Uzunluk;
        private System.Windows.Forms.Button e_harfi;
        private System.Windows.Forms.Button a_harfi;
        private System.Windows.Forms.Button tumSiparisGetir;
        private System.Windows.Forms.Button Date;
        private System.Windows.Forms.Button Top5;
        private System.Windows.Forms.Button son5;
        private System.Windows.Forms.Button yanWang;
        private System.Windows.Forms.Button siparisSayisi;
    }
}

