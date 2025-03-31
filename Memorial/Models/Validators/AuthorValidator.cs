using FluentValidation;

namespace Memorial.Models.Validators
{  
    /// <summary>
   /// Добавить проврку на цензурность имени?? сильно позже если потребуется расширить для более чем одного автора
   /// </summary>
    public class AuthorValidator : AbstractValidator<Author>
    { 
        public AuthorValidator()
        {
            RuleFor(a => a.Name)
                .NotEmpty().WithMessage("Имя автора обязательно")
                .Length(4, 100).WithMessage("Имя должно быть от 4 до 100 символов");

            RuleFor(a => a.Bio)
                .MaximumLength(10000).WithMessage("Биография не должна превышать 10000 символов");

            RuleFor(a => a.PhotoUrl)
                .Must(uri => Uri.TryCreate(uri, UriKind.Absolute, out _))
                .When(a => !string.IsNullOrEmpty(a.PhotoUrl))
                .WithMessage("Некорректный URL фотографии");
        }
    }
}
