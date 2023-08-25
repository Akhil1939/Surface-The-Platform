using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Surface.Common.Constants;
using Surface.Common.Enums;
using Surface.Entities.DataModels;

namespace Surface.Entities.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> entity)
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasIndex(e => e.Email).IsUnique();
        
            entity.Property(e => e.CreatedOn).HasDefaultValueSql(SystemConstant.DEFAULT_DATETIME);
            entity.Property(e => e.ModifiedOn).HasDefaultValueSql(SystemConstant.DEFAULT_DATETIME);
            entity.Property(e => e.StatusId).HasDefaultValue(StatusEnum.UserStatus.Active);
            entity.Property(e => e.AccessFailedCount).HasDefaultValue(SystemConstant.DEFAULT_ACCESS_FAILED_COUNT);
            entity.Property(e => e.MustChangePassword).HasDefaultValue(SystemConstant.DEFAULT_MUST_CHANGE_PASSWORD);
            
          
            entity
                                .HasOne(e => e.LoginProvider)
                                .WithMany()
                                .HasForeignKey(e => e.LoginProviderId)
                                .IsRequired()
                                .OnDelete(DeleteBehavior.NoAction);
            entity
                                .HasOne(e => e.Status)
                                .WithMany()
                                .HasForeignKey(e => e.StatusId)
                                .IsRequired()
                                .OnDelete(DeleteBehavior.NoAction);

            entity
                .HasData(new User[]
                {
                    new User
                    {
                        Id = 1,
                        Email = "admin@gmail.com",
                        Password = "5652DDF6EA419A920A948A4BBA99A1B48B434D1237218FCF8D2DA2DA41E7C0F4046BC10C12ABDA86D09022B2AD1D6F566F82F3DF72CDFAEE40AB154537DFB8FD",
                        Salt = "+QA9bkBDYMlaPDTRzIYMoPeMDd9oa9k/Ay4Lg==",
                        LoginProviderId = 1,
                        StatusId = 1,
                        AccessFailedCount = 0,
                        MustChangePassword = false,
                        Avatar="",
                        CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    }
                });
        }
    }
}
