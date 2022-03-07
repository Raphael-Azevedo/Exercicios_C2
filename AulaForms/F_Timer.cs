using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula60
{
    public partial class F_Timer : Form
    {
        int num;
        int px, py;
        public F_Timer()
        {
            InitializeComponent();
        }

        private void F_Timer_Load(object sender, EventArgs e)
        {
            num = 0;
            px = pictureBox1.Location.X;
            py = pictureBox1.Location.Y;
        }

        private void Btn_iniciar_t1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Btn_parar_t1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = num.ToString();
            num++;
        }

        private void Btn_reiniciar_t1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            num = 0;
            label1.Text = num.ToString();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            px ++;
            if (px >= 620)
                px = 12;

            pictureBox1.Location = new Point(px, py);
            px = pictureBox1.Location.X;
        }
    }
}
