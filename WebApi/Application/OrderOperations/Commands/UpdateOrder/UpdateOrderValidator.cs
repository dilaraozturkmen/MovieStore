using FluentValidation;
using WebApi.Application.OrderOperations.UpdateOrder;

namespace Webapi.Application.OrderOperations.UpdateOrder
{
    public class  UpdateOrderValidator : AbstractValidator<UpdateOrderCommand>
    {
        public UpdateOrderValidator()
        {
            RuleFor(command => command.Model.customerId).NotEmpty();
            RuleFor(command => command.Model.movieId).NotEmpty();
            RuleFor(command => command.orderId).NotEmpty().GreaterThan(0);


        }

    }
}