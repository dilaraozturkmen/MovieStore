using FluentValidation;
using WebApi.Application.OrderOperations.GetDetailOrder;

namespace Webapi.Application.OrderOperations.GetDetailOrder
{
    public class  GetDetailOrderValidator : AbstractValidator<GetDetailOrderQuery>
    {
        public GetDetailOrderValidator()
        {
            RuleFor(command => command.orderId).NotEmpty().GreaterThan(0);

        }

    }
}