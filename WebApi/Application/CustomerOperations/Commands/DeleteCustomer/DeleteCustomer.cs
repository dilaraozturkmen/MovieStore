using AutoMapper;
using WebApi.DBOperations;

namespace WebApi.Application.DeleteCustomer
{
    public class DeleteCustomer
    {

        public readonly IMovieStoreDbContext _context;
        public int customerId;
        public DeleteCustomer(IMovieStoreDbContext context)
        {
            _context = context;
        }
        public void Handle()
        {
            var customer= _context.Customers.SingleOrDefault(x => x.id == customerId);
            if(customer is not null)
                throw new InvalidOperationException("Kayıt bulunamadı");
            _context.Customers.Remove(customer);
            _context.SaveChanges();

        }
    }
}