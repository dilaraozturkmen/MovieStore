using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApi.DBOperations;

namespace WebApi.Application.OrderOperations.GetOrder
{
    public class GetOrderQuery
    {
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;
        public GetOrderQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<OrderViewModel> Handle()
        {
            var orders = _context.Orders.Include(x => x.Customer).Include(x => x.Movie).OrderBy(X => X.id);
            List<OrderViewModel> returnobj = _mapper.Map<List<OrderViewModel>>(orders);
            return returnobj;
        }
    }
    public class OrderViewModel
    {
        public string Customer { get; set; }
        public string Movie { get; set; }
      

    }

}