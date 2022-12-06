using WebApi.DBOperations;

namespace WebApi.Application.DeleteOrder
{
    public class DeleteOrder
    {

        public readonly IMovieStoreDbContext _context;
        public int orderId;
        public DeleteOrder(IMovieStoreDbContext context)
        {
            _context = context;
        }
        public void Handle()
        {
            var order= _context.Orders.SingleOrDefault(x => x.id == orderId);
            if(order is not null)
                throw new InvalidOperationException("Kayıt bulunamadı");
            _context.Orders.Remove(order);
            _context.SaveChanges();

        }
    }
}