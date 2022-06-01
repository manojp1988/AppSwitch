using System;
using System.Collections.Generic;
using System.Management;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;

namespace AppSwitch
{
    public class EventWatcherAsync
    {

        static Stopwatch watch = new Stopwatch();

        public static void Main(string[] args)
        {
            Console.WriteLine("Tracking time spent on Notepad....");

            var _timer = new Timer(TimerCallback, null, 0, 2000);

            Console.ReadLine();
        }

        private static void TimerCallback(Object o)
        {
            Process fgProc = ProcessUtils.getForegroundProcess();

            if (fgProc.ProcessName == "Notepad")
            {
                watch.Start();
                Console.WriteLine(fgProc.ProcessName + " - " + watch.Elapsed);

            }
            else
            {
                watch.Stop();
            }
        }


    }

    class ProcessUtils
    {
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        public static Process getForegroundProcess()
        {
            uint processID = 0;
            IntPtr hWnd = GetForegroundWindow(); // Get foreground window handle
            uint threadID = GetWindowThreadProcessId(hWnd, out processID); // Get PID from window handle
            Process fgProc = Process.GetProcessById(Convert.ToInt32(processID)); // Get it as a C# obj.
            // NOTE: In some rare cases ProcessID will be NULL. Handle this how you want. 
            return fgProc;
        }

        public static bool IsRunning(Process process)
        {
            if (process == null)
                throw new ArgumentNullException("process");

            try
            {
                Process.GetProcessById(process.Id);
            }
            catch (ArgumentException)
            {
                return false;
            }
            return true;
        }
    }

}
