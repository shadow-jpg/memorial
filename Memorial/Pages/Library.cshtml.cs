using Memorial.Data;
using Memorial.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace Memorial.Pages
{
    [Authorize]
    public class LibraryModel : PageModel
    {
        private readonly AppDbContext _context;

        public List<Book> Books { get; set; } = new();
        public List<Poem> Poems { get; set; } = new();

        public LibraryModel(AppDbContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            Books =  _context.Books.ToList();

            Poems =  _context.Poems.ToList();
        }
    }
}
