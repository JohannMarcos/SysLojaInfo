namespace SysLojaInfo
{
    partial class frmConsultaEstados
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
            dgEstados = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            uf = new DataGridViewTextBoxColumn();
            codPais = new DataGridViewTextBoxColumn();
            pais = new DataGridViewTextBoxColumn();
            datcad = new DataGridViewTextBoxColumn();
            datAlt = new DataGridViewTextBoxColumn();
            idUser = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgEstados).BeginInit();
            SuspendLayout();
            // 
            // dgEstados
            // 
            dgEstados.AllowUserToAddRows = false;
            dgEstados.AllowUserToDeleteRows = false;
            dgEstados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEstados.Columns.AddRange(new DataGridViewColumn[] { codigo, estado, uf, codPais, pais, datcad, datAlt, idUser });
            dgEstados.Location = new Point(12, 56);
            dgEstados.Name = "dgEstados";
            dgEstados.RowHeadersVisible = false;
            dgEstados.RowTemplate.Height = 25;
            dgEstados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgEstados.Size = new Size(776, 353);
            dgEstados.TabIndex = 7;
            // 
            // codigo
            // 
            codigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            codigo.FillWeight = 50F;
            codigo.HeaderText = "Código";
            codigo.Name = "codigo";
            codigo.ReadOnly = true;
            codigo.Width = 50;
            // 
            // estado
            // 
            estado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            estado.HeaderText = "Estado";
            estado.Name = "estado";
            estado.ReadOnly = true;
            // 
            // uf
            // 
            uf.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            uf.FillWeight = 5F;
            uf.HeaderText = "UF";
            uf.Name = "uf";
            uf.ReadOnly = true;
            uf.Width = 50;
            // 
            // codPais
            // 
            codPais.FillWeight = 50F;
            codPais.HeaderText = "Cód. País";
            codPais.Name = "codPais";
            codPais.ReadOnly = true;
            codPais.Width = 50;
            // 
            // pais
            // 
            pais.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            pais.HeaderText = "País";
            pais.Name = "pais";
            pais.ReadOnly = true;
            // 
            // datcad
            // 
            datcad.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            datcad.HeaderText = "Data Cadastro";
            datcad.Name = "datcad";
            datcad.ReadOnly = true;
            // 
            // datAlt
            // 
            datAlt.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            datAlt.HeaderText = "Data Alteração";
            datAlt.Name = "datAlt";
            datAlt.ReadOnly = true;
            // 
            // idUser
            // 
            idUser.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            idUser.FillWeight = 50F;
            idUser.HeaderText = "Quem Alterou";
            idUser.Name = "idUser";
            idUser.ReadOnly = true;
            idUser.Width = 50;
            // 
            // frmConsultaEstados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgEstados);
            Name = "frmConsultaEstados";
            Text = "Consulta de Estados";
            Activated += frmConsultaEstados_Activated;
            Load += Form1_Load;
            Controls.SetChildIndex(txtChave, 0);
            Controls.SetChildIndex(btnSair, 0);
            Controls.SetChildIndex(dgEstados, 0);
            ((System.ComponentModel.ISupportInitialize)dgEstados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgEstados;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn estado;
        private DataGridViewTextBoxColumn uf;
        private DataGridViewTextBoxColumn codPais;
        private DataGridViewTextBoxColumn pais;
        private DataGridViewTextBoxColumn datcad;
        private DataGridViewTextBoxColumn datAlt;
        private DataGridViewTextBoxColumn idUser;
    }
}