using AutoMapper;
using WebApi.DBOperations;
using WebApi.Entities;

namespace WebApi.Application.ActorOperations.CreateActor{
    public class CreateActorCommand
    {
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;
        public CreateActorModel Model;
        public CreateActorCommand(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public void Handle()
        {
            var actor = _context.Actors.SingleOrDefault(x => x.name == Model.name && x.surname == Model.surname);
      
            if(actor is not null)
                throw new InvalidOperationException("Actor zaten mevcut");
            actor = _mapper.Map<Actor>(Model);
            _context.Actors.Add(actor);
            _context.SaveChanges();
        }
    }
    public class CreateActorModel
    {
        public string name { get; set; }
        public string surname { get; set; }

    }

}