using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Interface;

namespace TimeTracker.Model
{
    public class ApplicationParameters : IApplicationParameters
    {
        public IDataModel DataModel { get; set; }
    }
}
