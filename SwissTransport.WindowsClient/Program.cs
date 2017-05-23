using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransport.WindowsClient
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmMain Mainfrm = new frmMain();
            ITransportController Controller = new MainController(new Transport(), Mainfrm);
            Controller.SetAllViewHandlers();
            Application.Run(Mainfrm);
        }
    }
}
