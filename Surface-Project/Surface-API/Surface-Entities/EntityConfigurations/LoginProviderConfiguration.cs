using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Surface.Common.Enums;
using Surface.Entities.DataModels;


namespace Surface_Entities.EntityConfigurations
{
    public class LoginProviderConfiguration : IEntityTypeConfiguration<LoginProvider>
    {
        public void Configure(EntityTypeBuilder<LoginProvider> entity)
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.HasIndex(e => e.Name).IsUnique();
            entity.Property(e => e.StatusId).HasDefaultValue(StatusEnum.UserStatus.Active);

            entity.HasData(

                new LoginProvider[]
                {
                    new LoginProvider
                    {
                        Id = 1,
                        Name = "Custom",
                        StatusId = 1,
                        CreatedOn= DateTime.UtcNow,
                        ModifiedOn= DateTime.UtcNow,
                    },
                    new LoginProvider
                    {
                        Id= 2,
                        Name="Google",
                        StatusId= 1,
                        CreatedOn= DateTime.UtcNow,
                        ModifiedOn= DateTime.UtcNow,
                    }
                });

        }
    }
}
