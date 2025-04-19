using Microsoft.EntityFrameworkCore;
using OutfitGen.Authenticate.API.Models;

namespace OutfitGen.Authenticate.API.data
{
    public class OutfitGenDbContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<ClothingItem> ClothingItems { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ClothingItemTag> clothingItemTags { get; set; }
        public OutfitGenDbContext(DbContextOptions<OutfitGenDbContext> options): base(options) { 
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ClothingItemTag>()
                .HasKey(cit => new { cit.ClothingItemId, cit.TagId });
            modelBuilder.Entity<ClothingItemTag>()
                .HasOne(cit => cit.ClothingItem)
                .WithMany(ci => ci.ClothingItemTags)
                .HasForeignKey(cit => cit.ClothingItemId);

            modelBuilder.Entity<ClothingItemTag>()
                .HasOne(cit => cit.Tag)
                .WithMany(t => t.ClothingItemTags)
                .HasForeignKey(cit => cit.TagId);
        }
    }
}
