using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace EditClicker
{
    class FortniteMonitor
    {
        const string FortniteProcessBeginningName = "FortniteClient-";

        [DllImport("user32.dll")] private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")] private static extern int GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        public static bool IsFortniteFocused()
        {
            var activeProcess = GetActiveProcess();
            return activeProcess != null && activeProcess.ProcessName.StartsWith(FortniteProcessBeginningName);
        }

        static Process GetActiveProcess()
        {
            IntPtr hwnd = GetForegroundWindow();
            return hwnd != null ? GetProcessByHandle(hwnd) : null;
        }

        static Process GetProcessByHandle(IntPtr hwnd)
        {
            try
            {
                GetWindowThreadProcessId(hwnd, out uint processID);
                return Process.GetProcessById((int)processID);
            }
            catch { return null; }
        }
    }
}
