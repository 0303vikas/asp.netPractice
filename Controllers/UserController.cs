
using Microsoft.AspNetCore.Mvc;
using PracticeAsp.Net.Dto;
using PracticeAsp.Net.Entity;
using PracticeAsp.Net.Service.Abstraction;

namespace PracticeAsp.Net.Controllers
{
    [ApiController]
    [Route("api/v1/[Controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _user;
        public UserController(IUserService user)
        {
            _user = user;
        }

        [HttpGet()]
        public ActionResult<UserDto> GetUserById([FromQuery] int id)
        {
            return _user.GetUserById(id);
        }

        [HttpPost()]
        public UserDto CreateUser([FromBody] UserDto user)
        {
            var newUser = _user.CreateUser(user);
            return newUser;
        }



    }
}