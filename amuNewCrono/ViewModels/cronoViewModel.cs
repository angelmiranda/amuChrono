using amuNewCrono.Models.Interfaces;
using amuNewCrono.ViewModels.Interfaces;
using System;
using System.ComponentModel;
using System.Windows.Threading;

namespace amuNewCrono.ViewModels
{
    public class cronoViewModel : ICronoViewModel, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public TimeSpan timeCronoValOut {
            get { return _cronoModel.cronoValues; }
            set { _cronoModel.cronoValues = value;
                PropertyChanged(this, new PropertyChangedEventArgs("timeCronoValOut"));
            }
        }

        private DispatcherTimer _timer;
        private ICronoModel _cronoModel;

        public cronoViewModel(ICronoModel cronoModel)
        {
            _cronoModel = cronoModel;

            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += new EventHandler(timer_Tick);
        }

        //Define timer
        private void timer_Tick(object sender, EventArgs arg)
        {
            timeCronoValOut = timeCronoValOut.Add(TimeSpan.FromSeconds(1));
        }

        //Define actions
        public void setCronoStop()
        {
            timeCronoValOut = new TimeSpan(0, 0, 0);
            _timer.Stop();
        }
        public void setCronoStart()
        {         
            _timer.Start();
        }

        public void setCronoPause()
        {
            if (_timer.IsEnabled)
            {
                _timer.Stop();
            }
            else
            {
                //Restart count only if it is paused
                if (timeCronoValOut.Ticks > 0)
                {
                    _timer.Start();
                }
            }
        }
    }
}
