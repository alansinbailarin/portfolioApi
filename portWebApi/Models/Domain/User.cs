namespace portWebApi.Models.Domain
{
    public class User
    {
        public Guid Id { get; set; }
        public string? avatar { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Salt { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? Phone { get; set; }
        public DateTime? Birthday { get; set; }
        public bool IsAdmin { get; set; }
        public string? About { get; set; }
        public DateTime CreatedAt { get; set; }

        // Relaciones con otras tables
        public IEnumerable<Ocupation> Ocupation { get; set; }
        public IEnumerable<TechnicalSkills> TechnicalSkills { get; set; }
        public IEnumerable<SoftSkills> SoftSkills { get; set; }
        public IEnumerable<Location> Location { get; set; }
        public IEnumerable<Education> Education { get; set; }
        public IEnumerable<WorkHistory> WorkHistory { get; set; }
        public IEnumerable<Social> Social { get; set; }
        public IEnumerable<Languages> Languages { get; set; }
        public IEnumerable<Trajectory> Trajectory { get; set; }
        public IEnumerable<Posts> Posts { get; set; }
    }
}
