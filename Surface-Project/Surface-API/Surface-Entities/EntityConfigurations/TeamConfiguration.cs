

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Surface_Entities.Entities;

namespace Surface_Entities.EntityConfigurations
{
    public class TeamConfiguration : IEntityTypeConfiguration<Team>

    {
        public void Configure(EntityTypeBuilder<Team> entity)
        {
            entity.HasOne(e => e.Projects).WithMany(e=>e.Teams).HasForeignKey(e => e.ProjectId).IsRequired().OnDelete(DeleteBehavior.NoAction);
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

            entity.HasData(
                new Team[]
                {
                    new Team
                    {
                        Id=1,
                        Name="Design",
                        ProjectId = 1,
                        CreatedBy = 1,
                        CreatedOn = DateTime.Now,
                        ModifiedBy = 1,
                        ModifiedOn = DateTime.Now,
                    },
                    new Team
                    {
                        Id = 2,
                        Name = "Development",
                        ProjectId = 1,
                        CreatedBy = 2,
                        CreatedOn = DateTime.Now,
                        ModifiedBy = 2,
                        ModifiedOn = DateTime.Now,
                    },
                    new Team
                    {
                        Id = 3,
                        Name = "Testing",
                        ProjectId = 1,
                        CreatedBy = 3,
                        CreatedOn = DateTime.Now,
                        ModifiedBy = 3,
                        ModifiedOn = DateTime.Now,
                    },
                }
            );
        }
    }
}
