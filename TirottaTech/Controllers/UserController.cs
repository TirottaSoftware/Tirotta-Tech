using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TirottaTech.Data;

namespace TirottaTech.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public UserController(ApplicationDbContext db, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.db = db;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }
        public async Task<IActionResult> AddUserToAdmin()
        {
            var currentUser = await this.userManager.GetUserAsync(this.User);
            if (!await roleManager.RoleExistsAsync("Admin"))
            {
                await this.roleManager.CreateAsync(new IdentityRole("Admin"));
            }
            await this.userManager.AddToRoleAsync(currentUser, "Admin");
            await this.db.SaveChangesAsync();
            return Content($"Added {currentUser.UserName} to Admin");
        }
    }
}
