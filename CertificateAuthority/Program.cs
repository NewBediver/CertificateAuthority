using CertificateAuthority.CertificateRepositoryViews;
using System;
using System.Windows.Forms;

namespace CertificateAuthority
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainWindow());
            Application.Run(new CountryViewForm());
        }
    }
}
