using MySqlX.XDevAPI;
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
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public override void BloqTxt()
        {
            base.BloqTxt();
        }

        public override void DesbloqTxt()
        {
            base.DesbloqTxt();
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
    }
}
