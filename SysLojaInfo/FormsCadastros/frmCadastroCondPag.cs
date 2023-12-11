using MySqlX.XDevAPI;
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
    public partial class frmCadastroCondPag : SysLojaInfo.frmCadastro
    {
        private ctrlFormas aCtrlForma;

        private ctrlCondPag aCtrlCond;

        private List<Parcelas> ListaParcelas;

        private CondicoesPag aCond;

        private double restante;
        public frmCadastroCondPag()
        {
            InitializeComponent();
            ListaParcelas = new List<Parcelas>();
            aCtrlForma = new ctrlFormas();
            aCond = new CondicoesPag();
            aCtrlCond = new ctrlCondPag();
            var lista = aCtrlForma.SelecionaDS();
            restante = 100;

            foreach (FormasPag item in lista)
            {
                cbFormas.Items.Add(item.forma);
            }
        }
        public void CarregaCampos(object obj)
        {
            aCond = (CondicoesPag)obj;
            this.txtCodigo.Text = aCond.Codigo.ToString();
            this.txtCond.Text = aCond.condicao;
            this.txtTaxa.Text = aCond.taxa.ToString();
            this.txtMulta.Text = aCond.multa.ToString();
            this.txtDesconto.Text = aCond.desconto.ToString();
            this.txtDatCad.Text = aCond.DatCad.ToString();
            this.txtDatUltAlt.Text = aCond.DatUltAlt.ToString();
            this.txtQuemAlt.Text = aCond.QuemAlter.ToString();


            ListaParcelas = aCtrlCond.BuscaParc(aCond.Codigo);

            manipulalista();
            carregaDgParcelas();

            verificarPreenchido();

        }

        public void verificarPreenchido()
        {
            if (btnSalvar.Text == "Salvar")
            {
                if (txtCond.Text.Length > 0 && txtTaxa.Text.Length > 0 && txtMulta.Text.Length > 0 && txtDesconto.Text.Length > 0)
                {
                    gbParcelas.Enabled = true;
                     dgParcelas.Enabled = true;
                    if (dgParcelas.Rows.Count != 0)
                    {
                        txtCond.Enabled = false;
                        txtTaxa.Enabled = false;
                        txtMulta.Enabled = false;
                        txtDesconto.Enabled = false;
                        if (restante == 0)
                        {
                            this.txtDias.Enabled = false;
                            this.txtPercent.Enabled = false;
                            this.cbFormas.Enabled = false;
                            this.btnAdicionaParc.Enabled = false;
                            btnSalvar.Enabled = true;
                        }
                        else
                        {
                            this.txtDias.Enabled = true;
                            this.txtPercent.Enabled = true;
                            this.cbFormas.Enabled = true;
                            this.btnAdicionaParc.Enabled = true;
                            btnSalvar.Enabled = false;
                        }
                    }
                    else
                    {
                        txtCond.Enabled = true;
                        txtTaxa.Enabled = true;
                        txtMulta.Enabled = true;
                        txtDesconto.Enabled = true;
                        btnSalvar.Enabled = false;
                    }
                }
                else
                {
                    gbParcelas.Enabled = false;
                    dgParcelas.Enabled = false;
                }
            }
            else if (btnSalvar.Text == "Alterar")
            {
                if (txtCond.Text.Length > 0 && txtTaxa.Text.Length > 0 && txtMulta.Text.Length > 0 && txtDesconto.Text.Length > 0)
                {
                    gbParcelas.Enabled = true;
                    dgParcelas.Enabled = true;
                    if (dgParcelas.Rows.Count != 0)
                    {
                        txtCond.Enabled = false;
                        txtTaxa.Enabled = false;
                        txtMulta.Enabled = false;
                        txtDesconto.Enabled = false;
                        if (restante == 0)
                        {
                            this.txtDias.Enabled = false;
                            this.txtPercent.Enabled = false;
                            this.cbFormas.Enabled = false;
                            this.btnAdicionaParc.Enabled = false;
                            btnSalvar.Enabled = true;
                        }
                        else
                        {
                            this.txtDias.Enabled = true;
                            this.txtPercent.Enabled = true;
                            this.cbFormas.Enabled = true;
                            this.btnAdicionaParc.Enabled = true;
                            btnSalvar.Enabled = false;
                        }
                    }
                    else
                    {
                        txtCond.Enabled = true;
                        txtTaxa.Enabled = true;
                        txtMulta.Enabled = true;
                        txtDesconto.Enabled = true;
                        btnSalvar.Enabled = false;
                    }
                }
                else
                {
                    gbParcelas.Enabled = false;
                    dgParcelas.Enabled = false;
                }
                btnRemove.Enabled = true;
                dgParcelas.Enabled = true;
            }
            else if (btnSalvar.Text == "Excluir")
            {
                btnSalvar.Enabled = true;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (dgParcelas.Rows.Count > 0)
            {
                txtCond.Enabled = false;
                txtTaxa.Enabled = false;
                txtMulta.Enabled = false;
                txtDesconto.Enabled = false;
            }
            this.lblParamRest.Text = restante.ToString() + "%";


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
            double total = 0;
            if (ListaParcelas.Count > 0)
            {
                foreach (Parcelas item in ListaParcelas)
                {
                    i = i + 1;
                    dgParcelas.Rows.Add(item.nParcela, item.dias, item.percent, item.aForma.forma);
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

            manipulalista();

            carregaDgParcelas();

            txtDias.Clear();
            txtPercent.Clear();
            cbFormas.SelectedItem = null;
            this.verificarPreenchido();
        }

        public void manipulalista()
        {
            List<Parcelas> mList = new List<Parcelas>();

            var i = 0;
            restante = 100;
            double total = 0;

            foreach (Parcelas item in ListaParcelas)
            {
                i = i + 1;
                total = total + item.percent;
                item.nParcela = i;
                mList.Add(item);
            }

            restante = restante - total;

            ListaParcelas = mList;
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
            foreach (Parcelas item in ListaParcelas)
            {
                if (mParcela.dias == item.dias && mParcela.percent == item.percent && mParcela.aForma.forma == item.aForma.forma)
                {
                    mParcela = item;
                }
            }
            ListaParcelas.Remove(mParcela);
            manipulalista();
            carregaDgParcelas();

            this.verificarPreenchido();
        }
        public override void Salvar()
        {
            aCond.condicao = txtCond.Text;
            aCond.multa = Convert.ToDouble(txtMulta.Text);
            aCond.taxa = Convert.ToDouble(txtTaxa.Text);
            aCond.desconto = Convert.ToDouble((txtDesconto.Text));
            aCond.ListaParc = ListaParcelas;
            if (btnSalvar.Text == "Salvar")
            {
                aCtrlCond.salvar(aCond);
            }else if (btnSalvar.Text == "Alterar")
            {
                aCtrlCond.editar(aCond);
            }else if (btnSalvar.Text == "Excluir")
            {
                aCtrlCond.excluir(aCond);
            }
            Close();
        }

        private void txtPercent_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPercent_Leave(object sender, EventArgs e)
        {
            if (txtPercent.Text.Length > 0)
            {
                if (IsInteger(txtPercent.Text))
                {
                    if (TentarConverterEVerificar(Convert.ToInt32(txtPercent.Text), out int valorInt))
                    {
                        if (valorInt < 0)
                        {
                            MessageBox.Show("O valor informado não é válido");
                            txtPercent.Clear();
                            txtPercent.Focus();
                        }
                        else
                        {
                            double mtotal = Convert.ToDouble(txtPercent.Text);
                            if (mtotal > restante)
                            {
                                MessageBox.Show("Valor Informado é maior que o permitido, altere o valor para liberar o botão.");
                                btnAdicionaParc.Enabled = false;
                            }
                            else
                            {
                                btnAdicionaParc.Enabled = true;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Valor informado´não é válido.");
                    txtPercent.Clear();
                    txtPercent.Focus();
                }
            }
            else
            {
                MessageBox.Show("Campo não pode estar em branco.");
                txtPercent.Clear();
                txtPercent.Focus();
            }
            
        }

        private void dgParcelas_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            /*this.verificarPreenchido();*/
            this.lblParamRest.Text = restante.ToString() + "%";
        }

        private void dgParcelas_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            /*this.verificarPreenchido();*/
            this.lblParamRest.Text = restante.ToString() + "%";
        }

        private void dgParcelas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // this.verificarPreenchido();
        }

        /*private void frmCadastroCondPag_Paint(object sender, PaintEventArgs e)
        {
            this.verificarPreenchido();
        }*/
    }
}
