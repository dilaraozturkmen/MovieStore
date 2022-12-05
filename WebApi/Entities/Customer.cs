namespace WebApi.Entities
{
    public class Customer
    {
        public int id { get; set; } 
        public string name { get; set; }
        public string surname { get; set; }
        public int favoriteGenreId { get; set; }
        public Genre genre { get; set; }
        
        
    }
}