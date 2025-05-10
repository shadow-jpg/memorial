using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Memorial.Data;
using Memorial.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
namespace Memorial.Pages
{
    public class AdminModel : PageModel
    {
        private readonly AppDbContext _context;
        private readonly UserManager<User> _userManager { get; set; };

        private List<Book> Books { get; set; } = new();
        private List<Poem> Poems { get; set; } = new();

        public AdminModel(AppDbContext context)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task OnGetAsync()
        {
            Books = await _context.Books
                .ToListAsync();

            Poems = await _context.Poems
                .Include(p => p.Author)
                .ToListAsync();
        }


        

        [HttpPost("assign-role")]
        public async Task<IActionResult> AssignRole(long userId, AppRoles role)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user == null) 
                return NotFound();

            var result = await _userManager.AddToRoleAsync(user, role.ToString());
            return result.Succeeded ? Ok() : BadRequest(result.Errors);
        }

        [HttpPost("remove-role")]
        public async Task<IActionResult> RemoveRole(long userId, AppRoles role)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user == null) return NotFound();

            var result = await _userManager.RemoveFromRoleAsync(user, role.ToString());
            return result.Succeeded ? Ok() : BadRequest(result.Errors);
        }
    }
}
