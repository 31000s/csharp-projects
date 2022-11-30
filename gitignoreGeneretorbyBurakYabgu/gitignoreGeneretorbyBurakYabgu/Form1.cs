using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Windows.Forms;



namespace gitignoreGeneretorbyBurakYabgu
{


    public partial class Form1 : Form
    {
        public static string chooseFile;
        public static string satir;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            chooseFile = comboBox2.Text + textBox2.Text + comboBox1.Text;
            if (textBox1.Text == "")
            {
                label1.Text = "Boş Metin";
            }
            else
            {
                if (!File.Exists(chooseFile))
                {

                    label1.Text = "Dosya Oluşturunuz";
                }
                else
                {
                    File.WriteAllText(chooseFile, textBox1.Text);
                    label1.Text = "Dosyaya Yazdırıldı.";

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            chooseFile = comboBox2.Text + textBox2.Text +  comboBox1.Text;
            if (!File.Exists(chooseFile))
            {
                FileStream fs = new FileStream(chooseFile, FileMode.OpenOrCreate);
                fs.Flush();
                fs.Close();
                label1.Text = "Dosya Oluşturuldu.";
            }
            else
            {
                label1.Text = "Dosya Mevcut";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chooseFile = comboBox2.Text + textBox2.Text + comboBox1.Text;
            if (!File.Exists(chooseFile))
            {
                label1.Text = "Böyle bir dosya yok.";
            }
            else
            {

                File.Delete(chooseFile);
                label1.Text = "Dosya silindi.";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chooseFile = comboBox2.Text + textBox2.Text + comboBox1.Text;


            gitignoreReader gr = new gitignoreReader();
            gr.Show();

           
            

     
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            string path = Application.StartupPath;
            comboBox2.Items.Add(path);


            XDocument doc = XDocument.Load("settings.xml");

            foreach (XElement element in doc.Element("ayarlar").Descendants("workplace"))
            {
        
                string value = element.Value;
                comboBox2.Items.Add(value);
            }

            foreach (XElement element in doc.Element("ayarlar").Descendants("downloadfile"))
            {

                string value = element.Value;
                comboBox2.Items.Add(value);
            }

                }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("creator by https://github.com/31000s \nLICENSE: Burak A. Y.", ".gitignore generetor v1.0");
        }

        private void button6_Click(object sender, EventArgs e)
        {

            settingsENV SE = new settingsENV();
            SE.Show();


        
        }

  
    }
}




