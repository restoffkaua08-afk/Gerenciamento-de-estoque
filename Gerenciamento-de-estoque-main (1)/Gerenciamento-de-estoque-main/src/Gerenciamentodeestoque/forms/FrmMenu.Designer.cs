namespace estoque_s_a
{
    partial class FrmMenu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnCadastrar = new Button();
            btnConsultar = new Button();
            btnAtualizar = new Button();
            btnRemover = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(100, 50);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(200, 40);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "CADASTRAR PRODUTO";
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(100, 100);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(200, 40);
            btnConsultar.TabIndex = 3;
            btnConsultar.Text = "CONSULTAR PRODUTOS";
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(100, 150);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(200, 40);
            btnAtualizar.TabIndex = 2;
            btnAtualizar.Text = "ATUALIZAR PRODUTO";
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(100, 200);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(200, 40);
            btnRemover.TabIndex = 1;
            btnRemover.Text = "REMOVER PRODUTO";
            btnRemover.Click += btnRemover_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(100, 270);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(200, 40);
            btnSair.TabIndex = 0;
            btnSair.Text = "SAIR";
            btnSair.Click += btnSair_Click;
            // 
            // FrmMenu
            // 
            ClientSize = new Size(400, 350);
            Controls.Add(btnSair);
            Controls.Add(btnRemover);
            Controls.Add(btnAtualizar);
            Controls.Add(btnConsultar);
            Controls.Add(btnCadastrar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            Load += FrmMenu_Load;
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnSair;
    }
}