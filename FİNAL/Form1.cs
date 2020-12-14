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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rastgele = new Random(); 
            int red = rastgele.Next(0, 256);
            int green = rastgele.Next(0, 256);
            int blue = rastgele.Next(0, 256);

            this.BackColor = Color.FromArgb(red, green, blue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HAYVAN_SESLERİ yeniform = new HAYVAN_SESLERİ();
            yeniform.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            İNGİLİZCE_HAYVANLAR ikinciform = new İNGİLİZCE_HAYVANLAR();
            ikinciform.Show();
        }
    }
}
