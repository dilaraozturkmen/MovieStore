using AutoMapper;
using WebApi.DBOperations;

namespace WebApi.Application.DeleteActor
{
    public class DeleteActor
    {

        public readonly IMovieStoreDbContext _context;
        public int actorId;
        public DeleteActor(IMovieStoreDbContext context)
        {
            _context = context;
        }
        public void Handle()
        {
            var actor = _context.Actors.SingleOrDefault(x => x.id == actorId);
            if(actor is not null)
                throw new InvalidOperationException("Kayıt bulunamadı");
            _context.Actors.Remove(actor);
            _context.SaveChanges();

        }
    }
}