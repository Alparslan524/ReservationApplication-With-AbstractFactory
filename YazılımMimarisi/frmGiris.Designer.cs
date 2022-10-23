
namespace YazılımMimarisi
{
    partial class frmGiris
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
            this.groupBoxRezAl = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.comboBoxPaketSeciniz = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtGidilecekLokasyon = new System.Windows.Forms.TextBox();
            this.maskedTextBoxDonusTarih = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBoxGidisTarih = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDogumTarih = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.groupBoxRezSil = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVeriSilmeTC = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnHtmlOlustur = new System.Windows.Forms.Button();
            this.btnXmlOlustur = new System.Windows.Forms.Button();
            this.btnJsonOlustur = new System.Windows.Forms.Button();
            this.groupBoxRezAl.SuspendLayout();
            this.groupBoxRezSil.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRezAl
            // 
            this.groupBoxRezAl.BackColor = System.Drawing.Color.Aqua;
            this.groupBoxRezAl.Controls.Add(this.label12);
            this.groupBoxRezAl.Controls.Add(this.lblFiyat);
            this.groupBoxRezAl.Controls.Add(this.comboBoxPaketSeciniz);
            this.groupBoxRezAl.Controls.Add(this.label5);
            this.groupBoxRezAl.Controls.Add(this.btnKaydet);
            this.groupBoxRezAl.Controls.Add(this.txtGidilecekLokasyon);
            this.groupBoxRezAl.Controls.Add(this.maskedTextBoxDonusTarih);
            this.groupBoxRezAl.Controls.Add(this.label10);
            this.groupBoxRezAl.Controls.Add(this.label8);
            this.groupBoxRezAl.Controls.Add(this.maskedTextBoxGidisTarih);
            this.groupBoxRezAl.Controls.Add(this.label4);
            this.groupBoxRezAl.Controls.Add(this.label3);
            this.groupBoxRezAl.Controls.Add(this.label9);
            this.groupBoxRezAl.Controls.Add(this.label7);
            this.groupBoxRezAl.Controls.Add(this.label11);
            this.groupBoxRezAl.Controls.Add(this.label2);
            this.groupBoxRezAl.Controls.Add(this.txtDogumTarih);
            this.groupBoxRezAl.Controls.Add(this.txtTC);
            this.groupBoxRezAl.Controls.Add(this.label1);
            this.groupBoxRezAl.Controls.Add(this.txtSoyisim);
            this.groupBoxRezAl.Controls.Add(this.txtAd);
            this.groupBoxRezAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxRezAl.Location = new System.Drawing.Point(5, 31);
            this.groupBoxRezAl.Name = "groupBoxRezAl";
            this.groupBoxRezAl.Size = new System.Drawing.Size(617, 328);
            this.groupBoxRezAl.TabIndex = 0;
            this.groupBoxRezAl.TabStop = false;
            this.groupBoxRezAl.Text = "Rezervasyon Yap";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(413, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "Fiyat :";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(474, 128);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(21, 20);
            this.lblFiyat.TabIndex = 13;
            this.lblFiyat.Text = "...";
            // 
            // comboBoxPaketSeciniz
            // 
            this.comboBoxPaketSeciniz.FormattingEnabled = true;
            this.comboBoxPaketSeciniz.Items.AddRange(new object[] {
            "Otobüs - Otel",
            "Otobüs - Çadır",
            "Uçak - Otel",
            "Uçak - Çadır"});
            this.comboBoxPaketSeciniz.Location = new System.Drawing.Point(169, 120);
            this.comboBoxPaketSeciniz.Name = "comboBoxPaketSeciniz";
            this.comboBoxPaketSeciniz.Size = new System.Drawing.Size(201, 28);
            this.comboBoxPaketSeciniz.TabIndex = 12;
            this.comboBoxPaketSeciniz.SelectedIndexChanged += new System.EventHandler(this.comboBoxPaketSeciniz_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Paket Seçiniz :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnKaydet.Location = new System.Drawing.Point(186, 275);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(184, 29);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtGidilecekLokasyon
            // 
            this.txtGidilecekLokasyon.Location = new System.Drawing.Point(186, 231);
            this.txtGidilecekLokasyon.Name = "txtGidilecekLokasyon";
            this.txtGidilecekLokasyon.Size = new System.Drawing.Size(184, 26);
            this.txtGidilecekLokasyon.TabIndex = 8;
            // 
            // maskedTextBoxDonusTarih
            // 
            this.maskedTextBoxDonusTarih.Location = new System.Drawing.Point(404, 174);
            this.maskedTextBoxDonusTarih.Mask = "00/00/0000";
            this.maskedTextBoxDonusTarih.Name = "maskedTextBoxDonusTarih";
            this.maskedTextBoxDonusTarih.Size = new System.Drawing.Size(117, 26);
            this.maskedTextBoxDonusTarih.TabIndex = 7;
            this.maskedTextBoxDonusTarih.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(376, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 24);
            this.label10.TabIndex = 4;
            this.label10.Text = "--";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(103, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "--";
            // 
            // maskedTextBoxGidisTarih
            // 
            this.maskedTextBoxGidisTarih.Location = new System.Drawing.Point(253, 175);
            this.maskedTextBoxGidisTarih.Mask = "00/00/0000";
            this.maskedTextBoxGidisTarih.Name = "maskedTextBoxGidisTarih";
            this.maskedTextBoxGidisTarih.Size = new System.Drawing.Size(117, 26);
            this.maskedTextBoxGidisTarih.TabIndex = 6;
            this.maskedTextBoxGidisTarih.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(290, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Doğum Tarihi : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(290, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "TC : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(131, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Dönüş Tarihi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(10, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Gidiş Tarihi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(13, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Gidilecek Lokasyon :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyisim : ";
            // 
            // txtDogumTarih
            // 
            this.txtDogumTarih.Location = new System.Drawing.Point(423, 77);
            this.txtDogumTarih.Name = "txtDogumTarih";
            this.txtDogumTarih.Size = new System.Drawing.Size(159, 26);
            this.txtDogumTarih.TabIndex = 3;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(423, 40);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(159, 26);
            this.txtTC.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsim :";
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(99, 77);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(162, 26);
            this.txtSoyisim.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(99, 39);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(162, 26);
            this.txtAd.TabIndex = 0;
            // 
            // groupBoxRezSil
            // 
            this.groupBoxRezSil.BackColor = System.Drawing.Color.Aqua;
            this.groupBoxRezSil.Controls.Add(this.label6);
            this.groupBoxRezSil.Controls.Add(this.txtVeriSilmeTC);
            this.groupBoxRezSil.Controls.Add(this.button1);
            this.groupBoxRezSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxRezSil.Location = new System.Drawing.Point(628, 31);
            this.groupBoxRezSil.Name = "groupBoxRezSil";
            this.groupBoxRezSil.Size = new System.Drawing.Size(629, 149);
            this.groupBoxRezSil.TabIndex = 1;
            this.groupBoxRezSil.TabStop = false;
            this.groupBoxRezSil.Text = "Rezervasyon Sil";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(351, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Silmek İstediğiniz Rezervasyonun TC\'sini Giriniz :";
            // 
            // txtVeriSilmeTC
            // 
            this.txtVeriSilmeTC.Location = new System.Drawing.Point(380, 31);
            this.txtVeriSilmeTC.Name = "txtVeriSilmeTC";
            this.txtVeriSilmeTC.Size = new System.Drawing.Size(184, 26);
            this.txtVeriSilmeTC.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(380, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Aqua;
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.btnHtmlOlustur);
            this.groupBox1.Controls.Add(this.btnXmlOlustur);
            this.groupBox1.Controls.Add(this.btnJsonOlustur);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(628, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 173);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rapor";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(473, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 20);
            this.label15.TabIndex = 13;
            this.label15.Text = "HTML";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(296, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 20);
            this.label14.TabIndex = 13;
            this.label14.Text = "XML";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(110, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 20);
            this.label13.TabIndex = 13;
            this.label13.Text = "JSON";
            // 
            // btnHtmlOlustur
            // 
            this.btnHtmlOlustur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHtmlOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHtmlOlustur.Location = new System.Drawing.Point(437, 120);
            this.btnHtmlOlustur.Name = "btnHtmlOlustur";
            this.btnHtmlOlustur.Size = new System.Drawing.Size(127, 29);
            this.btnHtmlOlustur.TabIndex = 0;
            this.btnHtmlOlustur.Text = "Oluştur";
            this.btnHtmlOlustur.UseVisualStyleBackColor = false;
            this.btnHtmlOlustur.Click += new System.EventHandler(this.btnXmlOlustur_Click);
            // 
            // btnXmlOlustur
            // 
            this.btnXmlOlustur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnXmlOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnXmlOlustur.Location = new System.Drawing.Point(257, 120);
            this.btnXmlOlustur.Name = "btnXmlOlustur";
            this.btnXmlOlustur.Size = new System.Drawing.Size(127, 29);
            this.btnXmlOlustur.TabIndex = 0;
            this.btnXmlOlustur.Text = "Oluştur";
            this.btnXmlOlustur.UseVisualStyleBackColor = false;
            this.btnXmlOlustur.Click += new System.EventHandler(this.btnXmlOlustur_Click);
            // 
            // btnJsonOlustur
            // 
            this.btnJsonOlustur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnJsonOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnJsonOlustur.Location = new System.Drawing.Point(77, 120);
            this.btnJsonOlustur.Name = "btnJsonOlustur";
            this.btnJsonOlustur.Size = new System.Drawing.Size(127, 29);
            this.btnJsonOlustur.TabIndex = 0;
            this.btnJsonOlustur.Text = "Oluştur";
            this.btnJsonOlustur.UseVisualStyleBackColor = false;
            this.btnJsonOlustur.Click += new System.EventHandler(this.btnJsonOlustur_Click);
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1266, 391);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxRezSil);
            this.Controls.Add(this.groupBoxRezAl);
            this.Name = "frmGiris";
            this.Text = "Girş Ekranı";
            this.groupBoxRezAl.ResumeLayout(false);
            this.groupBoxRezAl.PerformLayout();
            this.groupBoxRezSil.ResumeLayout(false);
            this.groupBoxRezSil.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRezAl;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.GroupBox groupBoxRezSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDogumTarih;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDonusTarih;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxGidisTarih;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtGidilecekLokasyon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxPaketSeciniz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtVeriSilmeTC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnXmlOlustur;
        private System.Windows.Forms.Button btnJsonOlustur;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnHtmlOlustur;
    }
}