namespace Memorial.Models
{
    public class User
    {
        public long UserId { get; set; }
        public string nickname { get; set; }
        public string fio { get; set; }
        public bool showFio { get; set; }
        public Roles Role { get; set; } 
        public string Password { get; set; }
        []
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
        public string AvatarPicture { get; set; }
    }
}
