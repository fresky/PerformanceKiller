using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace HalfGMemory
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            byte[] oneK = new byte[1024];
            List<object> memory = new List<object>();
            for (int i = 0; i < 500*1024; i++)
            {
                memory.Add(oneK.Clone());
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            while (true)
            {
                Thread.Sleep(1000);
            }
        }
    }
}
