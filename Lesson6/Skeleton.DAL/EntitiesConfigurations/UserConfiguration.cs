using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Skeleton.DAL.Entities;

namespace DAL.EntitiesConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(20);
            builder.Property(x => x.Surname)
                .IsRequired()
                .HasMaxLength(20);
            builder.Property(x => x.Password)
                .IsRequired()
                .HasMaxLength(20);

            builder
                .HasMany(user => user.Tests)
                .WithOne(test => test.CreatedForUser)
                .HasForeignKey(test => test.CreatedForUserId)
                .HasPrincipalKey(user => user.Id)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
