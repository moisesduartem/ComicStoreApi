using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComicStoreApi.Domain.Models
{
    public class UserPurchase
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int ComicId { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}