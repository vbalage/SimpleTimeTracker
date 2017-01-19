using System;
using System.ComponentModel.DataAnnotations.Schema;
using TimeTracker.DataTypes.Interfaces;
using TimeTracker.Models;
using TimeTracker.Utils.Interfaces;

namespace TimeTracker.DataTypes
{
    public class Session : NotifyBase, ISession
    {
        public ITimer Timer { get; }
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
        [NotMapped]
        public TimeSpan Length
        {
            get { return _length; }
            set {
                _length = value;
                OnPropertyChanged(nameof(Length));
            }
        }

        public long Id { get; protected set; }

        public Session(ITimer timer)
        {
            if (timer == null)
                throw new ArgumentNullException(nameof(timer));

            Timer = timer;
        }

        public Session()
        {
            
        }

        public void Start()
        {
            Timer.Start();
        }

        public void Pause()
        {
            Timer.Stop();
        }

        public void Stop()
        {
            if (!HasEnded)
                Stop();

            HasEnded = true;
            Length = Timer.Elapsed;
        }
    }
}
