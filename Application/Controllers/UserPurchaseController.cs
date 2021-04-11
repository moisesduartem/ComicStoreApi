using System.Security.Claims;
using System;
using ComicStoreApi.Application.Services;
using ComicStoreApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ComicStoreApi.Application.Controllers
{
    [ApiController]
    [Route("api/v1/users/purchases")]
    [Authorize]
    public class UserPurchaseController : ControllerBase
    {
        private readonly IUserPurchaseService _purchaseService;

        public UserPurchaseController(IUserPurchaseService purchaseService)
        {
            _purchaseService = purchaseService;
        }

        [HttpPost]
        public ActionResult<dynamic> Register([FromBody] UserPurchase model)
        {
            try
            {
                var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

                model.UserId = userId;
                model.CreatedAt = DateTime.UtcNow;

                var purchase = _purchaseService.Register(model);
                
                return Ok(
                    new {
                        purchase = purchase,
                    }
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