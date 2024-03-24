using System.ComponentModel.DataAnnotations.Schema;

namespace Memorial.Models
{
    public class Poem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; } = 1;
        public Author Author { get; set; }

        [Column(TypeName = "text")]
        public string Content { get; set; }
        public double? Rating { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public DateTime? CreatedAt { get; set; }
        public long ViewsCount { get; set; }
    }
}
