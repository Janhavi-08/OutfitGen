using System.ComponentModel.DataAnnotations;

namespace OutfitGen.Authenticate.API.Models
{
    public class Tag
    {
        public int TagId {  get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        public ICollection<ClothingItemTag> ClothingItemTags { get; set; }
    }
}
