using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Webapi.Application.GenreOperations.CreateGenre;
using Webapi.Application.GenreOperations.DeleteGenre;
using Webapi.Application.GenreOperations.UpdateGenre;
using WebApi.Application.GenreOperations.CreateGenre;
using WebApi.Application.GenreOperations.DeleteGenre;
using WebApi.Application.GenreOperations.GetGenre;
using WebApi.Application.GenreOperations.GetGenreDetail;
using WebApi.Application.GenreOperations.UpdateGenre;
using WebApi.DBOperations;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class GenreController : ControllerBase
    {
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;
        public GenreController(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult GetGenres()
        {
            GetGenreQuery query = new GetGenreQuery(_context,_mapper);
            var obj = query.Handle();
            return Ok(obj);

        }
        [HttpGet("id")]
        public ActionResult GetGenreDetail(int id)
        {
            GetGenreDetailQuery query = new GetGenreDetailQuery(_context,_mapper);
            query.genreId = id;
            GetGenreDetailValidator validator = new GetGenreDetailValidator();
            validator.ValidateAndThrow(query);

            var obj = query.Handle();
            return Ok(obj);

        }
        [HttpPost]
        public IActionResult AddGenre([FromBody] CreateGenreModel newGenre)
        {
            CreateGenreCommand command = new CreateGenreCommand(_context,_mapper);
            command.Model = newGenre;
            CreateGenreValidator validator = new CreateGenreValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
            return Ok();

        }
        [HttpPut("id")]
        public IActionResult UpdateGenre(int id , [FromBody] UpdateGenreModel updateGenre)
        {
            UpdateGenreCommand command = new UpdateGenreCommand(_context,_mapper);
            command.genreId = id;
            command.Model = updateGenre;

            UpdateGenreValidator validator = new UpdateGenreValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
            return Ok();
        }
        [HttpDelete("id")]
        public IActionResult DeleteGenre(int id)
        {
            DeleteGenreCommand command = new DeleteGenreCommand(_context);
            command.genreId = id;
            DeleteGenreValidator validator = new DeleteGenreValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
            return Ok();
        }

    }
}