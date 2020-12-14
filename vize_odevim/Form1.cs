using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vize_odevim
{
    public partial class Form1 : Form
    {
        string[] sesdosyasi = {"kedi (mp3cut.net).wav","köpek (mp3cut.net).wav","inek (mp3cut.net).wav","kuş (mp3cut.net).wav","aslan (mp3cut.net).wav","kurbağa2 (mp3cut.net).wav ","maymun-sesi (mp3cut.net).wav","ördek (mp3cut.net).wav","fil (mp3cut.net).wav","at (mp3cut.net).wav","kuzu (mp3cut.net).wav","arı (mp3cut.net).wav"};
        int sayi;
        int dogru = 0;
        int yanlis = 0;
        public Form1()
        {
            InitializeComponent();
        }
        
        System.Media.SoundPlayer ses = new System.Media.SoundPlayer();

        string belge;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            sayi = rastgele.Next(0, 12);
            ses.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + sesdosyasi[sayi];
            ses.Play();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sayi==0)
            {
                MessageBox.Show("doğru bildiniz");
                dogru++;
                label3.Text = dogru.ToString();
            }
            else if (sayi!=0)
            {
                MessageBox.Show("yanlış bildiniz");
                yanlis++;
                label4.Text = yanlis.ToString();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sayi == 1)
            {
                MessageBox.Show("doğru bildiniz");
                dogru++;
                label3.Text = dogru.ToString();
            }
            else if (sayi != 1)
            {
                MessageBox.Show("yanlış bildiniz");
                yanlis++;
                label4.Text = yanlis.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sayi == 2)
            {
                MessageBox.Show("doğru bildiniz");
                dogru++;
                label3.Text = dogru.ToString();
            }
            else if (sayi != 2)
            {
                MessageBox.Show("yanlış bildiniz");
                yanlis++;
                label4.Text = yanlis.ToString();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (sayi == 3)
            {
                MessageBox.Show("doğru bildiniz");
                dogru++;
                label3.Text = dogru.ToString();
            }
            else if (sayi != 3)
            {
                MessageBox.Show("yanlış bildiniz");
                yanlis++;
                label4.Text = yanlis.ToString();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sayi == 4)
            {
                MessageBox.Show("doğru bildiniz");
                dogru++;
                label3.Text = dogru.ToString();
            }
            else if (sayi != 4)
            {
                MessageBox.Show("yanlış bildiniz");
                yanlis++;
                label4.Text = yanlis.ToString();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (sayi == 5)
            {
                MessageBox.Show("doğru bildiniz");
                dogru++;
                label3.Text = dogru.ToString();
            }
            else if (sayi != 5)
            {
                MessageBox.Show("yanlış bildiniz");
                yanlis++;
                label4.Text = yanlis.ToString();

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (sayi == 6)
            {
                MessageBox.Show("doğru bildiniz");
                dogru++;
                label3.Text = dogru.ToString();
            }
            else if (sayi != 6)
            {
                MessageBox.Show("yanlış bildiniz");
                yanlis++;
                label4.Text = yanlis.ToString();

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (sayi == 7)
            {
                MessageBox.Show("doğru bildiniz");
                dogru++;
                label3.Text = dogru.ToString();
            }
            else if (sayi != 7)
            {
                MessageBox.Show("yanlış bildiniz");
                yanlis++;
                label4.Text = yanlis.ToString();

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (sayi == 8)
            {
                MessageBox.Show("doğru bildiniz");
                dogru++;
                label3.Text = dogru.ToString();
            }
            else if (sayi != 8)
            {
                MessageBox.Show("yanlış bildiniz");
                yanlis++;
                label4.Text = yanlis.ToString();

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (sayi == 9)
            {
                MessageBox.Show("doğru bildiniz");
                dogru++;
                label3.Text = dogru.ToString();
            }
            else if (sayi != 9)
            {
                MessageBox.Show("yanlış bildiniz");
                yanlis++;
                label4.Text = yanlis.ToString();

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (sayi == 10)
            {
                MessageBox.Show("doğru bildiniz");
                dogru++;
                label3.Text = dogru.ToString();
            }
            else if (sayi != 10)
            {
                MessageBox.Show("yanlış bildiniz");
                yanlis++;
                label4.Text = yanlis.ToString();

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (sayi == 11)
            {
                MessageBox.Show("doğru bildiniz");
                dogru++;
                label3.Text = dogru.ToString();
            }
            else if (sayi != 11)
            {
                MessageBox.Show("yanlış bildiniz");
                yanlis++;
                label4.Text = yanlis.ToString();

            }
        }
    }
}
