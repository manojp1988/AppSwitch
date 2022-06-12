using AppSwitchLibrary;
using System.Windows.Forms;

namespace AppSwitch
{
    public class EventWatcherAsync
    {
        public static void Main(string[] args)
        {
            new InputTracker();

            Application.Run(new ApplicationContext());
        }
    }
}
