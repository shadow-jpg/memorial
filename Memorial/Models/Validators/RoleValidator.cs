using FluentValidation;
using System.Data;

namespace Memorial.Models.Validators
{
    public class RoleValidator : AbstractValidator<Roles>
    {
        public RoleValidator()
        {
            RuleFor(x => x)
                .IsInEnum()
                .WithMessage("Недопустимая роль");
        }
    }
}
