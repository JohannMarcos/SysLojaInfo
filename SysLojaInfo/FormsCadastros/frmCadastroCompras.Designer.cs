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
            txtSerieNota = new TextBox();
            lblSerie = new Label();
            txtModeloNota = new TextBox();
            lblModelo = new Label();
            txtCodEmitente = new TextBox();
            lblCodEmit = new Label();
            txtEmitente = new TextBox();
            btnBuscarEmitente = new Button();
            lblUmedida = new Label();
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
            lblCodProd = new Label();
            btnRmvProd = new Button();
            btnAddProd = new Button();
            btnBuscaCond = new Button();
            txtCondicaoPag = new TextBox();
            dgDuplicatas = new DataGridView();
            parcela = new DataGridViewTextBoxColumn();
            venc = new DataGridViewTextBoxColumn();
            valor = new DataGridViewTextBoxColumn();
            txtCodCond = new TextBox();
            label16 = new Label();
            label9 = new Label();
            txtValorBruto = new TextBox();
            label10 = new Label();
            txtDescontos = new TextBox();
            label11 = new Label();
            txtFrete = new TextBox();
            label12 = new Label();
            txtSeguro = new TextBox();
            label13 = new Label();
            txtOutros = new TextBox();
            label14 = new Label();
            txtValorTotal = new TextBox();
            lblDtEmissao = new Label();
            dtEmissao = new DateTimePicker();
            dtChegada = new DateTimePicker();
            lblDtChegada = new Label();
            lblEmitente = new Label();
            llbDescPercent = new Label();
            txtDescPercent = new TextBox();
            gbProdutos = new GroupBox();
            lblProduto = new Label();
            gbPagamento = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgProd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgDuplicatas).BeginInit();
            gbProdutos.SuspendLayout();
            gbPagamento.SuspendLayout();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.CharacterCasing = CharacterCasing.Upper;
            txtCodigo.Enabled = true;
            txtCodigo.Leave += txtCodigo_Leave;
            // 
            // lblCodigo
            // 
            lblCodigo.Size = new Size(80, 15);
            lblCodigo.Text = "Numero Nota";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(788, 396);
            btnSalvar.TabIndex = 29;
            // 
            // txtDatCad
            // 
            txtDatCad.Location = new Point(35, 602);
            // 
            // txtDatUltAlt
            // 
            txtDatUltAlt.Location = new Point(153, 602);
            // 
            // txtQuemAlt
            // 
            txtQuemAlt.Location = new Point(297, 602);
            // 
            // lblDatCad
            // 
            lblDatCad.Location = new Point(35, 583);
            // 
            // btnSair
            // 
            btnSair.Location = new Point(973, 601);
            btnSair.TabIndex = 30;
            // 
            // lblQuemAlt
            // 
            lblQuemAlt.Location = new Point(297, 584);
            // 
            // lblDatUltAlt
            // 
            lblDatUltAlt.Location = new Point(153, 584);
            // 
            // txtSerieNota
            // 
            txtSerieNota.CharacterCasing = CharacterCasing.Upper;
            txtSerieNota.Location = new Point(143, 43);
            txtSerieNota.Name = "txtSerieNota";
            txtSerieNota.Size = new Size(40, 23);
            txtSerieNota.TabIndex = 2;
            // 
            // lblSerie
            // 
            lblSerie.AutoSize = true;
            lblSerie.Location = new Point(143, 25);
            lblSerie.Name = "lblSerie";
            lblSerie.Size = new Size(32, 15);
            lblSerie.TabIndex = 12;
            lblSerie.Text = "Série";
            // 
            // txtModeloNota
            // 
            txtModeloNota.CharacterCasing = CharacterCasing.Upper;
            txtModeloNota.Location = new Point(189, 43);
            txtModeloNota.Name = "txtModeloNota";
            txtModeloNota.Size = new Size(100, 23);
            txtModeloNota.TabIndex = 3;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(189, 25);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(48, 15);
            lblModelo.TabIndex = 14;
            lblModelo.Text = "Modelo";
            // 
            // txtCodEmitente
            // 
            txtCodEmitente.Location = new Point(297, 43);
            txtCodEmitente.Name = "txtCodEmitente";
            txtCodEmitente.Size = new Size(54, 23);
            txtCodEmitente.TabIndex = 4;
            txtCodEmitente.Leave += txtCodEmitente_Leave;
            // 
            // lblCodEmit
            // 
            lblCodEmit.AutoSize = true;
            lblCodEmit.Location = new Point(297, 25);
            lblCodEmit.Name = "lblCodEmit";
            lblCodEmit.Size = new Size(32, 15);
            lblCodEmit.TabIndex = 16;
            lblCodEmit.Text = "Cód.";
            // 
            // txtEmitente
            // 
            txtEmitente.Enabled = false;
            txtEmitente.Location = new Point(357, 43);
            txtEmitente.Name = "txtEmitente";
            txtEmitente.Size = new Size(378, 23);
            txtEmitente.TabIndex = 5;
            txtEmitente.TextChanged += txtEmitente_TextChanged;
            // 
            // btnBuscarEmitente
            // 
            btnBuscarEmitente.Location = new Point(741, 43);
            btnBuscarEmitente.Name = "btnBuscarEmitente";
            btnBuscarEmitente.Size = new Size(75, 23);
            btnBuscarEmitente.TabIndex = 6;
            btnBuscarEmitente.Text = "Buscar";
            btnBuscarEmitente.UseVisualStyleBackColor = true;
            btnBuscarEmitente.Click += btnBuscarEmitente_Click;
            // 
            // lblUmedida
            // 
            lblUmedida.AutoSize = true;
            lblUmedida.Location = new Point(335, 18);
            lblUmedida.Name = "lblUmedida";
            lblUmedida.Size = new Size(25, 15);
            lblUmedida.TabIndex = 33;
            lblUmedida.Text = "Un.";
            // 
            // dgProd
            // 
            dgProd.AllowUserToAddRows = false;
            dgProd.AllowUserToDeleteRows = false;
            dgProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProd.Columns.AddRange(new DataGridViewColumn[] { codigo, produto, umedida, quant, preco, desconto, total });
            dgProd.Location = new Point(10, 95);
            dgProd.Name = "dgProd";
            dgProd.RowHeadersVisible = false;
            dgProd.RowTemplate.Height = 25;
            dgProd.Size = new Size(986, 83);
            dgProd.TabIndex = 32;
            dgProd.RowsAdded += dgProd_RowsAdded;
            dgProd.RowsRemoved += dgProd_RowsRemoved;
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
            label8.Location = new Point(900, 19);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 31;
            label8.Text = "Quantidade";
            // 
            // txtQtd
            // 
            txtQtd.Location = new Point(900, 37);
            txtQtd.Name = "txtQtd";
            txtQtd.Size = new Size(96, 23);
            txtQtd.TabIndex = 17;
            txtQtd.Leave += txtQtd_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(676, 19);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 29;
            label7.Text = "Desconto";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(676, 37);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(116, 23);
            txtDesc.TabIndex = 15;
            txtDesc.Leave += txtDesc_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(574, 19);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 27;
            label6.Text = "Preço Unitário";
            // 
            // txtPreço
            // 
            txtPreço.Location = new Point(574, 37);
            txtPreço.Name = "txtPreço";
            txtPreço.Size = new Size(96, 23);
            txtPreço.TabIndex = 14;
            txtPreço.Leave += txtPreço_Leave;
            // 
            // txtProduto
            // 
            txtProduto.Enabled = false;
            txtProduto.Location = new Point(94, 37);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(235, 23);
            txtProduto.TabIndex = 10;
            // 
            // btnPesqProd
            // 
            btnPesqProd.Location = new Point(410, 36);
            btnPesqProd.Name = "btnPesqProd";
            btnPesqProd.Size = new Size(115, 23);
            btnPesqProd.TabIndex = 13;
            btnPesqProd.Text = "Buscar Produto";
            btnPesqProd.UseVisualStyleBackColor = true;
            btnPesqProd.Click += btnPesqProd_Click;
            // 
            // txtUnidMed
            // 
            txtUnidMed.Enabled = false;
            txtUnidMed.Location = new Point(335, 37);
            txtUnidMed.Name = "txtUnidMed";
            txtUnidMed.Size = new Size(69, 23);
            txtUnidMed.TabIndex = 12;
            // 
            // txtCodProd
            // 
            txtCodProd.Enabled = false;
            txtCodProd.Location = new Point(10, 36);
            txtCodProd.Name = "txtCodProd";
            txtCodProd.Size = new Size(78, 23);
            txtCodProd.TabIndex = 9;
            // 
            // lblCodProd
            // 
            lblCodProd.AutoSize = true;
            lblCodProd.Location = new Point(10, 18);
            lblCodProd.Name = "lblCodProd";
            lblCodProd.Size = new Size(78, 15);
            lblCodProd.TabIndex = 21;
            lblCodProd.Text = "Cód. Produto";
            // 
            // btnRmvProd
            // 
            btnRmvProd.Location = new Point(155, 66);
            btnRmvProd.Name = "btnRmvProd";
            btnRmvProd.Size = new Size(128, 23);
            btnRmvProd.TabIndex = 19;
            btnRmvProd.Text = "Remover Produto";
            btnRmvProd.UseVisualStyleBackColor = true;
            // 
            // btnAddProd
            // 
            btnAddProd.Location = new Point(10, 66);
            btnAddProd.Name = "btnAddProd";
            btnAddProd.Size = new Size(128, 23);
            btnAddProd.TabIndex = 18;
            btnAddProd.Text = "Adicionar Produto";
            btnAddProd.UseVisualStyleBackColor = true;
            btnAddProd.Click += btnAddProd_Click;
            // 
            // btnBuscaCond
            // 
            btnBuscaCond.Location = new Point(366, 31);
            btnBuscaCond.Name = "btnBuscaCond";
            btnBuscaCond.Size = new Size(75, 23);
            btnBuscaCond.TabIndex = 28;
            btnBuscaCond.Text = "Alterar";
            btnBuscaCond.UseVisualStyleBackColor = true;
            btnBuscaCond.Click += btnBuscaCond_Click;
            // 
            // txtCondicaoPag
            // 
            txtCondicaoPag.Location = new Point(85, 32);
            txtCondicaoPag.Name = "txtCondicaoPag";
            txtCondicaoPag.Size = new Size(271, 23);
            txtCondicaoPag.TabIndex = 27;
            // 
            // dgDuplicatas
            // 
            dgDuplicatas.AllowUserToAddRows = false;
            dgDuplicatas.AllowUserToDeleteRows = false;
            dgDuplicatas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDuplicatas.Columns.AddRange(new DataGridViewColumn[] { parcela, venc, valor });
            dgDuplicatas.Location = new Point(17, 65);
            dgDuplicatas.Name = "dgDuplicatas";
            dgDuplicatas.RowHeadersVisible = false;
            dgDuplicatas.RowTemplate.Height = 25;
            dgDuplicatas.Size = new Size(425, 165);
            dgDuplicatas.TabIndex = 2;
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
            // txtCodCond
            // 
            txtCodCond.Location = new Point(16, 32);
            txtCodCond.Name = "txtCodCond";
            txtCodCond.Size = new Size(63, 23);
            txtCodCond.TabIndex = 26;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(16, 14);
            label16.Name = "label16";
            label16.Size = new Size(138, 15);
            label16.TabIndex = 0;
            label16.Text = "Condição de Pagamento";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(29, 277);
            label9.Name = "label9";
            label9.Size = new Size(65, 15);
            label9.TabIndex = 29;
            label9.Text = "Valor Bruto";
            // 
            // txtValorBruto
            // 
            txtValorBruto.Enabled = false;
            txtValorBruto.Location = new Point(29, 295);
            txtValorBruto.Name = "txtValorBruto";
            txtValorBruto.Size = new Size(147, 23);
            txtValorBruto.TabIndex = 20;
            txtValorBruto.Text = "R$";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(193, 277);
            label10.Name = "label10";
            label10.Size = new Size(62, 15);
            label10.TabIndex = 31;
            label10.Text = "Descontos";
            // 
            // txtDescontos
            // 
            txtDescontos.CharacterCasing = CharacterCasing.Upper;
            txtDescontos.Enabled = false;
            txtDescontos.Location = new Point(193, 295);
            txtDescontos.Name = "txtDescontos";
            txtDescontos.Size = new Size(147, 23);
            txtDescontos.TabIndex = 21;
            txtDescontos.Text = "R$";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(357, 277);
            label11.Name = "label11";
            label11.Size = new Size(33, 15);
            label11.TabIndex = 33;
            label11.Text = "Frete";
            // 
            // txtFrete
            // 
            txtFrete.Enabled = false;
            txtFrete.Location = new Point(357, 295);
            txtFrete.Name = "txtFrete";
            txtFrete.Size = new Size(147, 23);
            txtFrete.TabIndex = 22;
            txtFrete.Text = "R$ ";
            txtFrete.TextChanged += txtFrete_TextChanged;
            txtFrete.Leave += txtFrete_Leave;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(519, 277);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 35;
            label12.Text = "Seguro";
            // 
            // txtSeguro
            // 
            txtSeguro.Enabled = false;
            txtSeguro.Location = new Point(519, 295);
            txtSeguro.Name = "txtSeguro";
            txtSeguro.Size = new Size(147, 23);
            txtSeguro.TabIndex = 23;
            txtSeguro.Text = "R$ ";
            txtSeguro.TextChanged += txtSeguro_TextChanged;
            txtSeguro.Leave += txtSeguro_Leave;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(681, 277);
            label13.Name = "label13";
            label13.Size = new Size(43, 15);
            label13.TabIndex = 37;
            label13.Text = "Outros";
            // 
            // txtOutros
            // 
            txtOutros.Enabled = false;
            txtOutros.Location = new Point(681, 295);
            txtOutros.Name = "txtOutros";
            txtOutros.Size = new Size(147, 23);
            txtOutros.TabIndex = 24;
            txtOutros.Text = "R$ ";
            txtOutros.TextChanged += txtOutros_TextChanged;
            txtOutros.Leave += txtOutros_Leave;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(891, 277);
            label14.Name = "label14";
            label14.Size = new Size(64, 15);
            label14.TabIndex = 39;
            label14.Text = "Valor Total ";
            // 
            // txtValorTotal
            // 
            txtValorTotal.Enabled = false;
            txtValorTotal.Location = new Point(891, 295);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.Size = new Size(147, 23);
            txtValorTotal.TabIndex = 25;
            txtValorTotal.Text = "R$";
            txtValorTotal.TextChanged += txtValorTotal_TextChanged;
            // 
            // lblDtEmissao
            // 
            lblDtEmissao.AutoSize = true;
            lblDtEmissao.Location = new Point(832, 25);
            lblDtEmissao.Name = "lblDtEmissao";
            lblDtEmissao.Size = new Size(93, 15);
            lblDtEmissao.TabIndex = 42;
            lblDtEmissao.Text = "Data de Emissão";
            // 
            // dtEmissao
            // 
            dtEmissao.Enabled = false;
            dtEmissao.Format = DateTimePickerFormat.Short;
            dtEmissao.Location = new Point(832, 43);
            dtEmissao.Name = "dtEmissao";
            dtEmissao.Size = new Size(99, 23);
            dtEmissao.TabIndex = 7;
            dtEmissao.Leave += dtEmissao_Leave;
            // 
            // dtChegada
            // 
            dtChegada.Enabled = false;
            dtChegada.Format = DateTimePickerFormat.Short;
            dtChegada.Location = new Point(939, 43);
            dtChegada.Name = "dtChegada";
            dtChegada.Size = new Size(99, 23);
            dtChegada.TabIndex = 8;
            dtChegada.Leave += dtChegada_Leave;
            // 
            // lblDtChegada
            // 
            lblDtChegada.AutoSize = true;
            lblDtChegada.Location = new Point(939, 25);
            lblDtChegada.Name = "lblDtChegada";
            lblDtChegada.Size = new Size(97, 15);
            lblDtChegada.TabIndex = 44;
            lblDtChegada.Text = "Data de Chegada";
            // 
            // lblEmitente
            // 
            lblEmitente.AutoSize = true;
            lblEmitente.Location = new Point(357, 25);
            lblEmitente.Name = "lblEmitente";
            lblEmitente.Size = new Size(54, 15);
            lblEmitente.TabIndex = 47;
            lblEmitente.Text = "Emitente";
            // 
            // llbDescPercent
            // 
            llbDescPercent.AutoSize = true;
            llbDescPercent.Location = new Point(798, 18);
            llbDescPercent.Name = "llbDescPercent";
            llbDescPercent.Size = new Size(45, 15);
            llbDescPercent.TabIndex = 35;
            llbDescPercent.Text = "Desc %";
            // 
            // txtDescPercent
            // 
            txtDescPercent.Location = new Point(798, 37);
            txtDescPercent.Name = "txtDescPercent";
            txtDescPercent.Size = new Size(96, 23);
            txtDescPercent.TabIndex = 16;
            txtDescPercent.Leave += txtDescPercent_Leave;
            // 
            // gbProdutos
            // 
            gbProdutos.Controls.Add(lblProduto);
            gbProdutos.Controls.Add(dgProd);
            gbProdutos.Controls.Add(llbDescPercent);
            gbProdutos.Controls.Add(btnRmvProd);
            gbProdutos.Controls.Add(btnAddProd);
            gbProdutos.Controls.Add(btnPesqProd);
            gbProdutos.Controls.Add(txtDescPercent);
            gbProdutos.Controls.Add(lblCodProd);
            gbProdutos.Controls.Add(lblUmedida);
            gbProdutos.Controls.Add(txtCodProd);
            gbProdutos.Controls.Add(txtUnidMed);
            gbProdutos.Controls.Add(label8);
            gbProdutos.Controls.Add(txtProduto);
            gbProdutos.Controls.Add(txtQtd);
            gbProdutos.Controls.Add(txtPreço);
            gbProdutos.Controls.Add(label7);
            gbProdutos.Controls.Add(label6);
            gbProdutos.Controls.Add(txtDesc);
            gbProdutos.Enabled = false;
            gbProdutos.Location = new Point(29, 76);
            gbProdutos.Name = "gbProdutos";
            gbProdutos.Size = new Size(1009, 190);
            gbProdutos.TabIndex = 48;
            gbProdutos.TabStop = false;
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Location = new Point(94, 18);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(50, 15);
            lblProduto.TabIndex = 36;
            lblProduto.Text = "Produto";
            // 
            // gbPagamento
            // 
            gbPagamento.Controls.Add(dgDuplicatas);
            gbPagamento.Controls.Add(label16);
            gbPagamento.Controls.Add(btnBuscaCond);
            gbPagamento.Controls.Add(txtCodCond);
            gbPagamento.Controls.Add(txtCondicaoPag);
            gbPagamento.Enabled = false;
            gbPagamento.Location = new Point(29, 331);
            gbPagamento.Name = "gbPagamento";
            gbPagamento.Size = new Size(460, 242);
            gbPagamento.TabIndex = 49;
            gbPagamento.TabStop = false;
            // 
            // frmCadastroCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 652);
            Controls.Add(gbPagamento);
            Controls.Add(gbProdutos);
            Controls.Add(lblEmitente);
            Controls.Add(dtChegada);
            Controls.Add(lblDtChegada);
            Controls.Add(dtEmissao);
            Controls.Add(lblDtEmissao);
            Controls.Add(label14);
            Controls.Add(txtValorTotal);
            Controls.Add(label13);
            Controls.Add(txtOutros);
            Controls.Add(label12);
            Controls.Add(txtSeguro);
            Controls.Add(label11);
            Controls.Add(txtFrete);
            Controls.Add(label10);
            Controls.Add(txtDescontos);
            Controls.Add(label9);
            Controls.Add(txtValorBruto);
            Controls.Add(btnBuscarEmitente);
            Controls.Add(txtEmitente);
            Controls.Add(txtCodEmitente);
            Controls.Add(lblCodEmit);
            Controls.Add(txtModeloNota);
            Controls.Add(lblModelo);
            Controls.Add(txtSerieNota);
            Controls.Add(lblSerie);
            Name = "frmCadastroCompras";
            Text = "frmCadastroCompras";
            Load += frmCadastroCompras_Load;
            Controls.SetChildIndex(lblSerie, 0);
            Controls.SetChildIndex(txtSerieNota, 0);
            Controls.SetChildIndex(lblModelo, 0);
            Controls.SetChildIndex(txtModeloNota, 0);
            Controls.SetChildIndex(lblCodEmit, 0);
            Controls.SetChildIndex(txtCodEmitente, 0);
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
            Controls.SetChildIndex(txtValorBruto, 0);
            Controls.SetChildIndex(label9, 0);
            Controls.SetChildIndex(txtDescontos, 0);
            Controls.SetChildIndex(label10, 0);
            Controls.SetChildIndex(txtFrete, 0);
            Controls.SetChildIndex(label11, 0);
            Controls.SetChildIndex(txtSeguro, 0);
            Controls.SetChildIndex(label12, 0);
            Controls.SetChildIndex(txtOutros, 0);
            Controls.SetChildIndex(label13, 0);
            Controls.SetChildIndex(txtValorTotal, 0);
            Controls.SetChildIndex(label14, 0);
            Controls.SetChildIndex(lblDtEmissao, 0);
            Controls.SetChildIndex(dtEmissao, 0);
            Controls.SetChildIndex(lblDtChegada, 0);
            Controls.SetChildIndex(dtChegada, 0);
            Controls.SetChildIndex(lblEmitente, 0);
            Controls.SetChildIndex(gbProdutos, 0);
            Controls.SetChildIndex(gbPagamento, 0);
            ((System.ComponentModel.ISupportInitialize)dgProd).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgDuplicatas).EndInit();
            gbProdutos.ResumeLayout(false);
            gbProdutos.PerformLayout();
            gbPagamento.ResumeLayout(false);
            gbPagamento.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSerieNota;
        private Label lblSerie;
        private TextBox txtModeloNota;
        private Label lblModelo;
        private TextBox txtCodEmitente;
        private Label lblCodEmit;
        private TextBox txtEmitente;
        private Button btnBuscarEmitente;
        private Button btnRmvProd;
        private Button btnAddProd;
        private Button btnPesqProd;
        private TextBox txtUnidMed;
        private TextBox txtCodProd;
        private Label lblCodProd;
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
        private TextBox txtDescontos;
        private Label label11;
        private TextBox txtFrete;
        private Label label12;
        private TextBox txtSeguro;
        private Label label13;
        private TextBox txtOutros;
        private Label label14;
        private TextBox txtValorTotal;
        private DataGridView dgDuplicatas;
        private TextBox txtCodCond;
        private Label label16;
        private Button btnBuscaCond;
        private TextBox txtCondicaoPag;
        private DataGridViewTextBoxColumn parcela;
        private DataGridViewTextBoxColumn venc;
        private DataGridViewTextBoxColumn valor;
        private Label lblUmedida;
        private Label lblDtEmissao;
        private Label llbDescPercent;
        private TextBox txtDescPercent;
        private DateTimePicker dtEmissao;
        private DateTimePicker dtChegada;
        private Label lblDtChegada;
        private Label lblEmitente;
        private GroupBox gbProdutos;
        private GroupBox gbPagamento;
        private Label lblProduto;
    }
}