namespace portWebApi.Models.Dtos
{
    public class Ocupation
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool IsActive { get; set; }

        public IEnumerable<User> User { get; set; }
        public Guid UserId { get; set; }
    }
}
