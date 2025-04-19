using System.ComponentModel.DataAnnotations;

namespace OutfitGen.Authenticate.API.Models
{
    public class ClothingItem
    {
        public int ClothingItemId { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Required, MaxLength(50)]
        public string Category { get; set; }
        [Required, MaxLength(50)]
        public string color { get; set; }
        [Required, MaxLength(50)]
        public string size  { get; set; }
        public string ImageUrl  { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<ClothingItemTag> ClothingItemTags { get; set; }

    }
}
