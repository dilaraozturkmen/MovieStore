using AutoMapper;
using WebApi.DBOperations;
using WebApi.Entities;

namespace WebApi.Application.DirectorOperations.UpdateDirector{
    public class UpdateDirectorCommand
    {
        public readonly IMovieStoreDbContext _context;
        public UpdateDirectorModel Model;
        public int directorId;
        public readonly IMapper _mapper;
        public UpdateDirectorCommand( IMovieStoreDbContext context ,IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }
        public void Handle(){
            var director = _context.Directors.SingleOrDefault(x=> x.id == directorId );
            if(director is null)
                throw new InvalidOperationException("kayıt bulunamadı");
            _mapper.Map(Model ,director);
            _context.SaveChanges();
        }

    }
    public class UpdateDirectorModel
    {
        public string name { get; set; }
        public string surname { get; set; }
    }
}