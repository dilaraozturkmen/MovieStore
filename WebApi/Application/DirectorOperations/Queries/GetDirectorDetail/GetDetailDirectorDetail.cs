using FluentValidation;
using WebApi.Application.DirectorOperations.GetDirectorDetail;

namespace Webapi.Application.DirectorOperations.GetDetailDirector
{
    public class  GetDetailDirectorValidator : AbstractValidator<GetDetailDirectorQuery>
    {
        public GetDetailDirectorValidator()
        {
            RuleFor(command => command.directorId).NotEmpty().GreaterThan(0);

        }

    }
}