namespace portWebApi.Models.Domain
{
    public class Image
    {
        public Guid Id { get; set; }
        public string? Alt { get; set; }

        public Posts Posts { get; set; }
        public Guid PostId { get; set; }
    }
}
