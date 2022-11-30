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
    public partial class settingsENV : Form
    {




        public settingsENV()
        {
            InitializeComponent();
        }

        private void settingsENV_Load(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load("settings.xml");


            foreach (XElement element in doc.Element("ayarlar").Descendants("on-off"))
            {

                string value = element.Value;
                textBox1.Text = value;
            }

            foreach (XElement element in doc.Element("ayarlar").Descendants("workplace"))
            {

                string value = element.Value;
                textBox2.Text = value;
            }

            foreach (XElement element in doc.Element("ayarlar").Descendants("downloadfile"))
            {

                string value = element.Value;
                textBox3.Text = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string settingsFile = "settings.xml";


            string onoff = textBox1.Text.ToString();
            string wp = textBox2.Text.ToString();
            string df = textBox3.Text.ToString();

            if (Directory.Exists(settingsFile))
            {
                Directory.CreateDirectory(settingsFile);
            }

            if (File.Exists(settingsFile))
            {
                FileStream fs = new FileStream(settingsFile, FileMode.OpenOrCreate);
                string icerik = "<?xml version=\"1.0\" encoding=\"utf-8\" ?> " + "\n<ayarlar>" + "\n<on-off>" + onoff + "</on-off>" + "\n<workplace>" + wp + "</workplace>" + "\n<downloadfile>" + df + "</downloadfile>" + "\n</ayarlar>";
                fs.Flush();
                fs.Close();

                File.WriteAllText(settingsFile, icerik);
            }
            else
            {
                MessageBox.Show("Hata", "Hata Yönetimi");
            }
             

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string settingsFile= "settings.xml";
            
            if (!File.Exists(settingsFile))
            {
                FileStream fs = new FileStream(settingsFile, FileMode.OpenOrCreate);
                fs.Flush();
                fs.Close();
                MessageBox.Show("Dosya Oluşturuldu.");
            }
            else
            {
                MessageBox.Show("Dosya Mevcut");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
