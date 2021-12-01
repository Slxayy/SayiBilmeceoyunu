using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Örnek6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Sayi, hak;

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.AcceptButton = button1;
            MessageBox.Show("Oyun zorluğu ayarlar kısmında, bir zorluk seçmeniz gerekmektedir.");
            MessageBox.Show("Toplam 10 hakkınız var");
            MessageBox.Show("Oyuna başlamak için Oyuna başla butonuna basın.");
        }

        private void button(object sender, EventArgs e)
        {
            //yanlışlıkla basıldı
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //yanlışlıkla basıldı
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label2.Text = "Sayı giriniz.";
            }
            else
            {
                int girdiginSayi = int.Parse(textBox1.Text);

                if (girdiginSayi < Sayi)
                {
                    label2.Text = "Yukarı";
                    hak--;
                }
                else if (girdiginSayi > Sayi)
                {
                    label2.Text = "Aşağı";
                    hak--;
                }
                else
                {
                    label2.Text = "İnanılmaz kazandın!!!";
                    
                }
            }
                    label3.Text = hak.ToString();

            if (hak == 0)
            {
                
                label1.Text = "Oyun bitti kaybettin :(... Sayı " + Sayi;
            }
        }

        private void kolayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            Sayi = rastgele.Next(0, 10);
        }

        private void ortaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            Sayi = rastgele.Next(0, 100);
        }

        private void zorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            Sayi = rastgele.Next(0, 1000);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            hak = 10;
            label3.Text = hak.ToString();
            label2.Text = "";
            textBox1.Text = "";

            button1.Enabled = true;
           
        }
    }
}
