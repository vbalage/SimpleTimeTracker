using System;
using System.Collections.Generic;
using TimeTracker.DataTypes.Interfaces;
using TimeTracker.Models;

namespace TimeTracker.DataTypes
{
    internal class ProjectTask : NotifyBase, ITask
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));                
            }
        }

        public IList<ISession> Sessions { get; set; }

        public long Id { get; protected set; }

        public ProjectTask()
        {
            Name = string.Empty;
            Sessions = new List<ISession>();
        }
    }
}
