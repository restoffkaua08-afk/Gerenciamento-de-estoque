namespace estoque_s_a
{
    partial class FrmLogin
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
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            btnEntrar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(50, 90);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(200, 23);
            txtUsuario.TabIndex = 4;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(50, 150);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(200, 23);
            txtSenha.TabIndex = 2;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(50, 200);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(90, 30);
            btnEntrar.TabIndex = 1;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(160, 200);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 30);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 70);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 5;
            label1.Text = "Usuário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 130);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Senha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label3.Location = new Point(50, 20);
            label3.Name = "label3";
            label3.Size = new Size(191, 24);
            label3.TabIndex = 6;
            label3.Text = "LOGIN - ESTOQUE";
            // 
            // FrmLogin
            // 
            ClientSize = new Size(300, 270);
            Controls.Add(btnCancelar);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenha);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}