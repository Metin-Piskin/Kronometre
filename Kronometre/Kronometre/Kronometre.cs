using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kronometre
{
    public partial class Kronometre : Form
    {
        public Kronometre()
        {
            InitializeComponent();
        }
        int saat = 0, dakika = 0, saniye = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            saat = 0;
            saniye = 0;
            dakika = 0;
            label1.Text = 0.ToString();
            label2.Text = 0.ToString();
            label3.Text = 0.ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            label3.Text = saniye.ToString();
            if (saniye == 60)
            {
                dakika++;
                label2.Text = dakika.ToString();
                saniye = 0;
                if (dakika == 6)
                {
                    saat++;
                    label1.Text = saat.ToString();
                    dakika = 0;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
