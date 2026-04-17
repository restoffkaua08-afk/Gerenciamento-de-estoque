using System;
using System.Windows.Forms;
using estoque_s_a;

namespace estoque_s_a
{
    public partial class FrmConsultar : Form
    {
        private ProdutoDAO produtoDAO = new ProdutoDAO();

        public FrmConsultar()
        {
            InitializeComponent();
            CarregarProdutos(); // Carrega quando abre a tela
        }

        // Carrega todos os produtos no DataGridView
        private void CarregarProdutos()
        {
            dgvProdutos.DataSource = produtoDAO.ConsultarTodos();
        }

        // Botão ATUALIZAR - recarrega a lista
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        // Botão FECHAR
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}