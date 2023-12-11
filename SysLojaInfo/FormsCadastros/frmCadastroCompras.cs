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
    public partial class frmCadastroCompras : SysLojaInfo.frmCadastro
    {
        private Compra aCompra;

        private ctrlCondPag aCtrlCondicao;
        public frmCadastroCompras()
        {
            InitializeComponent();
            aCompra = new Compra();
            aCtrlCondicao = new ctrlCondPag();
        }

        public void HabilitaProdutos()
        {
            if (txtCodigo.Text.Length > 0 && txtSerieNota.Text.Length > 0 && txtModeloNota.Text.Length > 0 && txtCodEmitente.Text.Length > 0 && txtEmitente.Text.Length > 0)
            {
                gbProdutos.Enabled = true;
            }
            else
            {
                gbProdutos.Enabled = false;
            }
        }

        public void BloqueiaCabecalho()
        {
            if (dgProd.Rows.Count > 0)
            {
                txtCodigo.Enabled = false;
                txtSerieNota.Enabled = false;
                txtModeloNota.Enabled = false;
                dtChegada.Enabled = false;
                dtEmissao.Enabled = false;
                txtCodEmitente.Enabled = false;
                txtEmitente.Enabled = false;
                lblCodigo.Enabled = false;
                lblSerie.Enabled = false;
                lblModelo.Enabled = false;
                lblDtEmissao.Enabled = false;
                lblDtChegada.Enabled = false;
                btnBuscarEmitente.Enabled = false;
                txtOutros.Enabled = true;
                txtSeguro.Enabled = true;
                txtFrete.Enabled = true;
            }
            else
            {
                txtCodigo.Enabled = true;
                txtSerieNota.Enabled = true;
                txtModeloNota.Enabled = true;
                dtChegada.Enabled = true;
                dtEmissao.Enabled = true;
                txtCodEmitente.Enabled = true;
                txtEmitente.Enabled = true;
                lblCodigo.Enabled = true;
                lblSerie.Enabled = true;
                lblModelo.Enabled = true;
                lblDtEmissao.Enabled = true;
                lblDtChegada.Enabled = true;
                btnBuscarEmitente.Enabled = true;
                txtOutros.Enabled = false;
                txtSeguro.Enabled = false;
                txtFrete.Enabled = false;
            }

        }
        private void frmCadastroCompras_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarEmitente_Click(object sender, EventArgs e)
        {

            frmConsultaFornecedor tela = new frmConsultaFornecedor();
            tela.botao_Selecionar();
            tela.ePai = true;
            tela.ShowDialog();

            Fornecedores mFornecedor = new Fornecedores();

            mFornecedor = (Fornecedores)tela.pegaFornecReg();

            txtCodEmitente.Text = mFornecedor.Codigo.ToString();
            txtEmitente.Text = mFornecedor.nome;

            txtCodCond.Text = mFornecedor.aCond.Codigo.ToString();
            txtCondicaoPag.Text = mFornecedor.aCond.condicao;
            tela.Close();

            this.validaPk();

        }

        private void btnPesqProd_Click(object sender, EventArgs e)
        {
            frmConsultaProdutos tela = new frmConsultaProdutos();
            tela.botao_Selecionar();
            tela.ePai = true;
            tela.ShowDialog();

            Produtos mProduto = new Produtos();
            mProduto = (Produtos)tela.pegaProdutoReg();

            txtCodProd.Text = mProduto.Codigo.ToString();
            txtProduto.Text = mProduto.produto;
            txtUnidMed.Text = mProduto.aMedida.uMedida;

            tela.Close();
        }

        public void CarregaDGProdutos()
        {
            double mTotalProd = 0;
            double mTotalDesc = 0;
            dgProd.Rows.Clear();
            dgProd.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            foreach (itemsCompras item in aCompra.itemsNota)
            {
                dgProd.Rows.Add(item.oProduto.Codigo.ToString(), item.oProduto.produto, item.oProduto.aMedida.uMedida, item.qtd, item.precoUnit, item.descUnit, item.totalProd);
                mTotalProd = mTotalProd + (item.precoUnit * item.qtd);
                mTotalDesc = mTotalDesc + (item.descUnit * item.qtd);
            }

            txtValorBruto.Text = "R$ " + mTotalProd.ToString();
            txtDescontos.Text = "R$ " + mTotalDesc.ToString();
            txtValorTotal.Text = "R$ " + (mTotalProd - mTotalDesc).ToString();
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {

            itemsCompras mItemCompra = new itemsCompras();

            bool mAchou = false;

            mItemCompra.oProduto.Codigo = Convert.ToInt32(txtCodProd.Text);

            foreach (itemsCompras item in aCompra.itemsNota)
            {
                if (item.oProduto.Codigo == mItemCompra.oProduto.Codigo)
                {
                    mAchou = true;
                }
            }

            if (mAchou == false)
            {
                mItemCompra.oProduto.produto = txtProduto.Text;
                mItemCompra.oProduto.aMedida.uMedida = txtUnidMed.Text;
                mItemCompra.qtd = Convert.ToInt32(txtQtd.Text);
                mItemCompra.precoUnit = Convert.ToDouble(txtPreço.Text);
                mItemCompra.descUnit = Convert.ToDouble(txtDesc.Text);
                mItemCompra.descPercent = Convert.ToDouble(txtDescPercent.Text);
                mItemCompra.totalProd = (mItemCompra.precoUnit - mItemCompra.descUnit) * mItemCompra.qtd;

                aCompra.itemsNota.Add(mItemCompra);

                CarregaDGProdutos();
            }
            else
            {
                MessageBox.Show("Produto ja inserido na Grid");
            }

            txtCodProd.Clear();
            txtProduto.Clear();
            txtUnidMed.Clear();
            txtQtd.Clear();
            txtPreço.Clear();
            txtDesc.Clear();
            txtDescPercent.Clear();

        }

        private void txtEmitente_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgProd_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            BloqueiaCabecalho();
        }

        private void dgProd_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            BloqueiaCabecalho();
        }

        private void txtDesc_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(txtDesc.Text, out double resultado))
            {
                if (Convert.ToDouble(txtDesc.Text) >= 0)
                {
                    double mValor = ((Convert.ToDouble(txtDesc.Text) / Convert.ToDouble(txtPreço.Text)) * 100);
                    txtDescPercent.Text = string.Format("{0:0.00}", mValor);
                    txtDescPercent.Enabled = false;
                    if (Convert.ToDouble(txtDesc.Text) == 0)
                    {
                        txtDescPercent.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("O valor informado nao pode ser negativo");
                }
            }
            else
            {
                MessageBox.Show("o Valor informado não é valido");
                txtDesc.Focus();
            }

        }

        private void txtDescPercent_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(txtDescPercent.Text, out double resultado))
            {
                txtDescPercent.Text = ((Convert.ToDouble(txtDescPercent.Text) / Convert.ToDouble(txtPreço.Text)) * 100).ToString();
            }
            else
            {
                MessageBox.Show("o Valor informado não é valido");
                txtDescPercent.Focus();
            }
        }
        public void CalcParcelas()
        {
            aCompra.duplicatasNota.Clear();
            List<Parcelas> listaParcelas = new List<Parcelas>();
            DateTime mDate = new DateTime();
            double mTotalNota = Convert.ToDouble(txtValorTotal.Text.Replace("R$", ""));
            double mRestante = mTotalNota;
            listaParcelas = aCtrlCondicao.BuscaParc(Convert.ToInt32(txtCodCond.Text));


            foreach (Parcelas item in listaParcelas)
            {
                duplicata mDuplicata = new duplicata();
                mDuplicata.nParcela = item.nParcela;
                mDuplicata.Vencimento = dtEmissao.Value.Date.AddDays(item.dias);

                if (item.nParcela <= listaParcelas.Count - 1)
                {
                    mDuplicata.Saldo = (item.percent / 100) * mTotalNota;

                    mRestante = mRestante - mDuplicata.Saldo;

                }
                else
                {
                    mDuplicata.Saldo = mRestante;
                }
                aCompra.duplicatasNota.Add(mDuplicata);
            }
            CarregaDGDuplicatas();
        }

        public void CarregaDGDuplicatas()
        {
            dgDuplicatas.Rows.Clear();
            dgDuplicatas.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            foreach (duplicata item in aCompra.duplicatasNota)
            {
                dgDuplicatas.Rows.Add(item.nParcela, item.Vencimento, item.Saldo);
            }
        }

        private void txtFrete_TextChanged(object sender, EventArgs e)
        {
            if (!txtFrete.Text.StartsWith("R$ "))
            {
                // Remove o manipulador de evento temporariamente para evitar recursão infinita
                txtFrete.TextChanged -= txtFrete_TextChanged;

                //limpa o campo
                txtFrete.Clear();
                // Atualiza o texto adicionando "R$ " no início
                txtFrete.Text = "R$ " + txtFrete.Text;

                // Move o cursor para o final do texto
                txtFrete.SelectionStart = txtFrete.Text.Length;

                //Restaura o manipuladori do evento
                txtFrete.TextChanged += txtFrete_TextChanged;
            }
        }

        private void txtSeguro_TextChanged(object sender, EventArgs e)
        {
            if (!txtSeguro.Text.StartsWith("R$ "))
            {
                // Remove o manipulador de evento temporariamente para evitar recursão infinita
                txtSeguro.TextChanged -= txtSeguro_TextChanged;

                //limpa o campo
                txtSeguro.Clear();
                // Atualiza o texto adicionando "R$ " no início
                txtSeguro.Text = "R$ " + txtSeguro.Text;

                // Move o cursor para o final do texto
                txtSeguro.SelectionStart = txtSeguro.Text.Length;

                //Restaura o manipuladori do evento
                txtSeguro.TextChanged += txtSeguro_TextChanged;
            }
        }

        private void txtSeguro_Leave(object sender, EventArgs e)
        {
            double mTotalNota = Convert.ToDouble(txtValorTotal.Text.Replace("R$", ""));

            mTotalNota = mTotalNota + Convert.ToDouble(txtSeguro.Text.Replace("R$ ", ""));

            txtValorTotal.Text = mTotalNota.ToString();

            if (txtFrete.Text.Length > 3 && txtOutros.Text.Length > 3 && txtSeguro.Text.Length > 3)
            {
                gbProdutos.Enabled = false;
                gbPagamento.Enabled = true;
            }
            else
            {
                gbProdutos.Enabled = true;
                gbPagamento.Enabled = false;
            }
        }

        private void txtFrete_Leave(object sender, EventArgs e)
        {
            double mTotalNota = Convert.ToDouble(txtValorTotal.Text.Replace("R$", ""));

            mTotalNota = mTotalNota + Convert.ToDouble(txtFrete.Text.Replace("R$ ", ""));

            txtValorTotal.Text = mTotalNota.ToString();

            if (txtFrete.Text.Length > 3 && txtOutros.Text.Length > 3 && txtSeguro.Text.Length > 3)
            {
                gbProdutos.Enabled = false;
                gbPagamento.Enabled = true;
            }
            else
            {
                gbProdutos.Enabled = true;
                gbPagamento.Enabled = false;
            }
        }

        private void txtOutros_Leave(object sender, EventArgs e)
        {
            double mTotalNota = Convert.ToDouble(txtValorTotal.Text.Replace("R$", ""));

            mTotalNota = mTotalNota + Convert.ToDouble(txtOutros.Text.Replace("R$ ", ""));

            txtValorTotal.Text = mTotalNota.ToString();

            if (txtFrete.Text.Length > 3 && txtOutros.Text.Length > 3 && txtSeguro.Text.Length > 3)
            {
                gbProdutos.Enabled = false;
                gbPagamento.Enabled = true;
            }
            else
            {
                gbProdutos.Enabled = true;
                gbPagamento.Enabled = false;
            }
        }

        private void txtValorTotal_TextChanged(object sender, EventArgs e)
        {
            CalcParcelas();
        }

        private void txtOutros_TextChanged(object sender, EventArgs e)
        {
            if (!txtOutros.Text.StartsWith("R$ "))
            {
                // Remove o manipulador de evento temporariamente para evitar recursão infinita
                txtOutros.TextChanged -= txtOutros_TextChanged;

                //limpa o campo
                txtOutros.Clear();
                // Atualiza o texto adicionando "R$ " no início
                txtOutros.Text = "R$ " + txtOutros.Text;

                // Move o cursor para o final do texto
                txtOutros.SelectionStart = txtOutros.Text.Length;

                //Restaura o manipuladori do evento
                txtOutros.TextChanged += txtOutros_TextChanged;
            }
        }

        public void validaPk()
        {
            aCompra.nNota = Convert.ToInt32(txtCodigo.Text);
            aCompra.SerieNota = txtSerieNota.Text;
            aCompra.ModeloNota = txtModeloNota.Text;
            aCompra.oFornecedor.Codigo = Convert.ToInt32(txtCodEmitente.Text);

            ctrlCompras aCtrl = new ctrlCompras();

            if (aCtrl.ValidaChaveNota(aCompra) == false)
            {
                dtEmissao.Enabled = true;
            }
            else
            {
                MessageBox.Show("Impossivel prosseguir, ja existe registro para NF nº" + txtCodigo.Text + " Serie: " + txtSerieNota.Text + " Modelo: " + txtModeloNota.Text + " Emitente: " + txtEmitente.Text);
            }

        }

        private void txtPreço_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(txtPreço.Text, out double resultado))
            {
                if (TentarConverterEVerificar(Convert.ToInt32(txtPreço.Text), out int valorInt))
                {
                    if (valorInt < 0)
                    {
                        MessageBox.Show("O valor informado não é válido");
                        txtPreço.Clear();
                        txtPreço.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("o Valor informado não é valido");
                txtPreço.Focus();
            }
        }

        public override void Salvar()
        {
            ctrlCompras aCtrlCompras = new ctrlCompras();

            if (aCompra.duplicatasNota.Count > 0)
            {
                aCompra.nNota = Convert.ToInt32(txtCodigo.Text);
                aCompra.SerieNota = txtSerieNota.Text;
                aCompra.ModeloNota = txtModeloNota.Text;
                aCompra.dtEmissao = Convert.ToDateTime(dtEmissao.Value.Date);
                aCompra.dtChegada = Convert.ToDateTime(dtChegada.Value.Date);
                aCompra.oFornecedor.Codigo = Convert.ToInt32(txtCodEmitente.Text);
                aCompra.valorBrutoItens = Convert.ToDouble(txtValorBruto.Text.Replace("R$ ", ""));
                aCompra.DescTotalItens = Convert.ToDouble(txtDescontos.Text.Replace("R$ ", ""));
                aCompra.valorFrete = Convert.ToDouble(txtFrete.Text.Replace("R$ ", ""));
                aCompra.valorSeguro = Convert.ToDouble(txtSeguro.Text.Replace("R$ ", ""));
                aCompra.ValorOutros = Convert.ToDouble(txtOutros.Text.Replace("R$ ", ""));
                aCompra.totalNota = Convert.ToDouble(txtValorTotal.Text.Replace("R$ ", ""));

                aCtrlCompras.salvar(aCompra);

                Close();
            }
            else
            {
                MessageBox.Show("Lançamento incompleto, Por favor revise o Lançamento.");
            }
        }

        private void dtEmissao_Leave(object sender, EventArgs e)
        {
            DateTime hoje = DateTime.Now.Date;
            if (dtEmissao.Value.Date <= hoje)
            {
                dtChegada.Enabled = true;
            }
            else
            {
                MessageBox.Show("Data de Emissão não pode ser maior do que hoje.");
                dtEmissao.Focus();
            }

        }

        private void dtChegada_Leave(object sender, EventArgs e)
        {
            DateTime hoje = DateTime.Now.Date;
            if (dtChegada.Value.Date <= hoje)
            {
                if (dtEmissao.Value.Date <= dtChegada.Value.Date)
                {
                    HabilitaProdutos();
                }
                else
                {
                    MessageBox.Show("Data de Emissão não pode ser maior do que data de chegada.");
                }
            }
            else
            {
                MessageBox.Show("Data de chegada não pode ser maior do que Hoje");
                dtChegada.Focus();
            }
        }

        private void txtCodEmitente_Leave(object sender, EventArgs e)
        {
            if (txtCodEmitente.Text.Length > 0)
            {
                if (IsInteger(txtCodEmitente.Text))
                {
                    if (TentarConverterEVerificar(Convert.ToInt32(txtCodEmitente.Text), out int valorInt))
                    {
                        if (valorInt < 0)
                        {
                            MessageBox.Show("O valor informado não é válido");
                            txtCodigo.Clear();
                            txtCodigo.Focus();
                        }
                        else
                        {
                            ctrlFornecedores aCtrlFornecedor = new ctrlFornecedores();
                            aCompra.oFornecedor = aCtrlFornecedor.buscar(Convert.ToInt32(txtCodEmitente.Text));

                            if (aCompra.oFornecedor != null)
                            {
                                txtEmitente.Text = aCompra.oFornecedor.nome;
                                txtCodCond.Text = aCompra.oFornecedor.aCond.Codigo.ToString();
                                txtCondicaoPag.Text = aCompra.oFornecedor.aCond.condicao;
                            }

                            this.validaPk();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Valor informado não é válido.");
                    txtCodigo.Clear();
                    txtCodigo.Focus();
                }
            }
            else
            {
                MessageBox.Show("Campo não pode estar em branco.");
                txtCodigo.Clear();
                txtCodigo.Focus();
            }
        }

        private void btnBuscaCond_Click(object sender, EventArgs e)
        {
            frmConsultaCondPag tela = new frmConsultaCondPag();
            tela.botao_Selecionar();
            tela.ePai = true;
            tela.ShowDialog();

            aCompra.oFornecedor.aCond = (CondicoesPag)tela.pegaCondReg();

            txtCodCond.Text = aCompra.oFornecedor.aCond.Codigo.ToString();
            txtCondicaoPag.Text = aCompra.oFornecedor.aCond.condicao;

            tela.Close();

            CalcParcelas();
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length > 0)
            {
                if (IsInteger(txtCodigo.Text))
                {
                    if (TentarConverterEVerificar(Convert.ToInt32(txtCodigo.Text), out int valorInt))
                    {
                        if (valorInt < 0)
                        {
                            MessageBox.Show("O valor informado não é válido");
                            txtCodigo.Clear();
                            txtCodigo.Focus();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Valor informado´não é válido.");
                    txtCodigo.Clear();
                    txtCodigo.Focus();
                }
            }
            else
            {
                MessageBox.Show("Campo não pode estar em branco.");
                txtCodigo.Clear();
                txtCodigo.Focus();
            }

        }

        private void txtQtd_Leave(object sender, EventArgs e)
        {

        }
    }
}
