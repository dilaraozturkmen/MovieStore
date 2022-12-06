using AutoMapper;
using WebApi.DBOperations;
using WebApi.Entities;

namespace WebApi.Application.DirectorOperations.CreateDirector{
    public class CreateDirectorCommand
    {
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;
        public CreateDirectorModel Model;
        public CreateDirectorCommand(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public void Handle()
        {
            var director = _context.Directors.SingleOrDefault(x => x.name == Model.name && x.surname == Model.surname );
      
            if(director is not null)
                throw new InvalidOperationException("bu yönetmen zaten mevcut");
            director= _mapper.Map<Director>(Model);
            _context.Directors.Add(director);
            _context.SaveChanges();
        }
    }
    public class CreateDirectorModel
{
        public string name { get; set; }
        public string surname { get; set; }
  

    }

}