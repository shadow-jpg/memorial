using Microsoft.EntityFrameworkCore;
using Memorial.Models;
using Memorial.Data;

namespace Memorial.services
{
    public class BookService
    {
        private readonly AppDbContext _context;

        public BookService(AppDbContext context)
        {
            _context = context;
        }

        public List<Book> GetBooks() => _context.Books.ToList();
    }
}
