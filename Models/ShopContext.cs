using Microsoft.EntityFrameworkCore;

namespace CardWebsite.Models
{
public class ShopContext(DbContextOptions<ShopContext> options) : DbContext(options)
    {
        public DbSet<Card> Cards { get; set; }
        public DbSet<Set> Sets { get; set; }
        public DbSet<Grade> Grades { get; set; } 
        public DbSet<Deck> Decks { get; set; }
        public DbSet<Collection> Collections { get; set; }
         
	}
}

