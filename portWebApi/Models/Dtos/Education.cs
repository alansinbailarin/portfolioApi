namespace portWebApi.Models.Dtos
{
    public class Education
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public bool? IsEnded { get; set; }
        public DateTime CreatedAt { get; set; }

        public User User { get; set; }
        public Guid UserId { get; set; }
    }
}
