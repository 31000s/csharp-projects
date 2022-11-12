using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MaasVergiHesaplamaSistemi

{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {



            if (Person1.Text == "" || Person2.Text == "" || Person3.Text == "")
            {

                MessageBox.Show("Lütfen Hesaplama Yaptıktan Sonra Toplamını Çıkarınız.", "Sistem");

            }
            else {
                double Persones1, Persones2, Persones3, Normal;
                double VergiKesintisiPer1, VergiKesintisiPer2, VergiKesintisiPer3;
                double GuncelMaasPer1, GuncelMaasPer2, GuncelMaasPer3, Gtoplam;
                string NormalYaziyaCev, Nyazi;
                string YaziyaCev, Gsonuc;

                Persones1 = Double.Parse(Person1.Text);
                Persones2 = Double.Parse(Person2.Text);
                Persones3 = Double.Parse(Person3.Text);

                Normal = Persones1 + Persones2 + Persones3;
                NormalYaziyaCev = Convert.ToString(Normal);
                Nyazi = normalMaaslar.Text = NormalYaziyaCev;

                VergiKesintisiPer1 = Persones1 * 15 / 100;
                GuncelMaasPer1 = Persones1 - VergiKesintisiPer1;

                VergiKesintisiPer2 = Persones2 * 15 / 100;
                GuncelMaasPer2 = Persones2 - VergiKesintisiPer2;

                VergiKesintisiPer3 = Persones3 * 15 / 100;
                GuncelMaasPer3 = Persones3 - VergiKesintisiPer3;

                Gtoplam = GuncelMaasPer1 + GuncelMaasPer2 + GuncelMaasPer3;

                YaziyaCev = Convert.ToString(Gtoplam);
                Gsonuc = toplami.Text = YaziyaCev;
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Github: 31000s
        }

        private void button2_Click(object sender, EventArgs e)
        //PERSON 1
        {
            
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Ad ve Soyad Alanı Boş", "Person 1");
            }
            else if (Person1.Text == "")
            {

                MessageBox.Show("Lütfen maaş giriniz.", "Person 1");
            }
            else
            {
                
                double PersonCash1 = Double.Parse(Person1.Text);
                double vergiKesintisi1 = 0, GuncelMaas1 = 0;
                vergiKesintisi1 = PersonCash1 * 15 / 100;
                GuncelMaas1 = PersonCash1 - vergiKesintisi1;
                string YaziyaCev1 = Convert.ToString(GuncelMaas1);
                string sonuc1 = maasl1.Text = YaziyaCev1;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //PERSON 2
            if (textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Ad ve Soyad Alanı Boş", "Person 2");
            }
            else if (Person2.Text == "")
            {

                MessageBox.Show("Lütfen maaş giriniz.", "Person 2");
            }
            else
            {
                double PersonCash2 = Double.Parse(Person2.Text);
                double vergiKesintisi2 = 0, GuncelMaas2 = 0;
                vergiKesintisi2 = PersonCash2 * 15 / 100;
                GuncelMaas2 = PersonCash2 - vergiKesintisi2;
                string YaziyaCev2 = Convert.ToString(GuncelMaas2);
                string sonuc2 = maasl2.Text = YaziyaCev2;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //PERSON 2
            if (textBox6.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Ad ve Soyad Alanı Boş", "Person 3");
            }
            else if (Person3.Text == "")
            {

                MessageBox.Show("Lütfen maaş giriniz.", "Person 3");
            }
            else
            {
                double PersonCash3 = Double.Parse(Person3.Text);
                double vergiKesintisi3 = 0, GuncelMaas3 = 0;
                vergiKesintisi3 = PersonCash3 * 15 / 100;
                GuncelMaas3 = PersonCash3 - vergiKesintisi3;
                string YaziyaCev3 = Convert.ToString(GuncelMaas3);
                string sonuc3 = maasl3.Text = YaziyaCev3;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/31000s");
        }

    }

        }

    

    

