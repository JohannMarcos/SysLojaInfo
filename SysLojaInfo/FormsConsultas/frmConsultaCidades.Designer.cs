namespace SysLojaInfo
{
    partial class frmConsultaCidades
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
            dgCidades = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            cidade = new DataGridViewTextBoxColumn();
            ddd = new DataGridViewTextBoxColumn();
            codestado = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            datcad = new DataGridViewTextBoxColumn();
            datalt = new DataGridViewTextBoxColumn();
            iduser = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgCidades).BeginInit();
            SuspendLayout();
            // 
            // dgCidades
            // 
            dgCidades.AllowUserToAddRows = false;
            dgCidades.AllowUserToDeleteRows = false;
            dgCidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCidades.Columns.AddRange(new DataGridViewColumn[] { codigo, cidade, ddd, codestado, estado, datcad, datalt, iduser });
            dgCidades.Location = new Point(16, 65);
            dgCidades.Name = "dgCidades";
            dgCidades.RowHeadersVisible = false;
            dgCidades.RowTemplate.Height = 25;
            dgCidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgCidades.Size = new Size(772, 335);
            dgCidades.TabIndex = 7;
            // 
            // codigo
            // 
            codigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            codigo.HeaderText = "Código";
            codigo.Name = "codigo";
            codigo.ReadOnly = true;
            codigo.Width = 50;
            // 
            // cidade
            // 
            cidade.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cidade.HeaderText = "Cidade";
            cidade.Name = "cidade";
            cidade.ReadOnly = true;
            // 
            // ddd
            // 
            ddd.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ddd.HeaderText = "DDD";
            ddd.Name = "ddd";
            ddd.ReadOnly = true;
            ddd.Width = 50;
            // 
            // codestado
            // 
            codestado.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            codestado.HeaderText = "Código Estado";
            codestado.Name = "codestado";
            codestado.ReadOnly = true;
            codestado.Width = 50;
            // 
            // estado
            // 
            estado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            estado.HeaderText = "Estado";
            estado.Name = "estado";
            estado.ReadOnly = true;
            // 
            // datcad
            // 
            datcad.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            datcad.HeaderText = "Data Cadastro";
            datcad.Name = "datcad";
            datcad.ReadOnly = true;
            // 
            // datalt
            // 
            datalt.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            datalt.HeaderText = "Data Alteração";
            datalt.Name = "datalt";
            datalt.ReadOnly = true;
            // 
            // iduser
            // 
            iduser.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            iduser.HeaderText = "Quem alterou";
            iduser.Name = "iduser";
            iduser.ReadOnly = true;
            iduser.Width = 50;
            // 
            // frmConsultaCidades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgCidades);
            Name = "frmConsultaCidades";
            Text = "Consulta de Cidades";
            Activated += frmConsultaCidades_Activated;
            Load += Form1_Load;
            Controls.SetChildIndex(txtChave, 0);
            Controls.SetChildIndex(btnSair, 0);
            Controls.SetChildIndex(dgCidades, 0);
            ((System.ComponentModel.ISupportInitialize)dgCidades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgCidades;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn cidade;
        private DataGridViewTextBoxColumn ddd;
        private DataGridViewTextBoxColumn codestado;
        private DataGridViewTextBoxColumn estado;
        private DataGridViewTextBoxColumn datcad;
        private DataGridViewTextBoxColumn datalt;
        private DataGridViewTextBoxColumn iduser;
    }
}