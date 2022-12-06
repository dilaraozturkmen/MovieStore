using FluentValidation;
using WebApi.Application.GenreOperations.GetGenreDetail;

namespace Webapi.Application.GenreOperations.DeleteGenre
{
    public class  GetGenreDetailValidator : AbstractValidator<GetGenreDetailQuery>
    {
        public GetGenreDetailValidator()
        {
            RuleFor(command => command.genreId).NotEmpty().GreaterThan(0);

        }

    }
}