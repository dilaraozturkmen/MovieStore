using FluentValidation;
using WebApi.Application.CustomerOperations.GetCustomerDetail;


namespace Webapi.Application.CustomerOperations.GetCustomerDetail
{
    public class  DeleteCustomerValidator : AbstractValidator<GetCustomerDetailQuery>
    {
        public DeleteCustomerValidator()
        {
            RuleFor(command => command.customerId).NotEmpty();
                  
        }

    }
}