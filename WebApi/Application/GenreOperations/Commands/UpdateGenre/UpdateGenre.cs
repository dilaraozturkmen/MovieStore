using AutoMapper;
using WebApi.DBOperations;
using WebApi.Entities;

namespace WebApi.Application.UpdateGenre{
    public class UpdateGenre
    {
        public readonly IMovieStoreDbContext _context;
        public UpdateGenreModel Model;
        public int genreId;
        public readonly IMapper _mapper;
        public UpdateGenre(IMapper mapper, IMovieStoreDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public void Handle(){
            var genre = _context.Genres.SingleOrDefault(x=> x.id == genreId );
            if(genre is null)
                throw new InvalidOperationException("kayıt bulunamadı");
            _mapper.Map(Model ,genre);
            _context.SaveChanges();
        }

    }
    public class UpdateGenreModel
    {
        public string name { get; set; }
    }
}