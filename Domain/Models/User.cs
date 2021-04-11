using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using ComicStoreApi.Core;

namespace ComicStoreApi.Domain.Models
{
    public class User : BaseEntity
    {
        public string Name { get; set; }

        public string Username { get; set; }

        [RegularExpression("^(.+)@(.+)$")]
        public string Email { get; set; }

        public string Password { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public ICollection<UserPurchase> PurchasedItems { get; set; } = new List<UserPurchase>();
    }
}