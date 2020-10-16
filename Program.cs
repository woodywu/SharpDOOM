using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpDoom3
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SharpLib.Timer t = new SharpLib.Timer();
            var st = Stopwatch.StartNew();
            st.Start();
            t.Start();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            t.Stop();
            st.Stop();
            Application.Run(new FormMain());
        }
    }
}
