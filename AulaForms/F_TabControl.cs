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
    public partial class F_TabControl : Form
    {
        public F_TabControl()
        {
            InitializeComponent();
        }

        private void Btn_novaTab_Click(object sender, EventArgs e)
        {
            if (Tb_nomeNovaTab.Text != "")
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = Tb_nomeNovaTab.Text;
                tabPage.Name = Tb_nomeNovaTab.Text;
                tabPage.TabIndex = tabControl1.TabPages.Count;
                tabControl1.TabPages.Add(tabPage);
                Tb_nomeNovaTab.Clear();
                DefirnirMaximo();
            }
            else
            {
                MessageBox.Show("Digite o nome da nova página");
                Tb_nomeNovaTab.Focus();
            }
        }

        private void Btn_removerTab_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            DefirnirMaximo();
        }

        private void Btn_posicionarTab_Click(object sender, EventArgs e)
        {
           tabControl1.SelectedIndex = int.Parse(numericUpDown1.Value.ToString());
        }

        private void DefirnirMaximo()
        {
            numericUpDown1.Maximum = tabControl1.TabPages.Count - 1;
        }

        private void F_TabControl_Load(object sender, EventArgs e)
        {
            DefirnirMaximo();
        }
    }
}
