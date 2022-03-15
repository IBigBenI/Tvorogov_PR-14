using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tvorogov_PR_14
{
    public partial class MainPage : ContentPage
    {
        int alive = 1;
        string time;
        bool a = true;
        public MainPage()
        {
            InitializeComponent();
        }
        private void StartStopTimer(object sender, EventArgs e)
        {
            if (alive % 2 != 0)
            {
                Timer();
            }
            else { LabelTimer.Text = DateTime.Now.ToString("F") + " " + time; }
            alive++;
        } 
        public string Timer()
        {
            double seconds = 0;
            double minute = 0;
            double hours = 0;
            Device.StartTimer(TimeSpan.FromSeconds(0.1), () =>
            {
                seconds += 0.1;
                if (seconds == 60)
                {
                    seconds = 0;
                    minute++;
                    if (minute == 60)
                    {
                        minute = 0;
                        hours++;
                    }
                }
                time = LabelTimer.Text = hours.ToString("00") + ":" + minute.ToString("00") + ":" + seconds.ToString("00.0");
                LabelTimer.Text = time;
                if (alive % 2 != 0) { return true; }
                else
                {
                    return false;
                }
            });
            return time;
        }
    }
}
