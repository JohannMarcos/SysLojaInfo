namespace SysLojaInfo
{
    partial class frmCadastroCompras
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
            label1 = new Label();
            txtNota = new TextBox();
            txtSerieNota = new TextBox();
            label2 = new Label();
            txtModeloNota = new TextBox();
            label3 = new Label();
            txtCodEmitente = new TextBox();
            label4 = new Label();
            txtCpfCnpj = new TextBox();
            txtEmitente = new TextBox();
            btnBuscarEmitente = new Button();
            tabControl1 = new TabControl();
            tbProd = new TabPage();
            dgProd = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            produto = new DataGridViewTextBoxColumn();
            umedida = new DataGridViewTextBoxColumn();
            quant = new DataGridViewTextBoxColumn();
            preco = new DataGridViewTextBoxColumn();
            desconto = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            label8 = new Label();
            txtQtd = new TextBox();
            label7 = new Label();
            txtDesc = new TextBox();
            label6 = new Label();
            txtPreço = new TextBox();
            txtProduto = new TextBox();
            btnPesqProd = new Button();
            txtUnidMed = new TextBox();
            txtCodProd = new TextBox();
            label5 = new Label();
            btnRmvProd = new Button();
            btnAddProd = new Button();
            tbPag = new TabPage();
            label9 = new Label();
            txtValorBruto = new TextBox();
            label10 = new Label();
            txtDesconto = new TextBox();
            label11 = new Label();
            txtFrete = new TextBox();
            label12 = new Label();
            txtSeguro = new TextBox();
            label13 = new Label();
            txtOutros = new TextBox();
            label14 = new Label();
            txtValorTotal = new TextBox();
            label15 = new Label();
            rTxtDados = new RichTextBox();
            label16 = new Label();
            txtCodCond = new TextBox();
            dataGridView1 = new DataGridView();
            txtCondicaoPag = new TextBox();
            btnBuscaCond = new Button();
            parcela = new DataGridViewTextBoxColumn();
            venc = new DataGridViewTextBoxColumn();
            valor = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tbProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgProd).BeginInit();
            tbPag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.Size = new Size(53, 15);
            lblCodigo.Text = "Controle";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(876, 654);
            // 
            // txtDatCad
            // 
            txtDatCad.Location = new Point(29, 655);
            // 
            // txtDatUltAlt
            // 
            txtDatUltAlt.Location = new Point(147, 655);
            // 
            // txtQuemAlt
            // 
            txtQuemAlt.Location = new Point(291, 655);
            // 
            // lblDatCad
            // 
            lblDatCad.Location = new Point(29, 636);
            // 
            // btnSair
            // 
            btnSair.Location = new Point(967, 654);
            // 
            // lblQuemAlt
            // 
            lblQuemAlt.Location = new Point(291, 637);
            // 
            // lblDatUltAlt
            // 
            lblDatUltAlt.Location = new Point(147, 637);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 25);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 10;
            label1.Text = "Número da Nota";
            // 
            // txtNota
            // 
            txtNota.Location = new Point(147, 43);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(100, 23);
            txtNota.TabIndex = 11;
            // 
            // txtSerieNota
            // 
            txtSerieNota.Location = new Point(253, 43);
            txtSerieNota.Name = "txtSerieNota";
            txtSerieNota.Size = new Size(40, 23);
            txtSerieNota.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 25);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 12;
            label2.Text = "Série";
            // 
            // txtModeloNota
            // 
            txtModeloNota.Location = new Point(299, 43);
            txtModeloNota.Name = "txtModeloNota";
            txtModeloNota.Size = new Size(100, 23);
            txtModeloNota.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(299, 25);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 14;
            label3.Text = "Modelo";
            // 
            // txtCodEmitente
            // 
            txtCodEmitente.Enabled = false;
            txtCodEmitente.Location = new Point(29, 94);
            txtCodEmitente.Name = "txtCodEmitente";
            txtCodEmitente.Size = new Size(54, 23);
            txtCodEmitente.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 76);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 16;
            label4.Text = "Emitente";
            // 
            // txtCpfCnpj
            // 
            txtCpfCnpj.Enabled = false;
            txtCpfCnpj.Location = new Point(89, 94);
            txtCpfCnpj.Name = "txtCpfCnpj";
            txtCpfCnpj.Size = new Size(158, 23);
            txtCpfCnpj.TabIndex = 18;
            // 
            // txtEmitente
            // 
            txtEmitente.Enabled = false;
            txtEmitente.Location = new Point(253, 94);
            txtEmitente.Name = "txtEmitente";
            txtEmitente.Size = new Size(260, 23);
            txtEmitente.TabIndex = 19;
            txtEmitente.TextChanged += textBox6_TextChanged;
            // 
            // btnBuscarEmitente
            // 
            btnBuscarEmitente.Location = new Point(519, 93);
            btnBuscarEmitente.Name = "btnBuscarEmitente";
            btnBuscarEmitente.Size = new Size(75, 23);
            btnBuscarEmitente.TabIndex = 20;
            btnBuscarEmitente.Text = "Buscar";
            btnBuscarEmitente.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbProd);
            tabControl1.Controls.Add(tbPag);
            tabControl1.Location = new Point(29, 137);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(894, 356);
            tabControl1.TabIndex = 21;
            // 
            // tbProd
            // 
            tbProd.Controls.Add(dgProd);
            tbProd.Controls.Add(label8);
            tbProd.Controls.Add(txtQtd);
            tbProd.Controls.Add(label7);
            tbProd.Controls.Add(txtDesc);
            tbProd.Controls.Add(label6);
            tbProd.Controls.Add(txtPreço);
            tbProd.Controls.Add(txtProduto);
            tbProd.Controls.Add(btnPesqProd);
            tbProd.Controls.Add(txtUnidMed);
            tbProd.Controls.Add(txtCodProd);
            tbProd.Controls.Add(label5);
            tbProd.Controls.Add(btnRmvProd);
            tbProd.Controls.Add(btnAddProd);
            tbProd.Location = new Point(4, 24);
            tbProd.Name = "tbProd";
            tbProd.Padding = new Padding(3);
            tbProd.Size = new Size(886, 328);
            tbProd.TabIndex = 0;
            tbProd.Text = "Produtos Entrada";
            tbProd.UseVisualStyleBackColor = true;
            // 
            // dgProd
            // 
            dgProd.AllowUserToAddRows = false;
            dgProd.AllowUserToDeleteRows = false;
            dgProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProd.Columns.AddRange(new DataGridViewColumn[] { codigo, produto, umedida, quant, preco, desconto, total });
            dgProd.Location = new Point(15, 100);
            dgProd.Name = "dgProd";
            dgProd.RowHeadersVisible = false;
            dgProd.RowTemplate.Height = 25;
            dgProd.Size = new Size(853, 210);
            dgProd.TabIndex = 32;
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
            // umedida
            // 
            umedida.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            umedida.HeaderText = "Unid. Medida";
            umedida.Name = "umedida";
            umedida.ReadOnly = true;
            umedida.Width = 50;
            // 
            // quant
            // 
            quant.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            quant.HeaderText = "Qtd";
            quant.Name = "quant";
            quant.ReadOnly = true;
            quant.Width = 50;
            // 
            // preco
            // 
            preco.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            preco.HeaderText = "Preço";
            preco.Name = "preco";
            preco.ReadOnly = true;
            // 
            // desconto
            // 
            desconto.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            desconto.HeaderText = "Desconto";
            desconto.Name = "desconto";
            desconto.ReadOnly = true;
            // 
            // total
            // 
            total.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            total.HeaderText = "Total ";
            total.Name = "total";
            total.ReadOnly = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(772, 11);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 31;
            label8.Text = "Quantidade";
            // 
            // txtQtd
            // 
            txtQtd.Location = new Point(772, 29);
            txtQtd.Name = "txtQtd";
            txtQtd.Size = new Size(96, 23);
            txtQtd.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(670, 12);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 29;
            label7.Text = "Desconto";
            label7.Click += label7_Click;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(670, 30);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(96, 23);
            txtDesc.TabIndex = 28;
            txtDesc.TextChanged += textBox11_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(568, 12);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 27;
            label6.Text = "Preço Unitário";
            // 
            // txtPreço
            // 
            txtPreço.Location = new Point(568, 30);
            txtPreço.Name = "txtPreço";
            txtPreço.Size = new Size(96, 23);
            txtPreço.TabIndex = 26;
            // 
            // txtProduto
            // 
            txtProduto.Enabled = false;
            txtProduto.Location = new Point(99, 30);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(235, 23);
            txtProduto.TabIndex = 25;
            // 
            // btnPesqProd
            // 
            btnPesqProd.Location = new Point(424, 29);
            btnPesqProd.Name = "btnPesqProd";
            btnPesqProd.Size = new Size(115, 23);
            btnPesqProd.TabIndex = 24;
            btnPesqProd.Text = "Buscar Produto";
            btnPesqProd.UseVisualStyleBackColor = true;
            // 
            // txtUnidMed
            // 
            txtUnidMed.Enabled = false;
            txtUnidMed.Location = new Point(340, 30);
            txtUnidMed.Name = "txtUnidMed";
            txtUnidMed.Size = new Size(69, 23);
            txtUnidMed.TabIndex = 23;
            txtUnidMed.TextChanged += textBox7_TextChanged;
            // 
            // txtCodProd
            // 
            txtCodProd.Enabled = false;
            txtCodProd.Location = new Point(15, 29);
            txtCodProd.Name = "txtCodProd";
            txtCodProd.Size = new Size(78, 23);
            txtCodProd.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 11);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 21;
            label5.Text = "Produto";
            // 
            // btnRmvProd
            // 
            btnRmvProd.Location = new Point(160, 71);
            btnRmvProd.Name = "btnRmvProd";
            btnRmvProd.Size = new Size(128, 23);
            btnRmvProd.TabIndex = 1;
            btnRmvProd.Text = "Remover Produto";
            btnRmvProd.UseVisualStyleBackColor = true;
            btnRmvProd.Click += button3_Click;
            // 
            // btnAddProd
            // 
            btnAddProd.Location = new Point(15, 71);
            btnAddProd.Name = "btnAddProd";
            btnAddProd.Size = new Size(128, 23);
            btnAddProd.TabIndex = 0;
            btnAddProd.Text = "Adicionar Produto";
            btnAddProd.UseVisualStyleBackColor = true;
            // 
            // tbPag
            // 
            tbPag.Controls.Add(btnBuscaCond);
            tbPag.Controls.Add(txtCondicaoPag);
            tbPag.Controls.Add(dataGridView1);
            tbPag.Controls.Add(txtCodCond);
            tbPag.Controls.Add(label16);
            tbPag.Location = new Point(4, 24);
            tbPag.Name = "tbPag";
            tbPag.Padding = new Padding(3);
            tbPag.Size = new Size(886, 328);
            tbPag.TabIndex = 1;
            tbPag.Text = "Pagamento";
            tbPag.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(29, 503);
            label9.Name = "label9";
            label9.Size = new Size(65, 15);
            label9.TabIndex = 29;
            label9.Text = "Valor Bruto";
            // 
            // txtValorBruto
            // 
            txtValorBruto.Location = new Point(29, 521);
            txtValorBruto.Name = "txtValorBruto";
            txtValorBruto.Size = new Size(147, 23);
            txtValorBruto.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(193, 503);
            label10.Name = "label10";
            label10.Size = new Size(62, 15);
            label10.TabIndex = 31;
            label10.Text = "Descontos";
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(193, 521);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(147, 23);
            txtDesconto.TabIndex = 30;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(357, 503);
            label11.Name = "label11";
            label11.Size = new Size(33, 15);
            label11.TabIndex = 33;
            label11.Text = "Frete";
            // 
            // txtFrete
            // 
            txtFrete.Location = new Point(357, 521);
            txtFrete.Name = "txtFrete";
            txtFrete.Size = new Size(147, 23);
            txtFrete.TabIndex = 32;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(519, 503);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 35;
            label12.Text = "Seguro";
            // 
            // txtSeguro
            // 
            txtSeguro.Location = new Point(519, 521);
            txtSeguro.Name = "txtSeguro";
            txtSeguro.Size = new Size(147, 23);
            txtSeguro.TabIndex = 34;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(681, 503);
            label13.Name = "label13";
            label13.Size = new Size(43, 15);
            label13.TabIndex = 37;
            label13.Text = "Outros";
            // 
            // txtOutros
            // 
            txtOutros.Location = new Point(681, 521);
            txtOutros.Name = "txtOutros";
            txtOutros.Size = new Size(147, 23);
            txtOutros.TabIndex = 36;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(895, 503);
            label14.Name = "label14";
            label14.Size = new Size(64, 15);
            label14.TabIndex = 39;
            label14.Text = "Valor Total ";
            // 
            // txtValorTotal
            // 
            txtValorTotal.Location = new Point(895, 521);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.Size = new Size(147, 23);
            txtValorTotal.TabIndex = 38;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(29, 558);
            label15.Name = "label15";
            label15.Size = new Size(98, 15);
            label15.TabIndex = 40;
            label15.Text = "Dados Adicionais";
            // 
            // rTxtDados
            // 
            rTxtDados.ImeMode = ImeMode.Off;
            rTxtDados.Location = new Point(29, 576);
            rTxtDados.Name = "rTxtDados";
            rTxtDados.Size = new Size(1013, 57);
            rTxtDados.TabIndex = 41;
            rTxtDados.Text = "";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(17, 15);
            label16.Name = "label16";
            label16.Size = new Size(138, 15);
            label16.TabIndex = 0;
            label16.Text = "Condição de Pagamento";
            // 
            // txtCodCond
            // 
            txtCodCond.Location = new Point(17, 33);
            txtCodCond.Name = "txtCodCond";
            txtCodCond.Size = new Size(63, 23);
            txtCodCond.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { parcela, venc, valor });
            dataGridView1.Location = new Point(17, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(425, 247);
            dataGridView1.TabIndex = 2;
            // 
            // txtCondicaoPag
            // 
            txtCondicaoPag.Location = new Point(86, 33);
            txtCondicaoPag.Name = "txtCondicaoPag";
            txtCondicaoPag.Size = new Size(271, 23);
            txtCondicaoPag.TabIndex = 3;
            // 
            // btnBuscaCond
            // 
            btnBuscaCond.Location = new Point(367, 32);
            btnBuscaCond.Name = "btnBuscaCond";
            btnBuscaCond.Size = new Size(75, 23);
            btnBuscaCond.TabIndex = 4;
            btnBuscaCond.Text = "Alterar";
            btnBuscaCond.UseVisualStyleBackColor = true;
            // 
            // parcela
            // 
            parcela.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            parcela.HeaderText = "Nº Parcela";
            parcela.Name = "parcela";
            parcela.ReadOnly = true;
            // 
            // venc
            // 
            venc.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            venc.HeaderText = "Vencimento";
            venc.Name = "venc";
            venc.ReadOnly = true;
            venc.Width = 150;
            // 
            // valor
            // 
            valor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            valor.HeaderText = "Valor";
            valor.Name = "valor";
            valor.ReadOnly = true;
            // 
            // frmCadastroCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 693);
            Controls.Add(rTxtDados);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(txtValorTotal);
            Controls.Add(label13);
            Controls.Add(txtOutros);
            Controls.Add(label12);
            Controls.Add(txtSeguro);
            Controls.Add(label11);
            Controls.Add(txtFrete);
            Controls.Add(label10);
            Controls.Add(txtDesconto);
            Controls.Add(label9);
            Controls.Add(txtValorBruto);
            Controls.Add(tabControl1);
            Controls.Add(btnBuscarEmitente);
            Controls.Add(txtEmitente);
            Controls.Add(txtCpfCnpj);
            Controls.Add(txtCodEmitente);
            Controls.Add(label4);
            Controls.Add(txtModeloNota);
            Controls.Add(label3);
            Controls.Add(txtSerieNota);
            Controls.Add(label2);
            Controls.Add(txtNota);
            Controls.Add(label1);
            Name = "frmCadastroCompras";
            Text = "frmCadastroCompras";
            Load += frmCadastroCompras_Load;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(txtNota, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtSerieNota, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(txtModeloNota, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(txtCodEmitente, 0);
            Controls.SetChildIndex(txtCpfCnpj, 0);
            Controls.SetChildIndex(txtEmitente, 0);
            Controls.SetChildIndex(btnBuscarEmitente, 0);
            Controls.SetChildIndex(lblCodigo, 0);
            Controls.SetChildIndex(txtCodigo, 0);
            Controls.SetChildIndex(txtDatCad, 0);
            Controls.SetChildIndex(txtDatUltAlt, 0);
            Controls.SetChildIndex(txtQuemAlt, 0);
            Controls.SetChildIndex(lblDatCad, 0);
            Controls.SetChildIndex(lblDatUltAlt, 0);
            Controls.SetChildIndex(lblQuemAlt, 0);
            Controls.SetChildIndex(btnSalvar, 0);
            Controls.SetChildIndex(btnSair, 0);
            Controls.SetChildIndex(tabControl1, 0);
            Controls.SetChildIndex(txtValorBruto, 0);
            Controls.SetChildIndex(label9, 0);
            Controls.SetChildIndex(txtDesconto, 0);
            Controls.SetChildIndex(label10, 0);
            Controls.SetChildIndex(txtFrete, 0);
            Controls.SetChildIndex(label11, 0);
            Controls.SetChildIndex(txtSeguro, 0);
            Controls.SetChildIndex(label12, 0);
            Controls.SetChildIndex(txtOutros, 0);
            Controls.SetChildIndex(label13, 0);
            Controls.SetChildIndex(txtValorTotal, 0);
            Controls.SetChildIndex(label14, 0);
            Controls.SetChildIndex(label15, 0);
            Controls.SetChildIndex(rTxtDados, 0);
            tabControl1.ResumeLayout(false);
            tbProd.ResumeLayout(false);
            tbProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgProd).EndInit();
            tbPag.ResumeLayout(false);
            tbPag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNota;
        private TextBox txtSerieNota;
        private Label label2;
        private TextBox txtModeloNota;
        private Label label3;
        private TextBox txtCodEmitente;
        private Label label4;
        private TextBox txtCpfCnpj;
        private TextBox txtEmitente;
        private Button btnBuscarEmitente;
        private TabControl tabControl1;
        private TabPage tbProd;
        private TabPage tbPag;
        private Button btnRmvProd;
        private Button btnAddProd;
        private Button btnPesqProd;
        private TextBox txtUnidMed;
        private TextBox txtCodProd;
        private Label label5;
        private TextBox txtProduto;
        private Label label7;
        private TextBox txtDesc;
        private Label label6;
        private TextBox txtPreço;
        private DataGridView dgProd;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn produto;
        private DataGridViewTextBoxColumn umedida;
        private DataGridViewTextBoxColumn quant;
        private DataGridViewTextBoxColumn preco;
        private DataGridViewTextBoxColumn desconto;
        private DataGridViewTextBoxColumn total;
        private Label label8;
        private TextBox txtQtd;
        private Label label9;
        private TextBox txtValorBruto;
        private Label label10;
        private TextBox txtDesconto;
        private Label label11;
        private TextBox txtFrete;
        private Label label12;
        private TextBox txtSeguro;
        private Label label13;
        private TextBox txtOutros;
        private Label label14;
        private TextBox txtValorTotal;
        private Label label15;
        private RichTextBox rTxtDados;
        private DataGridView dataGridView1;
        private TextBox txtCodCond;
        private Label label16;
        private Button btnBuscaCond;
        private TextBox txtCondicaoPag;
        private DataGridViewTextBoxColumn parcela;
        private DataGridViewTextBoxColumn venc;
        private DataGridViewTextBoxColumn valor;
    }
}