namespace WebApi.Entities
{
    public class Movie
    {
        public int id { get; set; } 
        public string name { get; set; }
        public double price { get; set; } 
        public int genreId  { get; set; }
        public Genre genre { get; set; }
        public int directorId { get; set; }
        public Director director { get; set; }
        

        
    }
}