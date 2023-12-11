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
    public partial class frmCadastroPaises : SysLojaInfo.frmCadastro
    {
        private Paises oPais;
        public frmCadastroPaises()
        {
            InitializeComponent();
            oPais = new Paises();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void CarregaCampos(object obj)
        {
            oPais = (Paises)obj;

            txtCodigo.Text = oPais.Codigo.ToString();
            txtPais.Text = oPais.Pais;
            txtDDI.Text = oPais.DDI;
            txtSigla.Text = oPais.Sigla;
        }

        public override void Salvar()
        {
            base.Salvar();
            ctrlPaises aCtrl = new ctrlPaises();
            oPais.Pais = txtPais.Text;
            oPais.Sigla = txtSigla.Text;
            oPais.DDI = txtDDI.Text;

            if (base.btnSalvar.Text is "Salvar")
            {
                aCtrl.salvar(oPais);
            }
            else if (base.btnSalvar.Text is "Alterar")
            {
                aCtrl.editar(oPais);
            }
            else if (base.btnSalvar.Text is "Excluir")
            {
                aCtrl.deletar(oPais);
            };
            Close();

        }

        public void BloqTxt()
        {
            this.txtPais.Enabled = false;
            this.txtDDI.Enabled = false;
            this.txtSigla.Enabled = false;
        }

        public void DesbloqTxt()
        {
            this.txtPais.Enabled = true;
            this.txtDDI.Enabled = true;
            this.txtSigla.Enabled = true;
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

        private void txtPais_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
