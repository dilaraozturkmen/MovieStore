using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApi.DBOperations;

namespace WebApi.Application.ActorOperations.GetActorDetail
{
    public class GetActorDetailQuery
    {
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;
        public int actorId;
        public GetActorDetailQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public ActorDetailViewModel Handle()
        {
            var actor = _context.actorMovies.Include(x => x.Actor).Include(x => x.Movie).Where(x=> x.actorId == actorId).SingleOrDefault();
            
            if (actor is null)
                throw new InvalidOperationException(" Oyuncu bulanamadı");
          
            ActorDetailViewModel vm =_mapper.Map<ActorDetailViewModel>(actor);

            return vm;
            
        }
    }
    public class ActorDetailViewModel
    {
       
        public int id { get; set; }
        public string Actor{ get; set; }
        public string Movie { get; set; }
    }
}
