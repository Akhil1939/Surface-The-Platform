using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Surface.Entities.DataModels;
using Surface_Entities.Entities;


namespace Surface_Entities.EntityConfigurations
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> entity)
        {
            entity
                                .HasOne(e => e.Statuses)
                                .WithMany()
                                .HasForeignKey(e => e.StatusId)
                                .IsRequired()
                                .OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(e => e.CreatedByUser)
                .WithMany()
                .HasForeignKey(e => e.CreatedBy)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(e => e.ModifiedByUser)
                .WithMany()
                .HasForeignKey(e => e.ModifiedBy)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);
            entity.HasMany(p => p.Teams)
               .WithOne(t => t.Projects)
               .HasForeignKey(t => t.ProjectId)
               .OnDelete(DeleteBehavior.Cascade);
            entity.HasData(
                new Project[]
                {
                    new Project
    {
        Id = 1,
        Name = "Surface",
        Description = "This is a demo project that all users are in this project",
        StartDate = DateTime.Now,
        ActualStartDate = DateTime.Now,
        EndDate = DateTime.Now.AddMonths(5),
        ActualEndDate = null,
        RepoLink = null,
        Budget = 5000,
        StatusId = 8,
        CreatedOn = DateTime.Now,
        CreatedBy = 1,
        ModifiedOn = DateTime.Now,
        ModifiedBy = 1,
    },
    new Project
    {
        Id = 2,
        Name = "Project A",
        Description = "A new development project",
        StartDate = DateTime.Now,
        ActualStartDate = DateTime.Now,
        EndDate = DateTime.Now.AddMonths(3),
        ActualEndDate = null,
        RepoLink = "https://github.com/projecta",
        Budget = 10000,
        StatusId = 8,
        CreatedOn = DateTime.Now,
        CreatedBy = 1,
        ModifiedOn = DateTime.Now,
        ModifiedBy = 1,
    },
    new Project
    {
        Id = 3,
        Name = "Project B",
        Description = "Another project for testing",
        StartDate = DateTime.Now,
        ActualStartDate = DateTime.Now,
        EndDate = DateTime.Now.AddMonths(2),
        ActualEndDate = null,
        RepoLink = "https://github.com/projectb",
        Budget = 7500,
        StatusId = 8,
        CreatedOn = DateTime.Now,
        CreatedBy = 1,
        ModifiedOn = DateTime.Now,
        ModifiedBy = 1,
    }
                });
        }
    }
}
