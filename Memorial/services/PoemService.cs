using Memorial.Models;

namespace Memorial.services
{
    public class PoemService
    {
        public List<Poem> GetPoems()
        {
            return new List<Poem>
        {
            new Poem
            {
                Id = 1,
                Title = "The Road Not Taken",
                Author = "Robert Frost",
                Content = "Two roads diverged in a wood, and I—\nI took the one less traveled by..."
            },
            new Poem
            {
                Id = 2,
                Title = "Ozymandias",
                Author = "Percy Bysshe Shelley",
                Content = "I met a traveler from an antique land..."
            }
        };
        }
    }
}
