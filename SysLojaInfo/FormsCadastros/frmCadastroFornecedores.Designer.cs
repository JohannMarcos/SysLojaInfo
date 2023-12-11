namespace SysLojaInfo
{
    partial class frmCadastroFornecedores
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
            lblCodCond = new Label();
            txtCodCond = new TextBox();
            btnProcuraCond = new Button();
            txtCond = new TextBox();
            lblCond = new Label();
            gpTipoPessoa.SuspendLayout();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtCpfCnpj
            // 
            txtCpfCnpj.Enabled = false;
            txtCpfCnpj.TextChanged += txtCpfCnpj_TextChanged;
            // 
            // txtRg
            // 
            txtRg.Enabled = false;
            txtRg.TextChanged += txtRg_TextChanged;
            // 
            // txtLogr
            // 
            txtLogr.Enabled = false;
            txtLogr.TextChanged += txtLogr_TextChanged;
            // 
            // txtNumero
            // 
            txtNumero.Enabled = false;
            txtNumero.TextChanged += txtNumero_TextChanged;
            // 
            // txtBairro
            // 
            txtBairro.Enabled = false;
            txtBairro.TextChanged += txtBairro_TextChanged;
            // 
            // txtCodCidade
            // 
            txtCodCidade.TextChanged += txtCodCidade_TextChanged;
            // 
            // txtCidade
            // 
            txtCidade.TextChanged += txtCidade_TextChanged;
            // 
            // txtTelRes
            // 
            txtTelRes.Enabled = false;
            txtTelRes.TextChanged += txtTelRes_TextChanged;
            txtTelRes.Leave += txtTelRes_Leave;
            // 
            // txtTelCel
            // 
            txtTelCel.Enabled = false;
            txtTelCel.TextChanged += txtTelCel_TextChanged;
            txtTelCel.Leave += txtTelCel_Leave;
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.TextChanged += txtEmail_TextChanged;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // btnProcuraCidade
            // 
            btnProcuraCidade.Enabled = false;
            btnProcuraCidade.Click += btnProcuraCidade_Click_1;
            // 
            // rbJuridica
            // 
            rbJuridica.CheckedChanged += rbJuridica_CheckedChanged;
            // 
            // rbFisica
            // 
            rbFisica.CheckedChanged += rbFisica_CheckedChanged;
            // 
            // btnSalvar
            // 
            btnSalvar.Enabled = false;
            // 
            // lblCodCond
            // 
            lblCodCond.AutoSize = true;
            lblCodCond.Location = new Point(18, 305);
            lblCodCond.Name = "lblCodCond";
            lblCodCond.Size = new Size(86, 15);
            lblCodCond.TabIndex = 34;
            lblCodCond.Text = "Cód. Condição";
            // 
            // txtCodCond
            // 
            txtCodCond.CharacterCasing = CharacterCasing.Upper;
            txtCodCond.Enabled = false;
            txtCodCond.Location = new Point(18, 323);
            txtCodCond.Name = "txtCodCond";
            txtCodCond.Size = new Size(109, 23);
            txtCodCond.TabIndex = 35;
            txtCodCond.TextChanged += txtCodCond_TextChanged;
            // 
            // btnProcuraCond
            // 
            btnProcuraCond.Enabled = false;
            btnProcuraCond.Location = new Point(380, 323);
            btnProcuraCond.Name = "btnProcuraCond";
            btnProcuraCond.Size = new Size(101, 23);
            btnProcuraCond.TabIndex = 36;
            btnProcuraCond.Text = "Pesq. Condição";
            btnProcuraCond.UseVisualStyleBackColor = true;
            btnProcuraCond.Click += btnProcuraCond_Click;
            // 
            // txtCond
            // 
            txtCond.Enabled = false;
            txtCond.Location = new Point(136, 323);
            txtCond.Name = "txtCond";
            txtCond.Size = new Size(238, 23);
            txtCond.TabIndex = 38;
            txtCond.TextChanged += txtCond_TextChanged;
            // 
            // lblCond
            // 
            lblCond.AutoSize = true;
            lblCond.Location = new Point(136, 305);
            lblCond.Name = "lblCond";
            lblCond.Size = new Size(138, 15);
            lblCond.TabIndex = 37;
            lblCond.Text = "Condição de Pagamento";
            // 
            // frmCadastroFornecedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCond);
            Controls.Add(lblCond);
            Controls.Add(btnProcuraCond);
            Controls.Add(txtCodCond);
            Controls.Add(lblCodCond);
            Name = "frmCadastroFornecedores";
            Text = "Cadastro de Fornecedores";
            Load += Form1_Load;
            Controls.SetChildIndex(lblCodigo, 0);
            Controls.SetChildIndex(lblDatCad, 0);
            Controls.SetChildIndex(lblDatUltAlt, 0);
            Controls.SetChildIndex(lblQuemAlt, 0);
            Controls.SetChildIndex(btnSair, 0);
            Controls.SetChildIndex(txtCodigo, 0);
            Controls.SetChildIndex(txtDatCad, 0);
            Controls.SetChildIndex(txtDatUltAlt, 0);
            Controls.SetChildIndex(txtQuemAlt, 0);
            Controls.SetChildIndex(btnSalvar, 0);
            Controls.SetChildIndex(lblNomeRazao, 0);
            Controls.SetChildIndex(lblCpfCnpj, 0);
            Controls.SetChildIndex(lblRg, 0);
            Controls.SetChildIndex(lblLogr, 0);
            Controls.SetChildIndex(lblNumero, 0);
            Controls.SetChildIndex(lblBairro, 0);
            Controls.SetChildIndex(txtNome, 0);
            Controls.SetChildIndex(txtCpfCnpj, 0);
            Controls.SetChildIndex(txtRg, 0);
            Controls.SetChildIndex(txtLogr, 0);
            Controls.SetChildIndex(txtNumero, 0);
            Controls.SetChildIndex(txtBairro, 0);
            Controls.SetChildIndex(lblCodCidade, 0);
            Controls.SetChildIndex(lblCidade, 0);
            Controls.SetChildIndex(lblTelRes, 0);
            Controls.SetChildIndex(lblTelCel, 0);
            Controls.SetChildIndex(lblEmail, 0);
            Controls.SetChildIndex(txtCodCidade, 0);
            Controls.SetChildIndex(txtCidade, 0);
            Controls.SetChildIndex(txtTelRes, 0);
            Controls.SetChildIndex(txtTelCel, 0);
            Controls.SetChildIndex(txtEmail, 0);
            Controls.SetChildIndex(btnProcuraCidade, 0);
            Controls.SetChildIndex(gpTipoPessoa, 0);
            Controls.SetChildIndex(lblCodCond, 0);
            Controls.SetChildIndex(txtCodCond, 0);
            Controls.SetChildIndex(btnProcuraCond, 0);
            Controls.SetChildIndex(lblCond, 0);
            Controls.SetChildIndex(txtCond, 0);
            gpTipoPessoa.ResumeLayout(false);
            gpTipoPessoa.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodCond;
        private TextBox txtCodCond;
        private Button btnProcuraCond;
        private TextBox txtCond;
        private Label lblCond;
    }
}