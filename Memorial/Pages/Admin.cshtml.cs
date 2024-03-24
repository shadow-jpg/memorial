using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Memorial.Data;
using Memorial.Models;
using Microsoft.EntityFrameworkCore;
namespace Memorial.Pages
{
    public class AdminModel : PageModel
    {
        private readonly AppDbContext _context;

        public List<Book> Books { get; set; } = new();
        public List<Poem> Poems { get; set; } = new();

        public AdminModel(AppDbContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            Books = await _context.Books
                .ToListAsync();

            Poems = await _context.Poems
                .Include(p => p.Author)
                .ToListAsync();
        }
    }
}
