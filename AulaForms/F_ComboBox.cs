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
    public partial class F_ComboBox : Form
    {
        public F_ComboBox()
        {
            InitializeComponent();
        }

        private void btn_mostrarSelecionados_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cb_transportes.Text);
        }

        private void btn_limparElementos_Click(object sender, EventArgs e)
        {
            cb_transportes.Items.Clear();
        }

        private void btn_resetarElementos_Click(object sender, EventArgs e)
        {
            cb_transportes.Items.Clear();

            List<string> transportes = new List<string>() {"Carro", "Avião", "Navio", "Onibus", "Trem" };
            cb_transportes.Items.AddRange(transportes.ToArray());
        }

        private void cb_transportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_transporte.Text = cb_transportes.Text;
        }

        private void btn_adicionarNovoTransporte_Click(object sender, EventArgs e)
        {
            if(tb_transporte.Text != "" && (cb_transportes.FindString(tb_transporte.Text) < 0))
            {
                cb_transportes.Items.Add(tb_transporte.Text);
            }
        }
    }
}
