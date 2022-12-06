using AutoMapper;
using WebApi.DBOperations;
using WebApi.Entities;

namespace WebApi.Application.CreateMovie{
    public class CreateMovie
    {
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;
        public CreateMovieModel Model;
        public CreateMovie(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public void Handle()
        {
            var movie = _context.Movies.SingleOrDefault(x => x.name == Model.name );
      
            if(movie is not null)
                throw new InvalidOperationException("bu tür zaten mevcut");
            movie = _mapper.Map<Movie>(Model);
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }
    }
    public class CreateMovieModel
{
        public string name { get; set; }
        public double price { get; set; } 
        public int genreId  { get; set; }
        public int directorId { get; set; }
  

    }

}