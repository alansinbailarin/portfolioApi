namespace portWebApi.Models.Domain
{
    public class Social
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Link { get; set; }

        public IEnumerable<User> User { get; set; }
        public Guid UserId { get; set; }
    }
}
