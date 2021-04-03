namespace ComicStoreApi.Domain
{
    public class User : BaseEntity
    {
        public string Nome { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}