using AutoMapper;
using WebApi.DBOperations;

namespace WebApi.Application.GetActorDetail
{
    public class GetActorDetail
    {
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;
        public int actorId;
        public GetActorDetail(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public ActorDetailViewModel Handle()
        {
            var actor = _context.actorMovies.SingleOrDefault(x=> x.id == actorId);
            if (actor is null)
                throw new InvalidOperationException(" Oyuncu bulanamadı");
          
            ActorDetailViewModel vm =_mapper.Map<ActorDetailViewModel>(actor);
            return vm;

        }
    }
    public class ActorDetailViewModel
    {
        public int actorId { get; set; }
        public int movieId { get; set; }
    }
}
