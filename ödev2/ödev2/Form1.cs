using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int saniye = 0;
        int dakika = 0;
        private void btnbaşlat_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int dakika = Convert.ToInt32(lbldakika.Text);
            saniye++;
            lblsaniye.Text = saniye.ToString();


            if (saniye == 59) 
            { 
            saniye = 0;
             lblsaniye.Text = saniye.ToString();

                dakika++;
                lbldakika.Text = dakika.ToString();
                


            }
        }

        private void btndur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnsifirla_Click(object sender, EventArgs e)
        {
            
            lbldakika.Text = "";
            lblsaniye.Text = "";
            saniye = 0;
            dakika = 0;
        }
    }
}
