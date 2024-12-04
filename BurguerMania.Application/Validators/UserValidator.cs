using BurguerMania.Application.Dtos.User;
using FluentValidation;

namespace BurguerMania.Application.Validators
{
    public class UserValidator : AbstractValidator<UserRequest>
    {
        public UserValidator()
        {
            RuleFor(u => u.Name)
                .NotEmpty().WithMessage("User.Name is required.")
                .MaximumLength(100).WithMessage("User.Name must be 100 characters or fewer.");
            
            RuleFor(u => u.Email)
                .NotEmpty().WithMessage("User.Email is required.")
                .EmailAddress().WithMessage("User.Email has an invalid email format.");

            RuleFor(u => u.Password)
                .NotEmpty().WithMessage("User.Password must be specified.")
                .MaximumLength(100).WithMessage("User.Password must be 8 characters or fewer.");
        }
    }
}