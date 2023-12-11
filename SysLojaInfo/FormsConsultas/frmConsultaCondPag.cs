using MySqlX.XDevAPI;
using SysLojaInfo.Classes;
using SysLojaInfo.Ctrls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysLojaInfo
{
    public partial class frmConsultaCondPag : SysLojaInfo.frmConsulta
    {
        private ctrlCondPag aCtrl;

        private CondicoesPag aCond;

        public bool ePai;
        public frmConsultaCondPag()
        {
            InitializeComponent();
            aCtrl = new ctrlCondPag();
            aCond = new CondicoesPag();
            this.PopulaDataGrid();

        }
        public void PopulaDataGrid()
        {
            dgCond.Rows.Clear();
            dgCond.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            var lista = aCtrl.SelecionaDS();

            if (lista.Count > 0)
            {
                foreach (CondicoesPag item in lista)
                {
                    dgCond.Rows.Add(item.Codigo, item.condicao, item.taxa, item.multa, item.desconto, item.DatCad, item.DatUltAlt, item.QuemAlter);
                }
            }
        }
        public void pegaRegDataGrid()
        {
            DataGridViewRow vLinha = dgCond.SelectedRows[0];
            aCond.Codigo = Convert.ToInt32(vLinha.Cells["codigo"].Value);
            aCond.condicao = Convert.ToString(vLinha.Cells["cond"].Value);
            aCond.taxa = Convert.ToDouble(vLinha.Cells["taxa"].Value);
            aCond.multa = Convert.ToDouble(vLinha.Cells["multa"].Value);
            aCond.desconto = Convert.ToDouble(vLinha.Cells["desc"].Value);
            aCond.DatCad = Convert.ToDateTime(vLinha.Cells["datcad"].Value);
            aCond.DatUltAlt = Convert.ToDateTime(vLinha.Cells["datalt"].Value);
            aCond.QuemAlter = Convert.ToInt32(vLinha.Cells["iduser"].Value);
        }
        public object pegaCondReg()
        {
            CondicoesPag mCond = new CondicoesPag();
            this.pegaRegDataGrid();
            mCond = aCond;
            return mCond;
        }

        public override void sair()
        {
            if (ePai)
            {
                this.Hide();
            }
            else
            {
                base.sair();
            }
        }
        public object pegaCondicaoReg()
        {
            CondicoesPag mCond = new CondicoesPag();
            this.pegaRegDataGrid();
            mCond = aCond;
            return mCond;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public override void alterar()
        {
            base.alterar();
            frmCadastroCondPag tela = new frmCadastroCondPag();
            tela.Botao_alterar();
            this.pegaRegDataGrid();
            tela.CarregaCampos(aCond);
            tela.Show();
        }

        public override void incluir()
        {
            base.incluir();
            frmCadastroCondPag tela = new frmCadastroCondPag();
            tela.Botao_Salvar();
            tela.Show();
        }

        public override void excluir()
        {
            base.excluir();
            frmCadastroCondPag tela = new frmCadastroCondPag();
            tela.Botao_Excluir();
            this.pegaRegDataGrid();
            tela.CarregaCampos(aCond);
            tela.Show();

        }

        private void frmConsultaCondPag_Activated(object sender, EventArgs e)
        {
            this.PopulaDataGrid();
        }

        public override void pesquisar()
        {
            if (this.txtChave.Text is "")
            {
                aCond = new CondicoesPag();
                MessageBox.Show("FAVOR INFORME O CÓDIGO OU DESCRIÇÃO DA CONDIÇÃO PARA REALIZAR A BUSCAR");
            }
            else
            {
                if (IsInteger(this.txtChave.Text))
                {
                    aCond = aCtrl.buscar(Convert.ToInt32(txtChave.Text));

                }
                else if (temCharEspecial(this.txtChave.Text) is false)
                {
                    aCond = aCtrl.buscar(txtChave.Text);
                }
                else
                {
                    MessageBox.Show("O TEXTO INFORMADO PARA BUSCA NÃO CORRESPONDE AO CÓDIGO OU DESCRIÇÃO DE UMA CONDIÇÃO!!");
                    aCond = new CondicoesPag();
                    this.txtChave.Clear();
                }

                dgCond.Rows.Clear();
                dgCond.Rows.Add(aCond.Codigo, aCond.condicao, aCond.taxa, aCond.multa, aCond.desconto, aCond.DatCad, aCond.DatUltAlt, aCond.QuemAlter);

            }

        }
    }
}
