namespace Aula60
{
    partial class F_NumericUpDown
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Tb_valor = new System.Windows.Forms.TextBox();
            this.Btn_definirValor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(12, 12);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Tb_valor
            // 
            this.Tb_valor.Location = new System.Drawing.Point(191, 12);
            this.Tb_valor.Name = "Tb_valor";
            this.Tb_valor.Size = new System.Drawing.Size(100, 20);
            this.Tb_valor.TabIndex = 1;
            this.Tb_valor.Text = "0";
            // 
            // Btn_definirValor
            // 
            this.Btn_definirValor.Location = new System.Drawing.Point(298, 8);
            this.Btn_definirValor.Name = "Btn_definirValor";
            this.Btn_definirValor.Size = new System.Drawing.Size(75, 23);
            this.Btn_definirValor.TabIndex = 2;
            this.Btn_definirValor.Text = "Definir Valor";
            this.Btn_definirValor.UseVisualStyleBackColor = true;
            this.Btn_definirValor.Click += new System.EventHandler(this.Btn_definirValor_Click);
            // 
            // F_NumericUpDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 450);
            this.Controls.Add(this.Btn_definirValor);
            this.Controls.Add(this.Tb_valor);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "F_NumericUpDown";
            this.Text = "F_NumericUpDown";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox Tb_valor;
        private System.Windows.Forms.Button Btn_definirValor;
    }
}