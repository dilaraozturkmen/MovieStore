using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Webapi.Application.ActorOperations.CreateActor;
using Webapi.Application.ActorOperations.DeleteActor;
using Webapi.Application.ActorOperations.GetActorDetail;
using Webapi.Application.ActorOperations.UpdateActor;
using WebApi.Application.ActorOperations.CreateActor;
using WebApi.Application.ActorOperations.DeleteActor;
using WebApi.Application.ActorOperations.GetActor;
using WebApi.Application.ActorOperations.GetActorDetail;
using WebApi.Application.ActorOperations.UpdateActor;
using WebApi.DBOperations;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class ActorController : ControllerBase
    {
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;
        public ActorController(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult GetActors()
        {
            GetActorQuery query = new GetActorQuery(_context,_mapper);
            var obj = query.Handle();
            return Ok(obj);

        }
        [HttpGet("id")]
        public ActionResult GetActorDetail(int id)
        {
            GetActorDetailQuery query = new GetActorDetailQuery(_context,_mapper);
            query.actorId = id;
            GetActorDetailValidator validator = new GetActorDetailValidator();
            validator.ValidateAndThrow(query);

            var obj = query.Handle();
            return Ok(obj);

        }
        [HttpPost]
        public IActionResult AddActor([FromBody] CreateActorModel newActor)
        {
            CreateActorCommand command = new CreateActorCommand(_context,_mapper);
            command.Model = newActor;
            CreateActorValidator validator = new CreateActorValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
            return Ok();

        }
        [HttpPut("id")]
        public IActionResult UpdateActor(int id , [FromBody] UpdateActorModel updateActor)
        {
            UpdateActorCommand command = new UpdateActorCommand(_context,_mapper);
            command.actorId = id;
            command.Model = updateActor;

            UpdateActorValidator validator = new UpdateActorValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
            return Ok();
        }
        [HttpDelete("id")]
        public IActionResult DeleteActor(int id)
        {
            DeleteActorCommand command = new DeleteActorCommand(_context);
            command.actorId = id;
            DeleteActorValidator validator = new DeleteActorValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
            return Ok();
        }



    }
}