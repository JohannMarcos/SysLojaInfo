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
    public partial class frmConsultaMedidas : SysLojaInfo.frmConsulta
    {
        private ctrlMedidas aCtrl;

        private Medidas aMedida;

        public bool ePai;
        public frmConsultaMedidas()
        {
            InitializeComponent();
            aCtrl = new ctrlMedidas();
            aMedida = new Medidas();
            this.PopulaDataGrid();
        }

        public void PopulaDataGrid()
        {
            dgMedidas.Rows.Clear();
            dgMedidas.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            List<Medidas> lista = new List<Medidas>();
            if (ePai)
            {
                lista = aCtrl.BuscaAtivos();
                this.btnAlterar.Visible = false;
            }
            else
            {
                lista = aCtrl.SelecionaDS();
            }
            

            if (lista.Count > 0)
            {
                foreach (Medidas item in lista)
                {
                    dgMedidas.Rows.Add(item.uMedida, item.descricao, item.ativo, item.DatUltAlt, item.QuemAlter);
                }
            }
        }

        public void pegaRegDataGrid()
        {
            DataGridViewRow vLinha = dgMedidas.SelectedRows[0];
            aMedida.uMedida = Convert.ToString(vLinha.Cells["umedida"].Value);
            aMedida.descricao = Convert.ToString(vLinha.Cells["descricao"].Value);
            aMedida.DatUltAlt = Convert.ToDateTime(vLinha.Cells["datAlt"].Value);
            aMedida.QuemAlter = Convert.ToInt32(vLinha.Cells["idUser"].Value);
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

        public object pegaMedidaReg()
        {
            Medidas mMedidas = new Medidas();
            this.pegaRegDataGrid();
            mMedidas = aMedida;
            return mMedidas;
        }

        public override void alterar()
        {
            base.alterar();
            frmCadastroMedidas tela = new frmCadastroMedidas();
            this.pegaRegDataGrid();
            tela.CarregaCampos(aMedida);
            tela.Botao_alterar();
            tela.Show();
        }

        public override void pesquisar()
        {
            if (this.txtChave.Text is "")
            {
                aMedida = new Medidas();
                MessageBox.Show("FAVOR INFORME O CÓDIGO OU NOME DE UMA UNIDADE DE MEDIDA PARA REALIZAR A BUSCAR");
            }
            else
            {
                if (this.txtChave.Text.Length <= 3)
                {
                    aMedida = aCtrl.buscarAbr(txtChave.Text);
                    dgMedidas.Rows.Clear();
                    dgMedidas.Rows.Add(aMedida.uMedida, aMedida.descricao, aMedida.ativo, aMedida.DatUltAlt, aMedida.QuemAlter);


                }
                else if (temCharEspecial(this.txtChave.Text) is false)
                {
                    var lista = aCtrl.buscar(this.txtChave.Text);

                    if (lista.Count > 0)
                    {
                        foreach (Medidas item in lista)
                        {
                            dgMedidas.Rows.Add(item.uMedida, item.descricao, item.ativo, item.DatUltAlt, item.QuemAlter);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("O TEXTO INFORMADO PARA BUSCA NÃO CORRESPONDE AO CÓDIGO OU NOME DE UMA UNIDADE DE MEDIDA!!");
                    aMedida = new Medidas();
                    this.txtChave.Clear();
                }

            }

        }

        private void frmConsultaMedidas_Activated(object sender, EventArgs e)
        {
            if (this.txtChave.Text is "")
            {
                this.PopulaDataGrid();
            }
        }
    }
}
