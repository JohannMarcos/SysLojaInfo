using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysLojaInfo.Classes;
using SysLojaInfo.Ctrls;

namespace SysLojaInfo
{
    public partial class frmCadastroClientes : SysLojaInfo.frmCadastroPessoas
    {
        private Clientes oCliente;
        public frmCadastroClientes()
        {
            InitializeComponent();
            oCliente = new Clientes();
        }

        public override void Salvar()
        {
            base.Salvar();
            ctrlClientes aCtrl = new ctrlClientes();
            oCliente.nome = txtNome.Text;
            if (rbFisica.Checked)
            {
                oCliente.natPess = "PF";
                oCliente.rg = txtRg.Text;
            }
            else if (rbJuridica.Checked)
            {
                oCliente.natPess = "PJ";
                oCliente.rg = "";
            }
            oCliente.cpfCnpj = txtCpfCnpj.Text;
            oCliente.limCred = Convert.ToDouble(txtLimite.Text);
            oCliente.logr = txtLogr.Text;
            oCliente.numero = Convert.ToInt32(txtNumero.Text);
            oCliente.bairro = txtBairro.Text;
            oCliente.aCidade.Codigo = Convert.ToInt32(txtCodCidade.Text);
            oCliente.telRes = txtTelRes.Text;
            oCliente.telCel = txtTelCel.Text;
            oCliente.email = txtEmail.Text;
            oCliente.aCond.Codigo = Convert.ToInt32(txtCodCond.Text);

            if (base.btnSalvar.Text is "Salvar")
            {
                aCtrl.salvar(oCliente);
            }
            else if (base.btnSalvar.Text is "Alterar")
            {
                aCtrl.editar(oCliente);
            }
            else if (base.btnSalvar.Text is "Excluir")
            {
                aCtrl.deletar(oCliente);
            };
            Close();

        }

        public void CarregaCampos(object obj)
        {
            oCliente = (Clientes)obj;
            this.txtCodigo.Text = oCliente.Codigo.ToString();
            this.txtNome.Text = oCliente.nome;
            if (oCliente.natPess == "PF")
            {
                rbFisica.Checked = true;
            }
            else if (oCliente.natPess == "PJ")
            {
                rbJuridica.Checked = true;
            }
            this.txtCpfCnpj.Text = oCliente.cpfCnpj;
            this.txtRg.Text = oCliente.rg;
            this.txtLimite.Text = oCliente.limCred.ToString();
            this.txtLogr.Text = oCliente.logr;
            this.txtNumero.Text = oCliente.numero.ToString();
            this.txtBairro.Text = oCliente.bairro;
            this.txtCodCidade.Text = oCliente.aCidade.Codigo.ToString();
            this.txtCidade.Text = oCliente.aCidade.cidade;
            this.txtTelRes.Text = oCliente.telRes;
            this.txtTelCel.Text = oCliente.telCel;
            this.txtEmail.Text = oCliente.email;
            this.txtDatCad.Text = oCliente.DatCad.ToString();
            this.txtDatUltAlt.Text = oCliente.DatUltAlt.ToString();
            this.txtQuemAlt.Text = oCliente.QuemAlter.ToString();
            this.txtCodCond.Text = oCliente.aCond.Codigo.ToString();
            this.txtCond.Text = oCliente.aCond.condicao.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public override void BloqTxt()
        {
            base.BloqTxt();
            this.txtLimite.Enabled = false;
            this.btnPesqCond.Enabled = false;
        }

        public override void DesbloqTxt()
        {
            base.DesbloqTxt();
            this.txtLimite.Enabled = true;
            this.lblLimite.Enabled = true;
            this.lblCodCond.Enabled = true;
            this.lblCond.Enabled = true;
            this.btnPesqCond.Enabled = true;
        }


        public override void btnProcuraCidade_Click(object sender, EventArgs e)
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

        private void btnPesqCond_Click(object sender, EventArgs e)
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

        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {
            /*txtNome.Enabled = true;
            lblNomeRazao.Enabled = true;*/
            lblNomeRazao.Text = "Nome:";
            lblCpfCnpj.Text = "CPF:";
            lblRg.Visible = true;
            txtRg.Visible = true;
            if (btnSalvar.Text != "Excluir")
            {
                this.DesbloqTxt();
            }
            //gpTipoPessoa.Enabled = false;
        }

        private void rbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            /*txtNome.Enabled = true;
            lblNomeRazao.Enabled = true;*/
            lblNomeRazao.Text = "Razão Social:";
            lblCpfCnpj.Text = "CNPJ:";
            lblRg.Visible = false;
            txtRg.Visible = false;
            if (btnSalvar.Text != "Excluir")
            {
                this.DesbloqTxt();
            }
            //gpTipoPessoa.Enabled = false;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            /*if (txtNome.Text.Count() > 3)
            {
                txtCpfCnpj.Enabled = true;
                txtRg.Enabled = true;
                lblCpfCnpj.Enabled = true;
                lblRg.Enabled = true;
            }*/

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

                /*if (txtCpfCnpj.Text.Length >= 14 && txtRg.Text.Length >= 12)
                {
                    btnProcuraCidade.Enabled = true;
                }
                else
                {
                    btnProcuraCidade.Enabled = false;
                }*/

                this.habilitaSalvar();
            }

        }

        private void txtCodCidade_TextChanged(object sender, EventArgs e)
        {
            /*if (txtCodCidade.Text.Length > 0 && txtCpfCnpj.Text.Length > 0 && txtRg.Text.Length > 0)
            {
                txtBairro.Enabled = true;
                txtLogr.Enabled = true;
                txtNumero.Enabled = true;
                txtTelCel.Enabled = true;
                txtTelRes.Enabled = true;
                txtEmail.Enabled = true;
                btnPesqCond.Enabled = true;
                txtLimite.Enabled = true;
                lblBairro.Enabled = true;
                lblLogr.Enabled = true;
                lblNumero.Enabled = true;
                lblTelCel.Enabled = true;
                lblTelRes.Enabled = true;
                lblEmail.Enabled = true;
                lblLimite.Enabled = true;
            }
            else
            {
                txtBairro.Enabled = false;
                txtLogr.Enabled = false;
                txtNumero.Enabled = false;
                txtTelCel.Enabled = false;
                txtTelRes.Enabled = false;
                txtEmail.Enabled = false;
                btnPesqCond.Enabled = false;
                txtLimite.Enabled = false;
                lblBairro.Enabled = false;
                lblLogr.Enabled = false;
                lblNumero.Enabled = false;
                lblTelCel.Enabled = false;
                lblTelRes.Enabled = false;
                lblEmail.Enabled = false;
                lblLimite.Enabled = false;

                
            }*/
            this.habilitaSalvar();
        }
        public void habilitaSalvar()
        {
            btnSalvar.Enabled = false;

            if (txtLimite.Text.Length <= 0)
            {
                txtLimite.Text = "0";
            }

            if (txtNome.Text.Length > 0 && txtCpfCnpj.Text.Length > 0 && txtCodCidade.Text.Length > 0 && txtCidade.Text.Length > 0 && txtLogr.Text.Length > 0 && txtNumero.Text.Length > 0 && txtBairro.Text.Length > 0 && txtTelRes.Text.Length > 0 && txtTelCel.Text.Length > 0 && txtEmail.Text.Length > 0 && txtCodCond.Text.Length > 0 && txtCond.Text.Length > 0 && txtLimite.Text.Length > 0)
            {
                btnSalvar.Enabled = true;
            }
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

        private void txtLimite_TextChanged(object sender, EventArgs e)
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
