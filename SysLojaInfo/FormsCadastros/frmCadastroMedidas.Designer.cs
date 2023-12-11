namespace SysLojaInfo
{
    partial class frmCadastroMedidas
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
            lblDesc = new Label();
            txtDesc = new TextBox();
            checkAtivo = new CheckBox();
            SuspendLayout();
            // 
            // txtDatCad
            // 
            txtDatCad.Visible = false;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(152, 25);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(58, 15);
            lblDesc.TabIndex = 10;
            lblDesc.Text = "Descrição";
            // 
            // txtDesc
            // 
            txtDesc.Enabled = false;
            txtDesc.Location = new Point(152, 43);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(310, 23);
            txtDesc.TabIndex = 11;
            // 
            // checkAtivo
            // 
            checkAtivo.AutoSize = true;
            checkAtivo.Location = new Point(480, 45);
            checkAtivo.Name = "checkAtivo";
            checkAtivo.Size = new Size(54, 19);
            checkAtivo.TabIndex = 12;
            checkAtivo.Text = "Ativo";
            checkAtivo.UseVisualStyleBackColor = true;
            // 
            // frmCadastroMedidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkAtivo);
            Controls.Add(txtDesc);
            Controls.Add(lblDesc);
            Name = "frmCadastroMedidas";
            Text = "frmCadastroMedidas";
            Controls.SetChildIndex(lblCodigo, 0);
            Controls.SetChildIndex(lblDatCad, 0);
            Controls.SetChildIndex(txtCodigo, 0);
            Controls.SetChildIndex(txtDatCad, 0);
            Controls.SetChildIndex(txtDatUltAlt, 0);
            Controls.SetChildIndex(txtQuemAlt, 0);
            Controls.SetChildIndex(btnSalvar, 0);
            Controls.SetChildIndex(lblDesc, 0);
            Controls.SetChildIndex(txtDesc, 0);
            Controls.SetChildIndex(checkAtivo, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDesc;
        private TextBox txtDesc;
        private CheckBox checkAtivo;
    }
}