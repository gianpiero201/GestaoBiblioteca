using Infra.Config;

namespace GestaoBiblioteca
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.ThreadException += (obj, e) =>
            {
                MessageBox.Show(e.Exception.Message);
            };

            ApplicationConfiguration.Initialize();
            Startup.Run();
        }
    }
}