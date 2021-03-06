﻿using BlazorDemo.Shared;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private static UserModel LoggedOutUser = new UserModel { IsAuthenticated = false };

        private readonly UserManager<IdentityUser> _userManager;

        public AccountsController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RegisterModel model)
        {
            var newUser = new IdentityUser { UserName = model.Email, Email = model.Email };

            var result = await _userManager.CreateAsync(newUser, model.Password);

            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(x => x.Description);

                return BadRequest(new RegisterResult { Successful = false, Errors = errors });
            }

            // Add all new users to the User role
            await _userManager.AddToRoleAsync(newUser, "User");

            // Add new users whose email starts with 'admin' or super admin to the Admin role
            if (newUser.Email.ToLower().StartsWith("admin")|| newUser.Email.ToLower().StartsWith("super"))
            {
                await _userManager.AddToRoleAsync(newUser, "Admin");
            }
            // Add new users whose email starts with 'superadmin' to the SuperAdmin role
            if (newUser.Email.ToLower().StartsWith("super"))
            {
                await _userManager.AddToRoleAsync(newUser, "SuperAdmin");
            }

            return Ok(new RegisterResult { Successful = true });
        }
    }
}
