using AutoMapper;
using WebApi.DBOperations;

namespace WebApi.Application.GetMovie
{
    public class GetMovie
    {
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;
        public GetMovie(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<MovieViewModel> Handle()
        {
            var movies = _context.actorMovies.OrderBy(X => X.id);
            List<MovieViewModel> returnobj = _mapper.Map<List<MovieViewModel>>(movies);
            return returnobj;
        }
    }
    public class MovieViewModel
    {
        public string name { get; set; }
        public double price { get; set; } 
        public int genreId  { get; set; }
        public int directorId { get; set; }

    }

}