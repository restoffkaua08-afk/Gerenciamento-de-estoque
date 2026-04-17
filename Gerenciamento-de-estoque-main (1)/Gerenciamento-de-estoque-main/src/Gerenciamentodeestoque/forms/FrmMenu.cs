using System;
using System.Windows.Forms;
using estoque_s_a;

namespace estoque_s_a
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        // Botão CADASTRAR - abre tela de cadastro
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastrar frm = new FrmCadastrar();
            frm.ShowDialog(); // Abre e espera fechar
        }

        // Botão CONSULTAR - abre tela de consulta
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FrmConsultar frm = new FrmConsultar();
            frm.ShowDialog();
        }

        // Botão ATUALIZAR - abre tela de atualização
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            FrmAtualizar frm = new FrmAtualizar();
            frm.ShowDialog();
        }

        // Botão REMOVER - abre tela de remoção
        private void btnRemover_Click(object sender, EventArgs e)
        {
            FrmRemover frm = new FrmRemover();
            frm.ShowDialog();
        }

        // Botão SAIR
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Sair",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}