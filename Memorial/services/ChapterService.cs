using Memorial.Data;
using Memorial.Models;
using Microsoft.EntityFrameworkCore;

namespace Memorial.services
{
    public class ChapterService
    {
        public List<Chapter> GetChapters()
        {
            return new List<Chapter>
        {
            new Chapter
            {
                Id = 1,
                Title = "Chapter 1: wadaawdaw",
                Content = "awdawdawd..."
            },
            new Chapter
            {
                Id = 2,
                Title = "Chapter 2: awdadwwa",
                Content = "Tawdadwadawd..."
            },
            new Chapter
            {
                Id = 3,
                Title = "Chapter 3: awdawda",
                Content = "wadadwa.."
            }
        };
        }

        public Chapter GetChapterById(int id)
        {
            return GetChapters().FirstOrDefault(c => c.Id == id);
        }
        private readonly AppDbContext _context;

        public ChapterService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Chapter>> GetChaptersByBookAsync(int bookId)
        {
            return await _context.Chapters
                .Where(c => c.BookId == bookId)
                .OrderBy(c => c.Id)
                .ToListAsync();
        }
        public async Task<List<Chapter>> GetChaptersWithAccessCheckAsync(long bookId, long? userId)
        {
            var book = await _context.Books
               .Include(b => b.UserBooks.Where(ub => ub.UserId == userId))
               .FirstOrDefaultAsync(b => b.Id == bookId);

            if (book == null)
                return new List<Chapter>();
            if (book.Allowed_ToRead_without_payment == null)
            {
                return
            }
            else {
                // Проверяем покупки пользователя
                bool isBookPurchased = book.UserBooks.Any(ub => ub.IsPurchased);
                var purchasedChapterIds = book.UserBooks
                    .SelectMany(ub => ub.PurchasedChapters)
                    .ToList();

                // Получаем все главы
                var chapters = await _context.Chapters
                    .Where(c => c.BookId == bookId)
                    .OrderBy(c => c.Number)
                    .ToListAsync();

                // Фильтруем результат
                return chapters
                    .Where(c =>
                        isBookFree || // Вся книга бесплатна
                        isBookPurchased || // Книга куплена
                        purchasedChapterIds.Contains(c.Id) || // Глава куплена
                        c.Number <= freeChaptersLimit // Глава в пределах бесплатного лимита
                    )
                    .ToList();
            }
        }
        public async Task<Chapter> GetChapterAsync(int id)
        {
            return await _context.Chapters
                .Include(c => c.Book)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task CreateChapterAsync(Chapter chapter)
        {
            _context.Chapters.Add(chapter);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateChapterAsync(Chapter chapter)
        {
            _context.Chapters.Update(chapter);
            await _context.SaveChangesAsync();
        }
        
        public async Task DeleteChapterAsync(int id)
        {
            var chapter = await _context.Chapters.FindAsync(id);
            if (chapter != null)
            {
                _context.Chapters.Remove(chapter);
                await _context.SaveChangesAsync();
            }
        }
    }
}
