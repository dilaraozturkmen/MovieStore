using FluentValidation;
using WebApi.Application.CustomerOperations.GetCustomerDetail;


namespace Webapi.Application.CustomerOperations.GetCustomerDetail
{
    public class  GetCustomerDetailValidator : AbstractValidator<GetCustomerDetailQuery>
    {
        public GetCustomerDetailValidator()
        {
            RuleFor(command => command.customerId).NotEmpty();
                  
        }

    }
}