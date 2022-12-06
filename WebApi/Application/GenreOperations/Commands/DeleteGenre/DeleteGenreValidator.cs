using FluentValidation;
using WebApi.Application.GenreOperations.DeleteGenre;

namespace Webapi.Application.GenreOperations.DeleteGenre
{
    public class  DeleteGenreValidator : AbstractValidator<DeleteGenreCommand>
    {
        public DeleteGenreValidator()
        {
            RuleFor(command => command.genreId).NotEmpty().GreaterThan(0);

        }

    }
}