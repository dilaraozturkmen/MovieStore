using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Webapi.Application.MovieOperations.CreateMovie;
using Webapi.Application.MovieOperations.DeleteMovie;
using Webapi.Application.MovieOperations.GetDetailMovie;
using Webapi.Application.MovieOperations.UpdateMovie;
using WebApi.Application.MovieOperations.CreateMovie;
using WebApi.Application.MovieOperations.DeleteMovie;
using WebApi.Application.MovieOperations.GetDetailMovie;
using WebApi.Application.MovieOperations.GetMovie;
using WebApi.Application.MovieOperations.UpdateMovie;
using WebApi.DBOperations;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class MovieController : ControllerBase
    {
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;
        public MovieController(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult GetMovies()
        {
            GetMovieQuery query = new GetMovieQuery(_context,_mapper);
            var obj = query.Handle();
            return Ok(obj);

        }
        [HttpGet("id")]
        public ActionResult GetMovieDetail(int id)
        {
            GetDetailMovieQuery query = new GetDetailMovieQuery(_context,_mapper);
            query.movieId = id;
            GetDetailMovieValidator validator = new GetDetailMovieValidator();
            validator.ValidateAndThrow(query);

            var obj = query.Handle();
            return Ok(obj);

        }
        [HttpPost]
        public IActionResult AddMovie([FromBody] CreateMovieModel newMovie)
        {
            CreateMovieCommand command = new CreateMovieCommand(_context,_mapper);
            command.Model = newMovie;
            CreateMovieValidator validator = new CreateMovieValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
            return Ok();

        }
        [HttpPut("id")]
        public IActionResult UpdateMovie(int id , [FromBody] UpdateMovieModel updateMovie)
        {
            UpdateMovieCommand command = new UpdateMovieCommand(_context,_mapper);
            command.movieId = id;
            command.Model = updateMovie;

            UpdateMovieValidator validator = new UpdateMovieValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
            return Ok();
        }
        [HttpDelete("id")]
        public IActionResult DeleteMovie(int id)
        {
            DeleteMovieCommand command = new DeleteMovieCommand(_context);
            command.movieId = id;
            DeleteMovieValidator validator = new DeleteMovieValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
            return Ok();
        }
        
        

    }
}