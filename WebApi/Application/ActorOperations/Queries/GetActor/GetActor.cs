using AutoMapper;
using WebApi.DBOperations;

namespace WebApi.Application.GetActor
{
    public class GetActor
    {
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;
        public GetActor(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<ActorViewModel> Handle()
        {
            var actors = _context.Actors.OrderBy(X => X.id);
            List<ActorViewModel> returnobj = _mapper.Map<List<ActorViewModel>>(actors);
            return returnobj;
        }
    }
    public class ActorViewModel
    {
        public string name { get; set; }
        public string surname { get; set; }

    }

}