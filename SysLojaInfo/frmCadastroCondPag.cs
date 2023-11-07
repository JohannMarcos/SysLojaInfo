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
    public partial class frmCadastroCondPag : SysLojaInfo.frmCadastro
    {
        private ctrlFormas aCtrlForma;

        private List<Parcelas> ListaParcelas;
        public frmCadastroCondPag()
        {
            InitializeComponent();
            ListaParcelas = new List<Parcelas>();
            aCtrlForma = new ctrlFormas();
            var lista = aCtrlForma.SelecionaDS();

            foreach (FormasPag item in lista)
            {
                cbFormas.Items.Add(item.forma);
            }
        }

        public void verificarPreenchido()
        {
            if (txtCond.Text.Length > 0 && txtTaxa.Text.Length > 0 && txtMulta.Text.Length > 0 && txtDesconto.Text.Length > 0)
            {
                gbParcelas.Enabled = true;
            }
            else
            {
                gbParcelas.Enabled = false;
            }
            if (dgParcelas.Rows.Count > 0)
            {
                txtCond.Enabled = false;
                txtTaxa.Enabled = false;
                txtMulta.Enabled = false;
                txtDesconto.Enabled = false;
            }
            else
            {
                txtCond.Enabled = true;
                txtTaxa.Enabled = true;
                txtMulta.Enabled = true;
                txtDesconto.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtCond_Leave(object sender, EventArgs e)
        {
            verificarPreenchido();
        }

        private void txtTaxa_Leave(object sender, EventArgs e)
        {
            verificarPreenchido();
        }

        private void txtMulta_Leave(object sender, EventArgs e)
        {
            verificarPreenchido();
        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            verificarPreenchido();
        }

        public void carregaDgParcelas()
        {
            dgParcelas.Rows.Clear();
            dgParcelas.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            var i = 0;
            if (ListaParcelas.Count > 0)
            {
                foreach (Parcelas item in ListaParcelas)
                {
                    i = i + 1;
                    dgParcelas.Rows.Add(i, item.dias, item.percent, item.aForma.forma);
                }
            }
        }
        private void btnAdicionaParc_Click(object sender, EventArgs e)
        {
            Parcelas mParcela = new Parcelas();

            mParcela.dias = Convert.ToInt32(txtDias.Text);
            mParcela.percent = Convert.ToDouble(txtPercent.Text);
            mParcela.aForma.forma = cbFormas.SelectedItem.ToString();
            ListaParcelas.Add(mParcela);

            carregaDgParcelas();

            txtDias.Clear();
            txtPercent.Clear();
            cbFormas.SelectedItem = null;
        }

        public object pegaRegParcela()
        {
            Parcelas mParcela = new Parcelas();

            DataGridViewRow vLinha = dgParcelas.SelectedRows[0];
            mParcela.dias = Convert.ToInt32(vLinha.Cells["dias"].Value);
            mParcela.percent = Convert.ToInt32(vLinha.Cells["percent"].Value);
            mParcela.aForma.forma = Convert.ToString(vLinha.Cells["forma"].Value);

            return mParcela;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Parcelas mParcela = (Parcelas)this.pegaRegParcela();

            ListaParcelas.Remove(mParcela);
            carregaDgParcelas();
        }
    }
}
