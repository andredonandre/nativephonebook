using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phonebook.Controllers;

namespace Phonebook
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// Authored by Group 2
        /// Andrew Owen Sembatya & Emil Pettersson
        /// </summary>
        [STAThread]
        static void Main()
        {
            mainController control = new mainController();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main(control));
        }
    }
}
