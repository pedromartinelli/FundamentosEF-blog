using FundamentosEF_Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace FundamentosEF_Blog.Data
{
    public class BlogDataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=localhost,1433;Database=Blog;User Id=sa;Password=1q2w3e!@#;TrustServerCertificate=True");

    }
}
