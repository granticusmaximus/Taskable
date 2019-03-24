using System;
using Microsoft.EntityFrameworkCore;
using Taskable.Models;

namespace Taskable.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Tasks> Tasks { get; set; }
    }
}
