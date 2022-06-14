using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AppSwitchLibrary
{
    public class ActiveApplication
    {
        WindowsHookHelper.WinEventDelegate dele = null;
        public event EventHandler<String> ApplicationSwitched;
        private bool disposed;
        private IntPtr m_hhook;

        private const uint WINEVENT_OUTOFCONTEXT = 0;
        private const uint EVENT_SYSTEM_FOREGROUND = 3;

        public ActiveApplication()
        {

            dele = new WindowsHookHelper.WinEventDelegate(WinEventProc);
            IntPtr m_hhook = WindowsHookHelper.SetWinEventHook(EVENT_SYSTEM_FOREGROUND, EVENT_SYSTEM_FOREGROUND, IntPtr.Zero, dele, 0, 0, WINEVENT_OUTOFCONTEXT);
        }


        private string GetActiveWindowTitle()
        {
            const int nChars = 256;
            uint processID = 0;
            IntPtr handle = IntPtr.Zero;
            StringBuilder Buff = new StringBuilder(nChars);
            handle = WindowsHookHelper.GetForegroundWindow();

            // To get window title.
            //if (WindowsHookHelper.GetWindowText(handle, Buff, nChars) > 0)
            //{
            //    return Buff.ToString();
            //}

            uint threadID = WindowsHookHelper.GetWindowThreadProcessId(handle, out processID); // Get PID from window handle
            Process fgProc = Process.GetProcessById(Convert.ToInt32(processID)); // Get it as a C# obj.

            if (fgProc != null)
                return fgProc.ProcessName;

            return null;
        }

        public void WinEventProc(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime)
        {
            var title = GetActiveWindowTitle();

            if (ApplicationSwitched != null)
                ApplicationSwitched(this, title);

        }

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (m_hhook != IntPtr.Zero)
                {
                    WindowsHookHelper.UnhookWindowsHookEx(m_hhook);
                }

                disposed = true;
            }
        }

        ~ActiveApplication()
        {
            Dispose(false);
        }
    }
}
