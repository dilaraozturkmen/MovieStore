using AutoMapper;
using WebApi.DBOperations;

namespace WebApi.Application.GetDetailMovie
{
    public class GetDetailMovie
    {
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;
        public int movieId;
        public GetDetailMovie(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public MovieDetailViewModel Handle()
        {
            var movie = _context.actorMovies.SingleOrDefault(x=> x.id == movieId);
            if (movie is null)
                throw new InvalidOperationException(" Oyuncu bulanamadı");
          
            MovieDetailViewModel vm =_mapper.Map<MovieDetailViewModel>(movie);
            return vm;

        }
    }
    public class MovieDetailViewModel
    {
        public string name { get; set; }
        public double price { get; set; } 
        public int genreId  { get; set; }
        public int directorId { get; set; }
    }
}