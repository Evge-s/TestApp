using Microsoft.EntityFrameworkCore;
using TestApp.Models.UserModels;

namespace TestApp.Models.DataModels
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }

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

            base.OnModelCreating(modelBuilder);
        }
    }
}
