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
            tela.ShowDialog();
        }

        private void estadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaEstados tela = new frmConsultaEstados();
            tela.ShowDialog();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaCidades tela = new frmConsultaCidades();
            tela.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaClientes tela = new frmConsultaClientes();
            tela.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor tela = new frmConsultaFornecedor();
            tela.ShowDialog();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaFuncionario tela = new frmConsultaFuncionario();
            tela.ShowDialog();
        }

        private void formasDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaFormaPag tela = new frmConsultaFormaPag();
            tela.ShowDialog();
        }

        private void condiçõesDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaCondPag tela = new frmConsultaCondPag();
            tela.ShowDialog();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaServicos tela = new frmConsultaServicos();
            tela.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaProdutos tela = new frmConsultaProdutos();
            tela.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaCargos tela = new frmConsultaCargos();
            tela.ShowDialog();
        }

        private void unidadesDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaMedidas tela = new frmConsultaMedidas();
            tela.ShowDialog();
        }

        private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaCompras tela = new frmConsultaCompras();
            tela.ShowDialog();
        }
    }
}