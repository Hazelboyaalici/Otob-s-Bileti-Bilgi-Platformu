namespace Araç_Kullanım_Uygulaması
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MskTime = new System.Windows.Forms.MaskedTextBox();
            this.MskDate = new System.Windows.Forms.MaskedTextBox();
            this.CmbNereye = new System.Windows.Forms.ComboBox();
            this.CmbNereden = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn = new System.Windows.Forms.Button();
            this.TxtAdSoyad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.MskTel = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(23, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 93);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(705, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(617, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Online Otobüs Bilet Satış Noktası";
            this.label1.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.MskTime);
            this.groupBox1.Controls.Add(this.MskDate);
            this.groupBox1.Controls.Add(this.CmbNereye);
            this.groupBox1.Controls.Add(this.CmbNereden);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(26, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 303);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kalkış Bilgileri";
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(250, 81);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(55, 39);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "<>";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(265, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 28);
            this.label9.TabIndex = 3;
            this.label9.Text = "label9";
            this.label9.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(487, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 34);
            this.textBox1.TabIndex = 1;
            // 
            // MskTime
            // 
            this.MskTime.Location = new System.Drawing.Point(119, 240);
            this.MskTime.Mask = "00:00";
            this.MskTime.Name = "MskTime";
            this.MskTime.Size = new System.Drawing.Size(125, 34);
            this.MskTime.TabIndex = 2;
            this.MskTime.ValidatingType = typeof(System.DateTime);
            // 
            // MskDate
            // 
            this.MskDate.Location = new System.Drawing.Point(119, 175);
            this.MskDate.Mask = "00/00/0000";
            this.MskDate.Name = "MskDate";
            this.MskDate.Size = new System.Drawing.Size(125, 34);
            this.MskDate.TabIndex = 2;
            this.MskDate.ValidatingType = typeof(System.DateTime);
            // 
            // CmbNereye
            // 
            this.CmbNereye.FormattingEnabled = true;
            this.CmbNereye.Items.AddRange(new object[] {
            "Adana ",
            "Adıyaman ",
            "Afyon ",
            "Ağrı ",
            "Amasya ",
            "Ankara ",
            "Antalya ",
            "Artvin ",
            "Aydın ",
            "Balıkesir ",
            "Bilecik ",
            "Bingöl ",
            "Bitlis ",
            "Bolu ",
            "Burdur ",
            "Bursa ",
            "Çanakkale ",
            "Çankırı ",
            "Çorum ",
            "Denizli ",
            "Diyarbakır ",
            "Edirne ",
            "Elazığ ",
            "Erzincan ",
            "Erzurum ",
            "Eskişehir ",
            "Gaziantep ",
            "Giresun ",
            "Gümüşhane ",
            "Hakkari ",
            "Hatay ",
            "Isparta ",
            "İçel ",
            "İstanbul ",
            "İzmir ",
            "Kars ",
            "Kastamonu ",
            "Kayseri ",
            "Kırklareli ",
            "Kırşehir ",
            "Kocaeli ",
            "Konya ",
            "Kütahya ",
            "Malatya ",
            "Manisa ",
            "Kahramanmaraş ",
            "Mardin ",
            "Muğla ",
            "Muş ",
            "Nevşehir ",
            "Niğde ",
            "Ordu ",
            "Rize ",
            "Sakarya ",
            "Samsun ",
            "Siirt ",
            "Sinop ",
            "Sivas ",
            "Tekirdağ ",
            "Tokat ",
            "Trabzon ",
            "Tunceli ",
            "Şanlıurfa ",
            "Uşak ",
            "Van ",
            "Yozgat",
            "Zonguldak ",
            "Aksaray ",
            "Bayburt ",
            "Karaman ",
            "Kırıkkale",
            "Batman",
            "Şırnak ",
            "Bartın ",
            "Ardahan ",
            "Iğdır ",
            "Yalova ",
            "Karabük ",
            "Kilis ",
            "Osmaniye ",
            "Düzce "});
            this.CmbNereye.Location = new System.Drawing.Point(119, 116);
            this.CmbNereye.Name = "CmbNereye";
            this.CmbNereye.Size = new System.Drawing.Size(125, 36);
            this.CmbNereye.TabIndex = 1;
            // 
            // CmbNereden
            // 
            this.CmbNereden.FormattingEnabled = true;
            this.CmbNereden.Items.AddRange(new object[] {
            "Adana ",
            "Adıyaman ",
            "Afyon ",
            "Ağrı ",
            "Amasya ",
            "Ankara ",
            "Antalya ",
            "Artvin ",
            "Aydın ",
            "Balıkesir ",
            "Bilecik ",
            "Bingöl ",
            "Bitlis ",
            "Bolu ",
            "Burdur ",
            "Bursa ",
            "Çanakkale ",
            "Çankırı ",
            "Çorum ",
            "Denizli ",
            "Diyarbakır ",
            "Edirne ",
            "Elazığ ",
            "Erzincan ",
            "Erzurum ",
            "Eskişehir ",
            "Gaziantep ",
            "Giresun ",
            "Gümüşhane ",
            "Hakkari ",
            "Hatay ",
            "Isparta ",
            "İçel ",
            "İstanbul ",
            "İzmir ",
            "Kars ",
            "Kastamonu ",
            "Kayseri ",
            "Kırklareli ",
            "Kırşehir ",
            "Kocaeli ",
            "Konya ",
            "Kütahya ",
            "Malatya ",
            "Manisa ",
            "Kahramanmaraş ",
            "Mardin ",
            "Muğla ",
            "Muş ",
            "Nevşehir ",
            "Niğde ",
            "Ordu ",
            "Rize ",
            "Sakarya ",
            "Samsun ",
            "Siirt ",
            "Sinop ",
            "Sivas ",
            "Tekirdağ ",
            "Tokat ",
            "Trabzon ",
            "Tunceli ",
            "Şanlıurfa ",
            "Uşak ",
            "Van ",
            "Yozgat",
            "Zonguldak ",
            "Aksaray ",
            "Bayburt ",
            "Karaman ",
            "Kırıkkale",
            "Batman",
            "Şırnak ",
            "Bartın ",
            "Ardahan ",
            "Iğdır ",
            "Yalova ",
            "Karabük ",
            "Kilis ",
            "Osmaniye ",
            "Düzce "});
            this.CmbNereden.Location = new System.Drawing.Point(119, 48);
            this.CmbNereden.Name = "CmbNereden";
            this.CmbNereden.Size = new System.Drawing.Size(125, 36);
            this.CmbNereden.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Saat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tarih:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nereye:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nereden:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn);
            this.groupBox2.Controls.Add(this.TxtAdSoyad);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.MskTC);
            this.groupBox2.Controls.Add(this.MskTel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(399, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 303);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yolcu Bilgileri";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(246, 240);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(89, 43);
            this.btn.TabIndex = 2;
            this.btn.Text = "Kaydet";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // TxtAdSoyad
            // 
            this.TxtAdSoyad.Location = new System.Drawing.Point(151, 57);
            this.TxtAdSoyad.Name = "TxtAdSoyad";
            this.TxtAdSoyad.Size = new System.Drawing.Size(125, 34);
            this.TxtAdSoyad.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 28);
            this.label8.TabIndex = 0;
            this.label8.Text = "T.C. Kimlik No:";
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(151, 175);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(125, 34);
            this.MskTC.TabIndex = 2;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // MskTel
            // 
            this.MskTel.Location = new System.Drawing.Point(151, 116);
            this.MskTel.Mask = "(999) 000-0000";
            this.MskTel.Name = "MskTel";
            this.MskTel.Size = new System.Drawing.Size(125, 34);
            this.MskTel.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Telefon:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ad Soyad:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(26, 463);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(620, 184);
            this.listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(961, 670);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private Label label8;
        private Label label7;
        private Label label6;
        private MaskedTextBox MskTime;
        private MaskedTextBox MskDate;
        private ComboBox CmbNereye;
        private ComboBox CmbNereden;
        private TextBox textBox1;
        private TextBox TxtAdSoyad;
        private Button btn;
        private MaskedTextBox MskTel;
        private ListBox listBox1;
        private MaskedTextBox MskTC;
        private Button btn2;
        private Label label9;
    }
}