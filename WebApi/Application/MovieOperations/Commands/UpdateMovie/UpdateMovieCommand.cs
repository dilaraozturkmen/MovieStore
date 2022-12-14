using AutoMapper;
using WebApi.DBOperations;
using WebApi.Entities;

namespace WebApi.Application.MovieOperations.UpdateMovie{
    public class UpdateMovieCommand
    {
        public readonly IMovieStoreDbContext _context;
        public UpdateMovieModel Model;
        public int movieId;
        public readonly IMapper _mapper;
        public UpdateMovieCommand( IMovieStoreDbContext context ,IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }
        public void Handle(){
            var movie = _context.Movies.SingleOrDefault(x=> x.id == movieId );
            if(movie is null)
                throw new InvalidOperationException("kayıt bulunamadı");
            _mapper.Map(Model ,movie);
            _context.SaveChanges();
        }

    }
    public class UpdateMovieModel
    {
        public string name { get; set; }
        public double price { get; set; } 
        public int genreId  { get; set; }
        public int directorId { get; set; }
    }
}