using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _171222
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            if(comboBox1.Text == "")
            {
                string showErr = label1.Text = "Vade Yeri Boş.";
            } else
            {
                double taksit = Double.Parse(comboBox1.Text);
                double input1 = Double.Parse(textBox1.Text);
                if (input1 > 1000 && input1 < 20000)
                {
                    double hesaplama = ((input1 * (1.015 * taksit)) / (taksit * taksit));
                    string yaziyaCEV = Convert.ToString(hesaplama);
                    string yaziyaDok = label1.Text = yaziyaCEV;
                }
                else if (input1 >= 20000 && input1 < 50000)
                {
                    double hesaplama = ((input1 * (1.02 * taksit)) / (taksit * taksit));
                    string yaziyaCEV = Convert.ToString(hesaplama);
                    string yaziyaDok = label1.Text = yaziyaCEV;
                }

                else
                {
                    string showErr = label1.Text = "Hata 5000'den büyük sayı girilemez.");
                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
