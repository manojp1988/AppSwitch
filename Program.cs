using AppSwitchLibrary;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Threading;

namespace AppSwitch
{
    public class EventWatcherAsync
    {

        static Stopwatch watch = new Stopwatch();
         
        public static void Main(string[] args)
        {
            Console.WriteLine("Tracking time spent on Notepad....");

             new InputTracker();

             Application.Run(new ApplicationContext());


        }
    }
}
