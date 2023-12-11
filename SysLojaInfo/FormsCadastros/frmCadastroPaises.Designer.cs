namespace SysLojaInfo
{
    partial class frmCadastroPaises
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
            lblPais = new Label();
            txtPais = new TextBox();
            txtDDI = new TextBox();
            lblDDI = new Label();
            txtSigla = new TextBox();
            lblSigla = new Label();
            SuspendLayout();
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Location = new Point(161, 25);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(28, 15);
            lblPais.TabIndex = 10;
            lblPais.Text = "País";
            // 
            // txtPais
            // 
            txtPais.CharacterCasing = CharacterCasing.Upper;
            txtPais.Location = new Point(161, 43);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(228, 23);
            txtPais.TabIndex = 11;
            txtPais.TextChanged += txtPais_TextChanged;
            // 
            // txtDDI
            // 
            txtDDI.CharacterCasing = CharacterCasing.Upper;
            txtDDI.Location = new Point(408, 43);
            txtDDI.MaxLength = 3;
            txtDDI.Name = "txtDDI";
            txtDDI.Size = new Size(109, 23);
            txtDDI.TabIndex = 12;
            // 
            // lblDDI
            // 
            lblDDI.AutoSize = true;
            lblDDI.Location = new Point(408, 25);
            lblDDI.Name = "lblDDI";
            lblDDI.Size = new Size(26, 15);
            lblDDI.TabIndex = 13;
            lblDDI.Text = "DDI";
            // 
            // txtSigla
            // 
            txtSigla.CharacterCasing = CharacterCasing.Upper;
            txtSigla.Location = new Point(539, 43);
            txtSigla.MaxLength = 3;
            txtSigla.Name = "txtSigla";
            txtSigla.Size = new Size(93, 23);
            txtSigla.TabIndex = 14;
            // 
            // lblSigla
            // 
            lblSigla.AutoSize = true;
            lblSigla.Location = new Point(539, 25);
            lblSigla.Name = "lblSigla";
            lblSigla.Size = new Size(32, 15);
            lblSigla.TabIndex = 15;
            lblSigla.Text = "Sigla";
            // 
            // frmCadastroPaises
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSigla);
            Controls.Add(txtSigla);
            Controls.Add(lblDDI);
            Controls.Add(txtDDI);
            Controls.Add(txtPais);
            Controls.Add(lblPais);
            Margin = new Padding(3, 5, 3, 5);
            Name = "frmCadastroPaises";
            Text = "Consulta de Países";
            Load += Form1_Load;
            Controls.SetChildIndex(txtDatCad, 0);
            Controls.SetChildIndex(txtDatUltAlt, 0);
            Controls.SetChildIndex(txtQuemAlt, 0);
            Controls.SetChildIndex(txtCodigo, 0);
            Controls.SetChildIndex(btnSalvar, 0);
            Controls.SetChildIndex(lblPais, 0);
            Controls.SetChildIndex(txtPais, 0);
            Controls.SetChildIndex(txtDDI, 0);
            Controls.SetChildIndex(lblDDI, 0);
            Controls.SetChildIndex(txtSigla, 0);
            Controls.SetChildIndex(lblSigla, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPais;
        private TextBox txtPais;
        private TextBox txtDDI;
        private Label lblDDI;
        private TextBox txtSigla;
        private Label lblSigla;
    }
}