namespace SysLojaInfo
{
    partial class frmCadastroClientes
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
            lblLimite = new Label();
            txtLimite = new TextBox();
            txtCodCond = new TextBox();
            lblCodCond = new Label();
            txtCond = new TextBox();
            lblCond = new Label();
            btnPesqCond = new Button();
            gpTipoPessoa.SuspendLayout();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.TabIndex = 2;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtCpfCnpj
            // 
            txtCpfCnpj.Enabled = false;
            txtCpfCnpj.TabIndex = 3;
            txtCpfCnpj.TextChanged += txtCpfCnpj_TextChanged;
            // 
            // txtRg
            // 
            txtRg.Enabled = false;
            txtRg.TabIndex = 4;
            txtRg.TextChanged += txtRg_TextChanged;
            // 
            // txtLogr
            // 
            txtLogr.Enabled = false;
            txtLogr.Location = new Point(18, 208);
            txtLogr.TabIndex = 6;
            txtLogr.TextChanged += txtLogr_TextChanged;
            // 
            // txtNumero
            // 
            txtNumero.Enabled = false;
            txtNumero.Location = new Point(418, 208);
            txtNumero.TabIndex = 7;
            txtNumero.TextChanged += txtNumero_TextChanged;
            // 
            // txtBairro
            // 
            txtBairro.Enabled = false;
            txtBairro.Location = new Point(524, 208);
            txtBairro.TabIndex = 8;
            txtBairro.TextChanged += txtBairro_TextChanged;
            // 
            // txtCodCidade
            // 
            txtCodCidade.Location = new Point(18, 149);
            txtCodCidade.TextChanged += txtCodCidade_TextChanged;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(136, 149);
            // 
            // txtTelRes
            // 
            txtTelRes.Enabled = false;
            txtTelRes.TabIndex = 9;
            txtTelRes.TextChanged += txtTelRes_TextChanged;
            txtTelRes.Leave += txtTelRes_Leave;
            // 
            // txtTelCel
            // 
            txtTelCel.Enabled = false;
            txtTelCel.TabIndex = 10;
            txtTelCel.TextChanged += txtTelCel_TextChanged;
            txtTelCel.Leave += txtTelCel_Leave;
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.TabIndex = 11;
            txtEmail.TextChanged += txtEmail_TextChanged;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // btnProcuraCidade
            // 
            btnProcuraCidade.Enabled = false;
            btnProcuraCidade.Location = new Point(418, 149);
            btnProcuraCidade.TabIndex = 5;
            // 
            // gpTipoPessoa
            // 
            gpTipoPessoa.TabIndex = 1;
            gpTipoPessoa.UseCompatibleTextRendering = true;
            // 
            // rbJuridica
            // 
            rbJuridica.CheckedChanged += rbJuridica_CheckedChanged;
            // 
            // rbFisica
            // 
            rbFisica.CheckedChanged += rbFisica_CheckedChanged;
            // 
            // lblNomeRazao
            // 
            lblNomeRazao.Enabled = false;
            // 
            // lblCpfCnpj
            // 
            lblCpfCnpj.Enabled = false;
            // 
            // lblRg
            // 
            lblRg.Enabled = false;
            // 
            // lblLogr
            // 
            lblLogr.Enabled = false;
            lblLogr.Location = new Point(18, 190);
            // 
            // lblNumero
            // 
            lblNumero.Enabled = false;
            lblNumero.Location = new Point(418, 190);
            // 
            // lblBairro
            // 
            lblBairro.Enabled = false;
            lblBairro.Location = new Point(524, 190);
            // 
            // lblCodCidade
            // 
            lblCodCidade.Enabled = false;
            lblCodCidade.Location = new Point(18, 130);
            // 
            // lblCidade
            // 
            lblCidade.Enabled = false;
            lblCidade.Location = new Point(136, 130);
            // 
            // lblTelRes
            // 
            lblTelRes.Enabled = false;
            // 
            // lblTelCel
            // 
            lblTelCel.Enabled = false;
            // 
            // lblEmail
            // 
            lblEmail.Enabled = false;
            // 
            // btnSalvar
            // 
            btnSalvar.Enabled = false;
            btnSalvar.TabIndex = 14;
            // 
            // btnSair
            // 
            btnSair.TabIndex = 15;
            // 
            // lblLimite
            // 
            lblLimite.AutoSize = true;
            lblLimite.Enabled = false;
            lblLimite.Location = new Point(564, 302);
            lblLimite.Name = "lblLimite";
            lblLimite.Size = new Size(98, 15);
            lblLimite.TabIndex = 34;
            lblLimite.Text = "Limite de Crédito";
            // 
            // txtLimite
            // 
            txtLimite.CharacterCasing = CharacterCasing.Upper;
            txtLimite.Enabled = false;
            txtLimite.Location = new Point(564, 320);
            txtLimite.Name = "txtLimite";
            txtLimite.Size = new Size(137, 23);
            txtLimite.TabIndex = 13;
            txtLimite.TextChanged += txtLimite_TextChanged;
            // 
            // txtCodCond
            // 
            txtCodCond.CharacterCasing = CharacterCasing.Upper;
            txtCodCond.Enabled = false;
            txtCodCond.Location = new Point(18, 320);
            txtCodCond.Name = "txtCodCond";
            txtCodCond.Size = new Size(120, 23);
            txtCodCond.TabIndex = 37;
            txtCodCond.TextChanged += txtCodCond_TextChanged;
            // 
            // lblCodCond
            // 
            lblCodCond.AutoSize = true;
            lblCodCond.Enabled = false;
            lblCodCond.Location = new Point(18, 302);
            lblCodCond.Name = "lblCodCond";
            lblCodCond.Size = new Size(116, 15);
            lblCodCond.TabIndex = 36;
            lblCodCond.Text = "Código da Condição";
            // 
            // txtCond
            // 
            txtCond.CharacterCasing = CharacterCasing.Upper;
            txtCond.Enabled = false;
            txtCond.Location = new Point(144, 320);
            txtCond.Name = "txtCond";
            txtCond.Size = new Size(268, 23);
            txtCond.TabIndex = 39;
            // 
            // lblCond
            // 
            lblCond.AutoSize = true;
            lblCond.Enabled = false;
            lblCond.Location = new Point(144, 302);
            lblCond.Name = "lblCond";
            lblCond.Size = new Size(138, 15);
            lblCond.TabIndex = 38;
            lblCond.Text = "Condição de Pagamento";
            // 
            // btnPesqCond
            // 
            btnPesqCond.Enabled = false;
            btnPesqCond.Location = new Point(418, 320);
            btnPesqCond.Name = "btnPesqCond";
            btnPesqCond.Size = new Size(100, 23);
            btnPesqCond.TabIndex = 12;
            btnPesqCond.Text = "Pesq. Condição";
            btnPesqCond.UseVisualStyleBackColor = true;
            btnPesqCond.Click += btnPesqCond_Click;
            // 
            // frmCadastroClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPesqCond);
            Controls.Add(txtCond);
            Controls.Add(lblCond);
            Controls.Add(txtCodCond);
            Controls.Add(lblCodCond);
            Controls.Add(txtLimite);
            Controls.Add(lblLimite);
            Name = "frmCadastroClientes";
            Text = "Cadastro De Clientes";
            Load += Form1_Load;
            Controls.SetChildIndex(gpTipoPessoa, 0);
            Controls.SetChildIndex(lblLimite, 0);
            Controls.SetChildIndex(txtLimite, 0);
            Controls.SetChildIndex(lblCodCond, 0);
            Controls.SetChildIndex(txtCodCond, 0);
            Controls.SetChildIndex(lblCond, 0);
            Controls.SetChildIndex(txtCond, 0);
            Controls.SetChildIndex(lblCodigo, 0);
            Controls.SetChildIndex(lblDatCad, 0);
            Controls.SetChildIndex(lblDatUltAlt, 0);
            Controls.SetChildIndex(lblQuemAlt, 0);
            Controls.SetChildIndex(btnSair, 0);
            Controls.SetChildIndex(lblNomeRazao, 0);
            Controls.SetChildIndex(lblCpfCnpj, 0);
            Controls.SetChildIndex(lblRg, 0);
            Controls.SetChildIndex(lblLogr, 0);
            Controls.SetChildIndex(lblNumero, 0);
            Controls.SetChildIndex(lblBairro, 0);
            Controls.SetChildIndex(lblCodCidade, 0);
            Controls.SetChildIndex(lblCidade, 0);
            Controls.SetChildIndex(lblTelRes, 0);
            Controls.SetChildIndex(lblTelCel, 0);
            Controls.SetChildIndex(lblEmail, 0);
            Controls.SetChildIndex(txtCodigo, 0);
            Controls.SetChildIndex(txtDatCad, 0);
            Controls.SetChildIndex(txtDatUltAlt, 0);
            Controls.SetChildIndex(txtQuemAlt, 0);
            Controls.SetChildIndex(btnSalvar, 0);
            Controls.SetChildIndex(txtNome, 0);
            Controls.SetChildIndex(txtCpfCnpj, 0);
            Controls.SetChildIndex(txtRg, 0);
            Controls.SetChildIndex(txtLogr, 0);
            Controls.SetChildIndex(txtNumero, 0);
            Controls.SetChildIndex(txtBairro, 0);
            Controls.SetChildIndex(txtCodCidade, 0);
            Controls.SetChildIndex(txtCidade, 0);
            Controls.SetChildIndex(txtTelRes, 0);
            Controls.SetChildIndex(txtTelCel, 0);
            Controls.SetChildIndex(txtEmail, 0);
            Controls.SetChildIndex(btnProcuraCidade, 0);
            Controls.SetChildIndex(btnPesqCond, 0);
            gpTipoPessoa.ResumeLayout(false);
            gpTipoPessoa.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLimite;
        private TextBox txtLimite;
        private TextBox txtCodCond;
        private Label lblCodCond;
        private TextBox txtCond;
        private Label lblCond;
        private Button btnPesqCond;
    }
}