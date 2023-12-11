namespace SysLojaInfo
{
    partial class frmCadastro
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
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            txtDatCad = new TextBox();
            txtDatUltAlt = new TextBox();
            txtQuemAlt = new TextBox();
            lblDatCad = new Label();
            lblDatUltAlt = new Label();
            lblQuemAlt = new Label();
            btnSalvar = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(29, 25);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(29, 43);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(109, 23);
            txtCodigo.TabIndex = 1;
            // 
            // txtDatCad
            // 
            txtDatCad.Enabled = false;
            txtDatCad.Location = new Point(29, 415);
            txtDatCad.Name = "txtDatCad";
            txtDatCad.Size = new Size(109, 23);
            txtDatCad.TabIndex = 2;
            // 
            // txtDatUltAlt
            // 
            txtDatUltAlt.Enabled = false;
            txtDatUltAlt.Location = new Point(147, 415);
            txtDatUltAlt.Name = "txtDatUltAlt";
            txtDatUltAlt.Size = new Size(138, 23);
            txtDatUltAlt.TabIndex = 3;
            // 
            // txtQuemAlt
            // 
            txtQuemAlt.Enabled = false;
            txtQuemAlt.Location = new Point(291, 415);
            txtQuemAlt.Name = "txtQuemAlt";
            txtQuemAlt.Size = new Size(109, 23);
            txtQuemAlt.TabIndex = 4;
            // 
            // lblDatCad
            // 
            lblDatCad.AutoSize = true;
            lblDatCad.Location = new Point(29, 396);
            lblDatCad.Name = "lblDatCad";
            lblDatCad.Size = new Size(97, 15);
            lblDatCad.TabIndex = 5;
            lblDatCad.Text = "Data de Cadastro";
            // 
            // lblDatUltAlt
            // 
            lblDatUltAlt.AutoSize = true;
            lblDatUltAlt.Location = new Point(147, 397);
            lblDatUltAlt.Name = "lblDatUltAlt";
            lblDatUltAlt.Size = new Size(138, 15);
            lblDatUltAlt.TabIndex = 6;
            lblDatUltAlt.Text = "Data da Última Alteração";
            // 
            // lblQuemAlt
            // 
            lblQuemAlt.AutoSize = true;
            lblQuemAlt.Location = new Point(291, 397);
            lblQuemAlt.Name = "lblQuemAlt";
            lblQuemAlt.Size = new Size(82, 15);
            lblQuemAlt.TabIndex = 7;
            lblQuemAlt.Text = "Quem Alterou";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(613, 414);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(704, 414);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 9;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSair);
            Controls.Add(btnSalvar);
            Controls.Add(lblQuemAlt);
            Controls.Add(lblDatUltAlt);
            Controls.Add(lblDatCad);
            Controls.Add(txtQuemAlt);
            Controls.Add(txtDatUltAlt);
            Controls.Add(txtDatCad);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Name = "frmCadastro";
            Text = "Cadastro";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public TextBox txtCodigo;
        public Label lblCodigo;
        public Button btnSalvar;
        public TextBox txtDatCad;
        public TextBox txtDatUltAlt;
        public TextBox txtQuemAlt;
        public Label lblDatCad;
        public Button btnSair;
        public Label lblQuemAlt;
        public Label lblDatUltAlt;
    }
}