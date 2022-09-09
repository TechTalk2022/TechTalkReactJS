

namespace TechTalkReactJS.API.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using TechTalkReactJS.Service;
    using TechTalkReactJS.Models.Input;
    using Microsoft.AspNetCore.Authorization;
    using TechTalkReactJS.API.APIAuth;

    public class UserDetailsController : BaseController
    {

        private readonly IUserService _userService;
        public UserDetailsController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet] 
        [Route("GetUser")]

        public async Task<IActionResult> GetUser()
        {
            return Ok(await _userService.GetUser());
        }
        [HttpGet] 
        [Route("GetUserById")]
        public async Task<IActionResult> GetUserById(int userId)
        {
            return Ok(await _userService.GetUserById(userId));
        }
        [HttpGet] 
        [Route("UserLogin")]
        public async Task<IActionResult> UserLogin(string userName,string password)
        {
            return Ok(await _userService.UserLogin(userName, password));
        }

        [HttpDelete] 
        [Route("DeleteUser")]
        public async Task<IActionResult> DeleteUser(int userId)
        {
            return Ok(await _userService.DeleteUser(userId));
        }
        [HttpPost] 
        [Route("SaveUser")]
        public async Task<IActionResult> SaveUser(UserDetails users)
        {

            return Ok(await _userService.SaveUser(users));
        }
    }
}