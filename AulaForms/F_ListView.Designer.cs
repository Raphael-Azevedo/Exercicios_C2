namespace Aula60
{
    partial class F_ListView
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "0",
            "Mouse",
            "120",
            "19,90"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Teclado",
            "85",
            "39,99"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Monitor",
            "38",
            "500,00"}, -1);
            this.Lv_produtos = new System.Windows.Forms.ListView();
            this.Col_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_qtde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tb_id = new System.Windows.Forms.TextBox();
            this.Tb_produto = new System.Windows.Forms.TextBox();
            this.Tb_qtde = new System.Windows.Forms.TextBox();
            this.Tb_preco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_obter = new System.Windows.Forms.Button();
            this.Btn_remover = new System.Windows.Forms.Button();
            this.Btn_adicionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lv_produtos
            // 
            this.Lv_produtos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col_id,
            this.Col_produto,
            this.Col_qtde,
            this.Col_preco});
            this.Lv_produtos.FullRowSelect = true;
            this.Lv_produtos.HideSelection = false;
            this.Lv_produtos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.Lv_produtos.Location = new System.Drawing.Point(12, 12);
            this.Lv_produtos.MultiSelect = false;
            this.Lv_produtos.Name = "Lv_produtos";
            this.Lv_produtos.Size = new System.Drawing.Size(500, 185);
            this.Lv_produtos.TabIndex = 0;
            this.Lv_produtos.UseCompatibleStateImageBehavior = false;
            this.Lv_produtos.View = System.Windows.Forms.View.Details;
            this.Lv_produtos.SelectedIndexChanged += new System.EventHandler(this.Lv_produtos_SelectedIndexChanged);
            // 
            // Col_id
            // 
            this.Col_id.Text = "Id";
            this.Col_id.Width = 40;
            // 
            // Col_produto
            // 
            this.Col_produto.Text = "Produto";
            this.Col_produto.Width = 250;
            // 
            // Col_qtde
            // 
            this.Col_qtde.Text = "Quantidade";
            this.Col_qtde.Width = 80;
            // 
            // Col_preco
            // 
            this.Col_preco.Text = "Preço";
            this.Col_preco.Width = 120;
            // 
            // Tb_id
            // 
            this.Tb_id.Location = new System.Drawing.Point(19, 254);
            this.Tb_id.Name = "Tb_id";
            this.Tb_id.Size = new System.Drawing.Size(40, 20);
            this.Tb_id.TabIndex = 1;
            // 
            // Tb_produto
            // 
            this.Tb_produto.Location = new System.Drawing.Point(65, 254);
            this.Tb_produto.Name = "Tb_produto";
            this.Tb_produto.Size = new System.Drawing.Size(226, 20);
            this.Tb_produto.TabIndex = 2;
            // 
            // Tb_qtde
            // 
            this.Tb_qtde.Location = new System.Drawing.Point(298, 254);
            this.Tb_qtde.Name = "Tb_qtde";
            this.Tb_qtde.Size = new System.Drawing.Size(81, 20);
            this.Tb_qtde.TabIndex = 3;
            // 
            // Tb_preco
            // 
            this.Tb_preco.Location = new System.Drawing.Point(385, 254);
            this.Tb_preco.Name = "Tb_preco";
            this.Tb_preco.Size = new System.Drawing.Size(111, 20);
            this.Tb_preco.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Preço";
            // 
            // Btn_obter
            // 
            this.Btn_obter.Location = new System.Drawing.Point(19, 351);
            this.Btn_obter.Name = "Btn_obter";
            this.Btn_obter.Size = new System.Drawing.Size(112, 23);
            this.Btn_obter.TabIndex = 9;
            this.Btn_obter.Text = "Obter";
            this.Btn_obter.UseVisualStyleBackColor = true;
            this.Btn_obter.Click += new System.EventHandler(this.Btn_obter_Click);
            // 
            // Btn_remover
            // 
            this.Btn_remover.Location = new System.Drawing.Point(19, 322);
            this.Btn_remover.Name = "Btn_remover";
            this.Btn_remover.Size = new System.Drawing.Size(112, 23);
            this.Btn_remover.TabIndex = 10;
            this.Btn_remover.Text = "Remover";
            this.Btn_remover.UseVisualStyleBackColor = true;
            this.Btn_remover.Click += new System.EventHandler(this.Btn_remover_Click);
            // 
            // Btn_adicionar
            // 
            this.Btn_adicionar.Location = new System.Drawing.Point(19, 293);
            this.Btn_adicionar.Name = "Btn_adicionar";
            this.Btn_adicionar.Size = new System.Drawing.Size(112, 23);
            this.Btn_adicionar.TabIndex = 11;
            this.Btn_adicionar.Text = "Adicionar";
            this.Btn_adicionar.UseVisualStyleBackColor = true;
            this.Btn_adicionar.Click += new System.EventHandler(this.Btn_adicionar_Click);
            // 
            // F_ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 413);
            this.Controls.Add(this.Btn_adicionar);
            this.Controls.Add(this.Btn_remover);
            this.Controls.Add(this.Btn_obter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tb_preco);
            this.Controls.Add(this.Tb_qtde);
            this.Controls.Add(this.Tb_produto);
            this.Controls.Add(this.Tb_id);
            this.Controls.Add(this.Lv_produtos);
            this.Name = "F_ListView";
            this.Text = "F_ListView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Lv_produtos;
        private System.Windows.Forms.ColumnHeader Col_id;
        private System.Windows.Forms.ColumnHeader Col_produto;
        private System.Windows.Forms.ColumnHeader Col_qtde;
        private System.Windows.Forms.ColumnHeader Col_preco;
        private System.Windows.Forms.TextBox Tb_id;
        private System.Windows.Forms.TextBox Tb_produto;
        private System.Windows.Forms.TextBox Tb_qtde;
        private System.Windows.Forms.TextBox Tb_preco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_obter;
        private System.Windows.Forms.Button Btn_remover;
        private System.Windows.Forms.Button Btn_adicionar;
    }
}