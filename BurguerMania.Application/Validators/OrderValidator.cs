using BurguerMania.Application.Dtos.Order;
using FluentValidation;

namespace BurguerMania.Application.Validators
{
    public class OrderValidator : AbstractValidator<OrderRequest>
    {
        public OrderValidator()
        {
            RuleFor(o => o.ProductId)
                .NotEmpty().WithMessage("Order.ProductId is required.");

            RuleFor(o => o.UserId)
                .NotNull().WithMessage("Order.UserId must be specified.");

            RuleFor(o => o.Quantity)
                .NotEmpty().WithMessage("Order.Quantity must be specified.");
        }
    }
}