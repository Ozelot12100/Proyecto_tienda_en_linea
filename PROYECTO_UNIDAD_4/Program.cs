using PROYECTO_UNIDAD_4.Forms;
using PROYECTO_UNIDAD_4.Forms.Admin;

namespace PROYECTO_UNIDAD_4
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
            Application.Run(new ClienteDashBoard());
        }
    }
}