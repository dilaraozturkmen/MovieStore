namespace WebApi.Entities
{
    public class Order
    {
        public int id { get; set; }
        public int customerId { get; set; }
        public Customer customer { get; set; }
        public int movieId { get; set; }
        public Movie movie { get; set; }
        
    }
}