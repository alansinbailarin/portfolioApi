namespace portWebApi.Models.Domain
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }

        public Posts Posts { get; set; }
        public Guid PostsId { get; set; }
    }
}
