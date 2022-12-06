using FluentValidation;
using WebApi.Application.GenreOperations.UpdateGenre;

namespace Webapi.Application.GenreOperations.UpdateGenre
{
    public class  UpdateGenreValidator : AbstractValidator<UpdateGenreCommand>
    {
        public UpdateGenreValidator()
        {
            RuleFor(command => command.Model.Name).NotEmpty();

        }

    }
}