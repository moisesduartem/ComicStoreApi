namespace ComicStoreApi.Domain
{
    public class UserComic
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int ComicId { get; set; }
    }
}