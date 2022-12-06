using FluentValidation;
using WebApi.Application.ActorOperations.GetActorDetail;

namespace Webapi.Application.ActorOperations.GetActorDetail
{
    public class  GetActorDetailValidator : AbstractValidator<GetActorDetailQuery>
    {
        public GetActorDetailValidator()
        {
            RuleFor(command => command.actorId).NotEmpty().GreaterThan(0);

        }

    }
}