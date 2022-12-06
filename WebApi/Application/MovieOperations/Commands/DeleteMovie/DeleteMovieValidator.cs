using FluentValidation;
using WebApi.Application.MovieOperations.DeleteMovie;

namespace Webapi.Application.MovieOperations.DeleteMovie
{
    public class  DeleteMovieValidator : AbstractValidator<DeleteMovieCommand>
    {
        public DeleteMovieValidator()
        {
            RuleFor(command => command.movieId).NotEmpty().GreaterThan(0);

        }

    }
}