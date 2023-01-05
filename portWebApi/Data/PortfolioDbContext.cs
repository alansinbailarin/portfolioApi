using Microsoft.EntityFrameworkCore;
using portWebApi.Models.Domain;

namespace portWebApi.Data
{
    public class PortfolioDbContext: DbContext
    {
        public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options): base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Languages> Languages { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Ocupation> Ocupations { get; set; }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<SoftSkills> SoftSkills { get; set; }
        public DbSet<TechnicalSkills> TechnicalSkills { get; set; }
        public DbSet<Trajectory> Trajectories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WorkHistory> WorkHistories { get; set; }

    }
}
