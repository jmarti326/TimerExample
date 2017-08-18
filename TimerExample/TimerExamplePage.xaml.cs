using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TimerExample
{
    public partial class TimerExamplePage : ContentPage
    {
        public TimerExamplePage()
        {
            InitializeComponent();
        }

        void StartTimer_Clicked(object sender, System.EventArgs e)
        {

            var minutes = 1;
            var seconds = 60;


            Device.StartTimer(TimeSpan.FromSeconds(1),() => {

                if(seconds > 0)
                {
                    seconds--;


					// Refresh UI Label.
					timeLabel.Text = $"{minutes}:{seconds}";
                }
                else
                {

                    if(minutes > 0)
                    {
                        // We reset the seconds.
                        seconds = 60;

                        //We discount 1 from minutes.
                        minutes--;

                        // Refresh UI Label.
                        timeLabel.Text = $"{minutes}:{seconds}";
                    }
                    else
                    {
                        // We display a message.
                        DisplayAlert("We did it!","woot woot", "Ok");

                        // We return a false to stop the timer.
                        return false;
                    }
                }
                
                return true; // True = Repeat again, False = Stop the timer
			});
        }
    }
}
