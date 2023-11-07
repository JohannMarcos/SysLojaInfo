namespace SysLojaInfo
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            endereçosToolStripMenuItem = new ToolStripMenuItem();
            paísToolStripMenuItem = new ToolStripMenuItem();
            estadoToolStripMenuItem = new ToolStripMenuItem();
            cidadeToolStripMenuItem = new ToolStripMenuItem();
            pessoasToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            fornecedoresToolStripMenuItem = new ToolStripMenuItem();
            funcionariosToolStripMenuItem = new ToolStripMenuItem();
            parâmetrosToolStripMenuItem = new ToolStripMenuItem();
            formasDePagamentoToolStripMenuItem = new ToolStripMenuItem();
            condiçõesDePagamentoToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            serviçosToolStripMenuItem = new ToolStripMenuItem();
            cargosToolStripMenuItem = new ToolStripMenuItem();
            ordemDeSeToolStripMenuItem = new ToolStripMenuItem();
            entradasToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            unidadesDeMedidaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, ordemDeSeToolStripMenuItem, entradasToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { endereçosToolStripMenuItem, pessoasToolStripMenuItem, parâmetrosToolStripMenuItem, produtosToolStripMenuItem, serviçosToolStripMenuItem, cargosToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // endereçosToolStripMenuItem
            // 
            endereçosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { paísToolStripMenuItem, estadoToolStripMenuItem, cidadeToolStripMenuItem });
            endereçosToolStripMenuItem.Name = "endereçosToolStripMenuItem";
            endereçosToolStripMenuItem.Size = new Size(180, 22);
            endereçosToolStripMenuItem.Text = "Endereços";
            // 
            // paísToolStripMenuItem
            // 
            paísToolStripMenuItem.Name = "paísToolStripMenuItem";
            paísToolStripMenuItem.Size = new Size(111, 22);
            paísToolStripMenuItem.Text = "País";
            paísToolStripMenuItem.Click += paísToolStripMenuItem_Click;
            // 
            // estadoToolStripMenuItem
            // 
            estadoToolStripMenuItem.Name = "estadoToolStripMenuItem";
            estadoToolStripMenuItem.Size = new Size(111, 22);
            estadoToolStripMenuItem.Text = "Estado";
            estadoToolStripMenuItem.Click += estadoToolStripMenuItem_Click;
            // 
            // cidadeToolStripMenuItem
            // 
            cidadeToolStripMenuItem.Name = "cidadeToolStripMenuItem";
            cidadeToolStripMenuItem.Size = new Size(111, 22);
            cidadeToolStripMenuItem.Text = "Cidade";
            cidadeToolStripMenuItem.Click += cidadeToolStripMenuItem_Click;
            // 
            // pessoasToolStripMenuItem
            // 
            pessoasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, fornecedoresToolStripMenuItem, funcionariosToolStripMenuItem });
            pessoasToolStripMenuItem.Name = "pessoasToolStripMenuItem";
            pessoasToolStripMenuItem.Size = new Size(180, 22);
            pessoasToolStripMenuItem.Text = "Pessoas";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(145, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // fornecedoresToolStripMenuItem
            // 
            fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            fornecedoresToolStripMenuItem.Size = new Size(145, 22);
            fornecedoresToolStripMenuItem.Text = "Fornecedores";
            fornecedoresToolStripMenuItem.Click += fornecedoresToolStripMenuItem_Click;
            // 
            // funcionariosToolStripMenuItem
            // 
            funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            funcionariosToolStripMenuItem.Size = new Size(145, 22);
            funcionariosToolStripMenuItem.Text = "Funcionarios";
            funcionariosToolStripMenuItem.Click += funcionariosToolStripMenuItem_Click;
            // 
            // parâmetrosToolStripMenuItem
            // 
            parâmetrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { formasDePagamentoToolStripMenuItem, condiçõesDePagamentoToolStripMenuItem, unidadesDeMedidaToolStripMenuItem });
            parâmetrosToolStripMenuItem.Name = "parâmetrosToolStripMenuItem";
            parâmetrosToolStripMenuItem.Size = new Size(180, 22);
            parâmetrosToolStripMenuItem.Text = "Parâmetros";
            // 
            // formasDePagamentoToolStripMenuItem
            // 
            formasDePagamentoToolStripMenuItem.Name = "formasDePagamentoToolStripMenuItem";
            formasDePagamentoToolStripMenuItem.Size = new Size(210, 22);
            formasDePagamentoToolStripMenuItem.Text = "Formas de Pagamento";
            formasDePagamentoToolStripMenuItem.Click += formasDePagamentoToolStripMenuItem_Click;
            // 
            // condiçõesDePagamentoToolStripMenuItem
            // 
            condiçõesDePagamentoToolStripMenuItem.Name = "condiçõesDePagamentoToolStripMenuItem";
            condiçõesDePagamentoToolStripMenuItem.Size = new Size(210, 22);
            condiçõesDePagamentoToolStripMenuItem.Text = "Condições de Pagamento";
            condiçõesDePagamentoToolStripMenuItem.Click += condiçõesDePagamentoToolStripMenuItem_Click;
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(180, 22);
            produtosToolStripMenuItem.Text = "Produtos";
            produtosToolStripMenuItem.Click += produtosToolStripMenuItem_Click;
            // 
            // serviçosToolStripMenuItem
            // 
            serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            serviçosToolStripMenuItem.Size = new Size(180, 22);
            serviçosToolStripMenuItem.Text = "Serviços";
            serviçosToolStripMenuItem.Click += serviçosToolStripMenuItem_Click;
            // 
            // cargosToolStripMenuItem
            // 
            cargosToolStripMenuItem.Name = "cargosToolStripMenuItem";
            cargosToolStripMenuItem.Size = new Size(180, 22);
            cargosToolStripMenuItem.Text = "Cargos";
            cargosToolStripMenuItem.Click += cargosToolStripMenuItem_Click;
            // 
            // ordemDeSeToolStripMenuItem
            // 
            ordemDeSeToolStripMenuItem.Name = "ordemDeSeToolStripMenuItem";
            ordemDeSeToolStripMenuItem.Size = new Size(113, 20);
            ordemDeSeToolStripMenuItem.Text = "Ordem de Serviço";
            // 
            // entradasToolStripMenuItem
            // 
            entradasToolStripMenuItem.Name = "entradasToolStripMenuItem";
            entradasToolStripMenuItem.Size = new Size(64, 20);
            entradasToolStripMenuItem.Text = "Entradas";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // unidadesDeMedidaToolStripMenuItem
            // 
            unidadesDeMedidaToolStripMenuItem.Name = "unidadesDeMedidaToolStripMenuItem";
            unidadesDeMedidaToolStripMenuItem.Size = new Size(210, 22);
            unidadesDeMedidaToolStripMenuItem.Text = "Unidades de Medida";
            unidadesDeMedidaToolStripMenuItem.Click += unidadesDeMedidaToolStripMenuItem_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            Text = "Principal";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem endereçosToolStripMenuItem;
        private ToolStripMenuItem paísToolStripMenuItem;
        private ToolStripMenuItem estadoToolStripMenuItem;
        private ToolStripMenuItem cidadeToolStripMenuItem;
        private ToolStripMenuItem pessoasToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem fornecedoresToolStripMenuItem;
        private ToolStripMenuItem funcionariosToolStripMenuItem;
        private ToolStripMenuItem parâmetrosToolStripMenuItem;
        private ToolStripMenuItem formasDePagamentoToolStripMenuItem;
        private ToolStripMenuItem condiçõesDePagamentoToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem serviçosToolStripMenuItem;
        private ToolStripMenuItem ordemDeSeToolStripMenuItem;
        private ToolStripMenuItem entradasToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem cargosToolStripMenuItem;
        private ToolStripMenuItem unidadesDeMedidaToolStripMenuItem;
    }
}