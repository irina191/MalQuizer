using MalQuizer.Models;
using Microsoft.EntityFrameworkCore;

namespace MalQuizer.Data
{
    public class QuizerDb : DbContext
    {
        public QuizerDb(DbContextOptions<QuizerDb> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Quiz>()
                .HasMany(o => o.Questions)
                .WithOne(q => q.Quiz);
        }

        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Question> Questions { get; set; }
    }
}
