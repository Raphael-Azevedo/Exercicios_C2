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
    public partial class F_NumericUpDown : Form
    {
        public F_NumericUpDown()
        {
            InitializeComponent();
        }

        private void Btn_definirValor_Click(object sender, EventArgs e)
        {
            if((Decimal.Parse(Tb_valor.Text) >= numericUpDown1.Minimum) && (Decimal.Parse(Tb_valor.Text) <= numericUpDown1.Maximum))
                numericUpDown1.Value = Decimal.Parse(Tb_valor.Text);
        }
    }
}
