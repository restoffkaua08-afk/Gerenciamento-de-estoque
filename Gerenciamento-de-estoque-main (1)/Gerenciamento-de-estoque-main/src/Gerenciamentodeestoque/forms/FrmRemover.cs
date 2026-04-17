using System;
using System.Windows.Forms;

namespace estoque_s_a
{
    public partial class FrmRemover : Form
    {
        // Declaração dos objetos (eles vêm do Designer)
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;

        private ProdutoDAO produtoDAO = new ProdutoDAO();
        private int produtoSelecionadoId = 0;

        public FrmRemover()
        {
            InitializeComponent(); // Isso chama o Designer
            CarregarProdutos();
        }

        // Carrega todos os produtos no grid
        private void CarregarProdutos()
        {
            dgvProdutos.DataSource = produtoDAO.ConsultarTodos();
        }

        // Quando clica em uma linha do grid
        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProdutos.Rows[e.RowIndex];
                produtoSelecionadoId = Convert.ToInt32(row.Cells["id"].Value);
            }
        }

        // Botão REMOVER
        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (produtoSelecionadoId == 0)
            {
                MessageBox.Show("Selecione um produto para remover!");
                return;
            }

            // Pergunta se tem certeza
            DialogResult resp = MessageBox.Show("Tem certeza que deseja remover este produto?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
            {
                // Tenta remover do banco
                if (produtoDAO.Remover(produtoSelecionadoId))
                {
                    MessageBox.Show("Produto removido com sucesso!");
                    produtoSelecionadoId = 0;
                    CarregarProdutos(); // Recarrega a lista
                }
            }
        }

        // Botão CANCELAR
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha a tela
        }
    }
}