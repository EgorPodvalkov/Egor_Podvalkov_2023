using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Skeleton.DAL.Entities;

namespace DAL.EntitiesConfigurations
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Text)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .HasMany(quest => quest.Answers)
                .WithOne(answer => answer.Question)
                .HasForeignKey(answer => answer.QuestionId)
                .HasPrincipalKey(quest => quest.Id)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
