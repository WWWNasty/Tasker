using System.Data.Entity;
using Domain;

namespace DataAccess
{
    public class ObjectiveContext : DbContext
    {
        public DbSet<Objective> Objectives { get; set; }

        public ObjectiveContext() : base("ObjectiveContext")
        {
        }

        public ObjectiveContext(string connectionString) : base(connectionString)
        {
        }
    }
}