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
    
    public partial class frmConsultaEstados : SysLojaInfo.frmConsulta
    {

        private ctrlEstados aCtrl;

        private Estados oEst;

        public bool ePai;

        public frmConsultaEstados()
        {
            InitializeComponent();
            aCtrl = new ctrlEstados();
            oEst = new Estados();
            this.PopulaDataGrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void PopulaDataGrid()
        {
            dgEstados.Rows.Clear();
            dgEstados.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;

            var lista = aCtrl.SelecionaDS();

            if (lista.Count > 0)
            {
                foreach (Estados item in lista)
                {
                    dgEstados.Rows.Add(item.Codigo, item.estado, item.uf, item.oPais.Codigo, item.oPais.Pais, item.DatCad, item.DatUltAlt, item.QuemAlter);
                }
            }
        }

        public void pegaRegDataGrid()
        {
            DataGridViewRow vLinha = dgEstados.SelectedRows[0];
            oEst.Codigo = Convert.ToInt32(vLinha.Cells["codigo"].Value);
            oEst.estado = Convert.ToString(vLinha.Cells["estado"].Value);
            oEst.uf = Convert.ToString(vLinha.Cells["uf"].Value);
            oEst.oPais.Codigo = Convert.ToInt32(vLinha.Cells["codPais"].Value);
            oEst.oPais.Pais = Convert.ToString(vLinha.Cells["pais"].Value);
            oEst.DatCad = Convert.ToDateTime(vLinha.Cells["datCad"].Value);
            oEst.DatUltAlt = Convert.ToDateTime(vLinha.Cells["datAlt"].Value);
            oEst.QuemAlter = Convert.ToInt32(vLinha.Cells["idUser"].Value);
        }

        public object pegaEstReg()
        {
            Estados mEst = new Estados();
            this.pegaRegDataGrid();
            mEst = oEst;
            return mEst;
        }

        public override void alterar()
        {
            base.alterar();
            frmCadastroEstados tela = new frmCadastroEstados();
            this.pegaRegDataGrid();
            tela.CarregaCampos(oEst);
            tela.Botao_alterar();
            tela.Show();
        }

        public override void incluir()
        {
            base.incluir();
            frmCadastroEstados tela = new frmCadastroEstados();
            tela.Botao_Salvar();
            tela.Show();
        }

        public override void excluir()
        {
            base.excluir();
            frmCadastroEstados tela = new frmCadastroEstados();
            this.pegaRegDataGrid();
            tela.CarregaCampos(oEst);
            tela.Botao_Excluir();
            tela.Show();

        }

        public override void pesquisar()
        {
            if (this.txtChave.Text is "")
            {
                oEst = new Estados();
                MessageBox.Show("FAVOR INFORME O CÓDIGO OU NOME DE UM ESTADO PARA REALIZAR A BUSCAR");
            }
            else
            {
                if (IsInteger(this.txtChave.Text))
                {
                    oEst = aCtrl.buscar(Convert.ToInt32(txtChave.Text));

                }
                else if (temCharEspecial(this.txtChave.Text) is false)
                {
                    oEst = aCtrl.buscar(txtChave.Text);
                }
                else
                {
                    MessageBox.Show("O TEXTO INFORMADO PARA BUSCA NÃO CORRESPONDE AO CODIGO OU NOME DE UM ESTADO!!");
                    oEst = new Estados();
                    this.txtChave.Clear();
                }

                dgEstados.Rows.Clear();
                dgEstados.Rows.Add(oEst.Codigo, oEst.estado, oEst.uf, oEst.oPais.Codigo, oEst.oPais.Pais, oEst.DatCad, oEst.DatUltAlt, oEst.QuemAlter);

            }

        }

        private void frmConsultaEstados_Activated(object sender, EventArgs e)
        {
            if (this.txtChave.Text is "")
            {
                this.PopulaDataGrid();
            }
        }
    }
}
