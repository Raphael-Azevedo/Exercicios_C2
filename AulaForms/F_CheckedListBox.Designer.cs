﻿namespace Aula60
{
    partial class F_CheckedListBox
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
            this.clb_transportes = new System.Windows.Forms.CheckedListBox();
            this.btn_mostrarSelecionados = new System.Windows.Forms.Button();
            this.btn_limparLista = new System.Windows.Forms.Button();
            this.btn_resetarLista = new System.Windows.Forms.Button();
            this.btn_addNovoTransporte = new System.Windows.Forms.Button();
            this.tb_novoTransporte = new System.Windows.Forms.TextBox();
            this.lb_novoTransp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clb_transportes
            // 
            this.clb_transportes.FormattingEnabled = true;
            this.clb_transportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Onibus",
            "Trem"});
            this.clb_transportes.Location = new System.Drawing.Point(12, 12);
            this.clb_transportes.Name = "clb_transportes";
            this.clb_transportes.Size = new System.Drawing.Size(120, 214);
            this.clb_transportes.TabIndex = 0;
            // 
            // btn_mostrarSelecionados
            // 
            this.btn_mostrarSelecionados.Location = new System.Drawing.Point(167, 12);
            this.btn_mostrarSelecionados.Name = "btn_mostrarSelecionados";
            this.btn_mostrarSelecionados.Size = new System.Drawing.Size(292, 23);
            this.btn_mostrarSelecionados.TabIndex = 1;
            this.btn_mostrarSelecionados.Text = "Mostrar Selecionados";
            this.btn_mostrarSelecionados.UseVisualStyleBackColor = true;
            this.btn_mostrarSelecionados.Click += new System.EventHandler(this.btn_mostrarSelecionados_Click);
            // 
            // btn_limparLista
            // 
            this.btn_limparLista.Location = new System.Drawing.Point(167, 42);
            this.btn_limparLista.Name = "btn_limparLista";
            this.btn_limparLista.Size = new System.Drawing.Size(292, 23);
            this.btn_limparLista.TabIndex = 2;
            this.btn_limparLista.Text = "Limpar Lista";
            this.btn_limparLista.UseVisualStyleBackColor = true;
            this.btn_limparLista.Click += new System.EventHandler(this.btn_limparLista_Click);
            // 
            // btn_resetarLista
            // 
            this.btn_resetarLista.Location = new System.Drawing.Point(167, 72);
            this.btn_resetarLista.Name = "btn_resetarLista";
            this.btn_resetarLista.Size = new System.Drawing.Size(292, 23);
            this.btn_resetarLista.TabIndex = 3;
            this.btn_resetarLista.Text = "Resetar Lista";
            this.btn_resetarLista.UseVisualStyleBackColor = true;
            this.btn_resetarLista.Click += new System.EventHandler(this.btn_resetarLista_Click);
            // 
            // btn_addNovoTransporte
            // 
            this.btn_addNovoTransporte.Location = new System.Drawing.Point(167, 198);
            this.btn_addNovoTransporte.Name = "btn_addNovoTransporte";
            this.btn_addNovoTransporte.Size = new System.Drawing.Size(292, 23);
            this.btn_addNovoTransporte.TabIndex = 4;
            this.btn_addNovoTransporte.Text = "Adicionar Novo Transporte";
            this.btn_addNovoTransporte.UseVisualStyleBackColor = true;
            this.btn_addNovoTransporte.Click += new System.EventHandler(this.btn_addNovoTransporte_Click);
            // 
            // tb_novoTransporte
            // 
            this.tb_novoTransporte.Location = new System.Drawing.Point(167, 172);
            this.tb_novoTransporte.Name = "tb_novoTransporte";
            this.tb_novoTransporte.Size = new System.Drawing.Size(292, 20);
            this.tb_novoTransporte.TabIndex = 5;
            // 
            // lb_novoTransp
            // 
            this.lb_novoTransp.AutoSize = true;
            this.lb_novoTransp.Location = new System.Drawing.Point(164, 156);
            this.lb_novoTransp.Name = "lb_novoTransp";
            this.lb_novoTransp.Size = new System.Drawing.Size(128, 13);
            this.lb_novoTransp.TabIndex = 6;
            this.lb_novoTransp.Text = "Digite um novo transporte";
            // 
            // F_CheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 274);
            this.Controls.Add(this.lb_novoTransp);
            this.Controls.Add(this.tb_novoTransporte);
            this.Controls.Add(this.btn_addNovoTransporte);
            this.Controls.Add(this.btn_resetarLista);
            this.Controls.Add(this.btn_limparLista);
            this.Controls.Add(this.btn_mostrarSelecionados);
            this.Controls.Add(this.clb_transportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_CheckedListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckedListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_transportes;
        private System.Windows.Forms.Button btn_mostrarSelecionados;
        private System.Windows.Forms.Button btn_limparLista;
        private System.Windows.Forms.Button btn_resetarLista;
        private System.Windows.Forms.Button btn_addNovoTransporte;
        private System.Windows.Forms.TextBox tb_novoTransporte;
        private System.Windows.Forms.Label lb_novoTransp;
    }
}