namespace portWebApi.Models.Domain
{
    public class Posts
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Title { get; set; }
        public string? Body { get; set; }

        public Guid? ImageId { get; set; }
        public IEnumerable<Image> Image { get; set; }
        public Guid CategoryId { get; set; }
        public IEnumerable<Category> Category { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
