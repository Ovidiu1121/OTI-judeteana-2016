using System.Diagnostics;

namespace Subiect_OTI_judeteana2016
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Start());




        }
    }
}