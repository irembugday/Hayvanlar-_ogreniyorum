using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FİNAL
{
    public partial class HAYVAN_SESLERİ : Form
    {
        string[] sesdosyasi = { "kedi (mp3cut.net).wav", "köpek (mp3cut.net).wav", "inek (mp3cut.net).wav", "kuş (mp3cut.net).wav", "aslan (mp3cut.net).wav", "kurbağa2 (mp3cut.net).wav ", "maymun-sesi (mp3cut.net).wav", "ördek (mp3cut.net).wav", "fil (mp3cut.net).wav", "at (mp3cut.net).wav", "kuzu (mp3cut.net).wav", "arı (mp3cut.net).wav" };
        int sayi;
        int dogru = 0; //sayac
        int yanlis = 0;
        string belge;

        public HAYVAN_SESLERİ()
        {
            InitializeComponent();
        }

        System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
        System.Media.SoundPlayer efekt = new System.Media.SoundPlayer();

        private void button14_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            sayi = rastgele.Next(0, 12);
            ses.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + sesdosyasi[sayi];
            ses.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ses.Stop();
            if (sayi == 0)
            {
                belge = "dogru_sesi.wav";
                efekt.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + belge;
                efekt.Play();
                MessageBox.Show("TEBRİKLER DOĞRU BİLDİNİZ! :)");
                dogru++;
                label3.Text = dogru.ToString();
                efekt.Stop();

            }
            else if (sayi != 0)
            {
                belge = "yanlis_sesi.wav";
                efekt.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + belge;
                efekt.Play();
                MessageBox.Show("ÜZGÜNÜM BİLEMEDİNİZ :(");
                yanlis++;
                label4.Text = yanlis.ToString();
                efekt.Stop();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ses.Stop();
            if (sayi == 1)
            {
                belge = "dogru_sesi.wav";
                efekt.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + belge;
                efekt.Play();
                MessageBox.Show("TEBRİKLER DOĞRU BİLDİNİZ! :)");
                dogru++;
                label3.Text = dogru.ToString();
                efekt.Stop();
            }
            else if (sayi != 1)
            {
                belge = "yanlis_sesi.wav";
                efekt.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + belge;
                efekt.Play();
                MessageBox.Show("ÜZGÜNÜM BİLEMEDİNİZ :(");
                yanlis++;
                label4.Text = yanlis.ToString();
                efekt.Stop();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ses.Stop();
            if (sayi == 2)
            {
                belge = "dogru_sesi.wav";
                efekt.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + belge;
                efekt.Play();
                MessageBox.Show("TEBRİKLER DOĞRU BİLDİNİZ! :)");
                dogru++;
                label3.Text = dogru.ToString();
                efekt.Stop();
            }
            else if (sayi != 2)
            {
                belge = "yanlis_sesi.wav";
                efekt.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + belge;
                efekt.Play();
                MessageBox.Show("ÜZGÜNÜM BİLEMEDİNİZ :(");
                yanlis++;
                label4.Text = yanlis.ToString();
                efekt.Stop();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ses.Stop();
            if (sayi == 3)
            {
                belge = "dogru_sesi.wav";
                efekt.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + belge;
                efekt.Play();
                MessageBox.Show("TEBRİKLER DOĞRU BİLDİNİZ! :)");
                dogru++;
                label3.Text = dogru.ToString();
                efekt.Stop();
            }
            else if (sayi != 3)
            {
                belge = "yanlis_sesi.wav";
                efekt.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + belge;
                efekt.Play();
                MessageBox.Show("ÜZGÜNÜM BİLEMEDİNİZ :(");
                yanlis++;
                label4.Text = yanlis.ToString();
                efekt.Stop();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ses.Stop();
            if (sayi == 4)
            {
                belge = "dogru_sesi.wav";
                efekt.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + belge;
                efekt.Play();
                MessageBox.Show("TEBRİKLER DOĞRU BİLDİNİZ! :)");
                dogru++;
                label3.Text = dogru.ToString();
                efekt.Stop();
            }
            else if (sayi != 4)
            {
                belge = "yanlis_sesi.wav";
                efekt.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + belge;
                efekt.Play();
                MessageBox.Show("ÜZGÜNÜM BİLEMEDİNİZ :(");
                yanlis++;
                label4.Text = yanlis.ToString();
                efekt.Stop();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ses.Stop();
            if (sayi == 5)
            {
                belge = "dogru_sesi.wav";
                efekt.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + belge;
                efekt.Play();
                MessageBox.Show("TEBRİKLER DOĞRU BİLDİNİZ! :)");
                dogru++;
                label3.Text = dogru.ToString();
                efekt.Stop();
            }
            else if (sayi != 5)
            {
                belge = "yanlis_sesi.wav";
                efekt.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + belge;
                efekt.Play();
                MessageBox.Show("ÜZGÜNÜM BİLEMEDİNİZ :(");
                yanlis++;
                label4.Text = yanlis.ToString();
                efekt.Stop();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ses.Stop();
            if (sayi == 6)
            {
                belge = "dogru_sesi.wav";
                efekt.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + belge;
                efekt.Play();
                MessageBox.Show("TEBRİKLER DOĞRU BİLDİNİZ! :)");
                dogru++;
                label3.Text = dogru.ToString();
                efekt.Stop();
            }
            else if (sayi != 6)
            {
                belge = "yanlis_sesi.wav";
                efekt.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + belge;
                efekt.Play();
                MessageBox.Show("ÜZGÜNÜM BİLEMEDİNİZ :(");
                yanlis++;
                label4.Text = yanlis.ToString();
                efekt.Stop();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ses.Stop();
            if (sayi == 7)
            {
                belge = "dogru_sesi.wav";
                efekt.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + belge;
                efekt.Play();
                MessageBox.Show("TEBRİKLER DOĞRU BİLDİNİZ! :)");
                dogru++;
                label3.Text = dogru.ToString();
                efekt.Stop();
            }
            else if (sayi != 7)
            {
                belge = "yanlis_sesi.wav";
                efekt.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + belge;
                efekt.Play();
                MessageBox.Show("ÜZGÜNÜM BİLEMEDİNİZ :(");
                yanlis++;
                label4.Text = yanlis.ToString();
                efekt.Stop();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ses.Stop();
            if (sayi == 8)
            {
                belge = "dogru_sesi.wav";
                efekt.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + belge;
                efekt.Play();
                MessageBox.Show("TEBRİKLER DOĞRU BİLDİNİZ! :)");
                dogru++;
                label3.Text = dogru.ToString();
                efekt.Stop();
            }
            else if (sayi != 8)
            {
                belge = "yanlis_sesi.wav";
                efekt.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + belge;
                efekt.Play();
                MessageBox.Show("ÜZGÜNÜM BİLEMEDİNİZ :(");
                yanlis++;
                label4.Text = yanlis.ToString();
                efekt.Stop();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ses.Stop();
            if (sayi == 9)
            {
                belge = "dogru_sesi.wav";
                efekt.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + belge;
                efekt.Play();
                MessageBox.Show("TEBRİKLER DOĞRU BİLDİNİZ! :)");
                dogru++;
                label3.Text = dogru.ToString();
                efekt.Stop();
            }
            else if (sayi != 9)
            {
                belge = "yanlis_sesi.wav";
                efekt.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + belge;
                efekt.Play();
                MessageBox.Show("ÜZGÜNÜM BİLEMEDİNİZ :(");
                yanlis++;
                label4.Text = yanlis.ToString();
                efekt.Stop();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ses.Stop();
            if (sayi == 10)
            {
                belge = "dogru_sesi.wav";
                efekt.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + belge;
                efekt.Play();
                MessageBox.Show("TEBRİKLER DOĞRU BİLDİNİZ! :)");
                dogru++;
                label3.Text = dogru.ToString();
                efekt.Stop();
            }
            else if (sayi != 10)
            {
                belge = "yanlis_sesi.wav";
                efekt.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + belge;
                efekt.Play();
                MessageBox.Show("ÜZGÜNÜM BİLEMEDİNİZ :(");
                yanlis++;
                label4.Text = yanlis.ToString();
                efekt.Stop();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ses.Stop();
            if (sayi == 11)
            {
                belge = "dogru_sesi.wav";
                efekt.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + belge;
                efekt.Play();
                MessageBox.Show("TEBRİKLER DOĞRU BİLDİNİZ! :)");
                dogru++;
                label3.Text = dogru.ToString();
                efekt.Stop();
            }
            else if (sayi != 11)
            {
                belge = "yanlis_sesi.wav";
                efekt.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + belge;
                efekt.Play();
                MessageBox.Show("ÜZGÜNÜM BİLEMEDİNİZ :(");
                yanlis++;
                label4.Text = yanlis.ToString();
                efekt.Stop();
            }
        }

        private void HAYVAN_SESLERİ_Load(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            kaynak yeniform = new kaynak();
            yeniform.Show();
        }
    }
}
