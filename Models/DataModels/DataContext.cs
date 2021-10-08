using Microsoft.EntityFrameworkCore;
using TestApp.Models.TestModels;
using TestApp.Models.UserModels;

namespace TestApp.Models.DataModels
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }

        public DataContext(DbContextOptions<DataContext> options)
         : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string userlog = "adminlog";
            string userpass = "adminpass";

            User testUser = new User { Id = 1, Login = userlog, Password = userpass };

            modelBuilder.Entity<User>().HasData(testUser);

            modelBuilder.Entity<Question>().OwnsMany(
               p => p.Answers, a =>
               {
                   a.WithOwner().HasForeignKey("QuestionId");
                   a.Property<int>("Id");
                   a.HasKey("Id");
               });

            base.OnModelCreating(modelBuilder);
        }
    }
}
