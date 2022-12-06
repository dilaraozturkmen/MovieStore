using AutoMapper;
using WebApi.DBOperations;

namespace WebApi.Application.GetDirector
{
    public class GetDirector
    {
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;
        public GetDirector(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<DirectorViewModel> Handle()
        {
            var directors = _context.Directors.OrderBy(X => X.id);
            List<DirectorViewModel> returnobj = _mapper.Map<List<DirectorViewModel>>(directors);
            return returnobj;
        }
    }
    public class DirectorViewModel
    {
        public string name { get; set; }
        public string surname { get; set; }
      

    }

}