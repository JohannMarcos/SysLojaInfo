namespace SysLojaInfo
{
    partial class frmCadastroEstados
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
            lblEstado = new Label();
            txtEstado = new TextBox();
            txtUF = new TextBox();
            txtCodPais = new TextBox();
            txtPais = new TextBox();
            btnPesquisa = new Button();
            lblUF = new Label();
            lblCodPais = new Label();
            lblPais = new Label();
            SuspendLayout();
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(147, 25);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 10;
            lblEstado.Text = "Estado";
            // 
            // txtEstado
            // 
            txtEstado.CharacterCasing = CharacterCasing.Upper;
            txtEstado.Location = new Point(147, 43);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(206, 23);
            txtEstado.TabIndex = 11;
            // 
            // txtUF
            // 
            txtUF.CharacterCasing = CharacterCasing.Upper;
            txtUF.Location = new Point(364, 43);
            txtUF.Name = "txtUF";
            txtUF.Size = new Size(100, 23);
            txtUF.TabIndex = 12;
            // 
            // txtCodPais
            // 
            txtCodPais.Enabled = false;
            txtCodPais.Location = new Point(29, 103);
            txtCodPais.Name = "txtCodPais";
            txtCodPais.Size = new Size(109, 23);
            txtCodPais.TabIndex = 13;
            // 
            // txtPais
            // 
            txtPais.Enabled = false;
            txtPais.Location = new Point(147, 103);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(206, 23);
            txtPais.TabIndex = 14;
            // 
            // btnPesquisa
            // 
            btnPesquisa.Location = new Point(364, 102);
            btnPesquisa.Name = "btnPesquisa";
            btnPesquisa.Size = new Size(100, 23);
            btnPesquisa.TabIndex = 15;
            btnPesquisa.Text = "Procurar";
            btnPesquisa.UseVisualStyleBackColor = true;
            btnPesquisa.Click += btnPesquisa_Click;
            // 
            // lblUF
            // 
            lblUF.AutoSize = true;
            lblUF.Location = new Point(364, 25);
            lblUF.Name = "lblUF";
            lblUF.Size = new Size(21, 15);
            lblUF.TabIndex = 16;
            lblUF.Text = "UF";
            // 
            // lblCodPais
            // 
            lblCodPais.AutoSize = true;
            lblCodPais.Location = new Point(29, 85);
            lblCodPais.Name = "lblCodPais";
            lblCodPais.Size = new Size(87, 15);
            lblCodPais.TabIndex = 17;
            lblCodPais.Text = "Código do País";
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Location = new Point(147, 85);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(28, 15);
            lblPais.TabIndex = 18;
            lblPais.Text = "País";
            // 
            // frmCadastroEstados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPais);
            Controls.Add(lblCodPais);
            Controls.Add(lblUF);
            Controls.Add(btnPesquisa);
            Controls.Add(txtPais);
            Controls.Add(txtCodPais);
            Controls.Add(txtUF);
            Controls.Add(txtEstado);
            Controls.Add(lblEstado);
            Name = "frmCadastroEstados";
            Text = "Cadastro de Estados";
            Load += Form1_Load;
            Controls.SetChildIndex(txtCodigo, 0);
            Controls.SetChildIndex(txtDatCad, 0);
            Controls.SetChildIndex(txtDatUltAlt, 0);
            Controls.SetChildIndex(txtQuemAlt, 0);
            Controls.SetChildIndex(btnSalvar, 0);
            Controls.SetChildIndex(lblEstado, 0);
            Controls.SetChildIndex(txtEstado, 0);
            Controls.SetChildIndex(txtUF, 0);
            Controls.SetChildIndex(txtCodPais, 0);
            Controls.SetChildIndex(txtPais, 0);
            Controls.SetChildIndex(btnPesquisa, 0);
            Controls.SetChildIndex(lblUF, 0);
            Controls.SetChildIndex(lblCodPais, 0);
            Controls.SetChildIndex(lblPais, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEstado;
        private TextBox txtEstado;
        private TextBox txtUF;
        private TextBox txtCodPais;
        private TextBox txtPais;
        private Button btnPesquisa;
        private Label lblUF;
        private Label lblCodPais;
        private Label lblPais;
    }
}