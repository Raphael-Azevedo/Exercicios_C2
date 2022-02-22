﻿using System;
using System.Windows.Forms;

namespace Aula60
{
    public partial class F_Principal : Form
    {
        public int num;
        public F_Principal()
        {
            InitializeComponent();
            num = 0;
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if(tb_veiculo.Text == "")
            {
                MessageBox.Show("Digite um Veículo");
                tb_veiculo.Focus();
                return;
            }

            tb_listaVeiculos.Text += tb_veiculo.Text + ", ";
            tb_veiculo.Clear();
            tb_veiculo.Focus();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_listaVeiculos.Clear();
            tb_veiculo.Clear();
            tb_veiculo.Focus();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            F_Veiculos f_Veiculos = new F_Veiculos(tb_listaVeiculos.Text, this);
            f_Veiculos.ShowDialog();
        }

        private void btn_valNum_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }
    }
}
