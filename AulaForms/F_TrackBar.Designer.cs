﻿namespace Aula60
{
    partial class F_TrackBar
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Tb_valor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_definir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 12);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(723, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Tb_valor
            // 
            this.Tb_valor.Location = new System.Drawing.Point(12, 89);
            this.Tb_valor.Name = "Tb_valor";
            this.Tb_valor.Size = new System.Drawing.Size(100, 20);
            this.Tb_valor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Btn_definir
            // 
            this.Btn_definir.Location = new System.Drawing.Point(137, 89);
            this.Btn_definir.Name = "Btn_definir";
            this.Btn_definir.Size = new System.Drawing.Size(75, 23);
            this.Btn_definir.TabIndex = 3;
            this.Btn_definir.Text = "Definir";
            this.Btn_definir.UseVisualStyleBackColor = true;
            this.Btn_definir.Click += new System.EventHandler(this.Btn_definir_Click);
            // 
            // F_TrackBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_definir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tb_valor);
            this.Controls.Add(this.trackBar1);
            this.Name = "F_TrackBar";
            this.Text = "F_TrackBar";
            this.Load += new System.EventHandler(this.F_TrackBar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox Tb_valor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_definir;
    }
}