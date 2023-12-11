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
    public partial class frmCadastroMedidas : SysLojaInfo.frmCadastro
    {
        private Medidas aMedida;
        public frmCadastroMedidas()
        {
            InitializeComponent();
            this.lblCodigo.Text = "Unidade";
            aMedida = new Medidas();

        }
        public void CarregaCampos(object obj)
        {
            aMedida = (Medidas)obj;

            txtCodigo.Text = aMedida.uMedida;
            txtDesc.Text = aMedida.descricao;
            if (aMedida.ativo == "S")
            {
                checkAtivo.Checked = true;
            }
            txtDatUltAlt.Text = aMedida.DatUltAlt.ToString();
            txtQuemAlt.Text = aMedida.QuemAlter.ToString();
        }
        public override void Salvar()
        {
            base.Salvar();
            ctrlMedidas aCtrl = new ctrlMedidas();
            if (checkAtivo.Checked == true)
            {
                aMedida.ativo = "S";
            }
            else
            {
                aMedida.ativo = "N";
            }


            aCtrl.editar(aMedida);

            Close();
        }

    }
}
