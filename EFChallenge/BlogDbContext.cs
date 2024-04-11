using System.Data.Entity;

namespace EFChallenge
{
    public class BlogDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
