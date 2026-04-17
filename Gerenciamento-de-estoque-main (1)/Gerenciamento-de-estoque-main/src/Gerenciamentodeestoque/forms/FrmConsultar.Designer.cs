namespace estoque_s_a
{
    partial class FrmConsultar
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
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();

            // dgvProdutos - grade de produtos
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(20, 20);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(560, 300);
            this.dgvProdutos.TabIndex = 0;

            // btnAtualizar
            this.btnAtualizar.Location = new System.Drawing.Point(360, 340);
            this.btnAtualizar.Size = new System.Drawing.Size(100, 30);
            this.btnAtualizar.Text = "ATUALIZAR";
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);

            // btnFechar
            this.btnFechar.Location = new System.Drawing.Point(480, 340);
            this.btnFechar.Size = new System.Drawing.Size(100, 30);
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);

            // FrmConsultar
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dgvProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnFechar;
    }
}