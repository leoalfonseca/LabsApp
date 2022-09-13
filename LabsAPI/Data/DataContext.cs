using Microsoft.EntityFrameworkCore;

namespace LabsAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<TaskType> TasksTypes { get; set; }
        public DbSet<Status> Statuses { get; set; }
    }
}
