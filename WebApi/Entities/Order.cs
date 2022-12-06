namespace WebApi.Entities
{
    public class Order
    {
        public int id { get; set; }
        public int customerId { get; set; }
        public Customer Customer { get; set; }
        public int movieId { get; set; }
        public Movie Movie { get; set; }
        
    }
}