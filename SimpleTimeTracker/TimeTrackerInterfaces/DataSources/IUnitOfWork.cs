using System;
namespace TimeTracker.Interface
{
	public interface IUnitOfWork
	{
		void SaveChanges();
	}
}
