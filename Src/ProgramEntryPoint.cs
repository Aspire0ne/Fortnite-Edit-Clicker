using System;
using System.Threading;
using System.Windows.Forms;

namespace FortniteAutoclicker
{
    static class ProgramEntryPoint
    {
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.Priority = ThreadPriority.Lowest;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
