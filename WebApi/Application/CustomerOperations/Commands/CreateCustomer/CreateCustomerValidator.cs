using FluentValidation;
using WebApi.Application.CustomerOperations.CreateCustomer;

namespace Webapi.Application.CustomerOperations.CreateCustomer
{
    public class  CreateCustomerValidator : AbstractValidator<CreateCustomerCommand>
    {
        public CreateCustomerValidator()
        {
            RuleFor(command => command.Model.name).NotEmpty();
            RuleFor(command => command.Model.surname).NotEmpty();
           
            

        }

    }
}