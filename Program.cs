using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ShutdownSystem
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
            if (MessageBox.Show("The application you are about to run contains shutdown functions for Windows and/or the computer's hardware, including ungraceful methods (e.g. BSOD, unplug-style power off). Most of these are UNSAFE and can result in the loss of all unsaved data. Any buttons clicked will trigger their respective functions immediately, with no confirmation message displayed beforehand. It is recommended to try these methods on a virtual machine, to avoid any issues.\n\nBY USING THIS SOFTWARE, YOU ARE EXPOSING YOURSELF TO POTENTIAL DATA LOSS AND/OR CORRUPTION!\n\nContinue anyway?",
                                Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                                == DialogResult.Yes)
                Application.Run(new MainForm());
            else Application.Exit();
        }
    }
}
