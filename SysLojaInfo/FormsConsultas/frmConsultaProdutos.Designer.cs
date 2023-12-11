namespace SysLojaInfo
{
    partial class frmConsultaProdutos
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
            dgProdutos = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            produto = new DataGridViewTextBoxColumn();
            estoque = new DataGridViewTextBoxColumn();
            umedida = new DataGridViewTextBoxColumn();
            precovenda = new DataGridViewTextBoxColumn();
            custo = new DataGridViewTextBoxColumn();
            customedio = new DataGridViewTextBoxColumn();
            datcad = new DataGridViewTextBoxColumn();
            datalt = new DataGridViewTextBoxColumn();
            iduser = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgProdutos).BeginInit();
            SuspendLayout();
            // 
            // dgProdutos
            // 
            dgProdutos.AllowUserToAddRows = false;
            dgProdutos.AllowUserToDeleteRows = false;
            dgProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProdutos.Columns.AddRange(new DataGridViewColumn[] { codigo, produto, estoque, umedida, precovenda, custo, customedio, datcad, datalt, iduser });
            dgProdutos.Location = new Point(12, 56);
            dgProdutos.Name = "dgProdutos";
            dgProdutos.RowHeadersVisible = false;
            dgProdutos.RowTemplate.Height = 25;
            dgProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgProdutos.Size = new Size(776, 353);
            dgProdutos.TabIndex = 7;
            // 
            // codigo
            // 
            codigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            codigo.HeaderText = "Código";
            codigo.Name = "codigo";
            codigo.ReadOnly = true;
            codigo.Width = 50;
            // 
            // produto
            // 
            produto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            produto.HeaderText = "Produto";
            produto.Name = "produto";
            produto.ReadOnly = true;
            // 
            // estoque
            // 
            estoque.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            estoque.HeaderText = "Qtd. Estoque";
            estoque.Name = "estoque";
            estoque.ReadOnly = true;
            estoque.Width = 50;
            // 
            // umedida
            // 
            umedida.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            umedida.HeaderText = "Un. Medida";
            umedida.Name = "umedida";
            umedida.ReadOnly = true;
            umedida.Width = 50;
            // 
            // precovenda
            // 
            precovenda.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            precovenda.HeaderText = "Preço de Venda";
            precovenda.Name = "precovenda";
            precovenda.ReadOnly = true;
            precovenda.Width = 80;
            // 
            // custo
            // 
            custo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            custo.HeaderText = "Preço de Custo";
            custo.Name = "custo";
            custo.ReadOnly = true;
            custo.Width = 80;
            // 
            // customedio
            // 
            customedio.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            customedio.HeaderText = "Custo Médio";
            customedio.Name = "customedio";
            customedio.ReadOnly = true;
            customedio.Width = 75;
            // 
            // datcad
            // 
            datcad.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            datcad.HeaderText = "Data Cadastro";
            datcad.Name = "datcad";
            datcad.ReadOnly = true;
            datcad.Width = 75;
            // 
            // datalt
            // 
            datalt.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            datalt.HeaderText = "Data Alteração";
            datalt.Name = "datalt";
            datalt.ReadOnly = true;
            datalt.Width = 75;
            // 
            // iduser
            // 
            iduser.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            iduser.HeaderText = "Quem Alterou";
            iduser.Name = "iduser";
            iduser.ReadOnly = true;
            iduser.Width = 50;
            // 
            // frmConsultaProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgProdutos);
            Name = "frmConsultaProdutos";
            Text = "Consulta de Produtos";
            Activated += frmConsultaProdutos_Activated;
            Load += Form1_Load;
            Controls.SetChildIndex(txtChave, 0);
            Controls.SetChildIndex(btnSair, 0);
            Controls.SetChildIndex(btnExcluir, 0);
            Controls.SetChildIndex(btnAlterar, 0);
            Controls.SetChildIndex(btnIncluir, 0);
            Controls.SetChildIndex(dgProdutos, 0);
            ((System.ComponentModel.ISupportInitialize)dgProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgProdutos;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn produto;
        private DataGridViewTextBoxColumn estoque;
        private DataGridViewTextBoxColumn umedida;
        private DataGridViewTextBoxColumn precovenda;
        private DataGridViewTextBoxColumn custo;
        private DataGridViewTextBoxColumn customedio;
        private DataGridViewTextBoxColumn datcad;
        private DataGridViewTextBoxColumn datalt;
        private DataGridViewTextBoxColumn iduser;
    }
}