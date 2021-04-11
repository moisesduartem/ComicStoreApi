using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ComicStoreApi.Core;

namespace ComicStoreApi.Models
{
    public class User : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Username { get; set; }
        
        [Required, RegularExpression("^(.+)@(.+)$")]
        public string Email { get; set; }
        
        [Required]
        public string Password { get; set; }
        
        public ICollection<UserPurchase> PurchasedItems { get; set; } = new List<UserPurchase>();
    }
}