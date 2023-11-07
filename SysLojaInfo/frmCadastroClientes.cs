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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public override void BloqTxt()
        {
            base.BloqTxt();
            this.txtLimite.Enabled = false;
        }

        public override void DesbloqTxt()
        {
            base.DesbloqTxt();
            this.txtLimite.Enabled = true;
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
    }
}
