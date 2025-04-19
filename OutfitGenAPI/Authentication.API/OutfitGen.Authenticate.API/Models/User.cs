using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace OutfitGen.Authenticate.API.Models
{
    public class User
    {
        public int Userid {  get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Required, MaxLength (250)]
        public string Email { get; set; }
        [Required]
        public string PasswordHash { get; set; }
        public DateTime CreatedAt { get; set; } 
        public DateTime LastUpdatedAt { get; set; } 
        public ICollection<ClothingItem> ClothingItems { get; set; }
 

    }
}
