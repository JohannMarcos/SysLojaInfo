namespace SysLojaInfo
{
    partial class frmCadastroCompras
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            tabControl1 = new TabControl();
            tbProd = new TabPage();
            dataGridView1 = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            produto = new DataGridViewTextBoxColumn();
            umedida = new DataGridViewTextBoxColumn();
            quant = new DataGridViewTextBoxColumn();
            preco = new DataGridViewTextBoxColumn();
            desconto = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            label8 = new Label();
            textBox12 = new TextBox();
            label7 = new Label();
            textBox11 = new TextBox();
            label6 = new Label();
            textBox10 = new TextBox();
            textBox9 = new TextBox();
            button4 = new Button();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label5 = new Label();
            button3 = new Button();
            button2 = new Button();
            tbPag = new TabPage();
            label9 = new Label();
            textBox13 = new TextBox();
            label10 = new Label();
            textBox14 = new TextBox();
            label11 = new Label();
            textBox15 = new TextBox();
            label12 = new Label();
            textBox16 = new TextBox();
            label13 = new Label();
            textBox17 = new TextBox();
            label14 = new Label();
            textBox18 = new TextBox();
            label15 = new Label();
            richTextBox1 = new RichTextBox();
            tabControl1.SuspendLayout();
            tbProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(876, 654);
            // 
            // txtDatCad
            // 
            txtDatCad.Location = new Point(29, 655);
            // 
            // txtDatUltAlt
            // 
            txtDatUltAlt.Location = new Point(147, 655);
            // 
            // txtQuemAlt
            // 
            txtQuemAlt.Location = new Point(291, 655);
            // 
            // lblDatCad
            // 
            lblDatCad.Location = new Point(29, 636);
            // 
            // btnSair
            // 
            btnSair.Location = new Point(967, 654);
            // 
            // lblQuemAlt
            // 
            lblQuemAlt.Location = new Point(291, 637);
            // 
            // lblDatUltAlt
            // 
            lblDatUltAlt.Location = new Point(147, 637);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 25);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 10;
            label1.Text = "Número da Nota";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(147, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(253, 43);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(40, 23);
            textBox2.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 25);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 12;
            label2.Text = "Série";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(299, 43);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(299, 25);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 14;
            label3.Text = "Modelo";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(29, 94);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(54, 23);
            textBox4.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 76);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 16;
            label4.Text = "Emitente";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(89, 94);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(158, 23);
            textBox5.TabIndex = 18;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(253, 94);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(260, 23);
            textBox6.TabIndex = 19;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(519, 93);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 20;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbProd);
            tabControl1.Controls.Add(tbPag);
            tabControl1.Location = new Point(29, 137);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(894, 356);
            tabControl1.TabIndex = 21;
            // 
            // tbProd
            // 
            tbProd.Controls.Add(dataGridView1);
            tbProd.Controls.Add(label8);
            tbProd.Controls.Add(textBox12);
            tbProd.Controls.Add(label7);
            tbProd.Controls.Add(textBox11);
            tbProd.Controls.Add(label6);
            tbProd.Controls.Add(textBox10);
            tbProd.Controls.Add(textBox9);
            tbProd.Controls.Add(button4);
            tbProd.Controls.Add(textBox7);
            tbProd.Controls.Add(textBox8);
            tbProd.Controls.Add(label5);
            tbProd.Controls.Add(button3);
            tbProd.Controls.Add(button2);
            tbProd.Location = new Point(4, 24);
            tbProd.Name = "tbProd";
            tbProd.Padding = new Padding(3);
            tbProd.Size = new Size(886, 328);
            tbProd.TabIndex = 0;
            tbProd.Text = "Produtos Entrada";
            tbProd.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { codigo, produto, umedida, quant, preco, desconto, total });
            dataGridView1.Location = new Point(15, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(853, 210);
            dataGridView1.TabIndex = 32;
            // 
            // codigo
            // 
            codigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            codigo.HeaderText = "Código";
            codigo.Name = "codigo";
            codigo.ReadOnly = true;
            codigo.Width = 50;
            // 
            // produto
            // 
            produto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            produto.HeaderText = "Produto";
            produto.Name = "produto";
            produto.ReadOnly = true;
            // 
            // umedida
            // 
            umedida.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            umedida.HeaderText = "Unid. Medida";
            umedida.Name = "umedida";
            umedida.ReadOnly = true;
            umedida.Width = 50;
            // 
            // quant
            // 
            quant.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            quant.HeaderText = "Qtd";
            quant.Name = "quant";
            quant.ReadOnly = true;
            quant.Width = 50;
            // 
            // preco
            // 
            preco.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            preco.HeaderText = "Preço";
            preco.Name = "preco";
            preco.ReadOnly = true;
            // 
            // desconto
            // 
            desconto.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            desconto.HeaderText = "Desconto";
            desconto.Name = "desconto";
            desconto.ReadOnly = true;
            // 
            // total
            // 
            total.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            total.HeaderText = "Total ";
            total.Name = "total";
            total.ReadOnly = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(772, 11);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 31;
            label8.Text = "Quantidade";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(772, 29);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(96, 23);
            textBox12.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(670, 12);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 29;
            label7.Text = "Desconto";
            label7.Click += label7_Click;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(670, 30);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(96, 23);
            textBox11.TabIndex = 28;
            textBox11.TextChanged += textBox11_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(568, 12);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 27;
            label6.Text = "Preço Unitário";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(568, 30);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(96, 23);
            textBox10.TabIndex = 26;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(99, 30);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(92, 23);
            textBox9.TabIndex = 25;
            // 
            // button4
            // 
            button4.Location = new Point(424, 29);
            button4.Name = "button4";
            button4.Size = new Size(115, 23);
            button4.TabIndex = 24;
            button4.Text = "Buscar Produto";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(197, 30);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(212, 23);
            textBox7.TabIndex = 23;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(15, 29);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(78, 23);
            textBox8.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 11);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 21;
            label5.Text = "Produto";
            // 
            // button3
            // 
            button3.Location = new Point(160, 71);
            button3.Name = "button3";
            button3.Size = new Size(128, 23);
            button3.TabIndex = 1;
            button3.Text = "Remover Produto";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(15, 71);
            button2.Name = "button2";
            button2.Size = new Size(128, 23);
            button2.TabIndex = 0;
            button2.Text = "Adicionar Produto";
            button2.UseVisualStyleBackColor = true;
            // 
            // tbPag
            // 
            tbPag.Location = new Point(4, 24);
            tbPag.Name = "tbPag";
            tbPag.Padding = new Padding(3);
            tbPag.Size = new Size(886, 328);
            tbPag.TabIndex = 1;
            tbPag.Text = "Pagamento";
            tbPag.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(29, 503);
            label9.Name = "label9";
            label9.Size = new Size(65, 15);
            label9.TabIndex = 29;
            label9.Text = "Valor Bruto";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(29, 521);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(147, 23);
            textBox13.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(193, 503);
            label10.Name = "label10";
            label10.Size = new Size(62, 15);
            label10.TabIndex = 31;
            label10.Text = "Descontos";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(193, 521);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(147, 23);
            textBox14.TabIndex = 30;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(357, 503);
            label11.Name = "label11";
            label11.Size = new Size(33, 15);
            label11.TabIndex = 33;
            label11.Text = "Frete";
            // 
            // textBox15
            // 
            textBox15.Location = new Point(357, 521);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(147, 23);
            textBox15.TabIndex = 32;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(519, 503);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 35;
            label12.Text = "Seguro";
            // 
            // textBox16
            // 
            textBox16.Location = new Point(519, 521);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(147, 23);
            textBox16.TabIndex = 34;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(681, 503);
            label13.Name = "label13";
            label13.Size = new Size(43, 15);
            label13.TabIndex = 37;
            label13.Text = "Outros";
            // 
            // textBox17
            // 
            textBox17.Location = new Point(681, 521);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(147, 23);
            textBox17.TabIndex = 36;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(895, 503);
            label14.Name = "label14";
            label14.Size = new Size(64, 15);
            label14.TabIndex = 39;
            label14.Text = "Valor Total ";
            // 
            // textBox18
            // 
            textBox18.Location = new Point(895, 521);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(147, 23);
            textBox18.TabIndex = 38;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(29, 558);
            label15.Name = "label15";
            label15.Size = new Size(98, 15);
            label15.TabIndex = 40;
            label15.Text = "Dados Adicionais";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(29, 576);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1013, 57);
            richTextBox1.TabIndex = 41;
            richTextBox1.Text = "";
            // 
            // frmCadastroCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 693);
            Controls.Add(richTextBox1);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(textBox18);
            Controls.Add(label13);
            Controls.Add(textBox17);
            Controls.Add(label12);
            Controls.Add(textBox16);
            Controls.Add(label11);
            Controls.Add(textBox15);
            Controls.Add(label10);
            Controls.Add(textBox14);
            Controls.Add(label9);
            Controls.Add(textBox13);
            Controls.Add(tabControl1);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "frmCadastroCompras";
            Text = "frmCadastroCompras";
            Load += frmCadastroCompras_Load;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(textBox1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(textBox2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(textBox3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(textBox4, 0);
            Controls.SetChildIndex(textBox5, 0);
            Controls.SetChildIndex(textBox6, 0);
            Controls.SetChildIndex(button1, 0);
            Controls.SetChildIndex(lblCodigo, 0);
            Controls.SetChildIndex(txtCodigo, 0);
            Controls.SetChildIndex(txtDatCad, 0);
            Controls.SetChildIndex(txtDatUltAlt, 0);
            Controls.SetChildIndex(txtQuemAlt, 0);
            Controls.SetChildIndex(lblDatCad, 0);
            Controls.SetChildIndex(lblDatUltAlt, 0);
            Controls.SetChildIndex(lblQuemAlt, 0);
            Controls.SetChildIndex(btnSalvar, 0);
            Controls.SetChildIndex(btnSair, 0);
            Controls.SetChildIndex(tabControl1, 0);
            Controls.SetChildIndex(textBox13, 0);
            Controls.SetChildIndex(label9, 0);
            Controls.SetChildIndex(textBox14, 0);
            Controls.SetChildIndex(label10, 0);
            Controls.SetChildIndex(textBox15, 0);
            Controls.SetChildIndex(label11, 0);
            Controls.SetChildIndex(textBox16, 0);
            Controls.SetChildIndex(label12, 0);
            Controls.SetChildIndex(textBox17, 0);
            Controls.SetChildIndex(label13, 0);
            Controls.SetChildIndex(textBox18, 0);
            Controls.SetChildIndex(label14, 0);
            Controls.SetChildIndex(label15, 0);
            Controls.SetChildIndex(richTextBox1, 0);
            tabControl1.ResumeLayout(false);
            tbProd.ResumeLayout(false);
            tbProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
        private TabControl tabControl1;
        private TabPage tbProd;
        private TabPage tbPag;
        private Button button3;
        private Button button2;
        private Button button4;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label5;
        private TextBox textBox9;
        private Label label7;
        private TextBox textBox11;
        private Label label6;
        private TextBox textBox10;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn produto;
        private DataGridViewTextBoxColumn umedida;
        private DataGridViewTextBoxColumn quant;
        private DataGridViewTextBoxColumn preco;
        private DataGridViewTextBoxColumn desconto;
        private DataGridViewTextBoxColumn total;
        private Label label8;
        private TextBox textBox12;
        private Label label9;
        private TextBox textBox13;
        private Label label10;
        private TextBox textBox14;
        private Label label11;
        private TextBox textBox15;
        private Label label12;
        private TextBox textBox16;
        private Label label13;
        private TextBox textBox17;
        private Label label14;
        private TextBox textBox18;
        private Label label15;
        private RichTextBox richTextBox1;
    }
}