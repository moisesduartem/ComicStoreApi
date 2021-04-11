using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComicStoreApi.Models
{
    public class UserPurchase
    {
        [Required]
        public int UserId { get; set; }
        public User User { get; set; }
        [Required]
        public int ComicId { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public decimal Price { get; set; }
        public DateTime PurchasedAt { get; set; }
    }
}