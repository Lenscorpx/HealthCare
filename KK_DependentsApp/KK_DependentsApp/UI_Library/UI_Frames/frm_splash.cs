using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KK_DependentsApp.UI_Library.UI_Frames
{
    public partial class frm_splash : Form
    {
        int count = 0, buffer = 0;
        public frm_splash()
        {
            InitializeComponent();
            Opacity = 0;
            timer1.Start();
        }      

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer2.Start();
                timer1.Stop();
            }
            else
            {
                count++;
                Opacity = count * 0.05;
                pictureBox2.Show();
                pictureBox1.Hide();
            }
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            pictureBox1.Show();
            pictureBox2.Hide();
            if (buffer == 30)
            {
                timer3.Start();
                timer2.Stop();
            }
            else
            {
                buffer++;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                this.Hide();
                var m = new frm_dashboard();
                m.Show();
                timer3.Stop();               
            }
            else
            {
                count--;
                Opacity = count * 0.05;
                pictureBox1.Show();
                //pictureBox2.Hide();
                pictureBox2.Hide();
            }
        }
    }
}
