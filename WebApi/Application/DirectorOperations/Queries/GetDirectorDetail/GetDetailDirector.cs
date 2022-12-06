using AutoMapper;
using WebApi.DBOperations;

namespace WebApi.Application.GetDirectorDetail
{
    public class GetDetailDirector
    {
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;
        public int directorId;
        public GetDetailDirector(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public DirectorDetailViewModel Handle()
        {
            var director = _context.Directors.SingleOrDefault(x=> x.id == directorId);
            if (director is null)
                throw new InvalidOperationException("Yönetmen bulanamadı");
          
            DirectorDetailViewModel vm =_mapper.Map<DirectorDetailViewModel>(director);
            return vm;

        }
    }
    public class DirectorDetailViewModel
    {
        public string name { get; set; }
        public string surname { get; set; }
        
    }
}