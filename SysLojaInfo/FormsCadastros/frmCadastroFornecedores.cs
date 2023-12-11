using MySqlX.XDevAPI;
using SysLojaInfo.Classes;
using SysLojaInfo.Ctrls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysLojaInfo
{
    public partial class frmCadastroFornecedores : SysLojaInfo.frmCadastroPessoas
    {
        private Fornecedores oFornecedor;

        public frmCadastroFornecedores()
        {
            InitializeComponent();
            oFornecedor = new Fornecedores();
        }

        public override void Salvar()
        {
            base.Salvar();
            ctrlFornecedores aCtrl = new ctrlFornecedores();
            oFornecedor.nome = txtNome.Text;
            if (rbFisica.Checked)
            {
                oFornecedor.natPess = "PF";
                oFornecedor.rg = txtRg.Text;
            }
            else if (rbJuridica.Checked)
            {
                oFornecedor.natPess = "PJ";
                oFornecedor.rg = "";
            }
            oFornecedor.cpfCnpj = txtCpfCnpj.Text;
            oFornecedor.logr = txtLogr.Text;
            oFornecedor.numero = Convert.ToInt32(txtNumero.Text);
            oFornecedor.bairro = txtBairro.Text;
            oFornecedor.aCidade.Codigo = Convert.ToInt32(txtCodCidade.Text);
            oFornecedor.telRes = txtTelRes.Text;
            oFornecedor.telCel = txtTelCel.Text;
            oFornecedor.email = txtEmail.Text;
            oFornecedor.aCond.Codigo = Convert.ToInt32(txtCodCond.Text);

            if (base.btnSalvar.Text is "Salvar")
            {
                aCtrl.salvar(oFornecedor);
            }
            else if (base.btnSalvar.Text is "Alterar")
            {
                aCtrl.editar(oFornecedor);
            }
            else if (base.btnSalvar.Text is "Excluir")
            {
                aCtrl.deletar(oFornecedor);
            };
            Close();

        }

        public void CarregaCampos(object obj)
        {
            oFornecedor = (Fornecedores)obj;
            this.txtCodigo.Text = oFornecedor.Codigo.ToString();
            this.txtNome.Text = oFornecedor.nome;
            if (oFornecedor.natPess == "PF")
            {
                rbFisica.Checked = true;
            }
            else if (oFornecedor.natPess == "PJ")
            {
                rbJuridica.Checked = true;
            }
            this.txtCpfCnpj.Text = oFornecedor.cpfCnpj;
            this.txtRg.Text = oFornecedor.rg;
            this.txtLogr.Text = oFornecedor.logr;
            this.txtNumero.Text = oFornecedor.numero.ToString();
            this.txtBairro.Text = oFornecedor.bairro;
            this.txtCodCidade.Text = oFornecedor.aCidade.Codigo.ToString();
            this.txtCidade.Text = oFornecedor.aCidade.cidade;
            this.txtTelRes.Text = oFornecedor.telRes;
            this.txtTelCel.Text = oFornecedor.telCel;
            this.txtEmail.Text = oFornecedor.email;
            this.txtDatCad.Text = oFornecedor.DatCad.ToString();
            this.txtDatUltAlt.Text = oFornecedor.DatUltAlt.ToString();
            this.txtQuemAlt.Text = oFornecedor.QuemAlter.ToString();
            this.txtCodCond.Text = oFornecedor.aCond.Codigo.ToString();
            this.txtCond.Text = oFornecedor.aCond.condicao.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public override void BloqTxt()
        {
            base.BloqTxt();
            this.btnProcuraCond.Enabled = false;
        }

        public override void DesbloqTxt()
        {
            base.DesbloqTxt();
            this.lblCodCond.Enabled = true;
            this.lblCond.Enabled = true;
            this.btnProcuraCond.Enabled = true;
        }

        private void btnProcuraCidade_Click_1(object sender, EventArgs e)
        {
            frmConsultaCidades tela = new frmConsultaCidades();
            tela.botao_Selecionar();
            tela.ePai = true;
            tela.ShowDialog();

            Cidades mCidade = new Cidades();

            mCidade = (Cidades)tela.pegaCidadeReg();

            txtCodCidade.Text = mCidade.Codigo.ToString();
            txtCidade.Text = mCidade.cidade;
            tela.Close();
        }

        private void btnProcuraCond_Click(object sender, EventArgs e)
        {
            frmConsultaCondPag tela = new frmConsultaCondPag();
            tela.botao_Selecionar();
            tela.ePai = true;
            tela.ShowDialog();

            CondicoesPag mCond = new CondicoesPag();

            mCond = (CondicoesPag)tela.pegaCondReg();

            txtCodCond.Text = mCond.Codigo.ToString();
            txtCond.Text = mCond.condicao;
            tela.Close();
        }

        private void rbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            lblNomeRazao.Text = "Razão Social:";
            lblCpfCnpj.Text = "CNPJ:";
            lblRg.Visible = false;
            txtRg.Visible = false;
            if (btnSalvar.Text != "Excluir")
            {
                this.DesbloqTxt();
            }
        }

        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {
            lblNomeRazao.Text = "Nome:";
            lblCpfCnpj.Text = "CPF:";
            lblRg.Visible = true;
            txtRg.Visible = true;
            if (btnSalvar.Text != "Excluir")
            {
                this.DesbloqTxt();
            }
        }

        public void habilitaSalvar()
        {
            btnSalvar.Enabled = false;

            if (txtNome.Text.Length > 0 && txtCpfCnpj.Text.Length > 0 && txtCodCidade.Text.Length > 0 && txtCidade.Text.Length > 0 && txtLogr.Text.Length > 0 && txtNumero.Text.Length > 0 && txtBairro.Text.Length > 0 && txtTelRes.Text.Length > 0 && txtTelCel.Text.Length > 0 && txtEmail.Text.Length > 0 && txtCodCond.Text.Length > 0 && txtCond.Text.Length > 0)
            {
                btnSalvar.Enabled = true;
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            this.habilitaSalvar();
        }

        private void txtCpfCnpj_TextChanged(object sender, EventArgs e)
        {
            if (rbFisica.Checked)
            {
                // Remove caracteres não numéricos do texto do CPF
                string cpfNumerico = new string(txtCpfCnpj.Text.Where(char.IsDigit).ToArray());

                // Aplica a máscara de CPF (XXX.XXX.XXX-XX)
                if (cpfNumerico.Length >= 3)
                {
                    cpfNumerico = cpfNumerico.Insert(3, ".");
                }
                if (cpfNumerico.Length >= 7)
                {
                    cpfNumerico = cpfNumerico.Insert(7, ".");
                }
                if (cpfNumerico.Length >= 11)
                {
                    cpfNumerico = cpfNumerico.Insert(11, "-");
                }

                // Atualiza o texto do TextBox com a máscara aplicada
                txtCpfCnpj.Text = cpfNumerico;
                txtCpfCnpj.SelectionStart = txtCpfCnpj.Text.Length;

                /*if (txtCpfCnpj.Text.Length >= 14 && txtRg.Text.Length >= 12)
                {
                    btnProcuraCidade.Enabled = true;
                }
                else
                {
                    btnProcuraCidade.Enabled = false;
                }*/
            }
            else if (rbJuridica.Checked)
            {
                string cnpjNumerico = new string(txtCpfCnpj.Text.Where(char.IsDigit).ToArray());

                // Aplica a máscara de CNPJ (XX.XXX.XXX/XXXX-XX)
                if (cnpjNumerico.Length >= 2)
                {
                    cnpjNumerico = cnpjNumerico.Insert(2, ".");
                }
                if (cnpjNumerico.Length >= 6)
                {
                    cnpjNumerico = cnpjNumerico.Insert(6, ".");
                }
                if (cnpjNumerico.Length >= 10)
                {
                    cnpjNumerico = cnpjNumerico.Insert(10, "/");
                }
                if (cnpjNumerico.Length >= 15)
                {
                    cnpjNumerico = cnpjNumerico.Insert(15, "-");
                }

                // Atualiza o texto do TextBox com a máscara aplicada
                txtCpfCnpj.Text = cnpjNumerico;
                txtCpfCnpj.SelectionStart = txtCpfCnpj.Text.Length;
                /*if (txtCpfCnpj.Text.Length >= 18)
                {
                    btnProcuraCidade.Enabled = true;
                }
                else
                {
                    btnProcuraCidade.Enabled = false;
                }*/
            }
            this.habilitaSalvar();
        }

        private void txtRg_TextChanged(object sender, EventArgs e)
        {
            if (rbFisica.Checked)
            {
                // Remove caracteres não numéricos do texto do RG
                string rgNumerico = new string(txtRg.Text.Where(char.IsDigit).ToArray());

                // Aplica a máscara de RG(XX.XXX.XXX-X)
                if (rgNumerico.Length >= 2)
                {
                    rgNumerico = rgNumerico.Insert(2, ".");
                }
                if (rgNumerico.Length >= 6)
                {
                    rgNumerico = rgNumerico.Insert(6, ".");
                }
                if (rgNumerico.Length >= 10)
                {
                    rgNumerico = rgNumerico.Insert(10, "-");
                }

                // Atualiza o texto do TextBox com a máscara aplicada
                txtRg.Text = rgNumerico;
                txtRg.SelectionStart = txtRg.Text.Length;

                this.habilitaSalvar();
            }
        }

        private void txtCodCidade_TextChanged(object sender, EventArgs e)
        {
            this.habilitaSalvar();
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
            this.habilitaSalvar();
        }

        private void txtLogr_TextChanged(object sender, EventArgs e)
        {
            this.habilitaSalvar();
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            this.habilitaSalvar();
        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {
            this.habilitaSalvar();
        }

        private void txtTelRes_TextChanged(object sender, EventArgs e)
        {
            this.habilitaSalvar();
        }

        private void txtTelCel_TextChanged(object sender, EventArgs e)
        {
            this.habilitaSalvar();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            this.habilitaSalvar();
        }

        private void txtCodCond_TextChanged(object sender, EventArgs e)
        {
            this.habilitaSalvar();
        }

        private void txtCond_TextChanged(object sender, EventArgs e)
        {
            this.habilitaSalvar();
        }

        private void txtTelRes_Leave(object sender, EventArgs e)
        {
            if (ValidarNumeroTelefoneBrasileiro(txtTelRes.Text))
            {

            }
            else
            {
                MessageBox.Show("O número de telefone não é válido.");
                txtTelRes.Focus();
            }
        }

        private void txtTelCel_Leave(object sender, EventArgs e)
        {
            if (ValidarNumeroTelefoneBrasileiro(txtTelCel.Text))
            {

            }
            else
            {
                MessageBox.Show("O número de telefone não é válido.");
                txtTelCel.Focus();
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (ValidarEmail(txtEmail.Text))
            { 

            }
            else
            {
                MessageBox.Show("O endereço de e-mail não é válido.");
            }
        }
    }
}
