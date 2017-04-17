using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// Authored by Group 8
        /// Andrew Owen Sembatya & Matthew John
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());

        }
    }
}
