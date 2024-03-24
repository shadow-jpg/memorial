namespace Memorial.Models
{
    public class Chapter
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
