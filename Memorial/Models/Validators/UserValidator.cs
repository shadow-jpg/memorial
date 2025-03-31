using FluentValidation;

namespace Memorial.Models.Validators
{
    public class UserValidator : AbstractValidator<RegisterDto>
    {
        public UserValidator()
        {
            RuleFor(x => x.nickname)
            .NotEmpty().WithMessage("Никнейм обязателен")
            .Length(3, 20).WithMessage("Никнейм должен быть от 3 до 20 символов")
            .Matches("^[a-zA-Z0-9_]+$").WithMessage("Допустимы только буквы, цифры и подчеркивание");

            When(x => x.showFio, () =>
            {
                RuleFor(x => x.fio)
                    .NotEmpty().WithMessage("ФИО обязательно при включенной опции показа")
                    .Matches(@"^[а-яА-ЯёЁa-zA-Z\s]{5,50}$").WithMessage("Некорректный формат ФИО");
            });

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email обязателен")
                .EmailAddress().WithMessage("Некорректный email");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Пароль обязателен")
                .Length(3,22).WithMessage("Пароль должен быть от 8  до 22 символов")
                .Matches("[A-Za-z]").WithMessage("Пароль должен содержать буквы латинского алфавита")
                .Matches("[0-9]").WithMessage("Пароль должен содержать цифры")
                .Matches("[@$!№%^*#?&_]").WithMessage("Пароль должен содержать спецсимволы (@,$,!,№,^,%,*,#,?,&,_)");

            RuleFor(x => x.ConfirmPassword)
                .Equal(x => x.Password)
                .WithMessage("Пароли не совпадают");

            RuleFor(x => x.Role)
                .IsInEnum().WithMessage("Недопустимая роль");

            RuleFor(x => x.AvatarPicture)
                .Must(uri => Uri.TryCreate(uri, UriKind.Absolute, out _))
                .When(x => !string.IsNullOrEmpty(x.AvatarPicture))
                .WithMessage("Некорректный URL аватара");
        }
    }
}