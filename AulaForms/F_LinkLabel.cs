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
    public partial class F_LinkLabel : Form
    {
        public F_LinkLabel()
        {
            InitializeComponent();
            Ll_multiplosLinks.Links.Add(0,6, "www.google.com.br");
            Ll_multiplosLinks.Links.Add(9, 5, "http://youtube.com/cfbcursos");
            Ll_multiplosLinks.Links.Add(17, 7, "http://youtube.com");

            Ll_multiplosLinks.Links[2].Enabled = false;
        }

        private void Ll_canal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://youtube.com/cfbcursos");
            LinkLabel linklabel = (LinkLabel)sender;
            linklabel.LinkVisited = true;
        }

        private void Ll_calculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void Ll_multiplosLinks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            e.Link.Visited = true;
        }
    }
}
