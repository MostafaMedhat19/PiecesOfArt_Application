using Microsoft.EntityFrameworkCore;
using PiecesOfArt_Application.Business_Layer.BLL.Models;

namespace PiecesOfArt_Application.Infrastructures_Layer.DAL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Impressionism", Description = "A 19th-century art movement..." },
                new Category { Id = 2, Name = "Renaissance", Description = "A period in European history..." },
                new Category { Id = 3, Name = "Abstract", Description = "Art that uses shapes and colors..." },
                new Category { Id = 4, Name = "Modern", Description = "Artistic work from late 19th century..." },
                new Category { Id = 5, Name = "Ancient", Description = "Art from ancient civilizations..." }
            );

          
            modelBuilder.Entity<LoyaltyCard>().HasData(
                new LoyaltyCard { Id = 1, Name = "Bronze", Description = "10% Off" },
                new LoyaltyCard { Id = 2, Name = "Silver", Description = "20% Off" },
                new LoyaltyCard { Id = 3, Name = "Gold", Description = "30% Off" },
                new LoyaltyCard { Id = 4, Name = "Platinum", Description = "40% Off" },
                new LoyaltyCard { Id = 5, Name = "Crystal", Description = "50% Off" }
            );

          
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Nourhan", Email = "nourhan@example.com", Age = 26, LoyaltyCardId = 1 },
                new User { Id = 2, Name = "Ahmed", Email = "ahmed@example.com", Age = 35, LoyaltyCardId = 2 },
                new User { Id = 3, Name = "Mona", Email = "mona@example.com", Age = 30, LoyaltyCardId = 3 },
                new User { Id = 4, Name = "Ali", Email = "ali@example.com", Age = 22, LoyaltyCardId = 4 },
                new User { Id = 5, Name = "Sara", Email = "sara@example.com", Age = 28, LoyaltyCardId = 5 }
            );

         
            modelBuilder.Entity<PieceOfArt>().HasData(
                new PieceOfArt { Id = 1, Title = "Starry Night", Price = 100000, PublicationDate = new DateTime(1889, 6, 1), UserId = 1, CategoryId = 1 },
                new PieceOfArt { Id = 2, Title = "Mona Lisa", Price = 500000, PublicationDate = new DateTime(1503, 1, 1), UserId = 2, CategoryId = 2 },
                new PieceOfArt { Id = 3, Title = "Composition VIII", Price = 120000, PublicationDate = new DateTime(1923, 7, 1), UserId = 3, CategoryId = 3 },
                new PieceOfArt { Id = 4, Title = "The Persistence of Memory", Price = 200000, PublicationDate = new DateTime(1931, 4, 1), UserId = 4, CategoryId = 4 },
                new PieceOfArt { Id = 5, Title = "Small Pyramid", Price = 150000, PublicationDate = new DateTime(2560, 1, 1), UserId = 5, CategoryId = 5 }
            );
        }

        public DbSet<User> users { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<PieceOfArt> pieceOfArts { get; set; }
        public DbSet<LoyaltyCard> loyaltyCards { get; set; }
    }
}
