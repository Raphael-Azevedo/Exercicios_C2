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
    public partial class F_Veiculos : Form
    {
        private readonly F_Principal _f_principal;
        public F_Veiculos(string veiculos, F_Principal f_Principal)
        {
            InitializeComponent();

            tb_listaVeiculos.Text = veiculos;

            _f_principal = f_Principal;

            f_Principal.num = 10;

        }

        private void F_Veiculos_FormClosed(object sender, FormClosedEventArgs e)
        {
            _f_principal.tb_listaVeiculos.Text = tb_listaVeiculos.Text;
        }
    }
}
