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
    public partial class frmConsultaFuncionario : SysLojaInfo.frmConsulta
    {
        private ctrlFuncionarios aCtrl;

        private Funcionarios oFuncionario;

        public bool ePai;
        public frmConsultaFuncionario()
        {
            InitializeComponent();
            aCtrl = new ctrlFuncionarios();
            oFuncionario = new Funcionarios();
            this.PopulaDataGrid();
        }

        public void PopulaDataGrid()
        {
            dgFuncionarios.Rows.Clear();
            dgFuncionarios.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            var lista = aCtrl.SelecionaDS();

            if (lista.Count > 0)
            {
                foreach (Funcionarios item in lista)
                {
                    dgFuncionarios.Rows.Add(item.Codigo, item.nome, item.cpfCnpj, item.rg, item.cnh, item.logr,
                        item.numero, item.natPess, item.bairro, item.oCargo.Codigo, item.oCargo.cargo, item.aCidade.Codigo,
                        item.aCidade.cidade, item.telRes, item.telCel, item.email, item.DatCad, item.DatUltAlt,
                        item.QuemAlter);
                }
            }
        }

        public void pegaRegDataGrid()
        {
            DataGridViewRow vLinha = dgFuncionarios.SelectedRows[0];
            oFuncionario.Codigo = Convert.ToInt32(vLinha.Cells["codigo"].Value);
            oFuncionario.nome = Convert.ToString(vLinha.Cells["nome"].Value);
            oFuncionario.cpfCnpj = Convert.ToString(vLinha.Cells["cpfcnpj"].Value);
            oFuncionario.rg = Convert.ToString(vLinha.Cells["rg"].Value);
            oFuncionario.rg = Convert.ToString(vLinha.Cells["cnh"].Value);
            oFuncionario.logr = Convert.ToString(vLinha.Cells["logr"].Value);
            oFuncionario.numero = Convert.ToInt32(vLinha.Cells["numero"].Value);
            oFuncionario.natPess = Convert.ToString(vLinha.Cells["natpess"].Value);
            oFuncionario.bairro = Convert.ToString(vLinha.Cells["bairro"].Value);
            oFuncionario.oCargo.Codigo = Convert.ToInt32(vLinha.Cells["codcargo"].Value);
            oFuncionario.oCargo.cargo = Convert.ToString(vLinha.Cells["cargo"].Value);
            oFuncionario.aCidade.Codigo = Convert.ToInt32(vLinha.Cells["codcidade"].Value);
            oFuncionario.aCidade.cidade = Convert.ToString(vLinha.Cells["cidade"].Value);
            oFuncionario.telRes = Convert.ToString(vLinha.Cells["telres"].Value);
            oFuncionario.telCel = Convert.ToString(vLinha.Cells["telcel"].Value);
            oFuncionario.email = Convert.ToString(vLinha.Cells["email"].Value);
            oFuncionario.DatCad = Convert.ToDateTime(vLinha.Cells["datcad"].Value);
            oFuncionario.DatUltAlt = Convert.ToDateTime(vLinha.Cells["datalt"].Value);
            oFuncionario.QuemAlter = Convert.ToInt32(vLinha.Cells["iduser"].Value);
        }

        public object pegaFuncionarioReg()
        {
            Funcionarios mFuncionario = new Funcionarios();
            this.pegaRegDataGrid();
            mFuncionario = oFuncionario;
            return mFuncionario;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public override void alterar()
        {
            base.alterar();
            frmCadastroFuncionario tela = new frmCadastroFuncionario();
            this.pegaRegDataGrid();
            tela.CarregaCampos(oFuncionario);
            tela.Botao_alterar();
            tela.Show();
        }

        public override void incluir()
        {
            base.incluir();
            frmCadastroFuncionario tela = new frmCadastroFuncionario();
            tela.Botao_Salvar();
            tela.Show();
        }

        public override void excluir()
        {
            base.excluir();
            frmCadastroFuncionario tela = new frmCadastroFuncionario();
            this.pegaRegDataGrid();
            tela.CarregaCampos(oFuncionario);
            tela.Botao_Excluir();
            tela.Show();
        }

        public override void pesquisar()
        {
            if (this.txtChave.Text is "")
            {
                oFuncionario = new Funcionarios();
                MessageBox.Show("FAVOR INFORME O CÓDIGO OU NOME DE UM FUNCIONÁRIO PARA REALIZAR A BUSCA");
            }
            else
            {
                if (IsInteger(this.txtChave.Text))
                {
                    oFuncionario = aCtrl.buscar(Convert.ToInt32(txtChave.Text));

                }
                else if (temCharEspecial(this.txtChave.Text) is false)
                {
                    oFuncionario = aCtrl.buscar(txtChave.Text);
                }
                else
                {
                    MessageBox.Show("O TEXTO INFORMADO PARA BUSCA NÃO CORRESPONDE AO CODIGO OU NOME DE UM FUNCIONÁRIO!!");
                    oFuncionario = new Funcionarios();
                    this.txtChave.Clear();
                }

                dgFuncionarios.Rows.Clear();
                dgFuncionarios.Rows.Add(oFuncionario.Codigo, oFuncionario.nome, oFuncionario.cpfCnpj, oFuncionario.rg, oFuncionario.cnh, oFuncionario.logr, oFuncionario.numero, oFuncionario.natPess, oFuncionario.bairro, oFuncionario.oCargo.Codigo, oFuncionario.oCargo.cargo, oFuncionario.aCidade.Codigo, oFuncionario.aCidade.cidade, oFuncionario.telRes, oFuncionario.telCel, oFuncionario.email, oFuncionario.DatCad, oFuncionario.DatUltAlt, oFuncionario.QuemAlter);

            }

        }

        private void frmConsultaFuncionario_Activated(object sender, EventArgs e)
        {
            if (this.txtChave.Text is "")
            {
                this.PopulaDataGrid();
            }
        }
    }
}
