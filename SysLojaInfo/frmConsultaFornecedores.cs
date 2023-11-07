using MySqlX.XDevAPI;
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
    public partial class frmConsultaFornecedor : SysLojaInfo.frmConsulta
    {
        private ctrlFornecedores aCtrl;

        private Fornecedores oFornecedor;

        public bool ePai;
        public frmConsultaFornecedor()
        {
            InitializeComponent();
            aCtrl = new ctrlFornecedores();
            oFornecedor = new Fornecedores();
            this.PopulaDataGrid();
        }

        public void PopulaDataGrid()
        {
            dgFornecedores.Rows.Clear();
            dgFornecedores.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;

            var lista = aCtrl.SelecionaDS();

            if (lista.Count > 0)
            {
                foreach (Fornecedores item in lista)
                {
                    dgFornecedores.Rows.Add(item.Codigo, item.nome, item.cpfCnpj, item.rg, item.logr, item.numero, item.natPess, item.bairro, item.aCidade.Codigo, item.aCidade.cidade, item.telRes, item.telCel, item.email, item.DatCad, item.DatUltAlt, item.QuemAlter);
                }
            }
        }

        public void pegaRegDataGrid()
        {
            DataGridViewRow vLinha = dgFornecedores.SelectedRows[0];
            oFornecedor.Codigo = Convert.ToInt32(vLinha.Cells["codigo"].Value);
            oFornecedor.nome = Convert.ToString(vLinha.Cells["nome"].Value);
            oFornecedor.cpfCnpj = Convert.ToString(vLinha.Cells["cpfcnpj"].Value);
            oFornecedor.rg = Convert.ToString(vLinha.Cells["rg"].Value);
            oFornecedor.logr = Convert.ToString(vLinha.Cells["logr"].Value);
            oFornecedor.numero = Convert.ToInt32(vLinha.Cells["numero"].Value);
            oFornecedor.natPess = Convert.ToString(vLinha.Cells["natpess"].Value);
            oFornecedor.bairro = Convert.ToString(vLinha.Cells["bairro"].Value);
            oFornecedor.aCidade.Codigo = Convert.ToInt32(vLinha.Cells["codcidade"].Value);
            oFornecedor.aCidade.cidade = Convert.ToString(vLinha.Cells["cidade"].Value);
            oFornecedor.telRes = Convert.ToString(vLinha.Cells["telres"].Value);
            oFornecedor.telCel = Convert.ToString(vLinha.Cells["telcel"].Value);
            oFornecedor.email = Convert.ToString(vLinha.Cells["email"].Value);
            oFornecedor.DatCad = Convert.ToDateTime(vLinha.Cells["datcad"].Value);
            oFornecedor.DatUltAlt = Convert.ToDateTime(vLinha.Cells["datalt"].Value);
            oFornecedor.QuemAlter = Convert.ToInt32(vLinha.Cells["iduser"].Value);
        }

        public object pegaClienteReg()
        {
            Fornecedores mFornecedor = new Fornecedores();
            this.pegaRegDataGrid();
            mFornecedor = oFornecedor;
            return mFornecedor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public override void alterar()
        {
            base.alterar();
            frmCadastroFornecedores tela = new frmCadastroFornecedores();
            this.pegaRegDataGrid();
            tela.CarregaCampos(oFornecedor);
            tela.Botao_alterar();
            tela.Show();
        }

        public override void incluir()
        {
            base.incluir();
            frmCadastroFornecedores tela = new frmCadastroFornecedores();
            tela.Botao_Salvar();
            tela.Show();
        }

        public override void excluir()
        {
            base.excluir();
            frmCadastroFornecedores tela = new frmCadastroFornecedores();
            this.pegaRegDataGrid();
            tela.CarregaCampos(oFornecedor);
            tela.Botao_Excluir();
            tela.Show();
        }

        public override void pesquisar()
        {
            if (this.txtChave.Text is "")
            {
                oFornecedor = new Fornecedores();
                MessageBox.Show("FAVOR INFORME O CÓDIGO OU NOME DE UM FORNECEDOR PARA REALIZAR A BUSCA");
            }
            else
            {
                if (IsInteger(this.txtChave.Text))
                {
                    oFornecedor = aCtrl.buscar(Convert.ToInt32(txtChave.Text));

                }
                else if (temCharEspecial(this.txtChave.Text) is false)
                {
                    oFornecedor = aCtrl.buscar(txtChave.Text);
                }
                else
                {
                    MessageBox.Show("O TEXTO INFORMADO PARA BUSCA NÃO CORRESPONDE AO CODIGO OU NOME DE UM FORNECEDOR!!");
                    oFornecedor = new Fornecedores();
                    this.txtChave.Clear();
                }

                dgFornecedores.Rows.Clear();
                dgFornecedores.Rows.Add(oFornecedor.Codigo, oFornecedor.nome, oFornecedor.cpfCnpj, oFornecedor.rg, oFornecedor.logr, oFornecedor.numero, oFornecedor.natPess, oFornecedor.bairro, oFornecedor.aCidade.Codigo, oFornecedor.aCidade.cidade, oFornecedor.telRes, oFornecedor.telCel, oFornecedor.email, oFornecedor.DatCad, oFornecedor.DatUltAlt, oFornecedor.QuemAlter);

            }

        }

        private void frmConsultaFornecedor_Activated(object sender, EventArgs e)
        {
            if (this.txtChave.Text is "")
            {
                this.PopulaDataGrid();
            }
        }
    }
}
