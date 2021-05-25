using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace StopWatch
{
    public partial class StopWatch : Form
    {
        Stopwatch stopwatch = new Stopwatch();
        public StopWatch()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            stopwatch.Start();

            TimeSpan elapsed = stopwatch.Elapsed;

            while(stopwatch.IsRunning)
            {
                elapsed = stopwatch.Elapsed;

                int hours = elapsed.Hours;
                int minutes = elapsed.Minutes;
                int seconds = elapsed.Seconds;

                string HoursToString   = hours.ToString();
                string MinutesToString = minutes.ToString();
                string SecondsToString = seconds.ToString();

                string ElapsedTimeString = HoursToString + ":" + MinutesToString + ":" + SecondsToString;

                TimerBox.Text = ElapsedTimeString;
                Thread.Sleep(1000);
                TimerBox.Refresh();
                Application.DoEvents();
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
            TimerBox.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
