namespace estoque_s_a
{
    partial class FrmAtualizar
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
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();

            // dgvProdutos
            this.dgvProdutos.Location = new System.Drawing.Point(20, 20);
            this.dgvProdutos.Size = new System.Drawing.Size(560, 200);
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 240);
            this.label1.Text = "Nome:";

            // txtNome
            this.txtNome.Location = new System.Drawing.Point(20, 260);
            this.txtNome.Size = new System.Drawing.Size(250, 20);

            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 290);
            this.label2.Text = "Código:";

            // txtCodigo
            this.txtCodigo.Location = new System.Drawing.Point(20, 310);
            this.txtCodigo.Size = new System.Drawing.Size(250, 20);

            // label3
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 240);
            this.label3.Text = "Quantidade:";

            // txtQuantidade
            this.txtQuantidade.Location = new System.Drawing.Point(300, 260);
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);

            // label4
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 290);
            this.label4.Text = "Preço:";

            // txtPreco
            this.txtPreco.Location = new System.Drawing.Point(300, 310);
            this.txtPreco.Size = new System.Drawing.Size(100, 20);

            // btnAtualizar
            this.btnAtualizar.Location = new System.Drawing.Point(300, 350);
            this.btnAtualizar.Size = new System.Drawing.Size(120, 30);
            this.btnAtualizar.Text = "ATUALIZAR";
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);

            // btnCancelar
            this.btnCancelar.Location = new System.Drawing.Point(440, 350);
            this.btnCancelar.Size = new System.Drawing.Size(120, 30);
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // FrmAtualizar
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar Produto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCancelar;
    }
}