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
    public partial class F_CheckedListBox : Form
    {
        public F_CheckedListBox()
        {
            InitializeComponent();
        }

        private void btn_mostrarSelecionados_Click(object sender, EventArgs e)
        {
            string txt = "";

            foreach(string transporte in clb_transportes.CheckedItems)
            {
                txt += transporte + ", ";
            }
            
            MessageBox.Show(txt);
        }

        private void btn_limparLista_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();
        }

        private void btn_resetarLista_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();

            List<string> transportes = new List<string>() {"Carro", "Avião", "Navio", "Onibus", "Trem"};

            clb_transportes.Items.AddRange(transportes.ToArray());
        }

        private void btn_addNovoTransporte_Click(object sender, EventArgs e)
        {
            if (tb_novoTransporte.Text != "")
            {
                clb_transportes.Items.Add(tb_novoTransporte.Text, false);
                tb_novoTransporte.Clear();
                tb_novoTransporte.Focus();
            }
        }
    }
}
