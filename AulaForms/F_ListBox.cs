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
    public partial class F_ListBox : Form
    {
        List<string> carros = new List<string>() {"HRV","Golf","Focus"};
        public F_ListBox()
        {
            InitializeComponent();

            Lb_carros.DataSource = carros;
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if(Tb_carro.Text == "")
            {
                MessageBox.Show("Digite um carro");
                Tb_carro.Focus();
            }
            else
            {
                carros.Add(Tb_carro.Text);
                Tb_carro.Clear();
                Atualizar_ListBoxCarros(Lb_carros, carros);
            }
        }

        private void Btn_Remover_Click(object sender, EventArgs e)
        {
            carros.RemoveAt(Lb_carros.SelectedIndex);
            Atualizar_ListBoxCarros(Lb_carros, carros);
        }

        private void Btn_obter_Click(object sender, EventArgs e)
        {
            Tb_carro.Text = carros[Lb_carros.SelectedIndex];
        }

        private void Btn_limpar_Click(object sender, EventArgs e)
        {
            carros.Clear();
            Atualizar_ListBoxCarros(Lb_carros, carros);
        }

        private void Atualizar_ListBoxCarros(ListBox listbox, List<string> list)
        {
            Lb_carros.DataSource = null;
            Lb_carros.DataSource = list;
        }
    }
}
