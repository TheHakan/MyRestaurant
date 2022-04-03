using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyRestaurant
{
    public partial class Form1 : Form
    {

        decimal kabab = 5m;
        decimal ayran = 0.50m;
        decimal kola = 1.50m;
        decimal fanta = 1.50m;
        decimal sprite = 1.50m;
        decimal tea = 0.50m;
        decimal pizza = 7m;
        decimal pilav = 3.50m;

        public Form1()
        {
            InitializeComponent();
        }

        decimal TopLam = 0;

        private void pctYemek_Click(object sender, EventArgs e)
        {
            PictureBox pct = sender as PictureBox;
            switch (pct.Name)
            {
                case "pctKabab":
                    TopLam = TopLam + kabab;

                    lstSiparisler.Items.Add(string.Format("Kabab  - {0} ({1})", kabab, lstMasalar.SelectedItem));
                    break;
                case "pctPilav":
                    TopLam = TopLam + pilav;
                    lstSiparisler.Items.Add(string.Format("Pilav  - {0} ({1})", pilav, lstMasalar.SelectedItem));

                    break;

                case "pctPizza":
                    TopLam = TopLam + pizza;
                    lstSiparisler.Items.Add(string.Format("Pizza  - {0} ({1})", pizza, lstMasalar.SelectedItem));

                    break;

                case "pctCola":
                    TopLam = TopLam + kola;
                    lstSiparisler.Items.Add(string.Format("Kola  - {0} ({1})", kabab, lstMasalar.SelectedItem));

                    break;

                case "pctAyran":
                    lstSiparisler.Items.Add(string.Format("Ayran  - {0} ({1})", ayran, lstMasalar.SelectedItem));

                    TopLam = TopLam + ayran;
                    break;

                case "pctSprite":
                    TopLam = TopLam + sprite;
                    lstSiparisler.Items.Add(string.Format("Sprite  - {0} ({1})", sprite, lstMasalar.SelectedItem));
                    break;

                case "pctFanta":
                    lstSiparisler.Items.Add(string.Format("Fanta  - {0} ({1})", fanta, lstMasalar.SelectedItem));

                    TopLam = TopLam + fanta;
                    break;

                case "pctTea":
                    lstSiparisler.Items.Add(string.Format("Cay  - {0} ({1})", tea, lstMasalar.SelectedItem));

                    TopLam = TopLam + tea;
                    break;
            }

            lblSum.Text = "Toplam Tutar : " + TopLam + " TL";
        }

        int masasayi = 0;

        private void btnYeniMasa_Click(object sender, EventArgs e)
        {
            //masasayi++;

           
            //lstSiparisler.Items.Add("Masa : " + masasayi);
            //lstMasalar.Items.Add("Masa : " + masasayi);

            //if (masasayi == 5)
            //{
            //    btnYeniMasa.Visible = false;
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lstMasalar.Items.Count > 0)
            {
                grpYemekler.Enabled = true;
            }
            else
            {
                grpYemekler.Enabled = false;
            }

            if (masasayi < 5)
            {
                btnYeniMasa.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnMasaSil_Click(object sender, EventArgs e)
        {
            int a = lstMasalar.SelectedIndex+1;
            lstMasalar.Items[lstMasalar.SelectedIndex] = "Masa"+ a;
            //lstMasalar.Items.Remove(lstMasalar.SelectedItem);
            //masasayi = masasayi - 1;
        }

        private void lstMasalar_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstMasalar.Items[lstMasalar.SelectedIndex] = "AKTIV";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstSiparisler.Items.Clear();
        }

        private void lstMasalar_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lstMasalar.SelectedIndex == 0)
            {
                listBox1.Items[lstMasalar.SelectedIndex] = "Hesap 1: " + TopLam + "TL";
            }
            else if(lstMasalar.SelectedIndex == 1)
            {
                listBox1.Items[lstMasalar.SelectedIndex] = "Hesap 2: " + TopLam + "TL";
            }
            else if (lstMasalar.SelectedIndex == 2)
            {
                listBox1.Items[lstMasalar.SelectedIndex] = "Hesap 3: " + TopLam + "TL";
            }
            else if (lstMasalar.SelectedIndex == 3)
            {
                listBox1.Items[lstMasalar.SelectedIndex] = "Hesap 4: " + TopLam + "TL";
            }
            else if (lstMasalar.SelectedIndex == 4)
            {
                listBox1.Items[lstMasalar.SelectedIndex] = "Hesap 5: " + TopLam + "TL";
            }
            else if (lstMasalar.SelectedIndex == 5)
            {
                listBox1.Items[lstMasalar.SelectedIndex] = "Hesap 6: " + TopLam + "TL";
            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            int count = richTextBox1.Text.Split(' ').Count();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
