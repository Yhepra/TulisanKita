using Microsoft.EntityFrameworkCore;
using TulisanKita.Models;

namespace TulisanKita.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Roles> Roles { get;set; }
        public virtual DbSet<User> Users { get;set; }
        public virtual DbSet<Blog> Blogs { get;set; }
    }
}
