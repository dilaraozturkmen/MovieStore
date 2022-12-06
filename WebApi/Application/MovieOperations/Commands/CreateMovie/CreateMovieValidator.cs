using FluentValidation;
using WebApi.Application.MovieOperations.CreateMovie;

namespace Webapi.Application.MovieOperations.CreateMovie
{
    public class  CreateMovieValidator : AbstractValidator<CreateMovieCommand>
    {
        public CreateMovieValidator()
        {
            RuleFor(command => command.Model.name).NotEmpty();
            RuleFor(command => command.Model.price).NotEmpty();
            RuleFor(command => command.Model.directorId).NotEmpty();
            RuleFor(command => command.Model.genreId).NotEmpty();
        


        }

    }
}