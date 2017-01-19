using SQLite.CodeFirst;

namespace TimeTracker.DataSources
{
    using DataTypes;
    using System;
    using System.Data.Entity;
    using System.Data.SQLite;
    using System.Linq;

    public class TimeTrackerContext : DbContext
    {
        // Your context has been configured to use a 'TimeTrackerContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'TimeTracker.DataSources.TimeTrackerContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'TimeTrackerContext' 
        // connection string in the application configuration file.
        public TimeTrackerContext()
            : base("name=SQLiteContext")
        {
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<TimeTrackerContext>(modelBuilder);
        //    Database.SetInitializer(sqliteConnectionInitializer);

        //    //var model = modelBuilder.Build(Database.Connection);
        //    //IDatabaseCreator sqliteDatabaseCreator = new SqliteDatabaseCreator();
        //    //sqliteDatabaseCreator.Create(Database, model);
        //}

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Session> Sessions { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
    }
}