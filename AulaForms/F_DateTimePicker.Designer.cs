namespace Aula60
{
    partial class F_DateTimePicker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Dtp_data = new System.Windows.Forms.DateTimePicker();
            this.Btn_obterData = new System.Windows.Forms.Button();
            this.Tb_data = new System.Windows.Forms.TextBox();
            this.Tb_dia = new System.Windows.Forms.TextBox();
            this.Tb_mes = new System.Windows.Forms.TextBox();
            this.Tb_ano = new System.Windows.Forms.TextBox();
            this.Btn_setarData = new System.Windows.Forms.Button();
            this.Btn_hoje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Dtp_data
            // 
            this.Dtp_data.Location = new System.Drawing.Point(37, 13);
            this.Dtp_data.Name = "Dtp_data";
            this.Dtp_data.Size = new System.Drawing.Size(313, 20);
            this.Dtp_data.TabIndex = 0;
            // 
            // Btn_obterData
            // 
            this.Btn_obterData.Location = new System.Drawing.Point(356, 12);
            this.Btn_obterData.Name = "Btn_obterData";
            this.Btn_obterData.Size = new System.Drawing.Size(322, 23);
            this.Btn_obterData.TabIndex = 1;
            this.Btn_obterData.Text = "Obter Data";
            this.Btn_obterData.UseVisualStyleBackColor = true;
            this.Btn_obterData.Click += new System.EventHandler(this.Btn_obterData_Click);
            // 
            // Tb_data
            // 
            this.Tb_data.Location = new System.Drawing.Point(37, 39);
            this.Tb_data.Name = "Tb_data";
            this.Tb_data.Size = new System.Drawing.Size(313, 20);
            this.Tb_data.TabIndex = 2;
            // 
            // Tb_dia
            // 
            this.Tb_dia.Location = new System.Drawing.Point(37, 66);
            this.Tb_dia.Name = "Tb_dia";
            this.Tb_dia.Size = new System.Drawing.Size(100, 20);
            this.Tb_dia.TabIndex = 3;
            // 
            // Tb_mes
            // 
            this.Tb_mes.Location = new System.Drawing.Point(144, 65);
            this.Tb_mes.Name = "Tb_mes";
            this.Tb_mes.Size = new System.Drawing.Size(100, 20);
            this.Tb_mes.TabIndex = 4;
            // 
            // Tb_ano
            // 
            this.Tb_ano.Location = new System.Drawing.Point(251, 65);
            this.Tb_ano.Name = "Tb_ano";
            this.Tb_ano.Size = new System.Drawing.Size(100, 20);
            this.Tb_ano.TabIndex = 5;
            // 
            // Btn_setarData
            // 
            this.Btn_setarData.Location = new System.Drawing.Point(356, 66);
            this.Btn_setarData.Name = "Btn_setarData";
            this.Btn_setarData.Size = new System.Drawing.Size(320, 23);
            this.Btn_setarData.TabIndex = 9;
            this.Btn_setarData.Text = "Setar Data";
            this.Btn_setarData.UseVisualStyleBackColor = true;
            this.Btn_setarData.Click += new System.EventHandler(this.Btn_setarData_Click);
            // 
            // Btn_hoje
            // 
            this.Btn_hoje.Location = new System.Drawing.Point(356, 96);
            this.Btn_hoje.Name = "Btn_hoje";
            this.Btn_hoje.Size = new System.Drawing.Size(320, 23);
            this.Btn_hoje.TabIndex = 10;
            this.Btn_hoje.Text = "Hoje";
            this.Btn_hoje.UseVisualStyleBackColor = true;
            this.Btn_hoje.Click += new System.EventHandler(this.Btn_hoje_Click);
            // 
            // F_DateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 450);
            this.Controls.Add(this.Btn_hoje);
            this.Controls.Add(this.Btn_setarData);
            this.Controls.Add(this.Tb_ano);
            this.Controls.Add(this.Tb_mes);
            this.Controls.Add(this.Tb_dia);
            this.Controls.Add(this.Tb_data);
            this.Controls.Add(this.Btn_obterData);
            this.Controls.Add(this.Dtp_data);
            this.Name = "F_DateTimePicker";
            this.Text = "DateTimePicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Dtp_data;
        private System.Windows.Forms.Button Btn_obterData;
        private System.Windows.Forms.TextBox Tb_data;
        private System.Windows.Forms.TextBox Tb_dia;
        private System.Windows.Forms.TextBox Tb_mes;
        private System.Windows.Forms.TextBox Tb_ano;
        private System.Windows.Forms.Button Btn_setarData;
        private System.Windows.Forms.Button Btn_hoje;
    }
}