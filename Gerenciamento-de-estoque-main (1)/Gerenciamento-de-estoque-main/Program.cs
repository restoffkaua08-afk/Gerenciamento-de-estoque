
using estoque_s_a;

internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

        // Abre a tela de login primeiro
        FrmLogin frmLogin = new FrmLogin();

            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                // Se login OK, abre o menu principal
                Application.Run(new FrmMenu());
            }
            else
            {
                Application.Exit(); // Sai do sistema se cancelar
            }
        }
    
}