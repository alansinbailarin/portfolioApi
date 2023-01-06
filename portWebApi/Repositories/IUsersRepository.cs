using portWebApi.Models.Domain;

namespace portWebApi.Repositories
{
    public interface IUsersRepository
    {
        Task<IEnumerable<User>> GetAll();
    }
}
