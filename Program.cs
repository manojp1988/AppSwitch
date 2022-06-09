
using IdleTimeTracker;
using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Threading;

namespace AppSwitch
{
    public class EventWatcherAsync
    {

        static Stopwatch watch = new Stopwatch();

        public static void Main(string[] args)
        {

            //FileStream filestream = new FileStream("C:/temp/out.txt", FileMode.Create);
            //var streamwriter = new StreamWriter(filestream);
            //streamwriter.AutoFlush = true;
            //Console.SetOut(streamwriter);
            //Console.SetError(streamwriter);

            var _timer = new Timer(timer_Tick2, null, 0, 1000);
            
            Console.ReadLine();

        }

        private static void timer_Tick2(object state)
        {
            Console.WriteLine("Idle Time: " + IdleTimeFinder.GetIdleTime());
        }
    }
}
