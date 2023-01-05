namespace portWebApi.Models.Domain
{
    public class Location
    {
        public Guid Id { get; set; }
        public string? City { get; set; }
        public string? Address { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public bool? StillHere { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
