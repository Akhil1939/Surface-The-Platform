using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Surface.Entities.DataModels;


namespace Surface_Entities.EntityConfigurations
{
    public class StatusConfiguration : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> entity)
        {
            entity
                                .HasOne(e => e.StatusGroup)
                                .WithMany()
                                .HasForeignKey(e => e.StatusGroupId)
                                .IsRequired()
                                .OnDelete(DeleteBehavior.NoAction);


            entity.HasData(
    new Status[]
    {
        // User Statuses
        new Status
        {
            Id = 1,
            Name = "Active",
            StatusGroupId = 1,
            CreatedOn = DateTime.Now,
            ModifiedOn = DateTime.Now,
        },
        new Status
        {
            Id = 2,
            Name = "Inactive",
            StatusGroupId = 1,
            CreatedOn = DateTime.Now,
            ModifiedOn = DateTime.Now,
        },
        new Status
        {
            Id = 3,
            Name = "Reported",
            StatusGroupId = 1,
            CreatedOn = DateTime.Now,
            ModifiedOn = DateTime.Now,
        },
        new Status
        {
            Id = 4,
            Name = "Blocked",
            StatusGroupId = 1,
            CreatedOn = DateTime.Now,
            ModifiedOn = DateTime.Now,
        },
        new Status
        {
            Id = 5,
            Name = "Deleted",
            StatusGroupId = 1,
            CreatedOn = DateTime.Now,
            ModifiedOn = DateTime.Now,
        },
        new Status
        {
            Id = 6,
            Name = "Locked",
            StatusGroupId = 1,
            CreatedOn = DateTime.Now,
            ModifiedOn = DateTime.Now,
        },
        // ... Other User Statuses

        // Project Statuses
        new Status
        {
            Id = 7,
            Name = "Planning",
            StatusGroupId = 2,
            CreatedOn = DateTime.Now,
            ModifiedOn = DateTime.Now,
        },
        new Status
        {
            Id = 8,
            Name = "Active",
            StatusGroupId = 2,
            CreatedOn = DateTime.Now,
            ModifiedOn = DateTime.Now,
        },
        new Status
        {
            Id = 9,
            Name = "On Hold",
            StatusGroupId = 2,
            CreatedOn = DateTime.Now,
            ModifiedOn = DateTime.Now,
        },
        new Status
        {
            Id = 10,
            Name = "Completed",
            StatusGroupId = 2,
            CreatedOn = DateTime.Now,
            ModifiedOn = DateTime.Now,
        },
        new Status
        {
            Id = 11,
            Name = "Cancelled",
            StatusGroupId = 2,
            CreatedOn = DateTime.Now,
            ModifiedOn = DateTime.Now,
        },
        // ... Other Project Statuses

        // Task Statuses
        new Status
        {
            Id = 12,
            Name = "To Do",
            StatusGroupId = 3,
            CreatedOn = DateTime.Now,
            ModifiedOn = DateTime.Now,
        },
        new Status
        {
            Id = 13,
            Name = "In Progress",
            StatusGroupId = 3,
            CreatedOn = DateTime.Now,
            ModifiedOn = DateTime.Now,
        },
        new Status
        {
            Id = 14,
            Name = "Blocked",
            StatusGroupId = 3,
            CreatedOn = DateTime.Now,
            ModifiedOn = DateTime.Now,
        },
        new Status
        {
            Id = 15,
            Name = "Completed",
            StatusGroupId = 3,
            CreatedOn = DateTime.Now,
            ModifiedOn = DateTime.Now,
        },
        new Status
        {
            Id = 16,
            Name = "Deferred",
            StatusGroupId = 3,
            CreatedOn = DateTime.Now,
            ModifiedOn = DateTime.Now,
        },
        // ... Other Task Statuses

        // Feature Statuses
        new Status
        {
            Id = 17,
            Name = "Idea",
            StatusGroupId = 4,
            CreatedOn = DateTime.Now,
            ModifiedOn = DateTime.Now,
        },
        new Status
        {
            Id = 18,
            Name = "Backlog",
            StatusGroupId = 4,
            CreatedOn = DateTime.Now,
            ModifiedOn = DateTime.Now,
        },
        new Status
        {
            Id = 19,
            Name = "In Progress",
            StatusGroupId = 4,
            CreatedOn = DateTime.Now,
            ModifiedOn = DateTime.Now,
        },
        new Status
        {
            Id = 20,
            Name = "Testing",
            StatusGroupId = 4,
            CreatedOn = DateTime.Now,
            ModifiedOn = DateTime.Now,
        },
        new Status
        {
            Id = 21,
            Name = "Released",
            StatusGroupId = 4,
            CreatedOn = DateTime.Now,
            ModifiedOn = DateTime.Now,
        },
        // ... Other Feature Statuses

        // Bug Statuses
        new Status
        {
            Id = 22,
            Name = "Reported",
            StatusGroupId = 5,
            CreatedOn = DateTime.Now,
            ModifiedOn = DateTime.Now,
        },
        new Status
        {
            Id = 23,
            Name = "In Progress",
            StatusGroupId = 5,
            CreatedOn = DateTime.Now,
            ModifiedOn = DateTime.Now,
        },
        new Status
        {
            Id = 24,
            Name = "Reproduced",
            StatusGroupId = 5,
            CreatedOn = DateTime.Now,
            ModifiedOn = DateTime.Now,
        },
        new Status
        {
            Id = 25,
            Name = "Fixed",
            StatusGroupId = 5,
            CreatedOn = DateTime.Now,
            ModifiedOn = DateTime.Now,
        },
        new Status
        {
            Id = 26,
            Name = "Verified",
            StatusGroupId = 5,
            CreatedOn = DateTime.Now,
            ModifiedOn = DateTime.Now,
        },
        // ... Other Bug Statuses
    }
);
        }
    }
}
