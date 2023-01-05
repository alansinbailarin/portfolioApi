namespace portWebApi.Models.Domain
{
    public class WorkHistory
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public bool? IsEnded { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
