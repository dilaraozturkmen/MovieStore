using FluentValidation;
using WebApi.Application.MovieOperations.UpdateMovie;

namespace Webapi.Application.MovieOperations.UpdateMovie
{
    public class  UpdateMovieValidator : AbstractValidator<UpdateMovieCommand>
    {
        public UpdateMovieValidator()
        {
            RuleFor(command => command.Model.name).NotEmpty();
            RuleFor(command => command.Model.price).NotEmpty();
            RuleFor(command => command.Model.directorId).NotEmpty();
            RuleFor(command => command.Model.genreId).NotEmpty();
            RuleFor(command => command.movieId).NotEmpty().GreaterThan(0);

        }

    }
}