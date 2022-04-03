namespace MyRestaurant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpYemekler = new System.Windows.Forms.GroupBox();
            this.pctTea = new System.Windows.Forms.PictureBox();
            this.pctSprite = new System.Windows.Forms.PictureBox();
            this.pctCola = new System.Windows.Forms.PictureBox();
            this.pctFanta = new System.Windows.Forms.PictureBox();
            this.pctPilav = new System.Windows.Forms.PictureBox();
            this.pctAyran = new System.Windows.Forms.PictureBox();
            this.pctKabab = new System.Windows.Forms.PictureBox();
            this.pctPizza = new System.Windows.Forms.PictureBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstSiparisler = new System.Windows.Forms.ListBox();
            this.grpMasalar = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lstMasalar = new System.Windows.Forms.ListBox();
            this.grpAdamlar = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnYeniMasa = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnMasaSil = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.grpYemekler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctTea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFanta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPilav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAyran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctKabab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPizza)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grpMasalar.SuspendLayout();
            this.grpAdamlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpYemekler
            // 
            this.grpYemekler.Controls.Add(this.pctTea);
            this.grpYemekler.Controls.Add(this.pctSprite);
            this.grpYemekler.Controls.Add(this.pctCola);
            this.grpYemekler.Controls.Add(this.pctFanta);
            this.grpYemekler.Controls.Add(this.pctPilav);
            this.grpYemekler.Controls.Add(this.pctAyran);
            this.grpYemekler.Controls.Add(this.pctKabab);
            this.grpYemekler.Controls.Add(this.pctPizza);
            this.grpYemekler.Enabled = false;
            this.grpYemekler.Location = new System.Drawing.Point(16, 15);
            this.grpYemekler.Margin = new System.Windows.Forms.Padding(4);
            this.grpYemekler.Name = "grpYemekler";
            this.grpYemekler.Padding = new System.Windows.Forms.Padding(4);
            this.grpYemekler.Size = new System.Drawing.Size(727, 369);
            this.grpYemekler.TabIndex = 0;
            this.grpYemekler.TabStop = false;
            this.grpYemekler.Text = "Yemekler ve Icecekler";
            // 
            // pctTea
            // 
            this.pctTea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctTea.Image = global::MyRestaurant.Properties.Resources.cup_of_tea;
            this.pctTea.Location = new System.Drawing.Point(557, 193);
            this.pctTea.Margin = new System.Windows.Forms.Padding(4);
            this.pctTea.Name = "pctTea";
            this.pctTea.Size = new System.Drawing.Size(144, 134);
            this.pctTea.TabIndex = 8;
            this.pctTea.TabStop = false;
            this.pctTea.Click += new System.EventHandler(this.pctYemek_Click);
            // 
            // pctSprite
            // 
            this.pctSprite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctSprite.Image = global::MyRestaurant.Properties.Resources._819b0d4f_fb54_40f2_91e0_4fcdf6a67b02_1_d9e01ffe1b90305060f9a8ad6451d3e3;
            this.pctSprite.Location = new System.Drawing.Point(387, 198);
            this.pctSprite.Margin = new System.Windows.Forms.Padding(4);
            this.pctSprite.Name = "pctSprite";
            this.pctSprite.Size = new System.Drawing.Size(144, 122);
            this.pctSprite.TabIndex = 7;
            this.pctSprite.TabStop = false;
            this.pctSprite.Click += new System.EventHandler(this.pctYemek_Click);
            // 
            // pctCola
            // 
            this.pctCola.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctCola.Image = global::MyRestaurant.Properties.Resources.Coca_Cola_Can_330_Ml__39467_thumb;
            this.pctCola.Location = new System.Drawing.Point(195, 193);
            this.pctCola.Margin = new System.Windows.Forms.Padding(4);
            this.pctCola.Name = "pctCola";
            this.pctCola.Size = new System.Drawing.Size(144, 134);
            this.pctCola.TabIndex = 6;
            this.pctCola.TabStop = false;
            this.pctCola.Click += new System.EventHandler(this.pctYemek_Click);
            // 
            // pctFanta
            // 
            this.pctFanta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctFanta.Image = global::MyRestaurant.Properties.Resources.fanta_2_1;
            this.pctFanta.Location = new System.Drawing.Point(8, 193);
            this.pctFanta.Margin = new System.Windows.Forms.Padding(4);
            this.pctFanta.Name = "pctFanta";
            this.pctFanta.Size = new System.Drawing.Size(144, 134);
            this.pctFanta.TabIndex = 5;
            this.pctFanta.TabStop = false;
            this.pctFanta.Click += new System.EventHandler(this.pctYemek_Click);
            // 
            // pctPilav
            // 
            this.pctPilav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctPilav.Image = global::MyRestaurant.Properties.Resources.photo__1_;
            this.pctPilav.Location = new System.Drawing.Point(557, 36);
            this.pctPilav.Margin = new System.Windows.Forms.Padding(4);
            this.pctPilav.Name = "pctPilav";
            this.pctPilav.Size = new System.Drawing.Size(144, 134);
            this.pctPilav.TabIndex = 4;
            this.pctPilav.TabStop = false;
            this.pctPilav.Click += new System.EventHandler(this.pctYemek_Click);
            // 
            // pctAyran
            // 
            this.pctAyran.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctAyran.Image = global::MyRestaurant.Properties.Resources.t_Sek_Bardak_Ayran_200_ml_1;
            this.pctAyran.Location = new System.Drawing.Point(387, 36);
            this.pctAyran.Margin = new System.Windows.Forms.Padding(4);
            this.pctAyran.Name = "pctAyran";
            this.pctAyran.Size = new System.Drawing.Size(144, 134);
            this.pctAyran.TabIndex = 3;
            this.pctAyran.TabStop = false;
            this.pctAyran.Click += new System.EventHandler(this.pctYemek_Click);
            // 
            // pctKabab
            // 
            this.pctKabab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctKabab.Image = global::MyRestaurant.Properties.Resources.photo;
            this.pctKabab.Location = new System.Drawing.Point(195, 36);
            this.pctKabab.Margin = new System.Windows.Forms.Padding(4);
            this.pctKabab.Name = "pctKabab";
            this.pctKabab.Size = new System.Drawing.Size(144, 134);
            this.pctKabab.TabIndex = 2;
            this.pctKabab.TabStop = false;
            this.pctKabab.Click += new System.EventHandler(this.pctYemek_Click);
            // 
            // pctPizza
            // 
            this.pctPizza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctPizza.Image = global::MyRestaurant.Properties.Resources.pizza_1;
            this.pctPizza.Location = new System.Drawing.Point(8, 36);
            this.pctPizza.Margin = new System.Windows.Forms.Padding(4);
            this.pctPizza.Name = "pctPizza";
            this.pctPizza.Size = new System.Drawing.Size(144, 134);
            this.pctPizza.TabIndex = 1;
            this.pctPizza.TabStop = false;
            this.pctPizza.Click += new System.EventHandler(this.pctYemek_Click);
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(784, 368);
            this.lblSum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(129, 17);
            this.lblSum.TabIndex = 2;
            this.lblSum.Text = "Toplam tutar : 0 TL";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstSiparisler);
            this.groupBox2.Location = new System.Drawing.Point(772, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(312, 327);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Siparisler";
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.FormattingEnabled = true;
            this.lstSiparisler.ItemHeight = 16;
            this.lstSiparisler.Location = new System.Drawing.Point(15, 25);
            this.lstSiparisler.Margin = new System.Windows.Forms.Padding(4);
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.Size = new System.Drawing.Size(276, 292);
            this.lstSiparisler.TabIndex = 2;
            // 
            // grpMasalar
            // 
            this.grpMasalar.Controls.Add(this.listBox1);
            this.grpMasalar.Controls.Add(this.lstMasalar);
            this.grpMasalar.Location = new System.Drawing.Point(16, 412);
            this.grpMasalar.Margin = new System.Windows.Forms.Padding(4);
            this.grpMasalar.Name = "grpMasalar";
            this.grpMasalar.Padding = new System.Windows.Forms.Padding(4);
            this.grpMasalar.Size = new System.Drawing.Size(416, 224);
            this.grpMasalar.TabIndex = 4;
            this.grpMasalar.TabStop = false;
            this.grpMasalar.Text = "Masalar";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Hesap 1:",
            "Hesap 2:",
            "Hesap 3:",
            "Hesap 4:",
            "Hesap 5:",
            "Hesap 6:"});
            this.listBox1.Location = new System.Drawing.Point(269, 23);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(139, 180);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lstMasalar
            // 
            this.lstMasalar.FormattingEnabled = true;
            this.lstMasalar.ItemHeight = 16;
            this.lstMasalar.Items.AddRange(new object[] {
            "Masa1",
            "Masa2",
            "Masa3",
            "Masa4",
            "Masa5"});
            this.lstMasalar.Location = new System.Drawing.Point(10, 23);
            this.lstMasalar.Margin = new System.Windows.Forms.Padding(4);
            this.lstMasalar.Name = "lstMasalar";
            this.lstMasalar.Size = new System.Drawing.Size(234, 180);
            this.lstMasalar.TabIndex = 5;
            this.lstMasalar.SelectedIndexChanged += new System.EventHandler(this.lstMasalar_SelectedIndexChanged_1);
            // 
            // grpAdamlar
            // 
            this.grpAdamlar.Controls.Add(this.richTextBox1);
            this.grpAdamlar.Location = new System.Drawing.Point(475, 412);
            this.grpAdamlar.Margin = new System.Windows.Forms.Padding(4);
            this.grpAdamlar.Name = "grpAdamlar";
            this.grpAdamlar.Padding = new System.Windows.Forms.Padding(4);
            this.grpAdamlar.Size = new System.Drawing.Size(268, 222);
            this.grpAdamlar.TabIndex = 6;
            this.grpAdamlar.TabStop = false;
            this.grpAdamlar.Text = "Adamlar";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(8, 23);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(252, 180);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // btnYeniMasa
            // 
            this.btnYeniMasa.Location = new System.Drawing.Point(772, 510);
            this.btnYeniMasa.Margin = new System.Windows.Forms.Padding(4);
            this.btnYeniMasa.Name = "btnYeniMasa";
            this.btnYeniMasa.Size = new System.Drawing.Size(159, 28);
            this.btnYeniMasa.TabIndex = 0;
            this.btnYeniMasa.Text = "Yeni masa yarat";
            this.btnYeniMasa.UseVisualStyleBackColor = true;
            this.btnYeniMasa.Click += new System.EventHandler(this.btnYeniMasa_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnMasaSil
            // 
            this.btnMasaSil.Location = new System.Drawing.Point(772, 557);
            this.btnMasaSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnMasaSil.Name = "btnMasaSil";
            this.btnMasaSil.Size = new System.Drawing.Size(159, 28);
            this.btnMasaSil.TabIndex = 6;
            this.btnMasaSil.Text = "Masayi iptal et";
            this.btnMasaSil.UseVisualStyleBackColor = true;
            this.btnMasaSil.Click += new System.EventHandler(this.btnMasaSil_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(772, 606);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Masani aktiv et";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(945, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(945, 368);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Hesap Ekle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 665);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpAdamlar);
            this.Controls.Add(this.btnMasaSil);
            this.Controls.Add(this.btnYeniMasa);
            this.Controls.Add(this.grpMasalar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.grpYemekler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Anadolu Restaurants";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpYemekler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctTea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFanta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPilav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAyran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctKabab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPizza)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.grpMasalar.ResumeLayout(false);
            this.grpAdamlar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpYemekler;
        private System.Windows.Forms.PictureBox pctPizza;
        private System.Windows.Forms.PictureBox pctKabab;
        private System.Windows.Forms.PictureBox pctAyran;
        private System.Windows.Forms.PictureBox pctPilav;
        private System.Windows.Forms.PictureBox pctFanta;
        private System.Windows.Forms.PictureBox pctCola;
        private System.Windows.Forms.PictureBox pctTea;
        private System.Windows.Forms.PictureBox pctSprite;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstSiparisler;
        private System.Windows.Forms.GroupBox grpMasalar;
        private System.Windows.Forms.Button btnYeniMasa;
        private System.Windows.Forms.ListBox lstMasalar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnMasaSil;
        private System.Windows.Forms.GroupBox grpAdamlar;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button3;
    }
}

