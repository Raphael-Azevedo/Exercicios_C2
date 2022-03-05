namespace Aula60
{
    partial class F_WebBrowser
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.Tb_url = new System.Windows.Forms.TextBox();
            this.Btn_ir = new System.Windows.Forms.Button();
            this.Btn_Home = new System.Windows.Forms.Button();
            this.Btn_voltar = new System.Windows.Forms.Button();
            this.Btn_proximo = new System.Windows.Forms.Button();
            this.Btn_parar = new System.Windows.Forms.Button();
            this.Btn_atualizar = new System.Windows.Forms.Button();
            this.Btn_pesquisar = new System.Windows.Forms.Button();
            this.Btn_definirHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.webBrowser1.Location = new System.Drawing.Point(0, 55);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(677, 606);
            this.webBrowser1.TabIndex = 0;
            // 
            // Tb_url
            // 
            this.Tb_url.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tb_url.Location = new System.Drawing.Point(0, 0);
            this.Tb_url.Name = "Tb_url";
            this.Tb_url.Size = new System.Drawing.Size(677, 20);
            this.Tb_url.TabIndex = 1;
            this.Tb_url.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tb_url_KeyDown);
            // 
            // Btn_ir
            // 
            this.Btn_ir.Location = new System.Drawing.Point(12, 26);
            this.Btn_ir.Name = "Btn_ir";
            this.Btn_ir.Size = new System.Drawing.Size(75, 23);
            this.Btn_ir.TabIndex = 2;
            this.Btn_ir.Text = "Ir";
            this.Btn_ir.UseVisualStyleBackColor = true;
            this.Btn_ir.Click += new System.EventHandler(this.Btn_ir_Click);
            // 
            // Btn_Home
            // 
            this.Btn_Home.Location = new System.Drawing.Point(93, 26);
            this.Btn_Home.Name = "Btn_Home";
            this.Btn_Home.Size = new System.Drawing.Size(75, 23);
            this.Btn_Home.TabIndex = 3;
            this.Btn_Home.Text = "Home";
            this.Btn_Home.UseVisualStyleBackColor = true;
            this.Btn_Home.Click += new System.EventHandler(this.Btn_Home_Click);
            // 
            // Btn_voltar
            // 
            this.Btn_voltar.Location = new System.Drawing.Point(174, 26);
            this.Btn_voltar.Name = "Btn_voltar";
            this.Btn_voltar.Size = new System.Drawing.Size(75, 23);
            this.Btn_voltar.TabIndex = 4;
            this.Btn_voltar.Text = "Voltar";
            this.Btn_voltar.UseVisualStyleBackColor = true;
            this.Btn_voltar.Click += new System.EventHandler(this.Btn_voltar_Click);
            // 
            // Btn_proximo
            // 
            this.Btn_proximo.Location = new System.Drawing.Point(255, 26);
            this.Btn_proximo.Name = "Btn_proximo";
            this.Btn_proximo.Size = new System.Drawing.Size(75, 23);
            this.Btn_proximo.TabIndex = 5;
            this.Btn_proximo.Text = "Próximo";
            this.Btn_proximo.UseVisualStyleBackColor = true;
            this.Btn_proximo.Click += new System.EventHandler(this.Btn_proximo_Click);
            // 
            // Btn_parar
            // 
            this.Btn_parar.Location = new System.Drawing.Point(336, 26);
            this.Btn_parar.Name = "Btn_parar";
            this.Btn_parar.Size = new System.Drawing.Size(75, 23);
            this.Btn_parar.TabIndex = 6;
            this.Btn_parar.Text = "Parar";
            this.Btn_parar.UseVisualStyleBackColor = true;
            this.Btn_parar.Click += new System.EventHandler(this.Btn_parar_Click);
            // 
            // Btn_atualizar
            // 
            this.Btn_atualizar.Location = new System.Drawing.Point(417, 26);
            this.Btn_atualizar.Name = "Btn_atualizar";
            this.Btn_atualizar.Size = new System.Drawing.Size(75, 23);
            this.Btn_atualizar.TabIndex = 7;
            this.Btn_atualizar.Text = "Atualizar";
            this.Btn_atualizar.UseVisualStyleBackColor = true;
            this.Btn_atualizar.Click += new System.EventHandler(this.Btn_atualizar_Click);
            // 
            // Btn_pesquisar
            // 
            this.Btn_pesquisar.Location = new System.Drawing.Point(498, 26);
            this.Btn_pesquisar.Name = "Btn_pesquisar";
            this.Btn_pesquisar.Size = new System.Drawing.Size(75, 23);
            this.Btn_pesquisar.TabIndex = 8;
            this.Btn_pesquisar.Text = "Pesquisar";
            this.Btn_pesquisar.UseVisualStyleBackColor = true;
            this.Btn_pesquisar.Click += new System.EventHandler(this.Btn_pesquisar_Click);
            // 
            // Btn_definirHome
            // 
            this.Btn_definirHome.Location = new System.Drawing.Point(579, 26);
            this.Btn_definirHome.Name = "Btn_definirHome";
            this.Btn_definirHome.Size = new System.Drawing.Size(80, 23);
            this.Btn_definirHome.TabIndex = 9;
            this.Btn_definirHome.Text = "Definir Home";
            this.Btn_definirHome.UseVisualStyleBackColor = true;
            this.Btn_definirHome.Click += new System.EventHandler(this.Btn_definirHome_Click);
            // 
            // F_WebBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 661);
            this.Controls.Add(this.Btn_definirHome);
            this.Controls.Add(this.Btn_pesquisar);
            this.Controls.Add(this.Btn_atualizar);
            this.Controls.Add(this.Btn_parar);
            this.Controls.Add(this.Btn_proximo);
            this.Controls.Add(this.Btn_voltar);
            this.Controls.Add(this.Btn_Home);
            this.Controls.Add(this.Btn_ir);
            this.Controls.Add(this.Tb_url);
            this.Controls.Add(this.webBrowser1);
            this.Name = "F_WebBrowser";
            this.Text = "F_WebBrowser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox Tb_url;
        private System.Windows.Forms.Button Btn_ir;
        private System.Windows.Forms.Button Btn_Home;
        private System.Windows.Forms.Button Btn_voltar;
        private System.Windows.Forms.Button Btn_proximo;
        private System.Windows.Forms.Button Btn_parar;
        private System.Windows.Forms.Button Btn_atualizar;
        private System.Windows.Forms.Button Btn_pesquisar;
        private System.Windows.Forms.Button Btn_definirHome;
    }
}