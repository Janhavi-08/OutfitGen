namespace OutfitGen.Authenticate.API.Models
{
    public class ClothingItemTag
    {
        public int ClothingItemId { get; set; }
        public ClothingItem ClothingItem { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
