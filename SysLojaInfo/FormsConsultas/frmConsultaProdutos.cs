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
    public partial class frmConsultaProdutos : SysLojaInfo.frmConsulta
    {
        private ctrlProdutos aCtrl;

        private Produtos oProduto;

        public bool ePai;
        public frmConsultaProdutos()
        {
            InitializeComponent();
            aCtrl = new ctrlProdutos();
            oProduto = new Produtos();
            this.PopulaDataGrid();
        }
        public void PopulaDataGrid()
        {
            dgProdutos.Rows.Clear();
            dgProdutos.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            var lista = aCtrl.SelecionaDS();

            if (lista.Count > 0)
            {
                foreach (Produtos item in lista)
                {
                    dgProdutos.Rows.Add(item.Codigo, item.produto, item.estoque, item.aMedida.uMedida, item.precoVenda, item.custo, item.custoMedio, item.DatCad, item.DatUltAlt, item.QuemAlter);
                }
            }
        }
        public void pegaRegDataGrid()
        {
            DataGridViewRow vLinha = dgProdutos.SelectedRows[0];
            oProduto.Codigo = Convert.ToInt32(vLinha.Cells["codigo"].Value);
            oProduto.produto = Convert.ToString(vLinha.Cells["produto"].Value);
            oProduto.estoque = Convert.ToInt32(vLinha.Cells["estoque"].Value);
            oProduto.aMedida.uMedida = Convert.ToString(vLinha.Cells["umedida"].Value);
            oProduto.precoVenda = Convert.ToDouble(vLinha.Cells["precovenda"].Value);
            oProduto.custo = Convert.ToDouble(vLinha.Cells["custo"].Value);
            oProduto.custoMedio = Convert.ToDouble(vLinha.Cells["custoMedio"].Value);
            oProduto.DatCad = Convert.ToDateTime(vLinha.Cells["datcad"].Value);
            oProduto.DatUltAlt = Convert.ToDateTime(vLinha.Cells["datalt"].Value);
            oProduto.QuemAlter = Convert.ToInt32(vLinha.Cells["iduser"].Value);
        }

        public object pegaProdutoReg()
        {
            Produtos mProdutos = new Produtos();
            this.pegaRegDataGrid();
            mProdutos = oProduto;
            return mProdutos;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public override void alterar()
        {
            base.alterar();
            frmCadastroProduto tela = new frmCadastroProduto();
            this.pegaRegDataGrid();
            tela.CarregaCampos(oProduto);
            tela.Botao_alterar();
            tela.Show();
        }

        public override void incluir()
        {
            base.incluir();
            frmCadastroProduto tela = new frmCadastroProduto();
            tela.Botao_Salvar();
            tela.Show();
        }

        public override void excluir()
        {
            base.excluir();
            frmCadastroProduto tela = new frmCadastroProduto();
            this.pegaRegDataGrid();
            tela.CarregaCampos(oProduto);
            tela.Botao_Excluir();
            tela.Show();

        }

        public override void pesquisar()
        {
            if (this.txtChave.Text is "")
            {
                oProduto = new Produtos();
                MessageBox.Show("FAVOR INFORME O CÓDIGO OU NOME DE UM PRODUTO PARA REALIZAR A BUSCA");
            }
            else
            {
                if (IsInteger(this.txtChave.Text))
                {
                    oProduto = aCtrl.buscar(Convert.ToInt32(txtChave.Text));

                }
                else if (temCharEspecial(this.txtChave.Text) is false)
                {
                    oProduto = aCtrl.buscar(txtChave.Text);
                }
                else
                {
                    MessageBox.Show("O TEXTO INFORMADO PARA BUSCA NÃO CORRESPONDE AO CODIGO OU NOME DE UM PRODUTO!!");
                    oProduto = new Produtos();
                    this.txtChave.Clear();
                }

                dgProdutos.Rows.Clear();
                dgProdutos.Rows.Add(oProduto.Codigo, oProduto.produto, oProduto.estoque, oProduto.aMedida.uMedida, oProduto.precoVenda, oProduto.custo, oProduto.custoMedio, oProduto.DatCad, oProduto.DatUltAlt, oProduto.QuemAlter);

            }



        }

        private void frmConsultaProdutos_Activated(object sender, EventArgs e)
        {
            if (this.txtChave.Text is "")
            {
                this.PopulaDataGrid();
            }
        }
    }
}
