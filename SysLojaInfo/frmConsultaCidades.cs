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
    public partial class frmConsultaCidades : SysLojaInfo.frmConsulta
    {
        private ctrlCidades aCtrl;

        private Cidades aCidade;

        public bool ePai;

        public frmConsultaCidades()
        {
            InitializeComponent();
            aCtrl = new ctrlCidades();
            aCidade = new Cidades();
            this.PopulaDataGrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void PopulaDataGrid()
        {
            dgCidades.Rows.Clear();
            dgCidades.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;

            var lista = aCtrl.SelecionaDS();

            if (lista.Count > 0)
            {
                foreach (Cidades item in lista)
                {
                    dgCidades.Rows.Add(item.Codigo, item.cidade, item.DDD, item.oEstado.Codigo, item.oEstado.estado, item.DatCad, item.DatUltAlt, item.QuemAlter);
                }
            }
        }
        public void pegaRegDataGrid()
        {
            DataGridViewRow vLinha = dgCidades.SelectedRows[0];
            aCidade.Codigo = Convert.ToInt32(vLinha.Cells["codigo"].Value);
            aCidade.cidade = Convert.ToString(vLinha.Cells["cidade"].Value);
            aCidade.DDD = Convert.ToString(vLinha.Cells["ddd"].Value);
            aCidade.oEstado.Codigo = Convert.ToInt32(vLinha.Cells["codestado"].Value);
            aCidade.oEstado.estado = Convert.ToString(vLinha.Cells["estado"].Value);
            aCidade.DatCad = Convert.ToDateTime(vLinha.Cells["datcad"].Value);
            aCidade.DatUltAlt = Convert.ToDateTime(vLinha.Cells["datalt"].Value);
            aCidade.QuemAlter = Convert.ToInt32(vLinha.Cells["iduser"].Value);
        }

        public object pegaCidadeReg()
        {
            Cidades mCidades = new Cidades();
            this.pegaRegDataGrid();
            mCidades = aCidade;
            return mCidades;
        }

        public override void alterar()
        {
            base.alterar();
            frmCadastroCidades tela = new frmCadastroCidades();
            this.pegaRegDataGrid();
            tela.CarregaCampos(aCidade);
            tela.Botao_alterar();
            tela.Show();
        }

        public override void incluir()
        {
            base.incluir();
            frmCadastroCidades tela = new frmCadastroCidades();
            tela.Botao_Salvar();
            tela.Show();
        }

        public override void excluir()
        {
            base.excluir();
            frmCadastroCidades tela = new frmCadastroCidades();
            this.pegaRegDataGrid();
            tela.CarregaCampos(aCidade);
            tela.Botao_Excluir();
            tela.Show();

        }
        public override void pesquisar()
        {
            if (this.txtChave.Text is "")
            {
                aCidade = new Cidades();
                MessageBox.Show("FAVOR INFORME O CÓDIGO OU NOME DE UMA CIDADE PARA REALIZAR A BUSCA");
            }
            else
            {
                if (IsInteger(this.txtChave.Text))
                {
                    aCidade = aCtrl.buscar(Convert.ToInt32(txtChave.Text));

                }
                else if (temCharEspecial(this.txtChave.Text) is false)
                {
                    aCidade = aCtrl.buscar(txtChave.Text);
                }
                else
                {
                    MessageBox.Show("O TEXTO INFORMADO PARA BUSCA NÃO CORRESPONDE AO CODIGO OU NOME DE UMA CIDADE!!");
                    aCidade = new Cidades();
                    this.txtChave.Clear();
                }

                dgCidades.Rows.Clear();
                dgCidades.Rows.Add(aCidade.Codigo, aCidade.cidade, aCidade.DDD, aCidade.oEstado.Codigo, aCidade.oEstado.estado, aCidade.DatCad, aCidade.DatUltAlt, aCidade.QuemAlter);

            }

        }

        private void frmConsultaCidades_Activated(object sender, EventArgs e)
        {
            if (this.txtChave.Text is "")
            {
                this.PopulaDataGrid();
            }
        }
    }
}
