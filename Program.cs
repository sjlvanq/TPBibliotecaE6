using TPBibliotecaE6.Models;

namespace TPBibliotecaE6
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Biblioteca biblioteca = new Biblioteca();
            Application.Run(new Form1(biblioteca));
        }
    }
}