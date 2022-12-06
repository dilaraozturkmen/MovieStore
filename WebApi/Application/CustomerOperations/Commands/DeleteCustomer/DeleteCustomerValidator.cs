using FluentValidation;
using WebApi.Application.CustomerOperations.DeleteCustomer;

namespace Webapi.Application.CustomerOperations.DeleteCustomer
{
    public class  DeleteCustomerValidator : AbstractValidator<DeleteCustomerCommand>
    {
        public DeleteCustomerValidator()
        {
            RuleFor(command => command.customerId).NotEmpty();
                  
        }

    }
}