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
        private ActiveApplication application;

        private String lastKeyboardActiveTime;
        private String lastMouseActiveTime;

        public InputTracker(bool _initWindowsForms = true)
        {

            Start();

            if (_initWindowsForms)
                Application.Run(new ApplicationContext());

        }

        public void Start()
        {
            keyboard = new KeyboardInput();
            keyboard.KeyBoardKeyPressed += keyboard_KeyBoardKeyPressed;

            mouse = new MouseInput();
            mouse.MouseMoved += mouse_MouseMoved;


            application = new ActiveApplication();
            application.ApplicationSwitched += application_Switched;

        }

        public string GetLastKeyboardActiveTime()
        {
            return lastKeyboardActiveTime;
        }

        public string GetLastMouseActiveTime()
        {
            return lastMouseActiveTime;
        }

        public void Stop()
        {
            keyboard.Dispose();
            mouse.Dispose();
            application.Dispose();
        }

        public void Exit()
        {
            System.Windows.Forms.Application.Exit();
        }

        void application_Switched(object sender, string e)
        {
            Console.WriteLine("Switched to: " + e + " at : " + FormatDateTime(DateTime.Now));
        }

        void keyboard_KeyBoardKeyPressed(object sender, EventArgs e)
        {
            lastKeyboardActiveTime = FormatDateTime(DateTime.Now);
        }

        private string FormatDateTime(DateTime dateTime)
        {
            return dateTime.ToString("HH:mm:ss fff", CultureInfo.CurrentUICulture);
        }

        void mouse_MouseMoved(object sender, EventArgs e)
        {
            lastMouseActiveTime = FormatDateTime(DateTime.Now);
        }
    }
}
