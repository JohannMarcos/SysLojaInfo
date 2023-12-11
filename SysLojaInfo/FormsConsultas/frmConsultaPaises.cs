using Google.Protobuf.WellKnownTypes;
using SysLojaInfo.Classes;
using SysLojaInfo.Ctrls;
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
    public partial class frmConsultaPaises : SysLojaInfo.frmConsulta
    {
        private ctrlPaises aCtrl;

        private Paises oPais;

        public bool ePai;

        public frmConsultaPaises()
        {
            InitializeComponent();
            aCtrl = new ctrlPaises();
            oPais = new Paises();
            this.PopulaDataGrid();
        }

        public void PopulaDataGrid()
        {
            dgPaises.Rows.Clear();
            dgPaises.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;

            var lista = aCtrl.SelecionaDS();

            if (lista.Count > 0)
            {
                foreach (Paises item in lista)
                {
                    dgPaises.Rows.Add(item.Codigo, item.Pais, item.Sigla, item.DDI, item.DatCad, item.DatUltAlt, item.QuemAlter);
                }
            }
        }

        public void pegaRegDataGrid()
        {
            DataGridViewRow vLinha = dgPaises.SelectedRows[0];
            oPais.Codigo = Convert.ToInt32(vLinha.Cells["codigo"].Value);
            oPais.Pais = Convert.ToString(vLinha.Cells["pais"].Value);
            oPais.DDI = Convert.ToString(vLinha.Cells["ddi"].Value);
            oPais.Sigla = Convert.ToString(vLinha.Cells["sigla"].Value);
            oPais.DatCad = Convert.ToDateTime(vLinha.Cells["datCad"].Value);
            oPais.DatUltAlt = Convert.ToDateTime(vLinha.Cells["datAlt"].Value);
            oPais.QuemAlter = Convert.ToInt32(vLinha.Cells["idUser"].Value);
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

        public object pegaPaisReg()
        {
            Paises mPais = new Paises();
            this.pegaRegDataGrid();
            mPais = oPais;
            return mPais;
        }
        public override void alterar()
        {
            base.alterar();
            frmCadastroPaises tela = new frmCadastroPaises();
            this.pegaRegDataGrid();
            tela.CarregaCampos(oPais);
            tela.Botao_alterar();
            tela.Show();
        }

        public override void incluir()
        {
            base.incluir();
            frmCadastroPaises tela = new frmCadastroPaises();
            tela.Botao_Salvar();
            tela.Show();
        }

        public override void excluir()
        {
            base.excluir();
            frmCadastroPaises tela = new frmCadastroPaises();
            this.pegaRegDataGrid();
            tela.CarregaCampos(oPais);
            tela.Botao_Excluir();
            tela.Show();

        }

        public override void pesquisar()
        {
            if (this.txtChave.Text is "")
            {
                oPais = new Paises();
                MessageBox.Show("FAVOR INFORME O CÓDIGO OU NOME DE UM PAÍS PARA REALIZAR A BUSCAR");
            }
            else
            {
                if (IsInteger(this.txtChave.Text))
                {
                    oPais = aCtrl.buscar(Convert.ToInt32(txtChave.Text));

                }
                else if (temCharEspecial(this.txtChave.Text) is false)
                {
                    oPais = aCtrl.buscar(txtChave.Text);
                }
                else
                {
                    MessageBox.Show("O TEXTO INFORMADO PARA BUSCA NÃO CORRESPONDE AO CODIGO OU NOME DE UM PAÍS!!");
                    oPais = new Paises();
                    this.txtChave.Clear();
                }

                dgPaises.Rows.Clear();
                dgPaises.Rows.Add(oPais.Codigo, oPais.Pais, oPais.Sigla, oPais.DDI, oPais.DatCad, oPais.DatUltAlt, oPais.QuemAlter);

            }

        }

        private void frmConsultaPaises_Activated(object sender, EventArgs e)
        {
            if (this.txtChave.Text is "")
            {
                this.PopulaDataGrid();
            }
        }
    }
}
