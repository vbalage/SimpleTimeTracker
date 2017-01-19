using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.DataSources.Interfaces;
using TimeTracker.DataTypes.Interfaces;

namespace TimeTracker.DataSources
{
    internal class SessionRepository : IRepository<ISession>
    {
        public void Create(ISession entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ISession entity)
        {
            throw new NotImplementedException();
        }

        public ISession GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Update(ISession entity)
        {
            throw new NotImplementedException();
        }
    }
}
