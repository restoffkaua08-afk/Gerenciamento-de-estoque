using System;
using System.Windows.Forms;
using estoque_s_a;

namespace estoque_s_a
{
    public partial class FrmAtualizar : Form
    {
        private ProdutoDAO produtoDAO = new ProdutoDAO();
        private int produtoSelecionadoId = 0;

        public FrmAtualizar()
        {
            InitializeComponent();
            CarregarProdutos(); // Carrega a lista
        }

        // Carrega produtos no DataGridView
        private void CarregarProdutos()
        {
            dgvProdutos.DataSource = produtoDAO.ConsultarTodos();
        }

        // Quando clica em uma linha do grid, carrega os dados nos campos
        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProdutos.Rows[e.RowIndex];

                produtoSelecionadoId = Convert.ToInt32(row.Cells["id"].Value);
                txtNome.Text = row.Cells["nome"].Value.ToString();
                txtCodigo.Text = row.Cells["codigo"].Value.ToString();
                txtQuantidade.Text = row.Cells["quantidade"].Value.ToString();
                txtPreco.Text = row.Cells["preco"].Value.ToString();
            }
        }

        // Botão ATUALIZAR
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            // Verifica se selecionou um produto
            if (produtoSelecionadoId == 0)
            {
                MessageBox.Show("Selecione um produto!");
                return;
            }

            // Valida os campos
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                !int.TryParse(txtQuantidade.Text, out int quantidade) ||
                !decimal.TryParse(txtPreco.Text, out decimal preco))
            {
                MessageBox.Show("Preencha todos os campos corretamente!");
                return;
            }

            // Cria objeto com os novos dados
            Produto p = new Produto
            {
                Id = produtoSelecionadoId,
                Nome = txtNome.Text,
                Codigo = txtCodigo.Text,
                Quantidade = quantidade,
                Preco = preco
            };

            // Atualiza no banco
            if (produtoDAO.Atualizar(p))
            {
                MessageBox.Show("Produto atualizado!");
                LimparCampos();
                CarregarProdutos();
            }
        }

        // Limpa os campos
        private void LimparCampos()
        {
            txtNome.Text = "";
            txtCodigo.Text = "";
            txtQuantidade.Text = "";
            txtPreco.Text = "";
            produtoSelecionadoId = 0;
        }

        // Botão CANCELAR
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}