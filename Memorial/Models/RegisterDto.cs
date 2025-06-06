﻿using System.ComponentModel.DataAnnotations;

namespace Memorial.Models
{
    public class RegisterDto
    {
        public string nickname { get; set; }
        public string fio { get; set; }
        public bool showFio { get; set; }
        public Roles Role { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string AvatarPicture { get; set; }

        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string ConfirmPassword { get; set; }
    }
}
