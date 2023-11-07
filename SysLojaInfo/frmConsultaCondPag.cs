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
    public partial class frmConsultaCondPag : SysLojaInfo.frmConsulta
    {
        public frmConsultaCondPag()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public override void alterar()
        {
            base.alterar();
            frmCadastroCondPag tela = new frmCadastroCondPag();
            tela.Botao_alterar();
            tela.Show();
        }

        public override void incluir()
        {
            base.incluir();
            frmCadastroCondPag tela = new frmCadastroCondPag();
            tela.Botao_Salvar();
            tela.Show();
        }

        public override void excluir()
        {
            base.excluir();
            frmCadastroCondPag tela = new frmCadastroCondPag();
            tela.Botao_Excluir();
            tela.Show();

        }
    }
}
