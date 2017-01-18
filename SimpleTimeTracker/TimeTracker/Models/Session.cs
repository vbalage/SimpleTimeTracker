using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using TimeTracker.Interface;
using TimeTracker.Models.Interfaces;

namespace TimeTracker.Models
{
    internal class Session : NotifyBase, ISession
    {
        private ITimer _timer;
        public ITask ParentTask { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }

        private bool _hasEnded;
        public bool HasEnded
        {
            get { return _hasEnded; }
            set {
                _hasEnded = value;
                OnPropertyChanged(nameof(HasEnded));
            }
        }

        private TimeSpan _length;
        public TimeSpan Length
        {
            get { return _length; }
            set {
                _length = value;
                OnPropertyChanged(nameof(Length));
            }
        }


        public Session(ITimer timer)
        {
            if (timer == null)
                throw new ArgumentNullException(nameof(timer));

            _timer = timer;
        }

        public void Start()
        {
            _timer.Start();
        }

        public void Pause()
        {
            _timer.Stop();
        }

        public void Stop()
        {
            if (!HasEnded)
                Stop();

            HasEnded = true;
            Length = _timer.Elapsed;
        }
    }
}
