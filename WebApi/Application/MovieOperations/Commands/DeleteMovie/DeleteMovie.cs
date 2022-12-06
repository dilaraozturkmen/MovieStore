using WebApi.DBOperations;

namespace WebApi.Application.DeleteMovie
{
    public class DeleteMovie
    {

        public readonly IMovieStoreDbContext _context;
        public int movieId;
        public DeleteMovie(IMovieStoreDbContext context)
        {
            _context = context;
        }
        public void Handle()
        {
            var movie= _context.Movies.SingleOrDefault(x => x.id == movieId);
            if(movie is not null)
                throw new InvalidOperationException("Kayıt bulunamadı");
            _context.Movies.Remove(movie);
            _context.SaveChanges();

        }
    }
}