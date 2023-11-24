using Microsoft.EntityFrameworkCore;
using surface.Entities.DataModels;
using Surface.Entities.Configurations;
using Surface.Entities.DataModels;
using Surface_Entities.Entities;
using Surface_Entities.EntityConfigurations;

namespace Surface_Entities.Context
{
    public class SurfaceContext : DbContext
    {

        public SurfaceContext(DbContextOptions<SurfaceContext> options) : base(options)
        {
        }

        //Overriding SavechangesAsync
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => (IsBaseEntity(e.Entity.GetType()) || IsTimeStampedEntity(e.Entity.GetType())) &&
                    (e.State == EntityState.Added || e.State == EntityState.Modified));
            foreach (var entityEntry in entries)
            {
                if (IsBaseEntity(entityEntry.Entity.GetType()))
                {
                    var baseEntity = (dynamic)entityEntry.Entity;
                    long userId = GetUserId();
                    if (entityEntry.State == EntityState.Added)
                    {
                        baseEntity.CreatedOn = DateTime.UtcNow;
                        baseEntity.CreatedBy = userId;
                    }
                    baseEntity.ModifiedOn = DateTime.UtcNow;
                    baseEntity.ModifiedBy = userId;
                }
                else if (IsTimeStampedEntity(entityEntry.Entity.GetType()))
                {
                    var timeStampedEntity = (dynamic)entityEntry.Entity;
                    if (entityEntry.State == EntityState.Added)
                    {
                        timeStampedEntity.CreatedOn = DateTime.UtcNow;
                    }
                    timeStampedEntity.ModifiedOn = DateTime.UtcNow;
                }
                else if (IsAuditableEntity(entityEntry.Entity.GetType()))
                {
                    var auditableEnity = (dynamic)entityEntry.Entity;
                    long userId = GetUserId();
                    if (entityEntry.State == EntityState.Added)
                    {
                        auditableEnity.CreatedBy = userId;
                    }
                    auditableEnity.ModifiedBy = userId;
                }
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
        //Helper methods
        private static bool IsAuditableEntity(Type entityType)
        {
            var baseType = entityType.BaseType;
            while (baseType != null)
            {
                if (baseType.IsGenericType &&
                    baseType.GetGenericTypeDefinition() == typeof(AuditableEntity<>))
                {
                    return true;
                }
                baseType = baseType.BaseType;
            }
            return false;
        }
        private static bool IsTimeStampedEntity(Type entityType)
        {
            var baseType = entityType.BaseType;
            while (baseType != null)
            {
                if (baseType.IsGenericType &&
                    baseType.GetGenericTypeDefinition() == typeof(TimeStampedEntity<>))
                {
                    return true;
                }
                baseType = baseType.BaseType;
            }
            return false;
        }
        private static bool IsBaseEntity(Type entityType)
        {
            var baseType = entityType.BaseType;
            while (baseType != null)
            {
                if (baseType.IsGenericType &&
                    baseType.GetGenericTypeDefinition() == typeof(BaseEntity<>))
                {
                    return true;
                }
                baseType = baseType.BaseType;
            }
            return false;
        }

        private long GetUserId()
        {
            return 1;
           // return long.Parse(_httpContextAccessor.HttpContext.User.Identity?.Name ?? "0");
        }

        public DbSet<StatusGroup> StatusGroups { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<LoginProvider> LoginProviders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Project> Projects {  get; set; }
        public DbSet<CustomerStory> CustomerStories { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StatusGroupConfiguration());
            modelBuilder.ApplyConfiguration(new StatusConfiguration());
            modelBuilder.ApplyConfiguration(new LoginProviderConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerStoryConfiguration());
            modelBuilder.ApplyConfiguration(new TeamConfiguration());
            modelBuilder.ApplyConfiguration(new TeamMemberConfiguration());
        }
    }
}