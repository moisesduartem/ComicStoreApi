using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ComicStoreApi.Application.Interfaces;
using ComicStoreApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComicStoreApi.Application.Controllers
{
    [Route("api/[controller]")]
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