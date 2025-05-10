using Microsoft.EntityFrameworkCore;
using Memorial.Models;
using Memorial.Data;
using FluentValidation;
using System.ComponentModel.DataAnnotations;

namespace Memorial.services
{
    public class BookService
    {
        private readonly AppDbContext _context; 
        private readonly IValidator<Book> _validator;

        public BookService(AppDbContext context, IValidator<Book> validator)
        {
            _context = context;
            _validator = validator;
        }
        public async Task CreateBook(Book book)
        {
            var validationResult = await _validator.ValidateAsync(book);
            if (!validationResult.IsValid)
                throw new Exception("Произошла ошибка при регистрации книги");

            _context.Books.Add(book);
            await _context.SaveChangesAsync();
        }
        public async Task<List<Book>> GetBooksAsync() => await _context.Books.ToListAsync();
        public async Task<List<Book>> GetBooksByUserAsync(long userId) {

            if (!await _context.Users.AnyAsync(u => u.UserId == userId))
                throw new ArgumentException("Пользователь не найден");

            return await _context.UserBooks
            .Where(ub => ub.UserId == userId)
            .Select(ub => ub.Book)
            .Include(b => b.Author)
            .ToListAsync();
        }
    }
}
