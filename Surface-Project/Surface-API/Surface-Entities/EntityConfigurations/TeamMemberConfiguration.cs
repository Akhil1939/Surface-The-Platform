

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Surface_Entities.Entities;

namespace Surface_Entities.EntityConfigurations
{
    public class TeamMemberConfiguration : IEntityTypeConfiguration<TeamMember>
    {
        public void Configure(EntityTypeBuilder<TeamMember> entity)
        {
            entity
                                 .HasOne(e => e.Status)
                                 .WithMany()
                                 .HasForeignKey(e => e.StatusId)
                                 .IsRequired()
                                 .OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(e => e.Teams).WithMany(e => e.TeamMembers).HasForeignKey(e => e.TeamId).IsRequired().OnDelete(DeleteBehavior.Restrict);
            entity.HasOne(e => e.Users).WithMany(e=>e.TeamMembers).HasForeignKey(E => E.UserId).IsRequired().OnDelete(DeleteBehavior.NoAction);
        }
    }
}
