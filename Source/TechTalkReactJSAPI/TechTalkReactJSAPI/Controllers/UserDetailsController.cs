

namespace TechTalkReactJS.API.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using TechTalkReactJS.Service;
    using TechTalkReactJS.Models.Input;


    [Route("api/[controller]")]
    [ApiController]
    public class UserDetailsController : ControllerBase
    {

        private readonly IUserService _userService;
        public UserDetailsController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [ActionName("GetUser")]
        [Route("GetUser")]
        public async Task<IActionResult> GetUser()
        {
            return Ok(await _userService.GetUser());
        }
        [HttpGet]
        [ActionName("GetUserById")]
        [Route("GetUserById")]
        public async Task<IActionResult> GetUserById(int userId)
        {
            return Ok(await _userService.GetUserById(userId));
        }
        [HttpDelete]
        [ActionName("DeleteUser")]
        [Route("DeleteUser")]
        public async Task<IActionResult> DeleteUser(int userId)
        {
            return Ok(await _userService.DeleteUser(userId));
        }
        [HttpPost]
        [ActionName("SaveUser")]
        [Route("SaveUser")]
        public async Task<IActionResult> SaveUser(UserDetails users)
        {

            return Ok(await _userService.SaveUser(users));
        }
    }
}