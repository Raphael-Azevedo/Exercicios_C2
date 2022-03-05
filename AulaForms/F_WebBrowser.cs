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
    public partial class F_WebBrowser : Form
    {
        string home = null;
        public F_WebBrowser()
        {
            InitializeComponent();
        }
        private void Navegar()
        {
            if (Tb_url.Text != "")
            {
                webBrowser1.Navigate(Tb_url.Text);
            }
            else
            {
                Tb_url.Focus();
            }
            
        }
        private void Btn_ir_Click(object sender, EventArgs e)
        {
          Navegar();
           
        }

        private void Tb_url_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter )
                Navegar();
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            if(home == null)
            {
                webBrowser1.GoHome();
            }
            else
            {
                webBrowser1.Navigate(home);
            }
            
        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void Btn_proximo_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void webBrowser1_CanGoForwardChanged(object sender, EventArgs e)
        {
            Btn_proximo.Enabled = webBrowser1.CanGoForward;
        }
        private void webBrowser1_CanGoBackChanged(object sender, EventArgs e)
        {
            Btn_voltar.Enabled = webBrowser1.CanGoBack;
        }

        private void Btn_parar_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void Btn_atualizar_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void Btn_pesquisar_Click(object sender, EventArgs e)
        {
            webBrowser1.GoSearch();
        }

        private void Btn_definirHome_Click(object sender, EventArgs e)
        {
            home = Tb_url.Text;
        }
    }
}
