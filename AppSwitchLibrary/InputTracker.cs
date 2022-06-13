using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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


            new Test();

            Application.Run(new ApplicationContext());


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
            Console.WriteLine("Mouse: " + FormatDateTime(DateTime.Now));
        }
    }
}
