using FluentValidation;
using WebApi.Application.DirectorOperations.CreateDirector;

namespace Webapi.Application.DirectorOperations.CreateDirector
{
    public class  CreateDirectorValidator : AbstractValidator<CreateDirectorCommand>
    {
        public CreateDirectorValidator()
        {
            RuleFor(command => command.Model.name).NotEmpty();
            RuleFor(command => command.Model.surname).NotEmpty();
           
            

        }

    }
}