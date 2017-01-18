using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Interface;
using TimeTracker.Models;
using TimeTracker.ViewModels;
using TimeTracker.ViewModels.Interfaces;
using TimeTracker.Views;

namespace TimeTracker
{
    internal class ApplicationViewModel
    {       

        public ApplicationParameters AppParams { get; set; }

        public ApplicationViewModel()
        {

            AppParams = new ApplicationParameters
            {
                DataModel = new DataModel()
            };
   
        }
    }
}
