using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PITONChallenge.Business.Abstract;
using PITONChallenge.Business.ViewModels;
using PITONChallenge.Entity.Concrete;

namespace PITONChallenge.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("GetAll")]
        public IEnumerable<UserVM> GetAllUser()
        {
            return _userService.GetAll();
        }

        [HttpPost("Create")]
        public string CreateUser(UserVM userVM)
        {
            return _userService.Add(userVM);

        }

        [HttpPut("Update")]
        public string UpdateUser(UserVM userVM)
        {
            return _userService.Update(userVM);
        }

        [HttpGet("Delete/{id}")]
        public string DeleteUser(int id)
        {
            return _userService.Delete(id);
        }
    }
}
