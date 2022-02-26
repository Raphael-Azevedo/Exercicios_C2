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
    public partial class F_MaskedTextBox : Form
    {
        public F_MaskedTextBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                maskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
            else
            {
                maskedTextBox1.TextMaskFormat = MaskFormat.IncludeLiterals;
            }

            MessageBox.Show(maskedTextBox1.Text);
        }

        private void Btn_mostrarSenha_Click(object sender, EventArgs e)
        {
            Mtb_senha.UseSystemPasswordChar = false;
        }
    }
}
