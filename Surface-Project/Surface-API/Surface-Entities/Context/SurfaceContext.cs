using Microsoft.EntityFrameworkCore;
using Surface_Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surface_Entities.Context
{
    public class SurfaceContext : DbContext
    {
        public SurfaceContext(DbContextOptions<SurfaceContext> options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<StatusGroup> StatusGroup { get; set; }
        public DbSet<LoginProvider> LoginProvider { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Ignore(x => x.Name);
        }
    }
}