namespace SysLojaInfo
{
    partial class frmConsultaFormaPag
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
            dgFormas = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            formapag = new DataGridViewTextBoxColumn();
            datcad = new DataGridViewTextBoxColumn();
            datalt = new DataGridViewTextBoxColumn();
            iduser = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgFormas).BeginInit();
            SuspendLayout();
            // 
            // dgFormas
            // 
            dgFormas.AllowUserToAddRows = false;
            dgFormas.AllowUserToDeleteRows = false;
            dgFormas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgFormas.Columns.AddRange(new DataGridViewColumn[] { codigo, formapag, datcad, datalt, iduser });
            dgFormas.Location = new Point(12, 65);
            dgFormas.Name = "dgFormas";
            dgFormas.RowHeadersVisible = false;
            dgFormas.RowTemplate.Height = 25;
            dgFormas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgFormas.Size = new Size(776, 344);
            dgFormas.TabIndex = 7;
            // 
            // codigo
            // 
            codigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            codigo.HeaderText = "Código";
            codigo.Name = "codigo";
            codigo.ReadOnly = true;
            codigo.Width = 50;
            // 
            // formapag
            // 
            formapag.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            formapag.HeaderText = "Forma de Pagamento";
            formapag.Name = "formapag";
            formapag.ReadOnly = true;
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
            iduser.HeaderText = "Quem Alterou";
            iduser.Name = "iduser";
            iduser.ReadOnly = true;
            iduser.Width = 50;
            // 
            // frmConsultaFormaPag
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgFormas);
            Name = "frmConsultaFormaPag";
            Text = "Consulta de Forma de Pagamento";
            Activated += frmConsultaFormaPag_Activated;
            Load += Form1_Load;
            Controls.SetChildIndex(txtChave, 0);
            Controls.SetChildIndex(btnSair, 0);
            Controls.SetChildIndex(btnExcluir, 0);
            Controls.SetChildIndex(btnAlterar, 0);
            Controls.SetChildIndex(btnIncluir, 0);
            Controls.SetChildIndex(dgFormas, 0);
            ((System.ComponentModel.ISupportInitialize)dgFormas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgFormas;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn formapag;
        private DataGridViewTextBoxColumn datcad;
        private DataGridViewTextBoxColumn datalt;
        private DataGridViewTextBoxColumn iduser;
    }
}