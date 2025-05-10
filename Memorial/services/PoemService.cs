using Memorial.Data;
using Memorial.Models;
using Microsoft.EntityFrameworkCore;

namespace Memorial.services
{
    public class PoemService
    {
        private readonly AppDbContext _context;

        public PoemService(AppDbContext context)
        {
            _context = context;
        }

        public List<Poem> GetPoems()
        {
                return new List<Poem>
            {
                new Poem
                {
                    Id = 1,
                    Title = "ГОЛУБАЯ   ВЕСНА",
                    Content = " Уходящей весне прокричал я вослед:\r\n\r\n- Голубая,  постой!  Отзовись…\r\n\r\nЧто же будет, скажи,\r\n\r\nЧерез тысячу лет?!-\r\n\r\nИ она мне ответила:\r\n\r\n                                   - Жизнь.",
                    AuthorId = 1,

                },
                new Poem
                {
                    Id = 2,
                    Title = "ОКНА",
                    AuthorId = 1,
                    Content = " Просыпаюсь я чистым утром.\r\n\r\nМолодая заря девчонкой\r\n\r\nЗасмотрелась в окошко дома\r\n\r\nИ шепнула: “Проспишь росу…”\r\n\r\n \r\n\r\nА второе светилось в полдень\r\n\r\nСиневой июньского неба\r\n\r\nМеж ветвей плюща и черешни,\r\n\r\nКак студеной воды родник.\r\n\r\n \r\n\r\nА когда закат отпылает,\r\n\r\nВ третье тихо стучится вечер:\r\n\r\n“Заждалась девчонка-соседка.”\r\n\r\nПодмигнет и помчится прочь.\r\n\r\n \r\n\r\nПоздно за полночь от любимой\r\n\r\nЯ домой возвращусь.\r\n\r\n                                     В четвертом\r\n\r\nВдруг увижу, как с болью смотрят\r\n\r\nНа меня в полутьме глаза.\r\n\r\n \r\n\r\nМолча в спальню мама уходит.\r\n\r\nВ дом войду. Тут  она стояла,\r\n\r\nОжидала… Ужель когда-то\r\n\r\nВ ночь смотреть буду так вот я?\r\n\r\n \r\n\r\nЯ не знаю такого дома,\r\n\r\nЧтоб все окна его смотрели\r\n\r\nНа зарю, на полдень, на вечер,\r\n\r\nА одно б не смотрело в ночь.\r\n\r\n \r\n\r\nЕсть еще окно в нашем доме.\r\n\r\nЯ к нему подойти не смею.\r\n\r\nТам сплетенные ветви сада,\r\n\r\nКак кресты на клáдбище старом,\r\n\r\nГде отец мой давно лежит…"
                }
            };
        }

        public async Task<List<Poem>> GetPoemsAsync()=> await _context.Poems.ToListAsync();

        public async Task<List<Poem>> GetPublishedPoemsAsync()
        {
            return await _context.Poems
                .Include(p => p.Author)
                .ToListAsync();
        }

        public async Task IncrementViewsAsync(int poemId)
        {
            var poem = await _context.Poems.FindAsync(poemId);
            if (poem != null)
            {
                poem.ViewsCount++;
                await _context.SaveChangesAsync();
            }
        }

        internal async Task<Poem> GetToREADPoemWithIdAsync(int poemId)
        {
            var poem = await _context.Poems
                        .Include(p => p.Author)
                        .FirstOrDefaultAsync(p => p.Id == poemId);
            if (poem != null)
            {
                poem.ViewsCount++;
                await _context.SaveChangesAsync();
            }
            return poem;
        }
    }
}
