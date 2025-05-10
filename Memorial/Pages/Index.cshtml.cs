using Memorial.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Memorial.services;

namespace Memorial.Pages;

public class IndexModel : PageModel
{
    private readonly BookService _bookService;
    private readonly PoemService _poemService;

    public IndexModel(BookService bookService, PoemService poemService)
    {
        _bookService = bookService;
        _poemService = poemService;
    }

    public List<Book> Books { get; set; }
    public List<Poem> Poems { get; set; }

    public async Task OnGet()
    {                                               
        var BooksTask =  _bookService.GetBooksAsync();
        var PoemsTask =  _poemService.GetPoemsAsync();
        await Task.WhenAll(BooksTask, PoemsTask);
        Books = await BooksTask;
        Poems = await PoemsTask;
    }
}
