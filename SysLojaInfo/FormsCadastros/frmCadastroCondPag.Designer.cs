namespace SysLojaInfo
{
    partial class frmCadastroCondPag
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
            lblCondicao = new Label();
            lblTaxa = new Label();
            lblMulta = new Label();
            lblDesconto = new Label();
            txtCond = new TextBox();
            txtTaxa = new TextBox();
            txtMulta = new TextBox();
            txtDesconto = new TextBox();
            lblDias = new Label();
            lblPercent = new Label();
            txtDias = new TextBox();
            txtPercent = new TextBox();
            btnAdicionaParc = new Button();
            dgParcelas = new DataGridView();
            nParcela = new DataGridViewTextBoxColumn();
            dias = new DataGridViewTextBoxColumn();
            percent = new DataGridViewTextBoxColumn();
            forma = new DataGridViewTextBoxColumn();
            gbParcelas = new GroupBox();
            lblParamRest = new Label();
            lblRest = new Label();
            lblForma = new Label();
            btnRemove = new Button();
            cbFormas = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgParcelas).BeginInit();
            gbParcelas.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Enabled = false;
            // 
            // lblCondicao
            // 
            lblCondicao.AutoSize = true;
            lblCondicao.Location = new Point(147, 25);
            lblCondicao.Name = "lblCondicao";
            lblCondicao.Size = new Size(138, 15);
            lblCondicao.TabIndex = 10;
            lblCondicao.Text = "Condição de Pagamento";
            // 
            // lblTaxa
            // 
            lblTaxa.AutoSize = true;
            lblTaxa.Location = new Point(406, 25);
            lblTaxa.Name = "lblTaxa";
            lblTaxa.Size = new Size(30, 15);
            lblTaxa.TabIndex = 11;
            lblTaxa.Text = "Taxa";
            // 
            // lblMulta
            // 
            lblMulta.AutoSize = true;
            lblMulta.Location = new Point(513, 25);
            lblMulta.Name = "lblMulta";
            lblMulta.Size = new Size(38, 15);
            lblMulta.TabIndex = 12;
            lblMulta.Text = "Multa";
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Location = new Point(623, 25);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(57, 15);
            lblDesconto.TabIndex = 13;
            lblDesconto.Text = "Desconto";
            // 
            // txtCond
            // 
            txtCond.CharacterCasing = CharacterCasing.Upper;
            txtCond.Location = new Point(147, 43);
            txtCond.Name = "txtCond";
            txtCond.Size = new Size(253, 23);
            txtCond.TabIndex = 14;
            txtCond.Leave += txtCond_Leave;
            // 
            // txtTaxa
            // 
            txtTaxa.CharacterCasing = CharacterCasing.Upper;
            txtTaxa.Location = new Point(406, 43);
            txtTaxa.Name = "txtTaxa";
            txtTaxa.Size = new Size(100, 23);
            txtTaxa.TabIndex = 15;
            txtTaxa.Leave += txtTaxa_Leave;
            // 
            // txtMulta
            // 
            txtMulta.CharacterCasing = CharacterCasing.Upper;
            txtMulta.Location = new Point(513, 43);
            txtMulta.Name = "txtMulta";
            txtMulta.Size = new Size(101, 23);
            txtMulta.TabIndex = 16;
            txtMulta.Leave += txtMulta_Leave;
            // 
            // txtDesconto
            // 
            txtDesconto.CharacterCasing = CharacterCasing.Upper;
            txtDesconto.Location = new Point(623, 43);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(96, 23);
            txtDesconto.TabIndex = 17;
            txtDesconto.Leave += txtDesconto_Leave;
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Location = new Point(6, 27);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(29, 15);
            lblDias.TabIndex = 18;
            lblDias.Text = "Dias";
            // 
            // lblPercent
            // 
            lblPercent.AutoSize = true;
            lblPercent.Location = new Point(124, 27);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new Size(63, 15);
            lblPercent.TabIndex = 19;
            lblPercent.Text = "Percentual";
            // 
            // txtDias
            // 
            txtDias.CharacterCasing = CharacterCasing.Upper;
            txtDias.Location = new Point(6, 45);
            txtDias.Name = "txtDias";
            txtDias.Size = new Size(109, 23);
            txtDias.TabIndex = 20;
            // 
            // txtPercent
            // 
            txtPercent.CharacterCasing = CharacterCasing.Upper;
            txtPercent.Location = new Point(124, 45);
            txtPercent.Name = "txtPercent";
            txtPercent.Size = new Size(109, 23);
            txtPercent.TabIndex = 21;
            txtPercent.TextChanged += txtPercent_TextChanged;
            txtPercent.Leave += txtPercent_Leave;
            // 
            // btnAdicionaParc
            // 
            btnAdicionaParc.Location = new Point(447, 44);
            btnAdicionaParc.Name = "btnAdicionaParc";
            btnAdicionaParc.Size = new Size(138, 23);
            btnAdicionaParc.TabIndex = 22;
            btnAdicionaParc.Text = "Adicionar Parcela";
            btnAdicionaParc.UseVisualStyleBackColor = true;
            btnAdicionaParc.Click += btnAdicionaParc_Click;
            // 
            // dgParcelas
            // 
            dgParcelas.AllowUserToAddRows = false;
            dgParcelas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgParcelas.Columns.AddRange(new DataGridViewColumn[] { nParcela, dias, percent, forma });
            dgParcelas.Location = new Point(6, 74);
            dgParcelas.MultiSelect = false;
            dgParcelas.Name = "dgParcelas";
            dgParcelas.RowHeadersVisible = false;
            dgParcelas.RowTemplate.Height = 25;
            dgParcelas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgParcelas.Size = new Size(738, 162);
            dgParcelas.TabIndex = 23;
            dgParcelas.CellValueChanged += dgParcelas_CellValueChanged;
            dgParcelas.RowsAdded += dgParcelas_RowsAdded;
            dgParcelas.RowsRemoved += dgParcelas_RowsRemoved;
            // 
            // nParcela
            // 
            nParcela.HeaderText = "Nº";
            nParcela.Name = "nParcela";
            nParcela.ReadOnly = true;
            nParcela.Width = 50;
            // 
            // dias
            // 
            dias.HeaderText = "Dias";
            dias.Name = "dias";
            dias.ReadOnly = true;
            dias.Width = 50;
            // 
            // percent
            // 
            percent.HeaderText = "%";
            percent.Name = "percent";
            percent.ReadOnly = true;
            percent.Width = 70;
            // 
            // forma
            // 
            forma.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            forma.HeaderText = "Forma de Pagamento";
            forma.Name = "forma";
            forma.ReadOnly = true;
            // 
            // gbParcelas
            // 
            gbParcelas.Controls.Add(lblParamRest);
            gbParcelas.Controls.Add(lblRest);
            gbParcelas.Controls.Add(lblForma);
            gbParcelas.Controls.Add(btnRemove);
            gbParcelas.Controls.Add(cbFormas);
            gbParcelas.Controls.Add(dgParcelas);
            gbParcelas.Controls.Add(lblDias);
            gbParcelas.Controls.Add(btnAdicionaParc);
            gbParcelas.Controls.Add(lblPercent);
            gbParcelas.Controls.Add(txtPercent);
            gbParcelas.Controls.Add(txtDias);
            gbParcelas.Enabled = false;
            gbParcelas.Location = new Point(29, 92);
            gbParcelas.Name = "gbParcelas";
            gbParcelas.Size = new Size(750, 243);
            gbParcelas.TabIndex = 24;
            gbParcelas.TabStop = false;
            // 
            // lblParamRest
            // 
            lblParamRest.AutoSize = true;
            lblParamRest.Enabled = false;
            lblParamRest.Location = new Point(677, 19);
            lblParamRest.Name = "lblParamRest";
            lblParamRest.Size = new Size(49, 15);
            lblParamRest.TabIndex = 28;
            lblParamRest.Text = "Restam:";
            // 
            // lblRest
            // 
            lblRest.AutoSize = true;
            lblRest.Enabled = false;
            lblRest.Location = new Point(560, 19);
            lblRest.Name = "lblRest";
            lblRest.Size = new Size(111, 15);
            lblRest.TabIndex = 27;
            lblRest.Text = "Percentual restante:";
            // 
            // lblForma
            // 
            lblForma.AutoSize = true;
            lblForma.Location = new Point(243, 27);
            lblForma.Name = "lblForma";
            lblForma.Size = new Size(129, 15);
            lblForma.TabIndex = 26;
            lblForma.Text = "Formas de Pagamento:";
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(594, 44);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(138, 23);
            btnRemove.TabIndex = 25;
            btnRemove.Text = "Remover Parcela";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // cbFormas
            // 
            cbFormas.FormattingEnabled = true;
            cbFormas.Location = new Point(243, 45);
            cbFormas.Name = "cbFormas";
            cbFormas.Size = new Size(198, 23);
            cbFormas.TabIndex = 24;
            // 
            // frmCadastroCondPag
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbParcelas);
            Controls.Add(txtDesconto);
            Controls.Add(txtMulta);
            Controls.Add(txtTaxa);
            Controls.Add(txtCond);
            Controls.Add(lblDesconto);
            Controls.Add(lblMulta);
            Controls.Add(lblTaxa);
            Controls.Add(lblCondicao);
            Name = "frmCadastroCondPag";
            Text = "Cadastro de Condição de Pagamento";
            Load += Form1_Load;
            Controls.SetChildIndex(lblDatUltAlt, 0);
            Controls.SetChildIndex(lblQuemAlt, 0);
            Controls.SetChildIndex(btnSair, 0);
            Controls.SetChildIndex(lblCodigo, 0);
            Controls.SetChildIndex(txtCodigo, 0);
            Controls.SetChildIndex(txtDatCad, 0);
            Controls.SetChildIndex(txtDatUltAlt, 0);
            Controls.SetChildIndex(txtQuemAlt, 0);
            Controls.SetChildIndex(lblDatCad, 0);
            Controls.SetChildIndex(btnSalvar, 0);
            Controls.SetChildIndex(lblCondicao, 0);
            Controls.SetChildIndex(lblTaxa, 0);
            Controls.SetChildIndex(lblMulta, 0);
            Controls.SetChildIndex(lblDesconto, 0);
            Controls.SetChildIndex(txtCond, 0);
            Controls.SetChildIndex(txtTaxa, 0);
            Controls.SetChildIndex(txtMulta, 0);
            Controls.SetChildIndex(txtDesconto, 0);
            Controls.SetChildIndex(gbParcelas, 0);
            ((System.ComponentModel.ISupportInitialize)dgParcelas).EndInit();
            gbParcelas.ResumeLayout(false);
            gbParcelas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCondicao;
        private Label lblTaxa;
        private Label lblMulta;
        private Label lblDesconto;
        private TextBox txtCond;
        private TextBox txtTaxa;
        private TextBox txtMulta;
        private TextBox txtDesconto;
        private Label lblDias;
        private Label lblPercent;
        private TextBox txtDias;
        private TextBox txtPercent;
        private Button btnAdicionaParc;
        private DataGridView dgParcelas;
        private DataGridViewTextBoxColumn nParcela;
        private DataGridViewTextBoxColumn dias;
        private DataGridViewTextBoxColumn percent;
        private DataGridViewTextBoxColumn forma;
        private GroupBox gbParcelas;
        private ComboBox cbFormas;
        private Button btnRemove;
        private Label lblForma;
        private Label lblParamRest;
        private Label lblRest;
    }
}