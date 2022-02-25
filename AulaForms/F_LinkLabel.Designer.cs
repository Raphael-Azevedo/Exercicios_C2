namespace Aula60
{
    partial class F_LinkLabel
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
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_nome = new System.Windows.Forms.TextBox();
            this.Ll_canal = new System.Windows.Forms.LinkLabel();
            this.Ll_calculadora = new System.Windows.Forms.LinkLabel();
            this.Ll_multiplosLinks = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite seu Nome:";
            // 
            // Tb_nome
            // 
            this.Tb_nome.Location = new System.Drawing.Point(15, 26);
            this.Tb_nome.Name = "Tb_nome";
            this.Tb_nome.Size = new System.Drawing.Size(235, 20);
            this.Tb_nome.TabIndex = 1;
            // 
            // Ll_canal
            // 
            this.Ll_canal.AutoSize = true;
            this.Ll_canal.Location = new System.Drawing.Point(15, 117);
            this.Ll_canal.Name = "Ll_canal";
            this.Ll_canal.Size = new System.Drawing.Size(34, 13);
            this.Ll_canal.TabIndex = 2;
            this.Ll_canal.TabStop = true;
            this.Ll_canal.Text = "Canal";
            this.Ll_canal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Ll_canal_LinkClicked);
            // 
            // Ll_calculadora
            // 
            this.Ll_calculadora.AutoSize = true;
            this.Ll_calculadora.Location = new System.Drawing.Point(144, 117);
            this.Ll_calculadora.Name = "Ll_calculadora";
            this.Ll_calculadora.Size = new System.Drawing.Size(63, 13);
            this.Ll_calculadora.TabIndex = 3;
            this.Ll_calculadora.TabStop = true;
            this.Ll_calculadora.Text = "Calculadora";
            this.Ll_calculadora.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Ll_calculadora_LinkClicked);
            // 
            // Ll_multiplosLinks
            // 
            this.Ll_multiplosLinks.AutoSize = true;
            this.Ll_multiplosLinks.Location = new System.Drawing.Point(15, 171);
            this.Ll_multiplosLinks.Name = "Ll_multiplosLinks";
            this.Ll_multiplosLinks.Size = new System.Drawing.Size(126, 13);
            this.Ll_multiplosLinks.TabIndex = 4;
            this.Ll_multiplosLinks.TabStop = true;
            this.Ll_multiplosLinks.Text = "Google - Canal - Youtube";
            this.Ll_multiplosLinks.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Ll_multiplosLinks_LinkClicked);
            // 
            // F_LinkLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 450);
            this.Controls.Add(this.Ll_multiplosLinks);
            this.Controls.Add(this.Ll_calculadora);
            this.Controls.Add(this.Ll_canal);
            this.Controls.Add(this.Tb_nome);
            this.Controls.Add(this.label1);
            this.Name = "F_LinkLabel";
            this.Text = "F_LinkLabel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_nome;
        private System.Windows.Forms.LinkLabel Ll_canal;
        private System.Windows.Forms.LinkLabel Ll_calculadora;
        private System.Windows.Forms.LinkLabel Ll_multiplosLinks;
    }
}