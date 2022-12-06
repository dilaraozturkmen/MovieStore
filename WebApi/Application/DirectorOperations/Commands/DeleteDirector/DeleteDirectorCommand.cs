using AutoMapper;
using WebApi.DBOperations;

namespace WebApi.Application.DirectorOperations.DeleteDirector
{
    public class DeleteDirectorCommand
    {

        public readonly IMovieStoreDbContext _context;
        public int directorId;
        public DeleteDirectorCommand(IMovieStoreDbContext context)
        {
            _context = context;
        }
        public void Handle()
        {
            var director= _context.Directors.SingleOrDefault(x => x.id == directorId);
            if(director is not null)
                throw new InvalidOperationException("Kayıt bulunamadı");
            _context.Directors.Remove(director);
            _context.SaveChanges();

        }
    }
}