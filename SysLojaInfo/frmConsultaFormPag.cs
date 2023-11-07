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
    public partial class frmConsultaFormaPag : SysLojaInfo.frmConsulta
    {
        private ctrlFormas aCtrl;

        private FormasPag aForma;

        public bool ePai;
        public frmConsultaFormaPag()
        {
            InitializeComponent();
            aCtrl = new ctrlFormas();
            aForma = new FormasPag();
            this.PopulaDataGrid();
        }
        public void PopulaDataGrid()
        {
            dgFormas.Rows.Clear();
            dgFormas.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            var lista = aCtrl.SelecionaDS();

            if (lista.Count > 0)
            {
                foreach (FormasPag item in lista)
                {
                    dgFormas.Rows.Add(item.Codigo, item.forma, item.DatCad, item.DatUltAlt, item.QuemAlter);
                }
            }
        }

        public void pegaRegDataGrid()
        {
            DataGridViewRow vLinha = dgFormas.SelectedRows[0];
            aForma.Codigo = Convert.ToInt32(vLinha.Cells["codigo"].Value);
            aForma.forma = Convert.ToString(vLinha.Cells["formapag"].Value);
            aForma.DatCad = Convert.ToDateTime(vLinha.Cells["datCad"].Value);
            aForma.DatUltAlt = Convert.ToDateTime(vLinha.Cells["datAlt"].Value);
            aForma.QuemAlter = Convert.ToInt32(vLinha.Cells["idUser"].Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        public object pegaFormaReg()
        {
            FormasPag mForma = new FormasPag();
            this.pegaRegDataGrid();
            mForma = aForma;
            return mForma;
        }
        public override void alterar()
        {
            base.alterar();
            frmCadastroFormaPag tela = new frmCadastroFormaPag();
            this.pegaRegDataGrid();
            tela.CarregaCampos(aForma);
            tela.Botao_alterar();
            tela.Show();
        }

        public override void incluir()
        {
            base.incluir();
            frmCadastroFormaPag tela = new frmCadastroFormaPag();
            tela.Botao_Salvar();
            tela.Show();
        }

        public override void excluir()
        {
            base.excluir();
            frmCadastroFormaPag tela = new frmCadastroFormaPag();
            this.pegaRegDataGrid();
            tela.CarregaCampos(aForma);
            tela.Botao_Excluir();
            tela.Show();

        }

        public override void pesquisar()
        {
            if (this.txtChave.Text is "")
            {
                aForma = new FormasPag();
                MessageBox.Show("FAVOR INFORME O CÓDIGO OU NOME DE UMA FORMA DE PAGAMENTO PARA REALIZAR A BUSCAR");
            }
            else
            {
                if (IsInteger(this.txtChave.Text))
                {
                    aForma = aCtrl.buscar(Convert.ToInt32(txtChave.Text));

                }
                else if (temCharEspecial(this.txtChave.Text) is false)
                {
                    aForma = aCtrl.buscar(txtChave.Text);
                }
                else
                {
                    MessageBox.Show("O TEXTO INFORMADO PARA BUSCA NÃO CORRESPONDE AO CÓDIGO OU NOME DE UMA FORMA DE PAGAMENTO!!");
                    aForma = new FormasPag();
                    this.txtChave.Clear();
                }

                dgFormas.Rows.Clear();
                dgFormas.Rows.Add(aForma.Codigo, aForma.forma, aForma.DatCad, aForma.DatUltAlt, aForma.QuemAlter);

            }

        }

        private void frmConsultaFormaPag_Activated(object sender, EventArgs e)
        {
            if (this.txtChave.Text is "")
            {
                this.PopulaDataGrid();
            }
        }
    }
}
