namespace estoque_s_a
{
    partial class FrmCadastrar
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
            txtNome = new TextBox();
            txtCodigo = new TextBox();
            txtQuantidade = new TextBox();
            txtPreco = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnSalvar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(30, 50);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(250, 23);
            txtNome.TabIndex = 8;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(30, 100);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(250, 23);
            txtCodigo.TabIndex = 6;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(30, 150);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(100, 23);
            txtQuantidade.TabIndex = 4;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(150, 150);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(100, 23);
            txtPreco.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 9;
            label1.Text = "Nome do Produto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 80);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 7;
            label2.Text = "Código do Produto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 130);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 5;
            label3.Text = "Quantidade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(150, 130);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 3;
            label4.Text = "Preço:";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(30, 200);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(100, 30);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "SALVAR";
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(150, 200);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 30);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmCadastrar
            // 
            ClientSize = new Size(320, 260);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtPreco);
            Controls.Add(label4);
            Controls.Add(txtQuantidade);
            Controls.Add(label3);
            Controls.Add(txtCodigo);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmCadastrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Produto";
            Load += FrmCadastrar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
    }
}