using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AppSwitchLibrary
{
    public class InputTracker
    {

        //private DispatcherTimer timer;
        private AllInputSources lastInput;
        private KeyboardInput keyboard;
        private MouseInput mouse;

        public InputTracker()
        {

            keyboard = new KeyboardInput();
            keyboard.KeyBoardKeyPressed += keyboard_KeyBoardKeyPressed;

            mouse = new MouseInput();
            mouse.MouseMoved += mouse_MouseMoved;

            //lastInput = new AllInputSources();
            //var _timer = new Timer(timer_Tick2, null, 0, 100);

            
            //timer = new DispatcherTimer();
            //timer.Interval = new TimeSpan();
            //timer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            //timer.Tick += timer_Tick;
            //timer.Start();

            new Test();

        }

        private void timer_Tick2(object state)
        {
            //Console.WriteLine(FormatDateTime(lastInput.GetLastInputTime()));
        }

        void keyboard_KeyBoardKeyPressed(object sender, EventArgs e)
        {
            Console.WriteLine("Keyboard: " + FormatDateTime(DateTime.Now));
        }

        private string FormatDateTime(DateTime dateTime)
        {
            return dateTime.ToString("HH:mm:ss fff", CultureInfo.CurrentUICulture);
        }
        void mouse_MouseMoved(object sender, EventArgs e)
        {
            Console.WriteLine("Mouse: " +FormatDateTime(DateTime.Now));
        }
    }
}
