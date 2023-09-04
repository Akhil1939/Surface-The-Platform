

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Surface.Entities.DataModels;

namespace Surface_Entities.EntityConfigurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> entity)
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.HasIndex(e => e.Name).IsUnique();

            entity.HasData(
                new UserRole[]
                {
                    new UserRole
    {
        Id = 1,
        Name = "ProjectManager",
        CreatedOn = DateTime.UtcNow,
        ModifiedOn = DateTime.UtcNow,
    },
    new UserRole
    {
        Id = 2,
        Name = "ProjectMember",
        CreatedOn = DateTime.UtcNow,
        ModifiedOn = DateTime.UtcNow,
    },
    new UserRole
    {
        Id = 3,
        Name = "ProjectViewer",
        CreatedOn = DateTime.UtcNow,
        ModifiedOn = DateTime.UtcNow,
    },
    new UserRole
    {
        Id = 4,
        Name = "ProjectAdmin",
        CreatedOn = DateTime.UtcNow,
        ModifiedOn = DateTime.UtcNow,
    },
    new UserRole
    {
        Id = 5,
        Name = "TeamLeader",
        CreatedOn = DateTime.UtcNow,
        ModifiedOn = DateTime.UtcNow,
    },
    new UserRole
    {
        Id = 6,
        Name = "Developer",
        CreatedOn = DateTime.UtcNow,
        ModifiedOn = DateTime.UtcNow,
    },
    new UserRole
    {
        Id = 7,
        Name = "QAEngineer",
        CreatedOn = DateTime.UtcNow,
        ModifiedOn = DateTime.UtcNow,
    },
    new UserRole
    {
        Id = 8,
        Name = "BusinessAnalyst",
        CreatedOn = DateTime.UtcNow,
        ModifiedOn = DateTime.UtcNow,
    },
                }
                );

        }

    }
}
