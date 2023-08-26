using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.EntitiesConfigurations
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasKey(x => x.ID);

            builder.Property(x => x.Text)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .HasMany(quest => quest.Answers)
                .WithOne(answer => answer.Question)
                .HasForeignKey(answer => answer.QuestionID)
                .HasPrincipalKey(quest => quest.ID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
