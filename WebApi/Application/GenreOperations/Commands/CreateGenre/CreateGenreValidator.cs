using FluentValidation;
using WebApi.Application.GenreOperations.CreateGenre;

namespace Webapi.Application.GenreOperations.CreateGenre
{
    public class  CreateGenreValidator : AbstractValidator<CreateGenreCommand>
    {
        public CreateGenreValidator()
        {
            RuleFor(command => command.Model.Name).NotEmpty();

        }

    }
}