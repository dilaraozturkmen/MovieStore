using WebApi.DBOperations;

namespace WebApi.Application.ActorOperations.DeleteActor
{
    public class DeleteActorCommand
    {

        public readonly IMovieStoreDbContext _context;
        public int actorId;
        public DeleteActorCommand(IMovieStoreDbContext context)
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