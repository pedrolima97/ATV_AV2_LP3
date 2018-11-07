using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fletnix
{
    
    static class Program
    {
        public static char time = '0';
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //Tela de inicio
            Splash _splash = new Splash();
            _splash.Show();
            Application.Run();
                        
        }
    }
}
