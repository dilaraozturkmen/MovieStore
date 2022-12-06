using FluentValidation;
using WebApi.Application.DirectorOperations.UpdateDirector;

namespace Webapi.Application.CustomerOperations.UpdateCustomer
{
    public class  UpdateDirectorValidator : AbstractValidator<UpdateDirectorCommand>
    {
        public UpdateDirectorValidator()
        {
            RuleFor(command => command.Model.name).NotEmpty();
            RuleFor(command => command.Model.surname).NotEmpty();
           
            

        }

    }
}