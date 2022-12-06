using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Webapi.Application.CustomerOperations.UpdateCustomer;
using Webapi.Application.DirectorOperations.CreateDirector;
using Webapi.Application.DirectorOperations.DeleteDirector;
using Webapi.Application.DirectorOperations.GetDetailDirector;
using WebApi.Application.DirectorOperations.CreateDirector;
using WebApi.Application.DirectorOperations.DeleteDirector;
using WebApi.Application.DirectorOperations.GetDirector;
using WebApi.Application.DirectorOperations.GetDirectorDetail;
using WebApi.Application.DirectorOperations.UpdateDirector;
using WebApi.DBOperations;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class DirectorController : ControllerBase
    {
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;
        public DirectorController(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult GetDirectors()
        {
            GetDirectorQuery query = new GetDirectorQuery(_context,_mapper);
            var obj = query.Handle();
            return Ok(obj);

        }
        [HttpGet("id")]
        public ActionResult GetDirectorDetail(int id)
        {
            GetDetailDirectorQuery query = new GetDetailDirectorQuery(_context,_mapper);
            query.directorId = id;
            GetDetailDirectorValidator validator = new GetDetailDirectorValidator();
            validator.ValidateAndThrow(query);

            var obj = query.Handle();
            return Ok(obj);

        }
        [HttpPost]
        public IActionResult AddDirector([FromBody] CreateDirectorModel newDirector)
        {
            CreateDirectorCommand command = new CreateDirectorCommand(_context,_mapper);
            command.Model = newDirector;
            CreateDirectorValidator validator = new CreateDirectorValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
            return Ok();

        }
        [HttpPut("id")]
        public IActionResult UpdateDirector(int id , [FromBody] UpdateDirectorModel updateDirector)
        {
            UpdateDirectorCommand command = new UpdateDirectorCommand(_context,_mapper);
            command.directorId = id;
            command.Model = updateDirector;

            UpdateDirectorValidator validator = new UpdateDirectorValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
            return Ok();
        }
        [HttpDelete("id")]
        public IActionResult DeleteDirector(int id)
        {
            DeleteDirectorCommand command = new DeleteDirectorCommand(_context);
            command.directorId = id;
            DeleteDirectorValidator validator = new DeleteDirectorValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
            return Ok();
        }
        

    }
}