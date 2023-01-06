namespace portWebApi.Models.Dtos
{
    public class TechnicalSkills
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int? Experience { get; set; }

        public IEnumerable<User> User { get; set; }
        public Guid UserId { get; set; }
    }
}
