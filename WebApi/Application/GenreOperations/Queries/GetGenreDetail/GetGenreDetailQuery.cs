using AutoMapper;
using WebApi.DBOperations;

namespace WebApi.Application.GenreOperations.GetGenreDetail
{
    public class GetGenreDetailQuery
    {
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;
        public int genreId;
        public GetGenreDetailQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public GenreDetailViewModel Handle()
        {
            var genre = _context.Genres.SingleOrDefault(x=> x.id == genreId);
            if (genre is null)
                throw new InvalidOperationException("Yönetmen bulanamadı");
          
            GenreDetailViewModel vm =_mapper.Map<GenreDetailViewModel>(genre);
            return vm;

        }
    }
    public class GenreDetailViewModel
    {
        public string name { get; set; }
    }
}