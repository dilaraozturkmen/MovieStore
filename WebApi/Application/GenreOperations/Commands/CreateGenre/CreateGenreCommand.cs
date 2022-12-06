using AutoMapper;
using WebApi.DBOperations;
using WebApi.Entities;

namespace WebApi.Application.GenreOperations.CreateGenre{
    public class CreateGenreCommand
    {
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;
        public CreateGenreModel Model;
        public CreateGenreCommand(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public void Handle()
        {
            var genre = _context.Genres.SingleOrDefault(x => x.Name == Model.Name );
      
            if(genre is not null)
                throw new InvalidOperationException("bu tür zaten mevcut");
            genre = _mapper.Map<Genre>(Model);
            _context.Genres.Add(genre);
            _context.SaveChanges();
        }
    }
    public class CreateGenreModel
    {
         public string Name { get; set; }

    }

}