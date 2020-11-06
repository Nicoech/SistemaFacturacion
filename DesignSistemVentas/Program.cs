using System;
using System.Windows.Forms;


namespace DesignSistemVentas
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm lf = new LoginForm();
            lf.ShowDialog();

            LoginForm loginForm = new LoginForm();
            Application.Run(loginForm);

        }
    }
}
