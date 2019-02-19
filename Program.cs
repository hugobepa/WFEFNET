//using AFEFWFV1_1010181539;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AFEFWFV05221018
{
    //static class Program
    class Program
    {

       
        //static string texto="99";
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {


           
           

           



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Application.Run(new FormUG1());

            /*
#if DEBUG
            //CreateConsole();
#endif
            Application.Run(new Form1());
*/
            Application.Run(new Form1());






        }


        #region CreateConsole
        /*
            
        static void CreateConsole()
        {
            var t = new System.Threading.Thread(() => {
                AllocConsole();
                for (; ; )
                {
                    var cmd = Console.ReadLine();
                    if (cmd.ToLower() == "quit") break;
                    // Etc...
                }
                FreeConsole();
            });
            t.IsBackground = true;
            t.Start();
        }
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool FreeConsole();

        */
        #endregion



        

    }


}

