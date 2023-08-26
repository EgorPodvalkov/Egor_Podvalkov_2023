using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.EntitiesConfigurations
{
    public class TestConfiguration : IEntityTypeConfiguration<Test>
    {
        public void Configure(EntityTypeBuilder<Test> builder)
        {
            builder.HasKey(x => x.ID);

            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(20);
            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(300);

            builder
                .HasMany(test => test.Questions)
                .WithOne(quest => quest.Test)
                .HasForeignKey(quest => quest.TestID)
                .HasPrincipalKey(test => test.ID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
