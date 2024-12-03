using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WEBBANHANG.Models;
using WEBBANHANG.Repository;

namespace WEBBANHANG.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class UserController :Controller
    {
        private readonly UserManager<AppUserModel> _userManager;
		private readonly RoleManager<IdentityRole> _roleManager;
        private readonly DataContext _dataContext;
        public UserController(UserManager<AppUserModel> userManager, RoleManager<IdentityRole> roleManager, DataContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _dataContext = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _userManager.Users.OrderByDescending(p => p.Id).ToListAsync());
        }
		[HttpGet]
		[Route("Create")]
		public async Task<IActionResult> Create()
		{
            var roles = await _roleManager.Roles.ToListAsync();
            ViewBag.Roles = new SelectList(roles, "Id", "Name");
			return View(new AppUserModel());
		}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string Id)
        {
            if(string.IsNullOrEmpty(Id))
            {
                return NotFound();
            }
            var user = await _roleManager.Roles.ToListAsync();
            {

            }
            var roles = await _roleManager.Roles.ToListAsync();
            ViewBag.Roles = new SelectList(roles, "Id", "Name");
            return View(user);
        }
    }
}
