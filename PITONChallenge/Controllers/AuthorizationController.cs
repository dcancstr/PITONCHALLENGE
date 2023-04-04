using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using PITONChallenge.Business.Abstract;
using PITONChallenge.Entity.Concrete;

namespace PITONChallenge.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorizationController : ControllerBase
    {
        readonly IConfiguration _configuration;
        readonly IUserService _userService;

        public AuthorizationController(IConfiguration configuration, IUserService userService)
        {
            _configuration = configuration;
            _userService = userService;
        }

        [HttpGet]
        public string Get(string userName, string password)
        {

            var _user = _userService.Get(u => u.UserName == userName && u.Password == password);

            if (_user!=null)
            {
                var claims = new[]
                {
                new Claim(ClaimTypes.Name,userName),

                };


                var signingKey = _configuration["JwtConfig:SigningKey"];
                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(signingKey));
                var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);



                var jwtSecurityToken = new JwtSecurityToken(
                    issuer: _configuration["JwtConfig:Issuer"],
                    audience: _configuration["JwtConfig:Audience"],
                    claims: claims,
                    expires: DateTime.Now.AddDays(15),
                    notBefore: DateTime.Now,
                    signingCredentials: credentials
                    );

                var token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);

                return token;
            }

            return "Eşleşme yapilamadi";
        }

    }
}
