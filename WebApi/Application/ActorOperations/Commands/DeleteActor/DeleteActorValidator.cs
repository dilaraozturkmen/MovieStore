using FluentValidation;
using WebApi.Application.ActorOperations.DeleteActor;


namespace Webapi.Application.ActorOperations.DeleteActor
{
    public class  DeleteActorValidator : AbstractValidator<DeleteActorCommand>
    {
        public DeleteActorValidator()
        {
            RuleFor(command => command.actorId).NotEmpty().GreaterThan(0);

        }

    }
}