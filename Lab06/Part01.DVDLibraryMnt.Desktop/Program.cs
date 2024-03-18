﻿using System;
using System.Windows.Forms;

namespace Part01.DVDLibraryMnt.Desktop
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
            Application.Run(new DVDLibraryForm());
        }
    }
}
