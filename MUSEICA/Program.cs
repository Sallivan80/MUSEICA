using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MUSEICA.Model;
using MUSEICA.Persistence;
using MUSEICA.Controllers;
using MUSEICA.ProvaView;

namespace MUSEICA
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
            Controller c = new ControllerProfilo();
            c.LoadCompenents();
            Application.Run(new ProfiloView(c));
        }
    }
}
