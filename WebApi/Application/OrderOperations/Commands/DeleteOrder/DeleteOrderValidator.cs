using FluentValidation;
using WebApi.Application.OrderOperations.DeleteOrder;

namespace Webapi.Application.OrderOperations.DeleteOrder
{
    public class  DeleteOrderValidator : AbstractValidator<DeleteOrderCommand>
    {
        public DeleteOrderValidator()
        {
            RuleFor(command => command.orderId).NotEmpty().GreaterThan(0);

        }

    }
}