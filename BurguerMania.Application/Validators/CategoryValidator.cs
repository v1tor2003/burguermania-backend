using BurguerMania.Application.Dtos.Category;
using FluentValidation;

namespace BurguerMania.Application.Validators
{
    public class CategoryValidator : AbstractValidator<CategoryRequest>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Category.Name is required.")
                .MaximumLength(50).WithMessage("Category.Name must be 50 characters or fewer.");

            RuleFor(o => o.Description)
                .NotNull().WithMessage("Category.Description must be specified.")
                .MaximumLength(100).WithMessage("Category.Description must be 100 characters or fewer.");
        }
    } 
}