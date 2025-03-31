using FluentValidation;

namespace Memorial.Models.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email обязателен")
                .EmailAddress().WithMessage("Некорректный email");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Пароль обязателен")
                .Matches(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!№^%*#?&*_])[A-Za-z\d@$!№^%*#?&*_]{8,}$")
                .WithMessage("Пароль должен содержать буквы,хотя бы 1 цифру и спецсимвол(@,$,!,№,^,%,*,#,?,&,*,_)");

            //RuleFor(x => x.ConfirmPassword)
            //    .Equal(x => x.password)
            //    .WithMessage("Пароли не совпадают");

            RuleFor(x => x.Role)
                .IsInEnum().WithMessage("Недопустимая роль");

            //RuleFor(x => x.AvatarPicture)
            //    //.Must(file =>
            //    //    new[] { ".jpg", ".png" }.Contains(Path.GetExtension(file.FileName).ToLower()))
            //    .When(x => x.AvatarPicture != null)
            //    .WithMessage("Допустимые форматы: JPG, PNG");
        }
    }
}