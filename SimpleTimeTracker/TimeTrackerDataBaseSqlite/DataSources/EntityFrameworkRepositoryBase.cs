using System;
using System.Collections.Generic;
using System.Data.Entity;
using TimeTracker.Interface.DataSources;
using TimeTracker.Interface.DataTypes;

namespace TimeTrackerDataBaseSqlite
{
	public class EntityFrameworkRepositoryBase<TEntity, TKey> 
		: IRepository<TEntity,TKey> where TEntity : class, IEntity<TKey>
	{
		private readonly DbContext _dbContext;

		public EntityFrameworkRepositoryBase(DbContext dbContext)
		{
			if (dbContext == null) throw new ArgumentNullException(nameof(dbContext));
			_dbContext = dbContext;
		}

		protected DbContext DbContext
		{
			get { return _dbContext; }
		}

		public void Create(TEntity entity)
		{
			if (entity == null) throw new ArgumentNullException(nameof(entity));
			DbContext.Set<TEntity>().Add(entity);
		}

		public TEntity GetById(TKey id)
		{
			return _dbContext.Set<TEntity>().Find(id);
		}

		public void Delete(TEntity entity)
		{
			if (entity == null) throw new ArgumentNullException(nameof(entity));
			DbContext.Set<TEntity>().Attach(entity);
			DbContext.Set<TEntity>().Remove(entity);
		}

		public void Update(TEntity entity)
		{
			if (entity == null) throw new ArgumentNullException(nameof(entity));
			DbContext.Set<TEntity>().Attach(entity);
			DbContext.Entry(entity).State = EntityState.Modified;
		}

		public IEnumerable<TEntity> GetAll()
		{
			return _dbContext.Set<TEntity>();
		}

	}
}
