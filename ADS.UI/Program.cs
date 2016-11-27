using System;
using System.Net.Configuration;
using System.Windows.Forms;
using ADS.Core.Domain.Model;

namespace Advanced_Data_Structures
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AdsApplication());
        }
    }
}
