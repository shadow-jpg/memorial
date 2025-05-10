namespace Memorial.Models
{
    public class UserBook
    {
        //pkey
        public long UserId { get; set; }
        public long BookId { get; set; }

        public int? Rating { get; set; } 
        public bool IsPurchased { get; set; } 
        public string LibrarySection { get; set; } 


        public User User { get; set; }
        public Book Book { get; set; }
    }
}
