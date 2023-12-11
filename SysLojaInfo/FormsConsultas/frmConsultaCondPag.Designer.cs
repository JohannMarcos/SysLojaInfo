namespace SysLojaInfo
{
    partial class frmConsultaCondPag
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
            dgCond = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            cond = new DataGridViewTextBoxColumn();
            taxa = new DataGridViewTextBoxColumn();
            multa = new DataGridViewTextBoxColumn();
            desc = new DataGridViewTextBoxColumn();
            datcad = new DataGridViewTextBoxColumn();
            datalt = new DataGridViewTextBoxColumn();
            idUser = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgCond).BeginInit();
            SuspendLayout();
            // 
            // txtChave
            // 
            txtChave.CharacterCasing = CharacterCasing.Upper;
            // 
            // dgCond
            // 
            dgCond.AllowUserToAddRows = false;
            dgCond.AllowUserToDeleteRows = false;
            dgCond.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgCond.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCond.Columns.AddRange(new DataGridViewColumn[] { codigo, cond, taxa, multa, desc, datcad, datalt, idUser });
            dgCond.Location = new Point(12, 66);
            dgCond.Name = "dgCond";
            dgCond.RowHeadersVisible = false;
            dgCond.RowTemplate.Height = 25;
            dgCond.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgCond.Size = new Size(776, 334);
            dgCond.TabIndex = 7;
            // 
            // codigo
            // 
            codigo.HeaderText = "Código";
            codigo.Name = "codigo";
            codigo.ReadOnly = true;
            codigo.Width = 50;
            // 
            // cond
            // 
            cond.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cond.HeaderText = "Condição";
            cond.Name = "cond";
            cond.ReadOnly = true;
            // 
            // taxa
            // 
            taxa.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            taxa.HeaderText = "Taxa";
            taxa.Name = "taxa";
            taxa.ReadOnly = true;
            taxa.Width = 50;
            // 
            // multa
            // 
            multa.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            multa.HeaderText = "Multa";
            multa.Name = "multa";
            multa.ReadOnly = true;
            multa.Width = 50;
            // 
            // desc
            // 
            desc.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            desc.HeaderText = "Desconto";
            desc.Name = "desc";
            desc.ReadOnly = true;
            desc.Width = 60;
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
            datalt.HeaderText = "Data alteração";
            datalt.Name = "datalt";
            datalt.ReadOnly = true;
            // 
            // idUser
            // 
            idUser.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            idUser.HeaderText = "Quem alterou";
            idUser.Name = "idUser";
            idUser.ReadOnly = true;
            idUser.Width = 50;
            // 
            // frmConsultaCondPag
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgCond);
            Name = "frmConsultaCondPag";
            Text = "Consulta de Condição de Pagamento";
            Activated += frmConsultaCondPag_Activated;
            Load += Form1_Load;
            Controls.SetChildIndex(txtChave, 0);
            Controls.SetChildIndex(btnSair, 0);
            Controls.SetChildIndex(btnExcluir, 0);
            Controls.SetChildIndex(btnAlterar, 0);
            Controls.SetChildIndex(btnIncluir, 0);
            Controls.SetChildIndex(dgCond, 0);
            ((System.ComponentModel.ISupportInitialize)dgCond).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgCond;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn cond;
        private DataGridViewTextBoxColumn taxa;
        private DataGridViewTextBoxColumn multa;
        private DataGridViewTextBoxColumn desc;
        private DataGridViewTextBoxColumn datcad;
        private DataGridViewTextBoxColumn datalt;
        private DataGridViewTextBoxColumn idUser;
    }
}