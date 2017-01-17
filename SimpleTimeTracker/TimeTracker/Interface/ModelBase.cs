using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.Interface
{
    internal abstract class ModelBase : IComponent
    {
        public string Name { get; set; }

        public string Title { get; set; }
    }
}
