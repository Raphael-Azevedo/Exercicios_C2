namespace Aula60
{
    partial class F_ListBox
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
            this.Lb_carros = new System.Windows.Forms.ListBox();
            this.Tb_carro = new System.Windows.Forms.TextBox();
            this.Lb_carro = new System.Windows.Forms.Label();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Remover = new System.Windows.Forms.Button();
            this.Btn_obter = new System.Windows.Forms.Button();
            this.Btn_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lb_carros
            // 
            this.Lb_carros.FormattingEnabled = true;
            this.Lb_carros.Location = new System.Drawing.Point(12, 12);
            this.Lb_carros.Name = "Lb_carros";
            this.Lb_carros.Size = new System.Drawing.Size(135, 251);
            this.Lb_carros.TabIndex = 0;
            // 
            // Tb_carro
            // 
            this.Tb_carro.Location = new System.Drawing.Point(177, 28);
            this.Tb_carro.Name = "Tb_carro";
            this.Tb_carro.Size = new System.Drawing.Size(100, 20);
            this.Tb_carro.TabIndex = 1;
            // 
            // Lb_carro
            // 
            this.Lb_carro.AutoSize = true;
            this.Lb_carro.Location = new System.Drawing.Point(174, 12);
            this.Lb_carro.Name = "Lb_carro";
            this.Lb_carro.Size = new System.Drawing.Size(32, 13);
            this.Lb_carro.TabIndex = 2;
            this.Lb_carro.Text = "Carro";
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(177, 55);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(100, 23);
            this.Btn_Add.TabIndex = 3;
            this.Btn_Add.Text = "Adicionar";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Remover
            // 
            this.Btn_Remover.Location = new System.Drawing.Point(177, 85);
            this.Btn_Remover.Name = "Btn_Remover";
            this.Btn_Remover.Size = new System.Drawing.Size(100, 23);
            this.Btn_Remover.TabIndex = 4;
            this.Btn_Remover.Text = "Remover";
            this.Btn_Remover.UseVisualStyleBackColor = true;
            this.Btn_Remover.Click += new System.EventHandler(this.Btn_Remover_Click);
            // 
            // Btn_obter
            // 
            this.Btn_obter.Location = new System.Drawing.Point(177, 115);
            this.Btn_obter.Name = "Btn_obter";
            this.Btn_obter.Size = new System.Drawing.Size(100, 23);
            this.Btn_obter.TabIndex = 5;
            this.Btn_obter.Text = "Obter";
            this.Btn_obter.UseVisualStyleBackColor = true;
            this.Btn_obter.Click += new System.EventHandler(this.Btn_obter_Click);
            // 
            // Btn_limpar
            // 
            this.Btn_limpar.Location = new System.Drawing.Point(177, 145);
            this.Btn_limpar.Name = "Btn_limpar";
            this.Btn_limpar.Size = new System.Drawing.Size(100, 23);
            this.Btn_limpar.TabIndex = 6;
            this.Btn_limpar.Text = "Limpar";
            this.Btn_limpar.UseVisualStyleBackColor = true;
            this.Btn_limpar.Click += new System.EventHandler(this.Btn_limpar_Click);
            // 
            // F_ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 450);
            this.Controls.Add(this.Btn_limpar);
            this.Controls.Add(this.Btn_obter);
            this.Controls.Add(this.Btn_Remover);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Lb_carro);
            this.Controls.Add(this.Tb_carro);
            this.Controls.Add(this.Lb_carros);
            this.Name = "F_ListBox";
            this.Text = "F_ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lb_carros;
        private System.Windows.Forms.TextBox Tb_carro;
        private System.Windows.Forms.Label Lb_carro;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Remover;
        private System.Windows.Forms.Button Btn_obter;
        private System.Windows.Forms.Button Btn_limpar;
    }
}