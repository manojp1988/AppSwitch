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
        private ActiveApplicationInput application;

        private String lastKeyboardActiveTime;
        private String lastMouseActiveTime;
        private ApplicationDetails latestApplication;

        private bool isListening = false;

        private Dictionary<string, ApplicationDetails> allAppDetails = new Dictionary<string, ApplicationDetails>();

        public InputTracker(bool _initWindowsForms = true)
        {

            Start();

            if (_initWindowsForms)
                Application.Run(new ApplicationContext());

        }

        public void Start()
        {
            if(isListening)
                return;

            
            keyboard = new KeyboardInput();
            keyboard.KeyBoardKeyPressed += keyboard_KeyBoardKeyPressed;

            mouse = new MouseInput();
            mouse.MouseMoved += mouse_MouseMoved;


            application = new ActiveApplicationInput();
            application.ApplicationSwitched += application_Switched;

            isListening = true;

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

             if(!isListening)
                return;

            keyboard.Dispose();
            mouse.Dispose();
            application.Dispose();

            keyboard = null;
            mouse = null;
            application = null;

            isListening = false;
        }

        public String GetLatestApplication()
        {
            List<ApplicationDetails> details = new List<ApplicationDetails>();

            if (latestApplication != null)
            {
                details.Add(latestApplication);


                ActiveApp app = new ActiveApp()
                {
                    details = details
                };


                return XmlUtils.Serialize(app);
            }


            return null;
        }

        public String GetAllActiveApplication()
        {
            if (allAppDetails.Any())
            {
                List<ApplicationDetails> applicationDetails = allAppDetails.Values.ToList();

                ActiveApp app = new ActiveApp()
                {
                    details = applicationDetails
                };

                return XmlUtils.Serialize(app);

            }

            return null;
        }

        public void Clear()
        {
            allAppDetails.Clear();
        }

        public void Exit()
        {
            System.Windows.Forms.Application.Exit();
        }

        void application_Switched(object sender, string e)
        {

            var now = DateTime.Now;
            var latestApplication = new ApplicationDetails()
            {
                Name = e,
                data = new ActiveData()
                {
                    Date = FormateDate(now),
                    Time = FormatDateTime(now)
                }
            };

            this.latestApplication = latestApplication;

            allAppDetails[e] = latestApplication;

        }

        void keyboard_KeyBoardKeyPressed(object sender, EventArgs e)
        {
            lastKeyboardActiveTime = FormatDateTime(DateTime.Now);
        }

        private string FormatDateTime(DateTime dateTime)
        {
            return dateTime.ToString("HH:mm:ss fff", CultureInfo.CurrentUICulture);
        }

        private string FormateDate(DateTime dateTime)
        {
            return dateTime.ToString("yyMMdd", CultureInfo.CurrentUICulture);
        }


        void mouse_MouseMoved(object sender, EventArgs e)
        {
            lastMouseActiveTime = FormatDateTime(DateTime.Now);
        }
    }
}
