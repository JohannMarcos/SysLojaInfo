namespace SysLojaInfo
{
    partial class frmConsultaFornecedor
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
            dgFornecedores = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            cpfcnpj = new DataGridViewTextBoxColumn();
            rg = new DataGridViewTextBoxColumn();
            logr = new DataGridViewTextBoxColumn();
            numero = new DataGridViewTextBoxColumn();
            natpess = new DataGridViewTextBoxColumn();
            bairro = new DataGridViewTextBoxColumn();
            codcidade = new DataGridViewTextBoxColumn();
            cidade = new DataGridViewTextBoxColumn();
            telres = new DataGridViewTextBoxColumn();
            telcel = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            codCond = new DataGridViewTextBoxColumn();
            condicao = new DataGridViewTextBoxColumn();
            datcad = new DataGridViewTextBoxColumn();
            datalt = new DataGridViewTextBoxColumn();
            idUser = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgFornecedores).BeginInit();
            SuspendLayout();
            // 
            // dgFornecedores
            // 
            dgFornecedores.AllowUserToAddRows = false;
            dgFornecedores.AllowUserToDeleteRows = false;
            dgFornecedores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgFornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgFornecedores.Columns.AddRange(new DataGridViewColumn[] { codigo, nome, cpfcnpj, rg, logr, numero, natpess, bairro, codcidade, cidade, telres, telcel, email, codCond, condicao, datcad, datalt, idUser });
            dgFornecedores.Location = new Point(12, 65);
            dgFornecedores.Name = "dgFornecedores";
            dgFornecedores.RowHeadersVisible = false;
            dgFornecedores.RowTemplate.Height = 25;
            dgFornecedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgFornecedores.Size = new Size(775, 340);
            dgFornecedores.TabIndex = 7;
            // 
            // codigo
            // 
            codigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            codigo.HeaderText = "Código";
            codigo.Name = "codigo";
            codigo.ReadOnly = true;
            codigo.Width = 50;
            // 
            // nome
            // 
            nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            nome.HeaderText = "Fornecedor";
            nome.Name = "nome";
            nome.ReadOnly = true;
            nome.Width = 500;
            // 
            // cpfcnpj
            // 
            cpfcnpj.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            cpfcnpj.HeaderText = "CPF | CNPJ";
            cpfcnpj.Name = "cpfcnpj";
            cpfcnpj.ReadOnly = true;
            cpfcnpj.Width = 175;
            // 
            // rg
            // 
            rg.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            rg.HeaderText = "RG";
            rg.Name = "rg";
            rg.ReadOnly = true;
            rg.Width = 75;
            // 
            // logr
            // 
            logr.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            logr.HeaderText = "Logradouro";
            logr.Name = "logr";
            logr.ReadOnly = true;
            logr.Width = 300;
            // 
            // numero
            // 
            numero.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            numero.HeaderText = "Número";
            numero.Name = "numero";
            numero.ReadOnly = true;
            numero.Width = 75;
            // 
            // natpess
            // 
            natpess.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            natpess.HeaderText = "Tipo";
            natpess.Name = "natpess";
            natpess.ReadOnly = true;
            natpess.Width = 50;
            // 
            // bairro
            // 
            bairro.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            bairro.HeaderText = "Bairro";
            bairro.Name = "bairro";
            bairro.ReadOnly = true;
            bairro.Width = 150;
            // 
            // codcidade
            // 
            codcidade.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            codcidade.HeaderText = "Cód. Cidade";
            codcidade.Name = "codcidade";
            codcidade.ReadOnly = true;
            codcidade.Width = 50;
            // 
            // cidade
            // 
            cidade.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            cidade.HeaderText = "Cidade";
            cidade.Name = "cidade";
            cidade.ReadOnly = true;
            cidade.Width = 200;
            // 
            // telres
            // 
            telres.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            telres.HeaderText = "Fone Residencial";
            telres.Name = "telres";
            telres.ReadOnly = true;
            // 
            // telcel
            // 
            telcel.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            telcel.HeaderText = "Fone Celular";
            telcel.Name = "telcel";
            telcel.ReadOnly = true;
            // 
            // email
            // 
            email.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            email.HeaderText = "E-mail";
            email.Name = "email";
            email.ReadOnly = true;
            email.Width = 300;
            // 
            // codCond
            // 
            codCond.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            codCond.HeaderText = "Cód. Condição";
            codCond.Name = "codCond";
            codCond.ReadOnly = true;
            codCond.Width = 75;
            // 
            // condicao
            // 
            condicao.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            condicao.HeaderText = "Condição de Pagamento";
            condicao.Name = "condicao";
            condicao.ReadOnly = true;
            condicao.Width = 200;
            // 
            // datcad
            // 
            datcad.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            datcad.HeaderText = "Data Cadastro";
            datcad.Name = "datcad";
            datcad.ReadOnly = true;
            datcad.Width = 75;
            // 
            // datalt
            // 
            datalt.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            datalt.HeaderText = "Data Alteração";
            datalt.Name = "datalt";
            datalt.ReadOnly = true;
            datalt.Width = 75;
            // 
            // idUser
            // 
            idUser.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            idUser.HeaderText = "Quem Alterou";
            idUser.Name = "idUser";
            idUser.ReadOnly = true;
            idUser.Width = 50;
            // 
            // frmConsultaFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgFornecedores);
            Name = "frmConsultaFornecedor";
            Text = "Consulta de Fornecedores";
            Activated += frmConsultaFornecedor_Activated;
            Load += Form1_Load;
            Controls.SetChildIndex(btnExcluir, 0);
            Controls.SetChildIndex(btnAlterar, 0);
            Controls.SetChildIndex(btnIncluir, 0);
            Controls.SetChildIndex(txtChave, 0);
            Controls.SetChildIndex(btnSair, 0);
            Controls.SetChildIndex(dgFornecedores, 0);
            ((System.ComponentModel.ISupportInitialize)dgFornecedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgFornecedores;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn cpfcnpj;
        private DataGridViewTextBoxColumn rg;
        private DataGridViewTextBoxColumn logr;
        private DataGridViewTextBoxColumn numero;
        private DataGridViewTextBoxColumn natpess;
        private DataGridViewTextBoxColumn bairro;
        private DataGridViewTextBoxColumn codcidade;
        private DataGridViewTextBoxColumn cidade;
        private DataGridViewTextBoxColumn telres;
        private DataGridViewTextBoxColumn telcel;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn codCond;
        private DataGridViewTextBoxColumn condicao;
        private DataGridViewTextBoxColumn datcad;
        private DataGridViewTextBoxColumn datalt;
        private DataGridViewTextBoxColumn idUser;
    }
}