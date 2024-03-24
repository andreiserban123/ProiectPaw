using System;
using System.Windows.Forms;

namespace ProiectPaw {
    internal static class Program {
        /// <summary>
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
