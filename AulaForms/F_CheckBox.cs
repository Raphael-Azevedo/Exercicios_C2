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
    public partial class F_CheckBox : Form
    {

        List<CheckBox> transportes = new List<CheckBox>();
        public F_CheckBox()
        {
            InitializeComponent();
            transportes.Add(cb_carro);
            transportes.Add(cb_aviao);
            transportes.Add(cb_navio);
            transportes.Add(cb_onibus);
        }

        private void btn_transportesMarcados_Click(object sender, EventArgs e)
        {
            string txt = "";
           
            foreach (CheckBox transporte in transportes)
            {
                if(transporte.Checked)
                {
                    txt += transporte.Text + ", ";
                }
            }
            MessageBox.Show(txt);
        }

        private void cb_patinete_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_patinete.Checked)
            {
                MessageBox.Show("Patinete marcada");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_filhoCheckBox f_FilhoCheckBox = new F_filhoCheckBox();
            f_FilhoCheckBox.ShowDialog();
        }
    }
}
