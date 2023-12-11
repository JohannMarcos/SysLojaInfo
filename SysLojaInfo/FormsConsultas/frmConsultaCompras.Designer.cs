namespace SysLojaInfo
{
    partial class frmConsultaCompras
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
            dgNotas = new DataGridView();
            nota = new DataGridViewTextBoxColumn();
            serieNota = new DataGridViewTextBoxColumn();
            modeloNota = new DataGridViewTextBoxColumn();
            emit = new DataGridViewTextBoxColumn();
            dtEmissao = new DataGridViewTextBoxColumn();
            dtChegada = new DataGridViewTextBoxColumn();
            totalnota = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgNotas).BeginInit();
            SuspendLayout();
            // 
            // btnIncluir
            // 
            btnIncluir.Click += btnIncluir_Click;
            // 
            // dgNotas
            // 
            dgNotas.AllowUserToAddRows = false;
            dgNotas.AllowUserToDeleteRows = false;
            dgNotas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgNotas.Columns.AddRange(new DataGridViewColumn[] { nota, serieNota, modeloNota, emit, dtEmissao, dtChegada, totalnota });
            dgNotas.Location = new Point(12, 56);
            dgNotas.Name = "dgNotas";
            dgNotas.RowHeadersVisible = false;
            dgNotas.RowTemplate.Height = 25;
            dgNotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgNotas.Size = new Size(776, 353);
            dgNotas.TabIndex = 7;
            // 
            // nota
            // 
            nota.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            nota.HeaderText = "Num Nota";
            nota.Name = "nota";
            nota.ReadOnly = true;
            nota.Width = 75;
            // 
            // serieNota
            // 
            serieNota.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            serieNota.HeaderText = "Serie";
            serieNota.Name = "serieNota";
            serieNota.ReadOnly = true;
            serieNota.Width = 75;
            // 
            // modeloNota
            // 
            modeloNota.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            modeloNota.HeaderText = "Modelo";
            modeloNota.Name = "modeloNota";
            modeloNota.ReadOnly = true;
            modeloNota.Width = 75;
            // 
            // emit
            // 
            emit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            emit.HeaderText = "Emitente";
            emit.Name = "emit";
            emit.ReadOnly = true;
            // 
            // dtEmissao
            // 
            dtEmissao.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dtEmissao.HeaderText = "Emissão";
            dtEmissao.Name = "dtEmissao";
            dtEmissao.ReadOnly = true;
            dtEmissao.Width = 75;
            // 
            // dtChegada
            // 
            dtChegada.HeaderText = "Chegada";
            dtChegada.Name = "dtChegada";
            dtChegada.ReadOnly = true;
            dtChegada.Width = 75;
            // 
            // totalnota
            // 
            totalnota.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            totalnota.HeaderText = "Valor Total Nota";
            totalnota.Name = "totalnota";
            totalnota.ReadOnly = true;
            // 
            // frmConsultaCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgNotas);
            Name = "frmConsultaCompras";
            Text = "frmConsultaCompras";
            Controls.SetChildIndex(txtChave, 0);
            Controls.SetChildIndex(btnSair, 0);
            Controls.SetChildIndex(btnExcluir, 0);
            Controls.SetChildIndex(btnAlterar, 0);
            Controls.SetChildIndex(btnIncluir, 0);
            Controls.SetChildIndex(dgNotas, 0);
            ((System.ComponentModel.ISupportInitialize)dgNotas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgNotas;
        private DataGridViewTextBoxColumn nota;
        private DataGridViewTextBoxColumn serieNota;
        private DataGridViewTextBoxColumn modeloNota;
        private DataGridViewTextBoxColumn emit;
        private DataGridViewTextBoxColumn dtEmissao;
        private DataGridViewTextBoxColumn dtChegada;
        private DataGridViewTextBoxColumn totalnota;
    }
}