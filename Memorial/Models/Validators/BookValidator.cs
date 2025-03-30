using FluentValidation;
using Memorial.Data;

namespace Memorial.Models.Validators
{
    public class BookValidator: AbstractValidator<Book>
    {
        /// <summary>
        /// Настроить кастомную валидацию на проверку уникальности названия книг?? требуется ли
        /// </summary>
        private readonly AppDbContext _context;
        public BookValidator()
            {
                RuleFor(b => b.Title)
                    .NotEmpty().WithMessage("Название книги обязательно")
                    .Length(3, 200).WithMessage("Название должно быть от 3 до 200 символов");


                RuleFor(b => b.AuthorId)
                    .GreaterThan(0).WithMessage("Автор не указан");

                RuleFor(b => b.Genre)
                    .MaximumLength(40).WithMessage("Жанр не должен превышать 40 символов");

                RuleFor(b => b.Description)
                    .MaximumLength(1000).WithMessage("Описание не должно превышать 1000 символов");

                RuleFor(b => b.CoverImageUrl)
                    .Must(uri => Uri.TryCreate(uri, UriKind.Absolute, out _))
                    .When(b => !string.IsNullOrEmpty(b.CoverImageUrl))
                    .WithMessage("Некорректный URL обложки");

                RuleFor(b => b.Price)
                    .GreaterThanOrEqualTo(0).When(b => b.Price.HasValue)
                    .WithMessage("Цена не может быть отрицательной");

                //RuleFor(b => b.Allowed_ToRead_without_payment)
                //    .InclusiveBetween((byte)0, (byte)1).When(b => b.Allowed_ToRead_without_payment.HasValue)
                //    .WithMessage("");
            }
    }
}
