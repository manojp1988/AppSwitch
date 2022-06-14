using AppSwitchLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form1 : Form
    {

        private InputTracker inputTracker;

        public Form1()
        {
            InitializeComponent();

            inputTracker = new InputTracker(false);
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            inputTracker.Start();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            inputTracker.Stop();
        }

        private void keyboardActiveBtn_Click(object sender, EventArgs e)
        {
            var time = inputTracker.GetLastKeyboardActiveTime();
            keyboardActiveLabel.Text = time == null ? "No Activity" : time;
        }

        private void mouseActiveBtn_Click(object sender, EventArgs e)
        {
            var time = inputTracker.GetLastMouseActiveTime();
            mouseActiveLabel.Text = time == null ? "No Activity" : time;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            inputTracker.Exit();
        }
    }
}
