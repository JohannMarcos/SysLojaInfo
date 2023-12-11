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
    public partial class frmCadastroCidades : SysLojaInfo.frmCadastro
    {
        private Cidades aCidade;
        public frmCadastroCidades()
        {
            InitializeComponent();
            aCidade = new Cidades();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public override void Salvar()
        {
            base.Salvar();
            ctrlCidades aCtrl = new ctrlCidades();
            aCidade.cidade = txtCidade.Text;
            aCidade.DDD = txtDDD.Text;
            aCidade.oEstado.Codigo = Convert.ToInt32(txtCodEstado.Text);

            if (base.btnSalvar.Text is "Salvar")
            {
                aCtrl.salvar(aCidade);
            }
            else if (base.btnSalvar.Text is "Alterar")
            {
                aCtrl.editar(aCidade);
            }
            else if (base.btnSalvar.Text is "Excluir")
            {
                aCtrl.deletar(aCidade);
            };
            Close();

        }
        public void CarregaCampos(object obj)
        {
            aCidade = (Cidades)obj;
            this.txtCodigo.Text = aCidade.Codigo.ToString();
            this.txtCidade.Text = aCidade.cidade;
            this.txtDDD.Text = aCidade.DDD;
            this.txtCodEstado.Text = aCidade.oEstado.Codigo.ToString();
            this.txtEstado.Text = aCidade.oEstado.estado;
            this.txtDatCad.Text = aCidade.DatCad.ToString();
            this.txtDatUltAlt.Text = aCidade.DatUltAlt.ToString();
            this.txtQuemAlt.Text = aCidade.QuemAlter.ToString();
        }

        public void BloqTxt()
        {
            this.txtCidade.Enabled = false;
            this.txtDDD.Enabled = false;
            this.btnProcuraEstado.Enabled = false;
        }

        public void DesbloqTxt()
        {
            this.txtCidade.Enabled = true;
            this.txtDDD.Enabled = true;
            this.btnProcuraEstado.Enabled = true;
        }
        public override void Botao_Salvar()
        {
            base.Botao_Salvar();
            this.DesbloqTxt();
        }

        public override void Botao_alterar()
        {
            base.Botao_alterar();
            this.DesbloqTxt();
            
        }

        public override void Botao_Excluir()
        {
            base.Botao_Excluir();
            this.BloqTxt();
        }

        private void btnProcuraEstado_Click(object sender, EventArgs e)
        {
            frmConsultaEstados tela = new frmConsultaEstados();
            tela.botao_Selecionar();
            tela.ePai = true;
            tela.ShowDialog();

            Estados mEstado = new Estados();

            mEstado = (Estados)tela.pegaEstReg();

            txtCodEstado.Text = mEstado.Codigo.ToString();
            txtEstado.Text = mEstado.estado;
            tela.Close();
        }

    }
}
