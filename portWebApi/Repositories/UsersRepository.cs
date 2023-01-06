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
            return await portfolioDbContext.Users.ToListAsync();
        }
    }
}
