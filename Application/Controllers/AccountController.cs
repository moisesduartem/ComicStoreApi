using System;
using ComicStoreApi.Application.Services;
using ComicStoreApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ComicStoreApi.Application.Controllers
{
    [Route("v1/account")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost]
        [Route("login", Name = "Login")]
        [AllowAnonymous]
        public ActionResult<dynamic> Authenticate([FromBody] User model)
        {
            try
            {
                var user = _accountService.Authenticate(model);
                var token = TokenService.GenerateToken(user);
                user.Password = "";

                return Ok(
                    new
                    {
                        user = user,
                        token = token
                    }
                );
            }
            catch (Exception e)
            {
                return NotFound(
                    new {
                        message = e.Message
                    }
                );
            }
        }

        [HttpPost]
        [Route("register")]
        [AllowAnonymous]
        public ActionResult<dynamic> Register([FromBody] User model)
        {
            try
            {
                var user = _accountService.Register(model);
                return new CreatedAtRouteResult(
                    "Login",
                    new { email = model.Email, password = model.Password }
                );
            }
            catch (Exception e)
            {
                return BadRequest(
                    new
                    {
                        message = e.Message
                    }
                );
            }
        }
    }
}