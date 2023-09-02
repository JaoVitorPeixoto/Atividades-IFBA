using System;
using System.Windows.Forms;

namespace Vitor04º_Cartorio
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Login_FORM frmLogin = new Login_FORM();
            frmLogin.Show();

            Application.Run();

        }
    }
}
