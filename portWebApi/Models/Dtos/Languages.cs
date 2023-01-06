namespace portWebApi.Models.Dtos
{
    public class Languages
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Level { get; set; }

        public IEnumerable<User> User { get; set; }
        public Guid UserId { get; set; }

    }
}
