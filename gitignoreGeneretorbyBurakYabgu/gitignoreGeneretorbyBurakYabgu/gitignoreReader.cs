using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace gitignoreGeneretorbyBurakYabgu
{
    public partial class gitignoreReader : Form
    {
        public static string satir;
        public static string chooseFile;


        public gitignoreReader()
        {
            InitializeComponent();
        }
        private void gitignoreReader_Load(object sender, EventArgs e)
        {
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string chooseFile = Form1.chooseFile;

            if (richTextBox1.Text == "")
            {
                MessageBox.Show("Boş metin.");
            }
            else
            {
                if (!File.Exists(chooseFile))
                {

                    MessageBox.Show("Dosya yok.");
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter(chooseFile))
                    {
                        foreach (var satir in richTextBox1.Lines)
                        {
                            writer.WriteLine(satir);
                        }

                        MessageBox.Show("Kaydedildi.");

                    }
                }
            }
        }

        private void okuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string chooseFile = Form1.chooseFile;

            if (!File.Exists(chooseFile))
            {
                MessageBox.Show("Böyle bir dosya yok.");
            }
            else {
                richTextBox1.Clear();
                FileStream fileStream = new FileStream(chooseFile, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    while (true)
                    {

                        satir = reader.ReadLine();
                        richTextBox1.Text += satir + "\n";
                        if (satir == null) break;
                    }
                    reader.Close();
                }
                fileStream.Close();
            }
        }

        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

    }

}