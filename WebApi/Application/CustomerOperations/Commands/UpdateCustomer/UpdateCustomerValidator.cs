using FluentValidation;
using WebApi.Application.CustomerOperations.UpdateCustomer;

namespace Webapi.Application.CustomerOperations.CreateCustomer
{
    public class  UpdateCustomerValidator : AbstractValidator<UpdateCustomerCommand>
    {
        public UpdateCustomerValidator()
        {
            RuleFor(command => command.Model.name).NotEmpty();
            RuleFor(command => command.Model.surname).NotEmpty();
           
            

        }

    }
}