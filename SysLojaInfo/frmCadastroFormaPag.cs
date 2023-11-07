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
    public partial class frmCadastroFormaPag : SysLojaInfo.frmCadastro
    {
        private FormasPag aForma;
        public frmCadastroFormaPag()
        {
            InitializeComponent();
            aForma = new FormasPag();
        }
        public void CarregaCampos(object obj)
        {
            aForma = (FormasPag)obj;

            txtCodigo.Text = aForma.Codigo.ToString();
            txtFormaPag.Text = aForma.forma;
            txtDatCad.Text = aForma.DatCad.ToString();
            txtDatUltAlt.Text = aForma.DatUltAlt.ToString();
            txtQuemAlt.Text = aForma.QuemAlter.ToString();
        }

        public override void Salvar()
        {
            base.Salvar();
            ctrlFormas aCtrl = new ctrlFormas();
            aForma.forma = txtFormaPag.Text;
           

            if (base.btnSalvar.Text is "Salvar")
            {
                aCtrl.salvar(aForma);
            }
            else if (base.btnSalvar.Text is "Alterar")
            {
                aCtrl.editar(aForma);
            }
            else if (base.btnSalvar.Text is "Excluir")
            {
                aCtrl.deletar(aForma);
            };
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        public void BloqTxt()
        {
            this.txtFormaPag.Enabled = false;
        }

        public void DesbloqTxt()
        {
            this.txtFormaPag.Enabled = true;
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

        public override void Botao_Salvar()
        {
            base.Botao_Salvar();
            this.DesbloqTxt();
        }


    }
}
