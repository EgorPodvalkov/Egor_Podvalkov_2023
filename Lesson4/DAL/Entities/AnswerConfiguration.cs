using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Entities
{
    public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.HasKey(x => x.ID);

            builder.Property(x => x.Text)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.IsCorrect)
                .IsRequired();
        }
    }
}
