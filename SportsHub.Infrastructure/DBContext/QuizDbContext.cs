using Microsoft.EntityFrameworkCore;
using Quiz_Api.Shared.Entities;

namespace Quiz_Api.Infrastructure.DBContext
{
    public partial class QuizDbContext : DbContext
    {
        public QuizDbContext()
        {
        }

        public QuizDbContext(DbContextOptions<QuizDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Question> Questions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=QuizDb;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Options).IsRequired();

                entity.Property(e => e.QuestionText).IsRequired();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
