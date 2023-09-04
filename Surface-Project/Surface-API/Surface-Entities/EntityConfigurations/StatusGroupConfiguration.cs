using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Surface.Entities.DataModels;
using Surface_Entities.Entities;

namespace Surface_Entities.EntityConfigurations
{
    public class StatusGroupConfiguration : IEntityTypeConfiguration<StatusGroup>
    {
        public void Configure(EntityTypeBuilder<StatusGroup> entity)
        {
            entity.HasData(
    new StatusGroup[]
    {
                    new StatusGroup
                    {
                        Id = 1,
                        Name = "User",
                        CreatedOn = DateTime.Now,
                        ModifiedOn = DateTime.Now,
                    },
                    new StatusGroup
                    {
                        Id= 2,
                        Name="Project",
                        CreatedOn = DateTime.Now,
                        ModifiedOn = DateTime.Now,
                    },
                    new StatusGroup
                    {
                        Id = 3,
                        Name="Task",
                        CreatedOn= DateTime.Now,
                        ModifiedOn= DateTime.Now,
                    },
                    new StatusGroup
    {
        Id = 4,
        Name = "Feature",
        CreatedOn = DateTime.Now,
        ModifiedOn = DateTime.Now,
    },
    new StatusGroup
    {
        Id = 5,
        Name = "Bug",
        CreatedOn = DateTime.Now,
        ModifiedOn = DateTime.Now,
    },
    new StatusGroup
    {
        Id = 6,
        Name= "Customer Story",
        CreatedOn = DateTime.Now,
        ModifiedOn = DateTime.Now,
    }
     
    }
    );
        }
    }
}
