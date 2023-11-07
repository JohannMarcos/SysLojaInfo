using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysLojaInfo
{
    public partial class frmCadastroPessoas : SysLojaInfo.frmCadastro
    {
        public frmCadastroPessoas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public virtual void BloqTxt()
        {
            this.txtNome.Enabled = false;
            this.txtCpfCnpj.Enabled = false;
            this.txtBairro.Enabled = false;
            this.txtEmail.Enabled = false;
            this.txtLogr.Enabled = false;
            this.txtNumero.Enabled = false;
            this.txtRg.Enabled = false;
            this.txtTelCel.Enabled = false;
            this.txtTelRes.Enabled = false;
            this.gpTipoPessoa.Enabled = false;
            this.btnProcuraCidade.Enabled = false;
        }

        public virtual void DesbloqTxt()
        {
            this.txtBairro.Enabled = true;
            this.txtEmail.Enabled = true;
            this.txtLogr.Enabled = true;
            this.txtNumero.Enabled = true;
            this.txtRg.Enabled = true;
            this.txtCpfCnpj.Enabled = true;
            this.txtNome.Enabled = true;
            this.txtTelCel.Enabled = true;
            this.txtTelRes.Enabled = true;
            this.btnProcuraCidade.Enabled = true;
            this.gpTipoPessoa.Enabled = true;
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

        public virtual void btnProcuraCidade_Click(object sender, EventArgs e)
        {
            SelecionaConsulta();
        }

        public virtual void SelecionaConsulta()
        {

        }
    }
}
