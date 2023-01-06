using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using portWebApi.Repositories;

namespace portWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : Controller
    {
        private readonly IUsersRepository usersRepository;
        private readonly IMapper mapper;

        public UsersController(IUsersRepository usersRepository, IMapper mapper)
        {
            this.usersRepository = usersRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await usersRepository.GetAll();
        
            var usersDto = mapper.Map<List<Models.Dtos.User>>(users);

            return Ok(usersDto);
        }
    }
}
