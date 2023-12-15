using At.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace At.Persistance.Context
{
    public sealed class TaskManagementContext : DbContext
    {
        public TaskManagementContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<AppTask> AppTasks { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<TaskReport> TaskReports  { get; set; }
    }
}
