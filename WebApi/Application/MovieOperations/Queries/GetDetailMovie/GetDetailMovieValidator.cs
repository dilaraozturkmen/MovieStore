using FluentValidation;
using WebApi.Application.MovieOperations.GetDetailMovie;

namespace Webapi.Application.MovieOperations.GetDetailMovie
{
    public class  GetDetailMovieValidator : AbstractValidator<GetDetailMovieQuery>
    {
        public GetDetailMovieValidator()
        {
            RuleFor(command => command.movieId).NotEmpty().GreaterThan(0);

        }

    }
}