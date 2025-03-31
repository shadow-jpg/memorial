using FluentValidation;

namespace Memorial.Models.Validators
{
    public class FileValidator : AbstractValidator<IFormFile>
    {
        private readonly string[] _allowedExtensions = { ".jpg", ".png" };

        public FileValidator()
        {
            RuleFor(x => x.FileName)
                .Must(BeValidExtension)
                .WithMessage("Допустимые расширения: " + string.Join(", ", _allowedExtensions));
        }

        private bool BeValidExtension(string fileName)
        {
            var extension = Path.GetExtension(fileName).ToLowerInvariant();
            return _allowedExtensions.Contains(extension);
        }
    }
}

