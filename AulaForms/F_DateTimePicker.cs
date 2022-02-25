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
    public partial class F_DateTimePicker : Form
    {
        public F_DateTimePicker()
        {
            InitializeComponent();
        }

        private void Btn_obterData_Click(object sender, EventArgs e)
        {
            Tb_data.Text = Dtp_data.Text;
            Tb_dia.Text = Dtp_data.Value.Day.ToString();
            Tb_mes.Text = Dtp_data.Value.Month.ToString();
            Tb_ano.Text = Dtp_data.Value.Year.ToString();
        }

        private void Btn_setarData_Click(object sender, EventArgs e)
        {
            int dia, mes, ano;
            dia = int.Parse(Tb_dia.Text);
            mes = int.Parse(Tb_mes.Text);
            ano = int.Parse(Tb_ano.Text);

            DateTime dateTime = new DateTime(ano, mes, dia);

            Dtp_data.Value = dateTime;
        }

        private void Btn_hoje_Click(object sender, EventArgs e)
        {
           
            Dtp_data.Value = DateTime.Today;
        }
    }
}
