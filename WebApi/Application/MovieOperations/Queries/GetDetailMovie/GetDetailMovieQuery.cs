using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApi.DBOperations;

namespace WebApi.Application.MovieOperations.GetDetailMovie
{
    public class GetDetailMovieQuery
    {
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;
        public int movieId;
        public GetDetailMovieQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<MovieDetailViewModel> Handle()
        {
            var movie = _context.actorMovies.Include(x =>x.Actor).Include(x => x.Movie).Where(x=> x.movieId == movieId);
            if (movie is null)
                throw new InvalidOperationException(" Oyuncu bulanamadı");
          
            List<MovieDetailViewModel> vm =_mapper.Map<List<MovieDetailViewModel>>(movie);
            return vm;

        }
    }
    public class MovieDetailViewModel
    {
        public string Actor { get; set; }
        public string Movie { get; set; }
    }
}