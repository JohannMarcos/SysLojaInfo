using MySql.Data.MySqlClient.Authentication;
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
    public partial class frmCadastroEstados : SysLojaInfo.frmCadastro
    {

        private Estados oEst;

        public frmCadastroEstados()
        {
            InitializeComponent();
            oEst = new Estados();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public override void Salvar()
        {
            base.Salvar();
            ctrlEstados aCtrl = new ctrlEstados();
            oEst.estado = txtEstado.Text;
            oEst.uf = txtUF.Text;
            oEst.oPais.Codigo = Convert.ToInt32(txtCodPais.Text);

            if (base.btnSalvar.Text is "Salvar")
            {
                aCtrl.salvar(oEst);
            }
            else if (base.btnSalvar.Text is "Alterar")
            {
                aCtrl.editar(oEst);
            }
            else if (base.btnSalvar.Text is "Excluir")
            {
                aCtrl.deletar(oEst);
            };
            Close();

        }

        public void CarregaCampos(object obj)
        {
            oEst = (Estados)obj;
            this.txtCodigo.Text = oEst.Codigo.ToString();
            this.txtEstado.Text = oEst.estado;
            this.txtUF.Text = oEst.uf;
            this.txtCodPais.Text = oEst.oPais.Codigo.ToString();
            this.txtPais.Text = oEst.oPais.Pais;
            this.txtDatCad.Text = oEst.DatCad.ToString();
            this.txtDatUltAlt.Text = oEst.DatUltAlt.ToString();
            this.txtQuemAlt.Text = oEst.QuemAlter.ToString();
        }

        public void BloqTxt()
        {
            this.txtEstado.Enabled = false;
            this.txtUF.Enabled = false;
            this.btnPesquisa.Enabled = false;

        }

        public void DesbloqTxt()
        {
            this.txtEstado.Enabled = true;
            this.txtUF.Enabled = true;
            this.btnPesquisa.Enabled = true;
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

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            frmConsultaPaises tela = new frmConsultaPaises();
            tela.botao_Selecionar();
            tela.ePai = true;
            tela.ShowDialog();
            Paises mPais = new Paises();

            mPais = (Paises)tela.pegaPaisReg();

            txtCodPais.Text = mPais.Codigo.ToString();
            txtPais.Text = mPais.Pais;
            tela.Close();
        }
    }
}
