using Microsoft.AspNetCore.Identity;

namespace Memorial.Data
{
    public class User : IdentityUser
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Nickname { get; set; }
        public string password { get; set; }

    }
}
