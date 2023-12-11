namespace SysLojaInfo
{
    partial class frmConsultaPaises
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
            dgPaises = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            pais = new DataGridViewTextBoxColumn();
            sigla = new DataGridViewTextBoxColumn();
            ddi = new DataGridViewTextBoxColumn();
            datCad = new DataGridViewTextBoxColumn();
            datAlt = new DataGridViewTextBoxColumn();
            idUser = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgPaises).BeginInit();
            SuspendLayout();
            // 
            // dgPaises
            // 
            dgPaises.AllowUserToAddRows = false;
            dgPaises.AllowUserToDeleteRows = false;
            dgPaises.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPaises.Columns.AddRange(new DataGridViewColumn[] { codigo, pais, sigla, ddi, datCad, datAlt, idUser });
            dgPaises.Location = new Point(12, 56);
            dgPaises.Name = "dgPaises";
            dgPaises.ReadOnly = true;
            dgPaises.RowHeadersVisible = false;
            dgPaises.RowTemplate.Height = 25;
            dgPaises.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPaises.Size = new Size(776, 353);
            dgPaises.TabIndex = 7;
            // 
            // codigo
            // 
            codigo.HeaderText = "Código";
            codigo.Name = "codigo";
            codigo.ReadOnly = true;
            codigo.Width = 75;
            // 
            // pais
            // 
            pais.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            pais.HeaderText = "País";
            pais.Name = "pais";
            pais.ReadOnly = true;
            // 
            // sigla
            // 
            sigla.HeaderText = "Sigla";
            sigla.Name = "sigla";
            sigla.ReadOnly = true;
            sigla.Width = 50;
            // 
            // ddi
            // 
            ddi.HeaderText = "DDI";
            ddi.Name = "ddi";
            ddi.ReadOnly = true;
            ddi.Width = 50;
            // 
            // datCad
            // 
            datCad.HeaderText = "Data de Cadastro";
            datCad.Name = "datCad";
            datCad.ReadOnly = true;
            datCad.Width = 150;
            // 
            // datAlt
            // 
            datAlt.HeaderText = "Data Alteração";
            datAlt.Name = "datAlt";
            datAlt.ReadOnly = true;
            datAlt.Width = 150;
            // 
            // idUser
            // 
            idUser.HeaderText = "Código usuário";
            idUser.Name = "idUser";
            idUser.ReadOnly = true;
            idUser.Width = 50;
            // 
            // frmConsultaPaises
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgPaises);
            Name = "frmConsultaPaises";
            Text = "Consulta de Países";
            Activated += frmConsultaPaises_Activated;
            Load += Form1_Load;
            Controls.SetChildIndex(txtChave, 0);
            Controls.SetChildIndex(btnSair, 0);
            Controls.SetChildIndex(dgPaises, 0);
            ((System.ComponentModel.ISupportInitialize)dgPaises).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgPaises;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn pais;
        private DataGridViewTextBoxColumn sigla;
        private DataGridViewTextBoxColumn ddi;
        private DataGridViewTextBoxColumn datCad;
        private DataGridViewTextBoxColumn datAlt;
        private DataGridViewTextBoxColumn idUser;
    }
}