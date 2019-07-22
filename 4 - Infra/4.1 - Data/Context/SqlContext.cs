using ddd.Domain.Entities;
using ddd.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace ddd.Infra.Data.Context
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {
        }

        public SqlContext(DbContextOptions<SqlContext> options)
            : base(options)
        {
        }

        public DbSet<Task> Task { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=NOT021-4A\\SQLEXPRESS;Database=ddd;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Task>(new TaskMap().Configure);
        }
    }
}
