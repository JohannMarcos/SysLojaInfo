namespace SysLojaInfo
{
    partial class frmCadastroFormaPag
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
            lblForma = new Label();
            txtFormaPag = new TextBox();
            SuspendLayout();
            // 
            // lblForma
            // 
            lblForma.AutoSize = true;
            lblForma.Location = new Point(147, 25);
            lblForma.Name = "lblForma";
            lblForma.Size = new Size(121, 15);
            lblForma.TabIndex = 10;
            lblForma.Text = "Forma de Pagamento";
            // 
            // txtFormaPag
            // 
            txtFormaPag.Location = new Point(147, 43);
            txtFormaPag.Name = "txtFormaPag";
            txtFormaPag.Size = new Size(253, 23);
            txtFormaPag.TabIndex = 11;
            // 
            // frmCadastroFormaPag
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtFormaPag);
            Controls.Add(lblForma);
            Name = "frmCadastroFormaPag";
            Text = "Cadastro de Formas de Pagamento";
            Load += Form1_Load;
            Controls.SetChildIndex(lblForma, 0);
            Controls.SetChildIndex(txtFormaPag, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblForma;
        private TextBox txtFormaPag;
    }
}