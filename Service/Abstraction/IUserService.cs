using Microsoft.AspNetCore.Mvc;
using PracticeAsp.Net.Dto;

namespace PracticeAsp.Net.Service.Abstraction
{
    public interface IUserService
    {
        ActionResult<UserDto> GetUserById(int id);
        UserDto CreateUser(UserDto user);

    }
}