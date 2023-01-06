using Microsoft.EntityFrameworkCore;
using portWebApi.Data;
using portWebApi.Models.Domain;

namespace portWebApi.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly PortfolioDbContext portfolioDbContext;

        public UsersRepository(PortfolioDbContext portfolioDbContext)
        {
            this.portfolioDbContext = portfolioDbContext;
        }
        public async Task<IEnumerable<User>> GetAll()
        {
            return await portfolioDbContext.Users
                .Include(x => x.Education)
                .Include(x => x.Ocupation)
                .Include(x => x.TechnicalSkills)
                .Include(x => x.SoftSkills)
                .Include(x => x.Location)
                .Include(x => x.WorkHistory)
                .Include(x => x.Social)
                .Include(x => x.Languages)
                .Include(x => x.Trajectory)
                .Include(x => x.Posts)
                .ToListAsync();
        }
    }
}
