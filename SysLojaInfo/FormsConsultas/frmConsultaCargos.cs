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
    public partial class frmConsultaCargos : SysLojaInfo.frmConsulta
    {
        private ctrlCargos aCtrl;

        private Cargos oCargo;

        public bool ePai;

        public frmConsultaCargos()
        {
            InitializeComponent();
            aCtrl = new ctrlCargos();
            oCargo = new Cargos();
            this.PopulaDataGrid();
        }

        public void PopulaDataGrid()
        {
            dgCargos.Rows.Clear();
            dgCargos.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            var lista = aCtrl.SelecionaDS();

            if (lista.Count > 0)
            {
                foreach (Cargos item in lista)
                {
                    dgCargos.Rows.Add(item.Codigo, item.cargo, item.externo, item.DatCad, item.DatUltAlt, item.QuemAlter);
                }
            }
        }

        public void pegaRegDataGrid()
        {
            DataGridViewRow vLinha = dgCargos.SelectedRows[0];
            oCargo.Codigo = Convert.ToInt32(vLinha.Cells["codigo"].Value);
            oCargo.cargo = Convert.ToString(vLinha.Cells["cargo"].Value);
            oCargo.externo = Convert.ToString(vLinha.Cells["externo"].Value);
            oCargo.DatCad = Convert.ToDateTime(vLinha.Cells["datCad"].Value);
            oCargo.DatUltAlt = Convert.ToDateTime(vLinha.Cells["datAlt"].Value);
            oCargo.QuemAlter = Convert.ToInt32(vLinha.Cells["idUser"].Value);
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

        public object pegaCargoReg()
        {
            Cargos mCargos = new Cargos();
            this.pegaRegDataGrid();
            mCargos = oCargo;
            return mCargos;
        }

        public override void alterar()
        {
            base.alterar();
            frmCadastroCargos tela = new frmCadastroCargos();
            this.pegaRegDataGrid();
            tela.CarregaCampos(oCargo);
            tela.Botao_alterar();
            tela.Show();
        }

        public override void incluir()
        {
            base.incluir();
            frmCadastroCargos tela = new frmCadastroCargos();
            tela.Botao_Salvar();
            tela.Show();
        }

        public override void excluir()
        {
            base.excluir();
            frmCadastroCargos tela = new frmCadastroCargos();
            this.pegaRegDataGrid();
            tela.CarregaCampos(oCargo);
            tela.Botao_Excluir();
            tela.Show();
        }

        public override void pesquisar()
        {
            if (this.txtChave.Text is "")
            {
                oCargo = new Cargos();
                MessageBox.Show("FAVOR INFORME O CÓDIGO OU NOME DE UM CARGO PARA REALIZAR A BUSCAR");
            }
            else
            {
                if (IsInteger(this.txtChave.Text))
                {
                    oCargo = aCtrl.buscar(Convert.ToInt32(txtChave.Text));

                }
                else if (temCharEspecial(this.txtChave.Text) is false)
                {
                    oCargo = aCtrl.buscar(txtChave.Text);
                }
                else
                {
                    MessageBox.Show("O TEXTO INFORMADO PARA BUSCA NÃO CORRESPONDE AO CÓDIGO OU NOME DE UM CARGO!!");
                    oCargo = new Cargos();
                    this.txtChave.Clear();
                }

                dgCargos.Rows.Clear();
                dgCargos.Rows.Add(oCargo.Codigo, oCargo.cargo, oCargo.externo, oCargo.DatCad, oCargo.DatUltAlt, oCargo.QuemAlter);

            }

        }

        private void frmConsultaCargos_Activated(object sender, EventArgs e)
        {
            if (this.txtChave.Text is "")
            {
                this.PopulaDataGrid();
            }
        }
    }
}
