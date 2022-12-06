using FluentValidation;
using WebApi.Application.ActorOperations.UpdateActor;

namespace Webapi.Application.ActorOperations.UpdateActor
{
    public class  UpdateActorValidator : AbstractValidator<UpdateActorCommand>
    {
        public UpdateActorValidator()
        {
            RuleFor(command => command.Model.name).NotEmpty();
            RuleFor(command => command.Model.surname).NotEmpty();
           
            

        }

    }
}