namespace SysLojaInfo
{
    partial class frmConsultaCargos
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
            dgCargos = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            cargo = new DataGridViewTextBoxColumn();
            externo = new DataGridViewTextBoxColumn();
            datcad = new DataGridViewTextBoxColumn();
            datalt = new DataGridViewTextBoxColumn();
            iduser = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgCargos).BeginInit();
            SuspendLayout();
            // 
            // dgCargos
            // 
            dgCargos.AllowUserToAddRows = false;
            dgCargos.AllowUserToDeleteRows = false;
            dgCargos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCargos.Columns.AddRange(new DataGridViewColumn[] { codigo, cargo, externo, datcad, datalt, iduser });
            dgCargos.Location = new Point(12, 65);
            dgCargos.Name = "dgCargos";
            dgCargos.RowHeadersVisible = false;
            dgCargos.RowTemplate.Height = 25;
            dgCargos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgCargos.Size = new Size(776, 341);
            dgCargos.TabIndex = 7;
            // 
            // codigo
            // 
            codigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            codigo.HeaderText = "Código";
            codigo.Name = "codigo";
            codigo.ReadOnly = true;
            codigo.Width = 50;
            // 
            // cargo
            // 
            cargo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cargo.HeaderText = "Cargo";
            cargo.Name = "cargo";
            cargo.ReadOnly = true;
            // 
            // externo
            // 
            externo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            externo.HeaderText = "Externo";
            externo.Name = "externo";
            externo.ReadOnly = true;
            externo.Width = 50;
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
            // frmConsultaCargos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgCargos);
            Name = "frmConsultaCargos";
            Text = "Consulta de Cargos";
            Activated += frmConsultaCargos_Activated;
            Load += Form1_Load;
            Controls.SetChildIndex(txtChave, 0);
            Controls.SetChildIndex(btnSair, 0);
            Controls.SetChildIndex(dgCargos, 0);
            ((System.ComponentModel.ISupportInitialize)dgCargos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgCargos;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn cargo;
        private DataGridViewTextBoxColumn externo;
        private DataGridViewTextBoxColumn datcad;
        private DataGridViewTextBoxColumn datalt;
        private DataGridViewTextBoxColumn iduser;
    }
}