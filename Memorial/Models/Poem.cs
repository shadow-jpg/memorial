namespace Memorial.Models
{
    public class Poem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public double? Rating { get; set; }
        public long Likes { get; set; }
        public long Dislikes { get; set; }
    }
}
