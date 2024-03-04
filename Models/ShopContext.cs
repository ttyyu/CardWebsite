using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CardWebsite.Models
{
public class ShopContext : IdentityDbContext<IdentityUser>
    {
        public ShopContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Card> Cards { get; set; }
        public DbSet<Set> Sets { get; set; }
        public DbSet<Grade> Grades { get; set; } 
        public DbSet<Deck> Decks { get; set; }
        public DbSet<Collection> Collections { get; set; }
         
	}
}

