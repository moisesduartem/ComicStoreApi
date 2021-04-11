using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ComicStoreApi.Core;

namespace ComicStoreApi.Models
{
    public class User : BaseEntity
    {
        public string Name { get; set; }

        public string Username { get; set; }

        [RegularExpression("^(.+)@(.+)$")]
        public string Email { get; set; }

        public string Password { get; set; }

        public ICollection<UserPurchase> PurchasedItems { get; set; } = new List<UserPurchase>();
    }
}