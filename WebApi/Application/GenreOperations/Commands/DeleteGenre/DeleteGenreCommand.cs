using AutoMapper;
using WebApi.DBOperations;

namespace WebApi.Application.GenreOperations.DeleteGenre
{
    public class DeleteGenreCommand
    {

        public readonly IMovieStoreDbContext _context;
        public int genreId;
        public DeleteGenreCommand(IMovieStoreDbContext context)
        {
            _context = context;
        }
        public void Handle()
        {
            var genre= _context.Genres.SingleOrDefault(x => x.id == genreId);
            if(genre is null)
                throw new InvalidOperationException("Kayıt bulunamadı");
            _context.Genres.Remove(genre);
            _context.SaveChanges();

        }
    }
}