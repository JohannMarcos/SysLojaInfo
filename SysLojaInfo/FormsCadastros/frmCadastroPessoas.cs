using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
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
            this.lblBairro.Enabled = true;
            this.lblEmail.Enabled = true;
            this.lblLogr.Enabled = true;
            this.lblNumero.Enabled = true;
            this.lblRg.Enabled = true;
            this.lblCpfCnpj.Enabled=true;
            this.lblNomeRazao.Enabled = true;
            this.lblTelCel.Enabled = true;
            this.lblTelRes.Enabled = true;
            this.lblCodCidade.Enabled = true;
            this.lblCidade.Enabled = true;
        }

        public override void Botao_Salvar()
        {
            base.Botao_Salvar();
            gpTipoPessoa.Enabled=true;
            //this.DesbloqTxt();
        }

        public override void Botao_alterar()
        {
            base.Botao_alterar();
            this.DesbloqTxt();
            gpTipoPessoa.Enabled=false;
        }

        public override void Botao_Excluir()
        {
            base.Botao_Excluir();
            this.BloqTxt();
            gpTipoPessoa.Enabled = false;
        }

        public virtual void btnProcuraCidade_Click(object sender, EventArgs e)
        {
            SelecionaConsulta();
        }

        public virtual void SelecionaConsulta()
        {

        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }

        public bool ValidarNumeroTelefoneBrasileiro(string numeroTelefone)
        {
            // Remove todos os caracteres não numéricos do número de telefone
            string apenasDigitos = Regex.Replace(numeroTelefone, @"[^\d]", "");

            // Verifica se o número possui exatamente 11 dígitos (formato padrão brasileiro)
            if (apenasDigitos.Length == 11)
            {
                // Verifica se todos os dígitos são iguais, indicando uma sequência repetitiva
                if (!TodosDigitosIguais(apenasDigitos))
                {
                    return true;
                }
            }

            return false;
        }

        public bool TodosDigitosIguais(string numero)
        {
            // Verifica se todos os dígitos são iguais
            char primeiroDigito = numero[0];
            return numero.All(digito => digito == primeiroDigito);
        }

        public bool ValidarEmail(string enderecoEmail)
        {
            // Utiliza uma expressão regular para validar o formato do e-mail
            string padrao = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(padrao);

            return regex.IsMatch(enderecoEmail);
        }
    }
}
