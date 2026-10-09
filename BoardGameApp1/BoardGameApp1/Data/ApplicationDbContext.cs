using BoardGameApp1.Data.Domail;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BoardGameApp1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<Creators> Games { get; set; } = null!;
        public DbSet<Sellers> Developers { get; set; } = null!;
        public DbSet<BoardgamesSellers> Genres { get; set; } = null!;
        public DbSet<Boardgames> Tags { get; set; } = null!;
    }
}
