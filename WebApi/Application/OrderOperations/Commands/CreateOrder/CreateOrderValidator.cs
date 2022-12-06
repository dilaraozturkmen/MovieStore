using FluentValidation;
using WebApi.Application.OrderOperations.CreateOrder;

namespace Webapi.Application.OrderOperations.CreateOrder
{
    public class  CreateOrderValidator : AbstractValidator<CreateOrderCommand>
    {
        public CreateOrderValidator()
        {
            RuleFor(command => command.Model.customerId).NotEmpty();
            RuleFor(command => command.Model.movieId).NotEmpty();

        }

    }
}