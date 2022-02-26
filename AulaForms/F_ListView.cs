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
    public partial class F_ListView : Form
    {
        public F_ListView()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            Tb_id.Clear();
            Tb_produto.Clear();
            Tb_qtde.Clear();
            Tb_preco.Clear();

            Tb_id.Focus();
        }

        private void Selecionar()
        {
            Tb_id.Text = Lv_produtos.SelectedItems[0].SubItems[0].Text;
            Tb_produto.Text = Lv_produtos.SelectedItems[0].SubItems[1].Text;
            Tb_qtde.Text = Lv_produtos.SelectedItems[0].SubItems[2].Text;
            Tb_preco.Text = Lv_produtos.SelectedItems[0].SubItems[3].Text;
        }
        private void Btn_adicionar_Click(object sender, EventArgs e)
        {
            if(Tb_id.Text == "")
            {
                MessageBox.Show("ID não pode ser vazio");
                Tb_id.Focus();
                return;
            }
            if (Tb_produto.Text == "")
            {
                MessageBox.Show("Produto não pode ser vazio");
                Tb_produto.Focus();
                return;
            }
            if (Tb_qtde.Text == "")
            {
                MessageBox.Show("Quantidade não pode ser vazio");
                Tb_qtde.Focus();
                return;
            }
            if (Tb_preco.Text == "")
            {
                MessageBox.Show("Preço não pode ser vazio");
                Tb_preco.Focus();
                return;
            }
            string[] produtos = new string[4];
            produtos[0] = Tb_id.Text;
            produtos[1] = Tb_produto.Text;
            produtos[2] = Tb_qtde.Text;
            produtos[3] = Tb_preco.Text;

            ListViewItem listView = new ListViewItem(produtos);
            Lv_produtos.Items.Add(listView);
            Limpar();
        }

        private void Btn_remover_Click(object sender, EventArgs e)
        {
            if(Lv_produtos.SelectedItems.Count > 0)
                Lv_produtos.Items.RemoveAt(Lv_produtos.SelectedIndices[0]);
        }

        private void Btn_obter_Click(object sender, EventArgs e)
        {
            Selecionar();
        }

        private void Lv_produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Lv_produtos.SelectedItems.Count > 0)
            {
                Selecionar();
            }
        }
    }
}
