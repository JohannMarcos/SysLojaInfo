using MySqlX.XDevAPI;
using SysLojaInfo.Classes;
using SysLojaInfo.Ctrls;
using SysLojaInfo.Daos;
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
    public partial class frmConsultaCompras : SysLojaInfo.frmConsulta
    {
        private ctrlCompras aCtrl;

        private Compra aCompra;

        public bool ePai;

        public frmConsultaCompras()
        {
            InitializeComponent();
            aCtrl = new ctrlCompras();
            aCompra = new Compra ();
            this.PopulaDataGrid();
        }
        public void PopulaDataGrid()
        {
            dgNotas.Rows.Clear();
            dgNotas.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;

            var lista = aCtrl.SelecionaDS();

            if (lista.Count > 0)
            {
                foreach (Compra item in lista)
                {
                    dgNotas.Rows.Add(item.nNota, item.SerieNota, item.ModeloNota, item.oFornecedor.nome, item.dtEmissao, item.dtChegada, item.totalNota);
                }
            }
        }

        public override void incluir()
        {
            frmCadastroCompras tela = new frmCadastroCompras();
            tela.ShowDialog();
        }
        public override void alterar()
        {
            frmCadastroCompras tela = new frmCadastroCompras();
            tela.ShowDialog();
        }
        public override void excluir()
        {
            frmCadastroCompras tela = new frmCadastroCompras();
            tela.ShowDialog();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

        }
    }
}
