using FluentValidation;

namespace Memorial.Models.Validators
{
    public class ChapterValidator : AbstractValidator<Chapter>
    {
        public ChapterValidator()
        {
            RuleFor(c => c.Title)
                .NotEmpty().WithMessage("Название главы обязательно")
                .Length(1, 70).WithMessage("Название главы должно быть от 1 до 70 символов");

            RuleFor(c => c.Content)
                .NotEmpty().WithMessage("Содержание главы обязательно")
                .MaximumLength(100_000).WithMessage("Слишком большой объем текста главы");

            RuleFor(c => c.BookId)
                .GreaterThan(0).WithMessage("Книга не указана");
        }
    }
}
