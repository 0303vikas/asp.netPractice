
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PracticeAsp.Net.Dto;
using PracticeAsp.Net.Entity;
using PracticeAsp.Net.Exceptions;
using PracticeAsp.Net.Service.Abstraction;

namespace PracticeAsp.Net.Service.Implementation
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly List<User> _users = new(){
            new User { Name = "Alia", Email="Alia@mail.com", Password = {}, CreatedAt= new DateTime(), Id = 1},
            new User { Name = "John", Email="John@mail.com", Password = {},CreatedAt= new DateTime(), Id = 2},
            new User { Name = "Dave", Email="Dave@mail.com", Password = {},CreatedAt= new DateTime(), Id = 3}
        };

        public UserService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public UserDto CreateUser(UserDto user)
        {
            var createUser = _mapper.Map<User>(user);
            _users.Add(createUser);
            return user;
        }

        public ActionResult<UserDto> GetUserById(int id)
        {
            var findUser = _users.FirstOrDefault(item => item.Id == id);
            if (findUser is null)
            {
                throw HandleException.UserNotFound("User not in the list.", 204);
            }

            return _mapper.Map<UserDto>(findUser);
        }



    }
}