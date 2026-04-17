using System;
using System.Windows.Forms;

namespace estoque_s_a
{
    public partial class FrmLogin : Form
    {
        private string usuarioCorreto = "admin";
        private string senhaCorreta = "123";

        public FrmLogin()
        {
            InitializeComponent();
            txtSenha.PasswordChar = '*'; // Esconde a senha
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Pega o que foi digitado
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text.Trim();

            // Verifica se não está vazio
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Preencha usuário e senha!");
                return;
            }

            // Verifica se é o admin
            if (usuario == usuarioCorreto && senha == senhaCorreta)
            {
                this.DialogResult = DialogResult.OK; // Login OK
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!");
                txtSenha.Clear();
                txtSenha.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Cancelou
            this.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}