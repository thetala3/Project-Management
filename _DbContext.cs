using Microsoft.EntityFrameworkCore;
using Project_Management.Models;

namespace Project_Management
{
    public class _DbContext : DbContext
    {
        public _DbContext(DbContextOptions<DbContext> options) : base(options)
        {
        }

        public DbSet<TaskModel> Tasks { get; set; }
    }
}
