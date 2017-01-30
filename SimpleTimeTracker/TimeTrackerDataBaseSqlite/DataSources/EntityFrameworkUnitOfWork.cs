using System;
using System.Data.Entity;

namespace TimeTrackerDataBaseSqlite
{
	public class EntityFrameworkUnitOfWork
	{
		private readonly DbContext _context;

		public EntityFrameworkUnitOfWork(DbContext context)
		{
			_context = context;
		}

		public void Dispose()
		{

		}

		public void SaveChanges()
		{
			_context.SaveChanges();
		}
	}
}
