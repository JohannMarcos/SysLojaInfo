namespace SysLojaInfo
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void paísToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaPaises tela = new frmConsultaPaises();
            tela.Show();
        }

        private void estadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaEstados tela = new frmConsultaEstados();
            tela.Show();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaCidades tela = new frmConsultaCidades();
            tela.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaClientes tela = new frmConsultaClientes();
            tela.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor tela = new frmConsultaFornecedor();
            tela.Show();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaFuncionario tela = new frmConsultaFuncionario();
            tela.Show();
        }

        private void formasDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaFormaPag tela = new frmConsultaFormaPag();
            tela.Show();
        }

        private void condiçõesDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaCondPag tela = new frmConsultaCondPag();
            tela.Show();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaServicos tela = new frmConsultaServicos();
            tela.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaProdutos tela = new frmConsultaProdutos();
            tela.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaCargos tela = new frmConsultaCargos();
            tela.Show();
        }

        private void unidadesDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaMedidas tela = new frmConsultaMedidas();
            tela.Show();
        }
    }
}