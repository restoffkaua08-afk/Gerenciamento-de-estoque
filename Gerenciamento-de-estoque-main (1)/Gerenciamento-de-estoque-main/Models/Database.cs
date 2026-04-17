using MySql.Data.MySqlClient;
using System;

namespace estoque_s_a
{
    public class Database
    {
        private string connectionString = "Server=localhost;Port=3307;Database=estoque_db;Uid=root;Pwd=;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public bool TestarConexao()
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Erro de conexão: " + ex.Message);
                return false;
            }
        }
    }
}