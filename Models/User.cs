using System.Collections.Generic;
using ComicStoreApi.Core;

namespace ComicStoreApi.Models
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public ICollection<UserComic> UsersComics { get; set; } = new List<UserComic>();
    }
}