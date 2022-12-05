namespace WebApi.Entities
{
    public class Actor_Movie
    {
        public int id { get; set; }
        public int actorId { get; set; }
        public Actor actor{ get; set; }
        
        public int movieId { get; set; }
        public Movie movie { get; set; }
    }
}