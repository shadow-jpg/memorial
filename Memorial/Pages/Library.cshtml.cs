using Memorial.Data;
using Memorial.Models;
using Memorial.services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace Memorial.Pages
{
    [Authorize]
    public class LibraryModel : PageModel
    {
        private readonly BookService _bookService;
        private readonly PoemService _poemService;

        public List<Book> Books { get; set; } = new();
        public List<Poem> Poems { get; set; } = new();

        public LibraryModel(BookService bookService, PoemService poemService)
        {
            _bookService = bookService;
            _poemService = poemService;
        }

        public async Task OnGetAsync()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var BooksTask = _bookService.GetBooksAsync();
            var PoemsTask = _poemService.GetPoemsAsync();
            await Task.WhenAll(BooksTask, PoemsTask);
            Books = await BooksTask;
            Poems = await PoemsTask;
        }
    }
}
