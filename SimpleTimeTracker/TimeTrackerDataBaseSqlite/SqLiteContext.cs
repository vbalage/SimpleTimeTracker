using System.Data.Entity;
using TimeTracker.Interface.DataSources;
using TimeTracker.Interface.DataTypes;

namespace TimeTrackerDataBaseSqlite
{
    public class SqLiteContext : DbContext
    {
        // Your context has been configured to use a 'SqLiteContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'TimeTracker.DataSources.SqLiteContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'SqLiteContext' 
        // connection string in the application configuration file.
        public SqLiteContext()
            : base("name=SQLiteContext")
        {
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<SqLiteContext>(modelBuilder);
        //    Database.SetInitializer(sqliteConnectionInitializer);

        //    //var model = modelBuilder.Build(Database.Connection);
        //    //IDatabaseCreator sqliteDatabaseCreator = new SqliteDatabaseCreator();
        //    //sqliteDatabaseCreator.Create(Database, model);
        //}

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<ISession> Sessions { get; set; }
        public virtual DbSet<ITask> Tasks { get; set; }
    }
}