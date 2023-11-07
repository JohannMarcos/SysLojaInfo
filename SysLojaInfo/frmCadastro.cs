using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysLojaInfo
{
    public partial class frmCadastro : SysLojaInfo.frmPai
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        public virtual void Salvar()
        {

        }

        public virtual void sair()
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.sair();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.Salvar();
        }

        public virtual void Botao_alterar()
        {
            btnSalvar.Text = "Alterar";
        }

        public virtual void Botao_Salvar()
        {
            btnSalvar.Text = "Salvar";
        }

        public virtual void Botao_Excluir()
        {
            btnSalvar.Text = "Excluir";
        }

        public bool IsInteger(string text)
        {
            return int.TryParse(text, out _);
        }


    }
}
