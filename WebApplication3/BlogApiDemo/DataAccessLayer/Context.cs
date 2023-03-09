using Microsoft.EntityFrameworkCore;

namespace BlogApiDemo.DataAccessLayer
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-ICTBULH\\SQLEXPRESS;database=BlogApiDb; integrated security=true;TrustServerCertificate=True;Trusted_Connection=True", options => options.EnableRetryOnFailure());
        }
        public DbSet <Employee> Employees { get; set; }
    }
}
