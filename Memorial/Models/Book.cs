namespace Memorial.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; } = 1;
        public Author Author { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public string CoverImageUrl { get; set; }
        public double? Rating { get; set; }
        public long Likes { get; set; }
        public long Dislikes { get; set; }
        public double? Price { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
