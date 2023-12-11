namespace SysLojaInfo
{
    partial class frmCadastroProduto
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
            lblProduto = new Label();
            lblPrecoVenda = new Label();
            lblPrecoCusto = new Label();
            lblEstoque = new Label();
            txtProduto = new TextBox();
            txtPrecoVenda = new TextBox();
            txtEstoque = new TextBox();
            txtPrecoCusto = new TextBox();
            txtUnMed = new TextBox();
            lblUnMed = new Label();
            btnPesqUnMed = new Button();
            txtCustoMedio = new TextBox();
            lblCustoMed = new Label();
            SuspendLayout();
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Location = new Point(147, 25);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(50, 15);
            lblProduto.TabIndex = 10;
            lblProduto.Text = "Produto";
            // 
            // lblPrecoVenda
            // 
            lblPrecoVenda.AutoSize = true;
            lblPrecoVenda.Location = new Point(29, 78);
            lblPrecoVenda.Name = "lblPrecoVenda";
            lblPrecoVenda.Size = new Size(88, 15);
            lblPrecoVenda.TabIndex = 11;
            lblPrecoVenda.Text = "Preço de Venda";
            // 
            // lblPrecoCusto
            // 
            lblPrecoCusto.AutoSize = true;
            lblPrecoCusto.Location = new Point(536, 78);
            lblPrecoCusto.Name = "lblPrecoCusto";
            lblPrecoCusto.Size = new Size(87, 15);
            lblPrecoCusto.TabIndex = 12;
            lblPrecoCusto.Text = "Preço de Custo";
            // 
            // lblEstoque
            // 
            lblEstoque.AutoSize = true;
            lblEstoque.Location = new Point(536, 25);
            lblEstoque.Name = "lblEstoque";
            lblEstoque.Size = new Size(134, 15);
            lblEstoque.TabIndex = 13;
            lblEstoque.Text = "Quantidade em Estoque";
            // 
            // txtProduto
            // 
            txtProduto.CharacterCasing = CharacterCasing.Upper;
            txtProduto.Location = new Point(147, 43);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(377, 23);
            txtProduto.TabIndex = 14;
            // 
            // txtPrecoVenda
            // 
            txtPrecoVenda.Enabled = false;
            txtPrecoVenda.Location = new Point(29, 96);
            txtPrecoVenda.Name = "txtPrecoVenda";
            txtPrecoVenda.Size = new Size(131, 23);
            txtPrecoVenda.TabIndex = 15;
            // 
            // txtEstoque
            // 
            txtEstoque.Enabled = false;
            txtEstoque.Location = new Point(536, 43);
            txtEstoque.Name = "txtEstoque";
            txtEstoque.Size = new Size(134, 23);
            txtEstoque.TabIndex = 16;
            // 
            // txtPrecoCusto
            // 
            txtPrecoCusto.Enabled = false;
            txtPrecoCusto.Location = new Point(536, 96);
            txtPrecoCusto.Name = "txtPrecoCusto";
            txtPrecoCusto.Size = new Size(100, 23);
            txtPrecoCusto.TabIndex = 17;
            // 
            // txtUnMed
            // 
            txtUnMed.CharacterCasing = CharacterCasing.Upper;
            txtUnMed.Enabled = false;
            txtUnMed.Location = new Point(174, 96);
            txtUnMed.Name = "txtUnMed";
            txtUnMed.Size = new Size(131, 23);
            txtUnMed.TabIndex = 19;
            // 
            // lblUnMed
            // 
            lblUnMed.AutoSize = true;
            lblUnMed.Location = new Point(174, 78);
            lblUnMed.Name = "lblUnMed";
            lblUnMed.Size = new Size(113, 15);
            lblUnMed.TabIndex = 18;
            lblUnMed.Text = "Unidade de  Medida";
            // 
            // btnPesqUnMed
            // 
            btnPesqUnMed.Location = new Point(317, 96);
            btnPesqUnMed.Name = "btnPesqUnMed";
            btnPesqUnMed.Size = new Size(207, 23);
            btnPesqUnMed.TabIndex = 20;
            btnPesqUnMed.Text = "Pesquisa Un de Medida";
            btnPesqUnMed.UseVisualStyleBackColor = true;
            btnPesqUnMed.Click += btnPesqUnMed_Click;
            // 
            // txtCustoMedio
            // 
            txtCustoMedio.Enabled = false;
            txtCustoMedio.Location = new Point(648, 96);
            txtCustoMedio.Name = "txtCustoMedio";
            txtCustoMedio.Size = new Size(100, 23);
            txtCustoMedio.TabIndex = 22;
            // 
            // lblCustoMed
            // 
            lblCustoMed.AutoSize = true;
            lblCustoMed.Location = new Point(648, 78);
            lblCustoMed.Name = "lblCustoMed";
            lblCustoMed.Size = new Size(75, 15);
            lblCustoMed.TabIndex = 21;
            lblCustoMed.Text = "Custo Médio";
            // 
            // frmCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCustoMedio);
            Controls.Add(lblCustoMed);
            Controls.Add(btnPesqUnMed);
            Controls.Add(txtUnMed);
            Controls.Add(lblUnMed);
            Controls.Add(txtPrecoCusto);
            Controls.Add(txtEstoque);
            Controls.Add(txtPrecoVenda);
            Controls.Add(txtProduto);
            Controls.Add(lblEstoque);
            Controls.Add(lblPrecoCusto);
            Controls.Add(lblPrecoVenda);
            Controls.Add(lblProduto);
            Name = "frmCadastroProduto";
            Text = "Cadastro de Produtos";
            Load += Form1_Load;
            Controls.SetChildIndex(lblCodigo, 0);
            Controls.SetChildIndex(txtCodigo, 0);
            Controls.SetChildIndex(txtDatCad, 0);
            Controls.SetChildIndex(txtDatUltAlt, 0);
            Controls.SetChildIndex(txtQuemAlt, 0);
            Controls.SetChildIndex(lblDatCad, 0);
            Controls.SetChildIndex(btnSalvar, 0);
            Controls.SetChildIndex(lblProduto, 0);
            Controls.SetChildIndex(lblPrecoVenda, 0);
            Controls.SetChildIndex(lblPrecoCusto, 0);
            Controls.SetChildIndex(lblEstoque, 0);
            Controls.SetChildIndex(txtProduto, 0);
            Controls.SetChildIndex(txtPrecoVenda, 0);
            Controls.SetChildIndex(txtEstoque, 0);
            Controls.SetChildIndex(txtPrecoCusto, 0);
            Controls.SetChildIndex(lblUnMed, 0);
            Controls.SetChildIndex(txtUnMed, 0);
            Controls.SetChildIndex(btnPesqUnMed, 0);
            Controls.SetChildIndex(lblCustoMed, 0);
            Controls.SetChildIndex(txtCustoMedio, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProduto;
        private Label lblPrecoVenda;
        private Label lblPrecoCusto;
        private Label lblEstoque;
        private TextBox txtProduto;
        private TextBox txtPrecoVenda;
        private TextBox txtEstoque;
        private TextBox txtPrecoCusto;
        private TextBox txtUnMed;
        private Label lblUnMed;
        private Button btnPesqUnMed;
        private TextBox txtCustoMedio;
        private Label lblCustoMed;
    }
}