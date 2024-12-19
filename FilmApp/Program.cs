using System;
using System.Windows.Forms;
using FilmApp.Forms.AuthForms;
using FilmApp.Forms.UserForms;
namespace FilmApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
        }
    }
}
