using AutoMapper;
using WebApi.DBOperations;

namespace WebApi.Application.CustomerOperations.GetCustomer
{
    public class GetCustomerQuery
    {
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;
        public GetCustomerQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<CustomerViewModel> Handle()
        {
            var customers = _context.Customers.OrderBy(X => X.id);
            List<CustomerViewModel> returnobj = _mapper.Map<List<CustomerViewModel>>(customers);
            return returnobj;
        }
    }
    public class CustomerViewModel
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int favoriteGenreId { get; set; }

    }

}