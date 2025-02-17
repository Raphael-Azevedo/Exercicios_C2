﻿using System;
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
    public partial class F_TrackBar : Form
    {
        public F_TrackBar()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Tb_valor.Text = trackBar1.Value.ToString();
            label1.Text = trackBar1.Value.ToString();
        }

        private void Btn_definir_Click(object sender, EventArgs e)
        {
            if (int.Parse(Tb_valor.Text) < trackBar1.Minimum)
            {
                MessageBox.Show("Valor muito pequeno");
                return;
            }
            if (int.Parse(Tb_valor.Text) > trackBar1.Maximum)
            {
                MessageBox.Show("Valor muito grande");
                return;
            }

            trackBar1.Value = int.Parse(Tb_valor.Text);
            label1.Text = Tb_valor.Text;
        }

        private void F_TrackBar_Load(object sender, EventArgs e)
        {
            Tb_valor.Text = trackBar1.Value.ToString();
            label1.Text = trackBar1.Value.ToString();
        }
    }
}
