using FluentValidation;
using WebApi.Application.DirectorOperations.DeleteDirector;

namespace Webapi.Application.DirectorOperations.DeleteDirector
{
    public class  DeleteDirectorValidator : AbstractValidator<DeleteDirectorCommand>
    {
        public DeleteDirectorValidator()
        {
            RuleFor(command => command.directorId).NotEmpty().GreaterThan(0);

        }

    }
}