using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Galkin_clickee
{
    public partial class Form1 : Form
    {
        double cislo=0;
        double GPS=0;
        int click = 1;
        int Leninade=0;
        int Krym = 0;
       




        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cislo = cislo + click ;
            Galkin.Text = cislo+"G";
            Galkin.Invalidate();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            Lenintext.Text = "Leninade za 100 Galkinu ( 0x +1GPS )";
            if (cislo>=100)
            {
                cislo = cislo - 100;
                Leninade++;
                GPS++;
                Galkin.Text = cislo+" Galkinu";
                Lenintext.Text = "Leninade za 100 Galkinu(+1GPS) (" + (Leninade) + "x )";
                timer1.Enabled = true;
            }
            if (Leninade >= 5)
            {
                pictureBox3.Enabled = true;
                Krymtext.Enabled = true;
                pictureBox3.Visible = true;
                Krymtext.Visible = true;
                Krymtext.Text = "Krym za 1000 Galkinu(+15GPS) (" + (Krym) + "x )";

            }
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cislo = cislo + GPS;
            
            
        }

        private void obnova_Tick(object sender, EventArgs e)
        {
            Galkin.Text = Math.Round(cislo,1) + "G";
            GPSLabel.Text = GPS + "GPS";
            Lenintext.Text = "Leninade za 100 Galkinu(+1GPS) (" + (Leninade) + "x )";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            if (cislo >= 1000)
            {
                cislo = cislo - 1000;
                Krym++;
                GPS = GPS + 15;
                Krymtext.Text = "Krym za 1000 Galkinu(+15GPS) (" + (Krym) + "x )";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
