using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysLojaInfo.Classes;
using SysLojaInfo.Ctrls;

namespace SysLojaInfo
{
    public partial class frmCadastroFuncionario : SysLojaInfo.frmCadastroPessoas
    {
        private Funcionarios oFuncionario;


        public frmCadastroFuncionario()
        {
            InitializeComponent();
            oFuncionario = new Funcionarios();
        }

        public override void Salvar()
        {
            base.Salvar();
            ctrlFuncionarios aCtrl = new ctrlFuncionarios();
            oFuncionario.nome = txtNome.Text;
            if (rbFisica.Checked)
            {
                oFuncionario.natPess = "PF";
                oFuncionario.rg = txtRg.Text;
            }
            else if (rbJuridica.Checked)
            {
                oFuncionario.natPess = "PJ";
                oFuncionario.rg = "";
            }
            oFuncionario.cpfCnpj = txtCpfCnpj.Text;
            oFuncionario.logr = txtLogr.Text;
            oFuncionario.numero = Convert.ToInt32(txtNumero.Text);
            oFuncionario.bairro = txtBairro.Text;
            oFuncionario.oCargo.Codigo = Convert.ToInt32(txtCodCargo.Text);
            oFuncionario.aCidade.Codigo = Convert.ToInt32(txtCodCidade.Text);
            oFuncionario.telRes = txtTelRes.Text;
            oFuncionario.telCel = txtTelCel.Text;
            oFuncionario.email = txtEmail.Text;

            if (base.btnSalvar.Text is "Salvar")
            {
                aCtrl.salvar(oFuncionario);
            }
            else if (base.btnSalvar.Text is "Alterar")
            {
                aCtrl.editar(oFuncionario);
            }
            else if (base.btnSalvar.Text is "Excluir")
            {
                aCtrl.deletar(oFuncionario);
            };
            Close();

        }

        public void CarregaCampos(object obj)
        {
            oFuncionario = (Funcionarios)obj;
            this.txtCodigo.Text = oFuncionario.Codigo.ToString();
            this.txtNome.Text = oFuncionario.nome;
            if (oFuncionario.natPess == "PF")
            {
                rbFisica.Checked = true;
            }
            else if (oFuncionario.natPess == "PJ")
            {
                rbJuridica.Checked = true;
            }
            this.txtCpfCnpj.Text = oFuncionario.cpfCnpj;
            this.txtRg.Text = oFuncionario.rg;
            this.txtCnh.Text = oFuncionario.cnh;
            this.txtLogr.Text = oFuncionario.logr;
            this.txtNumero.Text = oFuncionario.numero.ToString();
            this.txtBairro.Text = oFuncionario.bairro;
            this.txtCodCargo.Text = oFuncionario.oCargo.Codigo.ToString();
            this.txtCargo.Text = oFuncionario.oCargo.cargo;
            this.txtCodCidade.Text = oFuncionario.aCidade.Codigo.ToString();
            this.txtCidade.Text = oFuncionario.aCidade.cidade;
            this.txtTelRes.Text = oFuncionario.telRes;
            this.txtTelCel.Text = oFuncionario.telCel;
            this.txtEmail.Text = oFuncionario.email;
            this.txtDatCad.Text = oFuncionario.DatCad.ToString();
            this.txtDatUltAlt.Text = oFuncionario.DatUltAlt.ToString();
            this.txtQuemAlt.Text = oFuncionario.QuemAlter.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public override void BloqTxt()
        {
            base.BloqTxt();
            this.txtCnh.Enabled = false;
            this.btnProcuraCargo.Enabled = false;
        }

        public override void DesbloqTxt()
        {
            base.DesbloqTxt();
            this.txtCnh.Enabled = true;
            this.btnProcuraCargo.Enabled = true;
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

        private void btnProcuraCargo_Click(object sender, EventArgs e)
        {
            frmConsultaCargos tela = new frmConsultaCargos();
            tela.botao_Selecionar();
            tela.ePai = true;
            tela.ShowDialog();

            Cargos mCargos = new Cargos();

            mCargos = (Cargos)tela.pegaCargoReg();

            txtCodCargo.Text = mCargos.Codigo.ToString();
            txtCargo.Text = mCargos.cargo;

            if (mCargos.externo == "S")
            {
                lblCNH.Text = lblCNH.Text + "*";
                lblCNH.ForeColor = Color.Red;
            }
            else
            {
                lblCNH.Text = lblCNH.Text.Replace("*", "");
                lblCNH.ForeColor = Color.Black;
            }
            tela.Close();
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

        /*private void cbExterno_CheckedChanged(object sender, EventArgs e)
        {
            if ()
            {
                txtCnh.Enabled = true;
            }
            else
            {
                txtCnh.Enabled = false;
                txtCnh.Text = "";
            }
        }*/
    }
}
