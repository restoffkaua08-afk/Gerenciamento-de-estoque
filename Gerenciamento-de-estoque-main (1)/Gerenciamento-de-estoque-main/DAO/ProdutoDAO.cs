using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace estoque_s_a
{
    internal class ProdutoDAO
    {
        private Database db = new Database();

        internal bool Cadastrar(Produto p)
        {
            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO produtos (nome, codigo, quantidade, preco) VALUES (@nome, @codigo, @quantidade, @preco)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nome", p.Nome);
                    cmd.Parameters.AddWithValue("@codigo", p.Codigo);
                    cmd.Parameters.AddWithValue("@quantidade", p.Quantidade);
                    cmd.Parameters.AddWithValue("@preco", p.Preco);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
                return false;
            }
        }

        internal DataTable ConsultarTodos()
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM produtos ORDER BY id DESC";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar: " + ex.Message);
            }
            return dt;
        }

        internal bool Atualizar(Produto p)
        {
            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE produtos SET nome=@nome, codigo=@codigo, quantidade=@quantidade, preco=@preco WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", p.Id);
                    cmd.Parameters.AddWithValue("@nome", p.Nome);
                    cmd.Parameters.AddWithValue("@codigo", p.Codigo);
                    cmd.Parameters.AddWithValue("@quantidade", p.Quantidade);
                    cmd.Parameters.AddWithValue("@preco", p.Preco);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar: " + ex.Message);
                return false;
            }
        }

        internal bool Remover(int id)
        {
            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM produtos WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover: " + ex.Message);
                return false;
            }
        }

        internal Produto GetProduto(int id)
        {
            Produto produto = null;
            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM produtos WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        produto = new Produto
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Nome = reader["nome"].ToString() ?? "",
                            Codigo = reader["codigo"].ToString() ?? "",
                            Quantidade = Convert.ToInt32(reader["quantidade"]),
                            Preco = Convert.ToDecimal(reader["preco"])
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar: " + ex.Message);
            }
            return produto;
        }
    }
}