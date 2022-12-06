using AutoMapper;
using WebApi.DBOperations;

namespace WebApi.Application.GetGenre
{
    public class GetGenre
    {
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;
        public GetGenre(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<GenreViewModel> Handle()
        {
            var genres = _context.Directors.OrderBy(X => X.id);
            List<GenreViewModel> returnobj = _mapper.Map<List<GenreViewModel>>(genres);
            return returnobj;
        }
    }
    public class GenreViewModel
    {
        public string name { get; set; }
        
      

    }

}