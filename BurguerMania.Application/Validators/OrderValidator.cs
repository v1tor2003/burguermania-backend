using BurguerMania.Application.Dtos.Order;
using FluentValidation;

namespace BurguerMania.Application.Validators
{
    public class OrderValidator : AbstractValidator<OrderRequest>
    {
        public OrderValidator()
        {
            RuleFor(o => o.Value)
                .NotEmpty().WithMessage("Order.Value is required.");

            RuleFor(o => o.UserId)
                .NotNull().WithMessage("Order.UserId must be specified.");

            RuleFor(o => o.StatusId)
                .NotNull().WithMessage("Order.StatusId must be specified.");
        }
    }
}