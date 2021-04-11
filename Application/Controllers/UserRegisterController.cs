using System;
using System.Threading.Tasks;
using ComicStoreApi.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace ComicStoreApi.Application.Controllers
{
    [Route("api/v1/users")]
    [ApiController]

    public class UserRegisterController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserRegisterController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _userService.GetAllUsers());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}