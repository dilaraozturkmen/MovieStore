using AutoMapper;
using WebApi.DBOperations;
using WebApi.Entities;

namespace WebApi.Application.UpdateActor{
    public class UpdateActor
    {
        public readonly IMovieStoreDbContext _context;
        public UpdateActorModel Model;
        public int actorId;
        public readonly IMapper _mapper;
        public UpdateActor(IMapper mapper, IMovieStoreDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public void Handle(){
            var actor = _context.Actors.SingleOrDefault(x=> x.id == actorId );
            if(actor is null)
                throw new InvalidOperationException("kayıt bulunamadı");
            _mapper.Map(Model , actor);
            _context.SaveChanges();
        }

    }
    public class UpdateActorModel
    {
        public string name { get; set; }
        public string surname { get; set; }
    }
}