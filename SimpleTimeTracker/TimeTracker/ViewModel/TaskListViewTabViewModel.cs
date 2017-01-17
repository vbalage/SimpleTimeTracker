using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Interface;

namespace TimeTracker.ViewModel
{
    internal class TaskListViewTabViewModel : ModelBase {

        IDataModel DataModel { get; set; }

        public TaskListViewTabViewModel(IApplicationParameters app)
        {
            Name = "TaskListTabItem";
            Title = "Task list";

            if (app == null)
                throw new ArgumentNullException(nameof(app));

            DataModel = app.DataModel;
        }

    }
    
}
