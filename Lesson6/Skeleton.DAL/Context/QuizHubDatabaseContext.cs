using Microsoft.EntityFrameworkCore;
using Skeleton.DAL.Entities;

namespace Skeleton.DAL.Context
{
    public class QuizHubDatabaseContext:DbContext
    {
        public QuizHubDatabaseContext() { }

        public QuizHubDatabaseContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
