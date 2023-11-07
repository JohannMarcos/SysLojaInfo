namespace SysLojaInfo
{
    partial class frmConsultaMedidas
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
            dgMedidas = new DataGridView();
            umedida = new DataGridViewTextBoxColumn();
            descricao = new DataGridViewTextBoxColumn();
            ativo = new DataGridViewTextBoxColumn();
            datalt = new DataGridViewTextBoxColumn();
            iduser = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgMedidas).BeginInit();
            SuspendLayout();
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(486, 415);
            btnExcluir.Visible = false;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(628, 415);
            // 
            // btnIncluir
            // 
            btnIncluir.Visible = false;
            // 
            // dgMedidas
            // 
            dgMedidas.AllowUserToAddRows = false;
            dgMedidas.AllowUserToDeleteRows = false;
            dgMedidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMedidas.Columns.AddRange(new DataGridViewColumn[] { umedida, descricao, ativo, datalt, iduser });
            dgMedidas.Location = new Point(12, 65);
            dgMedidas.Name = "dgMedidas";
            dgMedidas.RowHeadersVisible = false;
            dgMedidas.RowTemplate.Height = 25;
            dgMedidas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgMedidas.Size = new Size(776, 344);
            dgMedidas.TabIndex = 7;
            // 
            // umedida
            // 
            umedida.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            umedida.HeaderText = "Unidade";
            umedida.Name = "umedida";
            umedida.ReadOnly = true;
            // 
            // descricao
            // 
            descricao.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descricao.HeaderText = "Descricão";
            descricao.Name = "descricao";
            descricao.ReadOnly = true;
            // 
            // ativo
            // 
            ativo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ativo.HeaderText = "Ativo";
            ativo.Name = "ativo";
            ativo.ReadOnly = true;
            ativo.Width = 50;
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
            iduser.HeaderText = "Quem Alterou";
            iduser.Name = "iduser";
            iduser.ReadOnly = true;
            iduser.Width = 50;
            // 
            // frmConsultaMedidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgMedidas);
            Name = "frmConsultaMedidas";
            Text = "Consulta Medidas";
            Activated += frmConsultaMedidas_Activated;
            Controls.SetChildIndex(txtChave, 0);
            Controls.SetChildIndex(btnSair, 0);
            Controls.SetChildIndex(btnExcluir, 0);
            Controls.SetChildIndex(btnAlterar, 0);
            Controls.SetChildIndex(btnIncluir, 0);
            Controls.SetChildIndex(dgMedidas, 0);
            ((System.ComponentModel.ISupportInitialize)dgMedidas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgMedidas;
        private DataGridViewTextBoxColumn umedida;
        private DataGridViewTextBoxColumn descricao;
        private DataGridViewTextBoxColumn ativo;
        private DataGridViewTextBoxColumn datalt;
        private DataGridViewTextBoxColumn iduser;
    }
}