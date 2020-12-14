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
    public partial class İNGİLİZCE_HAYVANLAR : Form
    {
        string[] sesdosyasi = { "cat.wav", "dog.wav", "cow.wav", "bird.wav", "lion.wav", "frog.wav ", "monkey.wav", "duck.wav", "elephant.wav", "horse.wav", "sheep.wav", "bee.wav" };
        int sayi;
        int dogru = 0;
        int yanlis = 0;
        string belge;

        public İNGİLİZCE_HAYVANLAR()
        {
            InitializeComponent();
        }

        System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
        System.Media.SoundPlayer efekt = new System.Media.SoundPlayer();

        private void İNGİLİZCE_HAYVANLAR_Load(object sender, EventArgs e)
        {

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
                MessageBox.Show("KEDİ SÖZCÜĞÜNÜN İNGİLİZCE YAZILIŞI: CAT ");
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
                MessageBox.Show("KÖPEK SÖZCÜĞÜNÜN İNGİLİZCE YAZILIŞI: DOG ");
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
                MessageBox.Show("İNEK SÖZCÜĞÜNÜN İNGİLİZCE YAZILIŞI: COW ");
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
                MessageBox.Show("KUŞ SÖZCÜĞÜNÜN İNGİLİZCE YAZILIŞI: BİRD ");
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
                MessageBox.Show("ASLAN SÖZCÜĞÜNÜN İNGİLİZCE YAZILIŞI: LİON ");
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
                MessageBox.Show("KURBAĞA SÖZCÜĞÜNÜN İNGİLİZCE YAZILIŞI: FROG ");
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
                MessageBox.Show("MAYMUN SÖZCÜĞÜNÜN İNGİLİZCE YAZILIŞI: MONKEY ");
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
                MessageBox.Show("ÖRDEK SÖZCÜĞÜNÜN İNGİLİZCE YAZILIŞI: DUCK ");
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
                MessageBox.Show("FİL SÖZCÜĞÜNÜN İNGİLİZCE YAZILIŞI: ELEPHANT ");
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
                MessageBox.Show("AT SÖZCÜĞÜNÜN İNGİLİZCE YAZILIŞI: HORSE ");
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
                MessageBox.Show("KOYUN SÖZCÜĞÜNÜN İNGİLİZCE  YAZILIŞI: SHEEP ");
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
                MessageBox.Show("ARI SÖZCÜĞÜNÜN İNGİLİZCE YAZILIŞI: BEE ");
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

        private void button14_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            sayi = rastgele.Next(0, 12);
            ses.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + sesdosyasi[sayi];
            ses.Play();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            kaynak2 ikincikaynak = new kaynak2();
            ikincikaynak.Show();
        }
    }
}
