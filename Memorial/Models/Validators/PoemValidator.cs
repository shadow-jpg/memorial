using FluentValidation;

namespace Memorial.Models.Validators
{  
   /// <summary>
   /// Добавить проврку на цензурность имени?? сильно позже если потребуется расширить для более чем одного автора
   /// </summary>
    public class PoemValidator : AbstractValidator<Poem>
    {
        public PoemValidator()
        {
            RuleFor(p => p.Title)
                .NotEmpty().WithMessage("Название поэму не может быть пустым")
                .Length(3, 100).WithMessage("Название поэмы/стиха слишком длинное более 100 символов");
           
            RuleFor(p => p.Content)
               .NotEmpty().WithMessage("Текст поэмы/стиха обязателен")
               .MaximumLength(5000).WithMessage("Слишком большой объем текста, попробуйте формат книги/ сборника (5+ тысяч символов)");

            RuleFor(p => p.AuthorId)
                .NotEmpty().WithMessage("У произведения не найден автор!");
        }
    }
}
