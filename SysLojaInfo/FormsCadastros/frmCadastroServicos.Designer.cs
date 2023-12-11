namespace SysLojaInfo
{
    partial class frmCadastroServicos
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
            lblServico = new Label();
            lblPrecoServ = new Label();
            txtServico = new TextBox();
            txtPrecoServ = new TextBox();
            SuspendLayout();
            // 
            // lblServico
            // 
            lblServico.AutoSize = true;
            lblServico.Location = new Point(147, 25);
            lblServico.Name = "lblServico";
            lblServico.Size = new Size(45, 15);
            lblServico.TabIndex = 10;
            lblServico.Text = "Serviço";
            // 
            // lblPrecoServ
            // 
            lblPrecoServ.AutoSize = true;
            lblPrecoServ.Location = new Point(29, 85);
            lblPrecoServ.Name = "lblPrecoServ";
            lblPrecoServ.Size = new Size(94, 15);
            lblPrecoServ.TabIndex = 11;
            lblPrecoServ.Text = "Valor  do Serviço";
            // 
            // txtServico
            // 
            txtServico.Location = new Point(147, 43);
            txtServico.Name = "txtServico";
            txtServico.Size = new Size(541, 23);
            txtServico.TabIndex = 12;
            // 
            // txtPrecoServ
            // 
            txtPrecoServ.Location = new Point(29, 103);
            txtPrecoServ.Name = "txtPrecoServ";
            txtPrecoServ.Size = new Size(109, 23);
            txtPrecoServ.TabIndex = 13;
            // 
            // frmCadastroServicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPrecoServ);
            Controls.Add(txtServico);
            Controls.Add(lblPrecoServ);
            Controls.Add(lblServico);
            Name = "frmCadastroServicos";
            Text = "Cadastro de Serviços";
            Load += Form1_Load;
            Controls.SetChildIndex(lblServico, 0);
            Controls.SetChildIndex(lblPrecoServ, 0);
            Controls.SetChildIndex(txtServico, 0);
            Controls.SetChildIndex(txtPrecoServ, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblServico;
        private Label lblPrecoServ;
        private TextBox txtServico;
        private TextBox txtPrecoServ;
    }
}