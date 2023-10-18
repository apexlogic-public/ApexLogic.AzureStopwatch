using System;
using System.Drawing;
using System.Windows.Forms;

namespace ApexLogic.AzureStopwatch
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

            Form form = new FormCounter();

            Size screen = Screen.PrimaryScreen.WorkingArea.Size;
            form.Location = new Point(screen.Width - form.Width, screen.Height - form.Height);

            Application.Run(form);
        }
    }
}