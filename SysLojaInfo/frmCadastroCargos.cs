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
    public partial class frmCadastroCargos : SysLojaInfo.frmCadastro
    {
        private Cargos oCargo;
        public frmCadastroCargos()
        {
            InitializeComponent();
            oCargo = new Cargos();
        }

        public void CarregaCampos(object obj)
        {
            oCargo = (Cargos)obj;

            txtCodigo.Text = oCargo.Codigo.ToString();
            txtCargo.Text = oCargo.cargo;
            if (oCargo.externo == "S")
            {
                cbExterno.Checked = true;
            }
            txtDatCad.Text = oCargo.DatCad.ToString();
            txtDatUltAlt.Text = oCargo.DatUltAlt.ToString();
            txtQuemAlt.Text = oCargo.QuemAlter.ToString();
        }

        public override void Salvar()
        {
            base.Salvar();
            ctrlCargos aCtrl = new ctrlCargos();
            oCargo.cargo = txtCargo.Text;
            if (cbExterno.Checked == true)
            {
                oCargo.externo = "S";
            }
            else
            {
                oCargo.externo = "N";
            }

            if (base.btnSalvar.Text is "Salvar")
            {
                aCtrl.salvar(oCargo);
            }
            else if (base.btnSalvar.Text is "Alterar")
            {
                aCtrl.editar(oCargo);
            }
            else if (base.btnSalvar.Text is "Excluir")
            {
                aCtrl.deletar(oCargo);
            };
            Close();
        }

        public void BloqTxt()
        {
            this.txtCargo.Enabled = false;
            this.cbExterno.Enabled = false;
        }

        public void DesbloqTxt()
        {
            this.txtCargo.Enabled = true;
            this.cbExterno.Enabled = true;
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
