using System.Threading.Tasks;
using ComicStoreApi.Application.Services;
using ComicStoreApi.Models;
using ComicStoreApi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ComicStoreApi.Application.Controllers.V1
{
    [Route("v1/account")]
    public class HomeController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody] User model)
        {
            var user = UserRepository.Get(model.Username, model.Password);

            if (user == null)
                return NotFound(new { message = "Usuário e/ou senha inválidos." });
        
            var token = TokenService.GenerateToken(user);

            user.Password = "";

            return new 
            {
                user = user,
                token = token
            };
        }
    }
}