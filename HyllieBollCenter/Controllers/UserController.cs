using HyllieBollCenter.Interfaces;
using HyllieBollCenter.Models;
using HyllieBollCenter.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HyllieBollCenter.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IHttpContextAccessor _httpcontextAccessor;


        public UserController(IUserRepository userRepository,IHttpContextAccessor httpcontextAccessor)
        {
            _userRepository = userRepository;
            _httpcontextAccessor = httpcontextAccessor;
        }
        public async Task<IActionResult> Index()
        {
            var users = await _userRepository.GetAllUsers();
            List<UserViewModel> result = new List<UserViewModel>();
            foreach (var user in users)
            {
                var userViewModel = new UserViewModel()
                {
                    Id = user.Id,
                    Usename = user.UserName
                };
                result.Add(userViewModel);
            }
            return View(result);
        }
        public async Task<IActionResult> Detail()
        {
            string curUserId = _httpcontextAccessor.HttpContext.User.GetUserId();
            AppUser user = await _userRepository.GetUserById(curUserId);
            var userDetailViewModel = new UserDetailViewModel()
            {
                Id = user.Id,
                Usename = user.UserName
            };
            return View(userDetailViewModel);
        }
    }
}
