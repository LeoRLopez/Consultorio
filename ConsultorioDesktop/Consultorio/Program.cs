using System;
using System.Windows.Forms;

namespace Consultorio
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
            SplashScreen splashScreen = new SplashScreen();

            if(splashScreen.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MenuInicio());
            }
        }
    }
}