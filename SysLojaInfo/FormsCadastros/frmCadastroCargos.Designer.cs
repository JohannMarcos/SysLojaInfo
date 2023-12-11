namespace SysLojaInfo
{
    partial class frmCadastroCargos
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
            lblCargo = new Label();
            txtCargo = new TextBox();
            cbExterno = new CheckBox();
            SuspendLayout();
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(147, 25);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(39, 15);
            lblCargo.TabIndex = 10;
            lblCargo.Text = "Cargo";
            // 
            // txtCargo
            // 
            txtCargo.CharacterCasing = CharacterCasing.Upper;
            txtCargo.Location = new Point(144, 43);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(209, 23);
            txtCargo.TabIndex = 11;
            // 
            // cbExterno
            // 
            cbExterno.AutoSize = true;
            cbExterno.Location = new Point(374, 45);
            cbExterno.Name = "cbExterno";
            cbExterno.Size = new Size(155, 19);
            cbExterno.TabIndex = 42;
            cbExterno.Text = "Exerce Atividade Externa";
            cbExterno.UseVisualStyleBackColor = true;
            // 
            // frmCadastroCargos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbExterno);
            Controls.Add(txtCargo);
            Controls.Add(lblCargo);
            Name = "frmCadastroCargos";
            Text = "Cadastro de Cargos";
            Load += Form1_Load;
            Controls.SetChildIndex(txtCodigo, 0);
            Controls.SetChildIndex(txtDatCad, 0);
            Controls.SetChildIndex(txtDatUltAlt, 0);
            Controls.SetChildIndex(txtQuemAlt, 0);
            Controls.SetChildIndex(btnSalvar, 0);
            Controls.SetChildIndex(lblCargo, 0);
            Controls.SetChildIndex(txtCargo, 0);
            Controls.SetChildIndex(cbExterno, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCargo;
        private TextBox txtCargo;
        private CheckBox cbExterno;
    }
}