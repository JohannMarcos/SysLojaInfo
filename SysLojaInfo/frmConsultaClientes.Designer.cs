namespace SysLojaInfo
{
    partial class frmConsultaClientes
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
            dgClientes = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            cpfcnpj = new DataGridViewTextBoxColumn();
            rg = new DataGridViewTextBoxColumn();
            logr = new DataGridViewTextBoxColumn();
            num = new DataGridViewTextBoxColumn();
            natpess = new DataGridViewTextBoxColumn();
            bairro = new DataGridViewTextBoxColumn();
            limcred = new DataGridViewTextBoxColumn();
            codcidade = new DataGridViewTextBoxColumn();
            cidade = new DataGridViewTextBoxColumn();
            telres = new DataGridViewTextBoxColumn();
            telcel = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            datcad = new DataGridViewTextBoxColumn();
            datalt = new DataGridViewTextBoxColumn();
            iduser = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgClientes).BeginInit();
            SuspendLayout();
            // 
            // dgClientes
            // 
            dgClientes.AllowUserToAddRows = false;
            dgClientes.AllowUserToDeleteRows = false;
            dgClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgClientes.Columns.AddRange(new DataGridViewColumn[] { codigo, nome, cpfcnpj, rg, logr, num, natpess, bairro, limcred, codcidade, cidade, telres, telcel, email, datcad, datalt, iduser });
            dgClientes.EnableHeadersVisualStyles = false;
            dgClientes.Location = new Point(12, 65);
            dgClientes.Name = "dgClientes";
            dgClientes.RowHeadersVisible = false;
            dgClientes.RowTemplate.Height = 25;
            dgClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgClientes.Size = new Size(776, 333);
            dgClientes.TabIndex = 7;
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
            nome.HeaderText = "Nome/Razão Social";
            nome.Name = "nome";
            nome.ReadOnly = true;
            nome.Width = 400;
            // 
            // cpfcnpj
            // 
            cpfcnpj.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            cpfcnpj.HeaderText = "CPF/CNPJ";
            cpfcnpj.Name = "cpfcnpj";
            cpfcnpj.ReadOnly = true;
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
            logr.Width = 400;
            // 
            // num
            // 
            num.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            num.HeaderText = "Número";
            num.Name = "num";
            num.ReadOnly = true;
            num.Width = 50;
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
            bairro.Width = 200;
            // 
            // limcred
            // 
            limcred.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            limcred.HeaderText = "Limite";
            limcred.Name = "limcred";
            limcred.ReadOnly = true;
            limcred.Width = 75;
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
            cidade.Width = 150;
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
            email.Width = 350;
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
            // iduser
            // 
            iduser.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            iduser.HeaderText = "Quem Alterou";
            iduser.Name = "iduser";
            iduser.ReadOnly = true;
            iduser.Width = 50;
            // 
            // frmConsultaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgClientes);
            Name = "frmConsultaClientes";
            Text = "Consulta de Clientes";
            Activated += frmConsultaClientes_Activated;
            Load += Form1_Load;
            Controls.SetChildIndex(txtChave, 0);
            Controls.SetChildIndex(btnSair, 0);
            Controls.SetChildIndex(dgClientes, 0);
            ((System.ComponentModel.ISupportInitialize)dgClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgClientes;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn cpfcnpj;
        private DataGridViewTextBoxColumn rg;
        private DataGridViewTextBoxColumn logr;
        private DataGridViewTextBoxColumn num;
        private DataGridViewTextBoxColumn natpess;
        private DataGridViewTextBoxColumn bairro;
        private DataGridViewTextBoxColumn limcred;
        private DataGridViewTextBoxColumn codcidade;
        private DataGridViewTextBoxColumn cidade;
        private DataGridViewTextBoxColumn telres;
        private DataGridViewTextBoxColumn telcel;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn datcad;
        private DataGridViewTextBoxColumn datalt;
        private DataGridViewTextBoxColumn iduser;
    }
}