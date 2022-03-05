namespace Aula60
{
    partial class F_TreeView
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
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Hrv");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Fit");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Honda", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Golf");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Polo");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Volkswagem", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.Btn_adicionar = new System.Windows.Forms.Button();
            this.Btn_remover = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Btn_removerSelecionado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode7.Name = "hrv";
            treeNode7.Tag = "youtube.com";
            treeNode7.Text = "Hrv";
            treeNode8.Name = "fit";
            treeNode8.Text = "Fit";
            treeNode9.Name = "honda";
            treeNode9.Text = "Honda";
            treeNode10.Name = "golf";
            treeNode10.Text = "Golf";
            treeNode11.Name = "polo";
            treeNode11.Text = "Polo";
            treeNode12.Name = "volkswagem";
            treeNode12.Text = "Volkswagem";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(219, 296);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Btn_adicionar
            // 
            this.Btn_adicionar.Location = new System.Drawing.Point(251, 12);
            this.Btn_adicionar.Name = "Btn_adicionar";
            this.Btn_adicionar.Size = new System.Drawing.Size(211, 23);
            this.Btn_adicionar.TabIndex = 1;
            this.Btn_adicionar.Text = "Adicionar";
            this.Btn_adicionar.UseVisualStyleBackColor = true;
            this.Btn_adicionar.Click += new System.EventHandler(this.Btn_adicionar_Click);
            // 
            // Btn_remover
            // 
            this.Btn_remover.Location = new System.Drawing.Point(251, 41);
            this.Btn_remover.Name = "Btn_remover";
            this.Btn_remover.Size = new System.Drawing.Size(211, 23);
            this.Btn_remover.TabIndex = 2;
            this.Btn_remover.Text = "Remover";
            this.Btn_remover.UseVisualStyleBackColor = true;
            this.Btn_remover.Click += new System.EventHandler(this.Btn_remover_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(251, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(251, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 20);
            this.textBox2.TabIndex = 4;
            // 
            // Btn_removerSelecionado
            // 
            this.Btn_removerSelecionado.Location = new System.Drawing.Point(481, 41);
            this.Btn_removerSelecionado.Name = "Btn_removerSelecionado";
            this.Btn_removerSelecionado.Size = new System.Drawing.Size(211, 23);
            this.Btn_removerSelecionado.TabIndex = 5;
            this.Btn_removerSelecionado.Text = "Remover Selecionado";
            this.Btn_removerSelecionado.UseVisualStyleBackColor = true;
            this.Btn_removerSelecionado.Click += new System.EventHandler(this.Btn_removerSelecionado_Click);
            // 
            // F_TreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_removerSelecionado);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Btn_remover);
            this.Controls.Add(this.Btn_adicionar);
            this.Controls.Add(this.treeView1);
            this.Name = "F_TreeView";
            this.Text = "F_TreeView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button Btn_adicionar;
        private System.Windows.Forms.Button Btn_remover;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Btn_removerSelecionado;
    }
}