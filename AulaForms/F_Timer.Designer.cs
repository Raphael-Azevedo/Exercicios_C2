namespace Aula60
{
    partial class F_Timer
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Btn_iniciar_t1 = new System.Windows.Forms.Button();
            this.Btn_parar_t1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_reiniciar_t1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Btn_iniciar_t1
            // 
            this.Btn_iniciar_t1.Location = new System.Drawing.Point(13, 13);
            this.Btn_iniciar_t1.Name = "Btn_iniciar_t1";
            this.Btn_iniciar_t1.Size = new System.Drawing.Size(75, 23);
            this.Btn_iniciar_t1.TabIndex = 0;
            this.Btn_iniciar_t1.Text = "Iniciar";
            this.Btn_iniciar_t1.UseVisualStyleBackColor = true;
            this.Btn_iniciar_t1.Click += new System.EventHandler(this.Btn_iniciar_t1_Click);
            // 
            // Btn_parar_t1
            // 
            this.Btn_parar_t1.Location = new System.Drawing.Point(103, 13);
            this.Btn_parar_t1.Name = "Btn_parar_t1";
            this.Btn_parar_t1.Size = new System.Drawing.Size(75, 23);
            this.Btn_parar_t1.TabIndex = 1;
            this.Btn_parar_t1.Text = "Parar";
            this.Btn_parar_t1.UseVisualStyleBackColor = true;
            this.Btn_parar_t1.Click += new System.EventHandler(this.Btn_parar_t1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Btn_reiniciar_t1
            // 
            this.Btn_reiniciar_t1.Location = new System.Drawing.Point(185, 12);
            this.Btn_reiniciar_t1.Name = "Btn_reiniciar_t1";
            this.Btn_reiniciar_t1.Size = new System.Drawing.Size(75, 23);
            this.Btn_reiniciar_t1.TabIndex = 3;
            this.Btn_reiniciar_t1.Text = "Reiniciar";
            this.Btn_reiniciar_t1.UseVisualStyleBackColor = true;
            this.Btn_reiniciar_t1.Click += new System.EventHandler(this.Btn_reiniciar_t1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Aula60.Properties.Resources.PikPng_com_carro_png_1303060;
            this.pictureBox1.Location = new System.Drawing.Point(12, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Iniciar carro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Parar carro";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // F_Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_reiniciar_t1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_parar_t1);
            this.Controls.Add(this.Btn_iniciar_t1);
            this.Name = "F_Timer";
            this.Text = "F_Timer";
            this.Load += new System.EventHandler(this.F_Timer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Btn_iniciar_t1;
        private System.Windows.Forms.Button Btn_parar_t1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_reiniciar_t1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button2;
    }
}