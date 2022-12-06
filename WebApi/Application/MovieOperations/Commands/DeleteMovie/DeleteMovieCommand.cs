using WebApi.DBOperations;

namespace WebApi.Application.MovieOperations.DeleteMovie
{
    public class DeleteMovieCommand
    {

        public readonly IMovieStoreDbContext _context;
        public int movieId;
        public DeleteMovieCommand(IMovieStoreDbContext context)
        {
            _context = context;
        }
        public void Handle()
        {
            var movie= _context.Movies.SingleOrDefault(x => x.id == movieId);
            if(movie is null)
                throw new InvalidOperationException("Kayıt bulunamadı");
            _context.Movies.Remove(movie);
            _context.SaveChanges();

        }
    }
}