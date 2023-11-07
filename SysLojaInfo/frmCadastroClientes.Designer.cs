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
            gpTipoPessoa.SuspendLayout();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.CharacterCasing = CharacterCasing.Upper;
            // 
            // txtCpfCnpj
            // 
            txtCpfCnpj.CharacterCasing = CharacterCasing.Upper;
            // 
            // txtRg
            // 
            txtRg.CharacterCasing = CharacterCasing.Upper;
            // 
            // txtLogr
            // 
            txtLogr.CharacterCasing = CharacterCasing.Upper;
            // 
            // txtNumero
            // 
            txtNumero.CharacterCasing = CharacterCasing.Upper;
            // 
            // txtBairro
            // 
            txtBairro.CharacterCasing = CharacterCasing.Upper;
            // 
            // txtCodCidade
            // 
            txtCodCidade.CharacterCasing = CharacterCasing.Upper;
            // 
            // txtCidade
            // 
            txtCidade.CharacterCasing = CharacterCasing.Upper;
            // 
            // txtTelRes
            // 
            txtTelRes.CharacterCasing = CharacterCasing.Upper;
            // 
            // txtTelCel
            // 
            txtTelCel.CharacterCasing = CharacterCasing.Upper;
            // 
            // txtEmail
            // 
            txtEmail.CharacterCasing = CharacterCasing.Upper;
            // 
            // lblLimite
            // 
            lblLimite.AutoSize = true;
            lblLimite.Location = new Point(392, 83);
            lblLimite.Name = "lblLimite";
            lblLimite.Size = new Size(98, 15);
            lblLimite.TabIndex = 34;
            lblLimite.Text = "Limite de Crédito";
            // 
            // txtLimite
            // 
            txtLimite.CharacterCasing = CharacterCasing.Upper;
            txtLimite.Location = new Point(392, 101);
            txtLimite.Name = "txtLimite";
            txtLimite.Size = new Size(137, 23);
            txtLimite.TabIndex = 35;
            // 
            // frmCadastroClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLimite);
            Controls.Add(lblLimite);
            Name = "frmCadastroClientes";
            Text = "Cadastro De Clientes";
            Load += Form1_Load;
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
            Controls.SetChildIndex(gpTipoPessoa, 0);
            Controls.SetChildIndex(lblLimite, 0);
            Controls.SetChildIndex(txtLimite, 0);
            gpTipoPessoa.ResumeLayout(false);
            gpTipoPessoa.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLimite;
        private TextBox txtLimite;
    }
}