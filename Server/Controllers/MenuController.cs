using BlazorDemo.Server.Data;
using BlazorDemo.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.Immutable;


namespace BlazorDemo.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public MenuController(ApplicationDbContext context)
        {
            this._context = context;
        }

        // GET: api/<MenuController>
        [HttpGet]
        public async Task<IActionResult> GetMenuData()
        {
            var menuitems = await _context.MenuItems.ToListAsync();
            return Ok(menuitems);
        }
    }
}
