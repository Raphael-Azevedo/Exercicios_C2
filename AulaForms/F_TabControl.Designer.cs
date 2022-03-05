namespace Aula60
{
    partial class F_TabControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tab_componentes = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Tb_nomeNovaTab = new System.Windows.Forms.TextBox();
            this.Btn_novaTab = new System.Windows.Forms.Button();
            this.Btn_removerTab = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Btn_posicionarTab = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Tab_componentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tab_componentes);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 362);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1274, 213);
            this.tabControl1.TabIndex = 0;
            // 
            // Tab_componentes
            // 
            this.Tab_componentes.Controls.Add(this.button1);
            this.Tab_componentes.Controls.Add(this.label1);
            this.Tab_componentes.Controls.Add(this.textBox1);
            this.Tab_componentes.Location = new System.Drawing.Point(4, 22);
            this.Tab_componentes.Name = "Tab_componentes";
            this.Tab_componentes.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_componentes.Size = new System.Drawing.Size(1266, 187);
            this.Tab_componentes.TabIndex = 0;
            this.Tab_componentes.Text = "Componentes";
            this.Tab_componentes.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1266, 187);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Tb_nomeNovaTab
            // 
            this.Tb_nomeNovaTab.Location = new System.Drawing.Point(13, 13);
            this.Tb_nomeNovaTab.Name = "Tb_nomeNovaTab";
            this.Tb_nomeNovaTab.Size = new System.Drawing.Size(179, 20);
            this.Tb_nomeNovaTab.TabIndex = 1;
            // 
            // Btn_novaTab
            // 
            this.Btn_novaTab.Location = new System.Drawing.Point(213, 9);
            this.Btn_novaTab.Name = "Btn_novaTab";
            this.Btn_novaTab.Size = new System.Drawing.Size(140, 23);
            this.Btn_novaTab.TabIndex = 2;
            this.Btn_novaTab.Text = "Nova Pagina";
            this.Btn_novaTab.UseVisualStyleBackColor = true;
            this.Btn_novaTab.Click += new System.EventHandler(this.Btn_novaTab_Click);
            // 
            // Btn_removerTab
            // 
            this.Btn_removerTab.Location = new System.Drawing.Point(359, 9);
            this.Btn_removerTab.Name = "Btn_removerTab";
            this.Btn_removerTab.Size = new System.Drawing.Size(140, 23);
            this.Btn_removerTab.TabIndex = 3;
            this.Btn_removerTab.Text = "Remover pagina atual";
            this.Btn_removerTab.UseVisualStyleBackColor = true;
            this.Btn_removerTab.Click += new System.EventHandler(this.Btn_removerTab_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(13, 40);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // Btn_posicionarTab
            // 
            this.Btn_posicionarTab.Location = new System.Drawing.Point(213, 40);
            this.Btn_posicionarTab.Name = "Btn_posicionarTab";
            this.Btn_posicionarTab.Size = new System.Drawing.Size(140, 23);
            this.Btn_posicionarTab.TabIndex = 5;
            this.Btn_posicionarTab.Text = "Posicionar na pagina";
            this.Btn_posicionarTab.UseVisualStyleBackColor = true;
            this.Btn_posicionarTab.Click += new System.EventHandler(this.Btn_posicionarTab_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // F_TabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 587);
            this.Controls.Add(this.Btn_posicionarTab);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Btn_removerTab);
            this.Controls.Add(this.Btn_novaTab);
            this.Controls.Add(this.Tb_nomeNovaTab);
            this.Controls.Add(this.tabControl1);
            this.Name = "F_TabControl";
            this.Text = "F_TabControl";
            this.Load += new System.EventHandler(this.F_TabControl_Load);
            this.tabControl1.ResumeLayout(false);
            this.Tab_componentes.ResumeLayout(false);
            this.Tab_componentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tab_componentes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Tb_nomeNovaTab;
        private System.Windows.Forms.Button Btn_novaTab;
        private System.Windows.Forms.Button Btn_removerTab;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button Btn_posicionarTab;
    }
}