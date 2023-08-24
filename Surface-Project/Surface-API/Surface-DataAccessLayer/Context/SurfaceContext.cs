using Microsoft.EntityFrameworkCore;
using surface.Entities.DataModels;
using Surface.Common.Utils;
using Surface.Entities.DataModels;

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
                        baseEntity.CreatedOn = DateTimeProvider.GetCurrentDateTime();
                        baseEntity.CreatedBy = userId;
                    }
                    baseEntity.ModifiedOn = DateTimeProvider.GetCurrentDateTime();
                    baseEntity.ModifiedBy = userId;
                }
                else if (IsTimeStampedEntity(entityEntry.Entity.GetType()))
                {
                    var timeStampedEntity = (dynamic)entityEntry.Entity;
                    if (entityEntry.State == EntityState.Added)
                    {
                        timeStampedEntity.CreatedOn = DateTimeProvider.GetCurrentDateTime();
                    }
                    timeStampedEntity.ModifiedOn = DateTimeProvider.GetCurrentDateTime();
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
            //return long.Parse(_httpContextAccessor.HttpContext.User.Identity?.Name ?? "0");
        }

        public DbSet<User> User { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<StatusGroup> StatusGroup { get; set; }
        public DbSet<LoginProvider> LoginProvider { get; set; }
       
    }
}