using AutoMapper;
using WebApi.DBOperations;

namespace WebApi.Application.GetCustomerDetail
{
    public class GetCustomerDetail
    {
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;
        public int customerId;
        public GetCustomerDetail(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public CustomerDetailViewModel Handle()
        {
            var customer = _context.Customers.SingleOrDefault(x=> x.id == customerId);
            if (customer is null)
                throw new InvalidOperationException("Müşteri bulanamadı");
          
            CustomerDetailViewModel vm =_mapper.Map<CustomerDetailViewModel>(customer);
            return vm;

        }
    }
    public class CustomerDetailViewModel
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int favoriteGenreId { get; set; }
    }
}