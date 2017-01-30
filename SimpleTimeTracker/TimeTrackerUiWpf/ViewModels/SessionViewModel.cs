using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TimeTracker.Core.Utils;
using TimeTracker.Interface.DataTypes;
using TimeTracker.Interface.Timer;
using TimeTrackerUiWpf.BaseClasses;
using TimeTrackerUiWpf.Commands;

namespace TimeTrackerUiWpf.ViewModels
{
    public enum SessionState
    {
        New,
        Started,
        Paused,
        Ended
    }

    public class SessionViewModel : ModelBase, ISession, IDisposable
    {
        private readonly ITimer _timer;
        private TimeSpan _elapsedTime;
        private SessionState _state;

        public SessionState State
        {
            get { return _state; }
            set
            {
                _state = value;
                OnPropertyChanged("State");
            }
        }

        public string Description { get; set; }

        public DateTime EndTime { get; set; }

        public Int32 Id { get; set; }

        public DateTime StartTime { get; set; }

        public ITask ParentTask { get; set; }

        public TimeSpan ElapsedTime
        {
            get { return _elapsedTime; }
            set
            {
                _elapsedTime = value;         
                OnPropertyChanged("ElapsedTime");       
            }
        }

        #region Commands

        public ICommand StartSessionCommand { get; set; }
        public ICommand EndSessionCommand { get; set; }
        public ICommand PauseSessionCommand { get; set; }

        #endregion

        public SessionViewModel(ITimerFactory timerFactory)
        {
            if(timerFactory == null)
                throw new ArgumentNullException("timerFactory");

            State = SessionState.New;

            _timer = timerFactory.Instance();
            _timer.TimeChanged += (sender, args) =>
            {
                ElapsedTime = new TimeSpan(_timer.ElapsedTimeTicks);
            };

            _timer.TimerStarted += (sender, args) =>
            {
                State = SessionState.Started;
            };

            _timer.TimerStopped += (sender, args) =>
            {
                State = SessionState.Ended;
            };

            StartSessionCommand = new RelayCommand(() => {_timer.Start();}, () => State != SessionState.Started);
            EndSessionCommand = new RelayCommand(() => _timer.Stop(), () => (State == SessionState.Started));
            PauseSessionCommand = new RelayCommand(() => _timer.Stop(), () => _timer.IsRunning);
        }

        public static SessionViewModel Create(ISession session)
        {
            return new SessionViewModel(new TimerFactory(new SimpleDateProvider()))
            {
                Id = session.Id,
                Description = session.Description,
                EndTime = session.EndTime,
                StartTime = session.StartTime,
                ParentTask = session.ParentTask
            };
        }

        public void Dispose()
        {
            _timer.Dispose();
        }
    }
}
