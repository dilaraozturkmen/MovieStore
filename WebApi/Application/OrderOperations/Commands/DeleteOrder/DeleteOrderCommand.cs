using WebApi.DBOperations;

namespace WebApi.Application.OrderOperations.DeleteOrder
{
    public class DeleteOrderCommand
    {

        public readonly IMovieStoreDbContext _context;
        public int orderId;
        public DeleteOrderCommand(IMovieStoreDbContext context)
        {
            _context = context;
        }
        public void Handle()
        {
            var order= _context.Orders.SingleOrDefault(x => x.id == orderId);
            if(order is null)
                throw new InvalidOperationException("Kayıt bulunamadı");
            _context.Orders.Remove(order);
            _context.SaveChanges();

        }
    }
}