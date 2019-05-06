using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serial
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Sono sicuro che sia concettualmente sbagliato
            try
            {
                Application.Run(new CentraleFX());
            }
            catch (ObjectDisposedException e)
            {
                Console.WriteLine("Caught: {0}", e.Message);
            }
        }

    }
}
