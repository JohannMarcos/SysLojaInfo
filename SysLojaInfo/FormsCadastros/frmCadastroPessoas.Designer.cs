﻿namespace SysLojaInfo
{
    partial class frmCadastroPessoas
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
            lblNomeRazao = new Label();
            lblCpfCnpj = new Label();
            lblRg = new Label();
            lblLogr = new Label();
            lblNumero = new Label();
            lblBairro = new Label();
            txtNome = new TextBox();
            txtCpfCnpj = new TextBox();
            txtRg = new TextBox();
            txtLogr = new TextBox();
            txtNumero = new TextBox();
            txtBairro = new TextBox();
            lblCodCidade = new Label();
            lblCidade = new Label();
            lblTelRes = new Label();
            lblTelCel = new Label();
            lblEmail = new Label();
            txtCodCidade = new TextBox();
            txtCidade = new TextBox();
            txtTelRes = new TextBox();
            txtTelCel = new TextBox();
            txtEmail = new TextBox();
            btnProcuraCidade = new Button();
            gpTipoPessoa = new GroupBox();
            rbJuridica = new RadioButton();
            rbFisica = new RadioButton();
            gpTipoPessoa.SuspendLayout();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(17, 43);
            // 
            // lblCodigo
            // 
            lblCodigo.Location = new Point(17, 25);
            lblCodigo.Click += lblCodigo_Click;
            // 
            // lblNomeRazao
            // 
            lblNomeRazao.AutoSize = true;
            lblNomeRazao.Location = new Point(380, 25);
            lblNomeRazao.Name = "lblNomeRazao";
            lblNomeRazao.Size = new Size(116, 15);
            lblNomeRazao.TabIndex = 10;
            lblNomeRazao.Text = "Nome / Razão Social";
            // 
            // lblCpfCnpj
            // 
            lblCpfCnpj.AutoSize = true;
            lblCpfCnpj.Location = new Point(17, 78);
            lblCpfCnpj.Name = "lblCpfCnpj";
            lblCpfCnpj.Size = new Size(66, 15);
            lblCpfCnpj.TabIndex = 11;
            lblCpfCnpj.Text = "CPF / CNPJ";
            // 
            // lblRg
            // 
            lblRg.AutoSize = true;
            lblRg.Location = new Point(208, 78);
            lblRg.Name = "lblRg";
            lblRg.Size = new Size(22, 15);
            lblRg.TabIndex = 12;
            lblRg.Text = "RG";
            // 
            // lblLogr
            // 
            lblLogr.AutoSize = true;
            lblLogr.Location = new Point(18, 189);
            lblLogr.Name = "lblLogr";
            lblLogr.Size = new Size(69, 15);
            lblLogr.TabIndex = 13;
            lblLogr.Text = "Logradouro";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(418, 189);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 14;
            lblNumero.Text = "Número";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(524, 189);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(38, 15);
            lblBairro.TabIndex = 15;
            lblBairro.Text = "Bairro";
            // 
            // txtNome
            // 
            txtNome.CharacterCasing = CharacterCasing.Upper;
            txtNome.Enabled = false;
            txtNome.Location = new Point(380, 44);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(399, 23);
            txtNome.TabIndex = 16;
            // 
            // txtCpfCnpj
            // 
            txtCpfCnpj.CharacterCasing = CharacterCasing.Upper;
            txtCpfCnpj.Location = new Point(17, 96);
            txtCpfCnpj.Name = "txtCpfCnpj";
            txtCpfCnpj.Size = new Size(184, 23);
            txtCpfCnpj.TabIndex = 17;
            // 
            // txtRg
            // 
            txtRg.CharacterCasing = CharacterCasing.Upper;
            txtRg.Location = new Point(208, 96);
            txtRg.Name = "txtRg";
            txtRg.Size = new Size(166, 23);
            txtRg.TabIndex = 18;
            // 
            // txtLogr
            // 
            txtLogr.CharacterCasing = CharacterCasing.Upper;
            txtLogr.Location = new Point(18, 207);
            txtLogr.Name = "txtLogr";
            txtLogr.Size = new Size(394, 23);
            txtLogr.TabIndex = 19;
            // 
            // txtNumero
            // 
            txtNumero.CharacterCasing = CharacterCasing.Upper;
            txtNumero.Location = new Point(418, 207);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 20;
            // 
            // txtBairro
            // 
            txtBairro.CharacterCasing = CharacterCasing.Upper;
            txtBairro.Location = new Point(524, 207);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(255, 23);
            txtBairro.TabIndex = 21;
            // 
            // lblCodCidade
            // 
            lblCodCidade.AutoSize = true;
            lblCodCidade.Location = new Point(18, 135);
            lblCodCidade.Name = "lblCodCidade";
            lblCodCidade.Size = new Size(102, 15);
            lblCodCidade.TabIndex = 22;
            lblCodCidade.Text = "Código da Cidade";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(136, 135);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(44, 15);
            lblCidade.TabIndex = 23;
            lblCidade.Text = "Cidade";
            // 
            // lblTelRes
            // 
            lblTelRes.AutoSize = true;
            lblTelRes.Location = new Point(18, 249);
            lblTelRes.Name = "lblTelRes";
            lblTelRes.Size = new Size(113, 15);
            lblTelRes.TabIndex = 24;
            lblTelRes.Text = "Telefone Residencial";
            // 
            // lblTelCel
            // 
            lblTelCel.AutoSize = true;
            lblTelCel.Location = new Point(136, 249);
            lblTelCel.Name = "lblTelCel";
            lblTelCel.Size = new Size(91, 15);
            lblTelCel.TabIndex = 25;
            lblTelCel.Text = "Telefone Celular";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(251, 249);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 26;
            lblEmail.Text = "E-mail";
            // 
            // txtCodCidade
            // 
            txtCodCidade.CharacterCasing = CharacterCasing.Upper;
            txtCodCidade.Enabled = false;
            txtCodCidade.Location = new Point(18, 154);
            txtCodCidade.Name = "txtCodCidade";
            txtCodCidade.Size = new Size(109, 23);
            txtCodCidade.TabIndex = 27;
            // 
            // txtCidade
            // 
            txtCidade.CharacterCasing = CharacterCasing.Upper;
            txtCidade.Enabled = false;
            txtCidade.Location = new Point(136, 154);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(276, 23);
            txtCidade.TabIndex = 28;
            // 
            // txtTelRes
            // 
            txtTelRes.CharacterCasing = CharacterCasing.Upper;
            txtTelRes.Location = new Point(18, 267);
            txtTelRes.Name = "txtTelRes";
            txtTelRes.Size = new Size(109, 23);
            txtTelRes.TabIndex = 29;
            // 
            // txtTelCel
            // 
            txtTelCel.CharacterCasing = CharacterCasing.Upper;
            txtTelCel.Location = new Point(136, 267);
            txtTelCel.Name = "txtTelCel";
            txtTelCel.Size = new Size(109, 23);
            txtTelCel.TabIndex = 30;
            // 
            // txtEmail
            // 
            txtEmail.CharacterCasing = CharacterCasing.Upper;
            txtEmail.Location = new Point(251, 267);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(528, 23);
            txtEmail.TabIndex = 31;
            // 
            // btnProcuraCidade
            // 
            btnProcuraCidade.Location = new Point(418, 153);
            btnProcuraCidade.Name = "btnProcuraCidade";
            btnProcuraCidade.Size = new Size(100, 23);
            btnProcuraCidade.TabIndex = 32;
            btnProcuraCidade.Text = "Procurar Cidade";
            btnProcuraCidade.UseVisualStyleBackColor = true;
            btnProcuraCidade.Click += btnProcuraCidade_Click;
            // 
            // gpTipoPessoa
            // 
            gpTipoPessoa.Controls.Add(rbJuridica);
            gpTipoPessoa.Controls.Add(rbFisica);
            gpTipoPessoa.Location = new Point(132, 26);
            gpTipoPessoa.Name = "gpTipoPessoa";
            gpTipoPessoa.Size = new Size(242, 41);
            gpTipoPessoa.TabIndex = 33;
            gpTipoPessoa.TabStop = false;
            gpTipoPessoa.Text = "Tipo De Pessoa:";
            // 
            // rbJuridica
            // 
            rbJuridica.AutoSize = true;
            rbJuridica.Location = new Point(125, 18);
            rbJuridica.Name = "rbJuridica";
            rbJuridica.Size = new Size(104, 19);
            rbJuridica.TabIndex = 1;
            rbJuridica.Text = "Pessoa Jurídica";
            rbJuridica.UseVisualStyleBackColor = true;
            // 
            // rbFisica
            // 
            rbFisica.AutoSize = true;
            rbFisica.Location = new Point(16, 18);
            rbFisica.Name = "rbFisica";
            rbFisica.Size = new Size(93, 19);
            rbFisica.TabIndex = 0;
            rbFisica.Text = "Pessoa Física";
            rbFisica.UseVisualStyleBackColor = true;
            // 
            // frmCadastroPessoas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gpTipoPessoa);
            Controls.Add(btnProcuraCidade);
            Controls.Add(txtEmail);
            Controls.Add(txtTelCel);
            Controls.Add(txtTelRes);
            Controls.Add(txtCidade);
            Controls.Add(txtCodCidade);
            Controls.Add(lblEmail);
            Controls.Add(lblTelCel);
            Controls.Add(lblTelRes);
            Controls.Add(lblCidade);
            Controls.Add(lblCodCidade);
            Controls.Add(txtBairro);
            Controls.Add(txtNumero);
            Controls.Add(txtLogr);
            Controls.Add(txtRg);
            Controls.Add(txtCpfCnpj);
            Controls.Add(txtNome);
            Controls.Add(lblBairro);
            Controls.Add(lblNumero);
            Controls.Add(lblLogr);
            Controls.Add(lblRg);
            Controls.Add(lblCpfCnpj);
            Controls.Add(lblNomeRazao);
            Name = "frmCadastroPessoas";
            Text = "Cadastro de Pessoas";
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
            gpTipoPessoa.ResumeLayout(false);
            gpTipoPessoa.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public TextBox txtNome;
        public TextBox txtCpfCnpj;
        public TextBox txtRg;
        public TextBox txtLogr;
        public TextBox txtNumero;
        public TextBox txtBairro;
        public TextBox txtCodCidade;
        public TextBox txtCidade;
        public TextBox txtTelRes;
        public TextBox txtTelCel;
        public TextBox txtEmail;
        public Button btnProcuraCidade;
        public GroupBox gpTipoPessoa;
        public RadioButton rbJuridica;
        public RadioButton rbFisica;
        public Label lblNomeRazao;
        public Label lblCpfCnpj;
        public Label lblRg;
        public Label lblLogr;
        public Label lblNumero;
        public Label lblBairro;
        public Label lblCodCidade;
        public Label lblCidade;
        public Label lblTelRes;
        public Label lblTelCel;
        public Label lblEmail;
    }
}