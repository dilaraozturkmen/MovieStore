using AutoMapper;
using WebApi.DBOperations;

namespace WebApi.Application.GetGenreDetail
{
    public class GetGenreDetail
    {
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;
        public int genreId;
        public GetGenreDetail(IMovieStoreDbContext context, IMapper mapper)
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