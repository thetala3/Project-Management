using Microsoft.EntityFrameworkCore;
using Project_Management.Models;

namespace Project_Management
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskModel>()
                .HasKey(x => x.Id);
        }

        public DbSet<TaskModel> Tasks { get; set; }
    }
}
