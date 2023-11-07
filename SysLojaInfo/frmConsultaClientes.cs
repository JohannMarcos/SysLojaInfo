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
    public partial class frmConsultaClientes : SysLojaInfo.frmConsulta
    {
        private ctrlClientes aCtrl;

        private Clientes oCliente;

        public bool ePai;
        public frmConsultaClientes()
        {
            InitializeComponent();
            aCtrl = new ctrlClientes();
            oCliente = new Clientes();
            this.PopulaDataGrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void PopulaDataGrid()
        {
            dgClientes.Rows.Clear();
            dgClientes.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;

            var lista = aCtrl.SelecionaDS();

            if (lista.Count > 0)
            {
                foreach (Clientes item in lista)
                {
                    dgClientes.Rows.Add(item.Codigo, item.nome, item.cpfCnpj, item.rg, item.logr, item.numero, item.natPess, item.bairro, item.limCred, item.aCidade.Codigo, item.aCidade.cidade, item.telRes, item.telCel, item.email, item.DatCad, item.DatUltAlt, item.QuemAlter);
                }
            }
        }

        public void pegaRegDataGrid()
        {
            DataGridViewRow vLinha = dgClientes.SelectedRows[0];
            oCliente.Codigo = Convert.ToInt32(vLinha.Cells["codigo"].Value);
            oCliente.nome = Convert.ToString(vLinha.Cells["nome"].Value);
            oCliente.cpfCnpj = Convert.ToString(vLinha.Cells["cpfcnpj"].Value);
            oCliente.rg = Convert.ToString(vLinha.Cells["rg"].Value);
            oCliente.logr = Convert.ToString(vLinha.Cells["logr"].Value);
            oCliente.numero = Convert.ToInt32(vLinha.Cells["num"].Value);
            oCliente.natPess = Convert.ToString(vLinha.Cells["natpess"].Value);
            oCliente.bairro = Convert.ToString(vLinha.Cells["bairro"].Value);
            oCliente.limCred = Convert.ToDouble(vLinha.Cells["limcred"].Value);
            oCliente.aCidade.Codigo = Convert.ToInt32(vLinha.Cells["codcidade"].Value);
            oCliente.aCidade.cidade = Convert.ToString(vLinha.Cells["cidade"].Value);
            oCliente.telRes = Convert.ToString(vLinha.Cells["telres"].Value);
            oCliente.telCel = Convert.ToString(vLinha.Cells["telcel"].Value);
            oCliente.email = Convert.ToString(vLinha.Cells["email"].Value);
            oCliente.DatCad = Convert.ToDateTime(vLinha.Cells["datcad"].Value);
            oCliente.DatUltAlt = Convert.ToDateTime(vLinha.Cells["datalt"].Value);
            oCliente.QuemAlter = Convert.ToInt32(vLinha.Cells["iduser"].Value);
        }

        public object pegaClienteReg()
        {
            Clientes mCliente = new Clientes();
            this.pegaRegDataGrid();
            mCliente = oCliente;
            return mCliente;
        }

        public override void alterar()
        {
            base.alterar();
            frmCadastroClientes tela = new frmCadastroClientes();
            this.pegaRegDataGrid();
            tela.CarregaCampos(oCliente);
            tela.Botao_alterar();
            tela.Show();
        }

        public override void incluir()
        {
            base.incluir();
            frmCadastroClientes tela = new frmCadastroClientes();
            tela.Botao_Salvar();
            tela.Show();
        }

        public override void excluir()
        {
            base.excluir();
            frmCadastroClientes tela = new frmCadastroClientes();
            this.pegaRegDataGrid();
            tela.CarregaCampos(oCliente);
            tela.Botao_Excluir();
            tela.Show();

        }
        public override void pesquisar()
        {
            if (this.txtChave.Text is "")
            {
                oCliente = new Clientes();
                MessageBox.Show("FAVOR INFORME O CÓDIGO OU NOME DE UM CLIENTE PARA REALIZAR A BUSCA");
            }
            else
            {
                if (IsInteger(this.txtChave.Text))
                {
                    oCliente = aCtrl.buscar(Convert.ToInt32(txtChave.Text));

                }
                else if (temCharEspecial(this.txtChave.Text) is false)
                {
                    oCliente = aCtrl.buscar(txtChave.Text);
                }
                else
                {
                    MessageBox.Show("O TEXTO INFORMADO PARA BUSCA NÃO CORRESPONDE AO CODIGO OU NOME DE UM CLIENTE!!");
                    oCliente = new Clientes();
                    this.txtChave.Clear();
                }

                dgClientes.Rows.Clear();
                dgClientes.Rows.Add(oCliente.Codigo, oCliente.nome, oCliente.cpfCnpj, oCliente.rg, oCliente.logr, oCliente.numero, oCliente.natPess, oCliente.bairro, oCliente.limCred, oCliente.aCidade.Codigo, oCliente.aCidade.cidade, oCliente.telRes, oCliente.telCel, oCliente.email, oCliente.DatCad, oCliente.DatUltAlt, oCliente.QuemAlter);

            }

        }

        private void frmConsultaClientes_Activated(object sender, EventArgs e)
        {
            if (this.txtChave.Text is "")
            {
                this.PopulaDataGrid();
            }
        }
    }
}
