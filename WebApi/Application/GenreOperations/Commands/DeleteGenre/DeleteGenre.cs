using AutoMapper;
using WebApi.DBOperations;

namespace WebApi.Application.DeleteGenre
{
    public class DeleteGenre
    {

        public readonly IMovieStoreDbContext _context;
        public int genreId;
        public DeleteGenre(IMovieStoreDbContext context)
        {
            _context = context;
        }
        public void Handle()
        {
            var genre= _context.Genres.SingleOrDefault(x => x.id == genreId);
            if(genre is not null)
                throw new InvalidOperationException("Kayıt bulunamadı");
            _context.Genres.Remove(genre);
            _context.SaveChanges();

        }
    }
}