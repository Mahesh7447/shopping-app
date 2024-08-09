using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyShoppingApp.Models;
using MyShoppingApp.Services;

namespace MyShoppingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        [HttpPost]
        public IActionResult SaveUser(User user)
        {
            return Ok(userService.SaveUser(user));
        }
        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            return Ok(userService.GetUser(id)); 
        }
        [HttpPost("/role")]
        public IActionResult AddRole(Role role)
        {
            if (ModelState.IsValid)
            {
                return Ok(userService.AddRole(role));
            }
            return BadRequest();
        }
        [HttpPost("/assign")]
        public IActionResult AssignRoleToUser(UserRole role)
        {
            if (ModelState.IsValid)
            {
                return Ok(userService.AssignRoleToUser(role));
            }
            return BadRequest();
        }
    }
}
