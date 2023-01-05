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
        public int? Phone { get; set; }
        public DateTime? Birthday { get; set; }
        public bool IsAdmin { get; set; }
        public string? About { get; set; }
        public DateTime CreatedAt { get; set; }

        // Relaciones con otras tables
        public Guid OcupationId { get; set; }
        public IEnumerable<Ocupation> Ocupation { get; set; }

        public Guid TechnicalSkillsId { get; set; }
        public IEnumerable<TechnicalSkills> TechnicalSkills { get; set; }

        public Guid SoftSkillsId { get; set; }
        public IEnumerable<SoftSkills> SoftSkills { get; set; }

        public Guid LocationId { get; set; }
        public IEnumerable<Location> Location { get; set; }

        public Guid EducationId { get; set; }
        public IEnumerable<Education> Education { get; set; }

        public Guid WorkHistoryId { get; set; }
        public IEnumerable<WorkHistory> WorkHistory { get; set; }

        public Guid SocialId { get; set; }
        public IEnumerable<Social> Social { get; set; }

        public Guid LanguagesId { get; set; }
        public IEnumerable<Languages> Languages { get; set; }

        public Guid TrajectoryId { get; set; }
        public IEnumerable<Trajectory> Trajectory { get; set; }

        public Guid PostsId { get; set; }
        public IEnumerable<Posts> Posts { get; set; }
    }
}
