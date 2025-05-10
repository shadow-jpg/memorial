using Microsoft.AspNetCore.Identity;

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
        public string Email { get; set; }
        public string AvatarPicture { get; set; }
        public bool IsAuthor { get; set; }

        public ICollection<UserBook> UserBooks { get; set; } = new List<UserBook>();
        public virtual ICollection<IdentityUserRole<long>> UserRoles { get; set; }
    }

    public enum AppRoles
    {
        NonAuthorized, // Не авторизован (особая роль)
        User,
        Author,
        Moderator,
        Admin,
        SuperAdmin,
        ProductOwner
    }
}
