using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysLojaInfo
{
    public partial class frmCadastroProduto : SysLojaInfo.frmCadastro
    {
        private Produtos oProduto;
        public frmCadastroProduto()
        {
            InitializeComponent();
            oProduto = new Produtos();
        }
        public override void Salvar()
        {
            base.Salvar();
            ctrlProdutos aCtrl = new ctrlProdutos();
            oProduto.produto = txtProduto.Text;
            oProduto.aMedida.uMedida = txtUnMed.Text;
            if (IsInteger(txtPrecoVenda.Text))
            {
                oProduto.precoVenda = Convert.ToDouble(txtPrecoVenda.Text);
            }

            if (base.btnSalvar.Text is "Salvar")
            {
                aCtrl.salvar(oProduto);
            }
            else if (base.btnSalvar.Text is "Alterar")
            {
                aCtrl.editar(oProduto);
            }
            else if (base.btnSalvar.Text is "Excluir")
            {
                aCtrl.deletar(oProduto);
            };
            Close();

        }
        public void CarregaCampos(object obj)
        {
            oProduto = (Produtos)obj;
            this.txtCodigo.Text = oProduto.Codigo.ToString();
            this.txtProduto.Text = oProduto.produto;
            this.txtPrecoCusto.Text = oProduto.custo.ToString();
            this.txtCustoMedio.Text = oProduto.custoMedio.ToString();
            this.txtEstoque.Text = oProduto.estoque.ToString();
            this.txtPrecoVenda.Text = oProduto.precoVenda.ToString();
            this.txtUnMed.Text = oProduto.aMedida.uMedida;
            this.txtDatCad.Text = oProduto.DatCad.ToString();
            this.txtDatUltAlt.Text = oProduto.DatUltAlt.ToString();
            this.txtQuemAlt.Text = oProduto.QuemAlter.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void BloqTxt()
        {
            this.txtProduto.Enabled = false;
        }

        public void DesbloqTxt()
        {
            this.txtProduto.Enabled = true;
        }

        public override void Botao_alterar()
        {
            base.Botao_alterar();
            this.DesbloqTxt();
            if (oProduto.custo > 0)
            {
                txtPrecoVenda.Enabled = true;
                btnPesqUnMed.Enabled = false;
            }
        }

        public override void Botao_Excluir()
        {
            base.Botao_Excluir();
            this.BloqTxt();
            btnPesqUnMed.Enabled = false;
            if (oProduto.custo > 0)
            {
                btnSalvar.Enabled = false;
            }
        }

        public override void Botao_Salvar()
        {
            base.Botao_Salvar();
            this.DesbloqTxt();
        }



        private void btnPesqUnMed_Click(object sender, EventArgs e)
        {
            frmConsultaMedidas tela = new frmConsultaMedidas();
            tela.botao_Selecionar();
            tela.ePai = true;
            tela.ShowDialog();

            Medidas mMedida = new Medidas();

            mMedida = (Medidas)tela.pegaMedidaReg();

            txtUnMed.Text = mMedida.uMedida;
            tela.Close();
        }
    }
}
