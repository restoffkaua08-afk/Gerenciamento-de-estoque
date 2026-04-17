using System;
using System.Windows.Forms;
using estoque_s_a;

namespace estoque_s_a
{
    public partial class FrmCadastrar : Form
    {
        private estoque_s_a.ProdutoDAO   produtoDAO = new estoque_s_a.ProdutoDAO();

        public FrmCadastrar()
        {
            InitializeComponent();
        }

        // Botão SALVAR
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Verifica se os campos foram preenchidos
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Digite o nome do produto!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Digite o código do produto!");
                return;
            }
            if (!int.TryParse(txtQuantidade.Text, out int quantidade) || quantidade < 0)
            {
                MessageBox.Show("Quantidade inválida!");
                return;
            }
            if (!decimal.TryParse(txtPreco.Text, out decimal preco) || preco <= 0)
            {
                MessageBox.Show("Preço inválido! Use vírgula (ex: 25,90)");
                return;
            }

            // Cria o objeto produto
            Produto p = new Produto
            {
                Nome = txtNome.Text,
                Codigo = txtCodigo.Text,
                Quantidade = quantidade,
                Preco = preco
            };

            // Chama o método para cadastrar no banco
            if (produtoDAO.Cadastrar(p))
            {
                MessageBox.Show("Produto cadastrado com sucesso!");
                LimparCampos();
            }
        }

        // Limpa os campos
        private void LimparCampos()
        {
            txtNome.Text = "";
            txtCodigo.Text = "";
            txtQuantidade.Text = "";
            txtPreco.Text = "";
            txtNome.Focus();
        }

        // Botão CANCELAR
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha a tela
        }

        private void FrmCadastrar_Load(object sender, EventArgs e)
        {

        }
    }
}