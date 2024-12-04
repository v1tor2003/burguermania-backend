using BurguerMania.Application.Dtos.Product;
using FluentValidation;

namespace BurguerMania.Application.Validators
{
    public sealed class ProductValidator : AbstractValidator<ProductRequest>
    {
        public ProductValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("Product.Name is required.")
                .MaximumLength(50).WithMessage("Product.Name must be 50 characters or fewer.");

            RuleFor(p => p.BaseDescription)
                .NotEmpty().WithMessage("Product.BaseDescription is required.")
                .MaximumLength(100).WithMessage("Product.BaseDescription must be 100 characters or fewer.");
            
            RuleFor(p => p.FullDescription)
                .NotEmpty().WithMessage("Product.FullDescription is required.")
                .MaximumLength(150).WithMessage("Product.FullDescription must be 150 characters or fewer.");

            RuleFor(p => p.Price)
                .NotNull().WithMessage("Product.Price must be specified.");

            RuleFor(p => p.CategoryId)
                .NotNull().WithMessage("Product.CategoryId must be specified.");
        }
    }
}