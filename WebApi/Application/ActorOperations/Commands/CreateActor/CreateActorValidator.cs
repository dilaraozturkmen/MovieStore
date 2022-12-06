using FluentValidation;
using WebApi.Application.ActorOperations.CreateActor;


namespace Webapi.Application.ActorOperations.CreateActor
{
    public class  CreateActorValidator : AbstractValidator<CreateActorCommand>
    {
        public CreateActorValidator()
        {
            RuleFor(command => command.Model.name).NotEmpty();
            RuleFor(command => command.Model.surname).NotEmpty();
           
            

        }

    }
}