using Microsoft.EntityFrameworkCore;
using RoyalLibrary.Domain.Entitie;

namespace RoyalLibrary.Infra.Context
{
    public class RoyalLibraryContext : DbContext
    {
        public RoyalLibraryContext(DbContextOptions<RoyalLibraryContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { }

        public DbSet<Book> Book { get; set; }
    }
}