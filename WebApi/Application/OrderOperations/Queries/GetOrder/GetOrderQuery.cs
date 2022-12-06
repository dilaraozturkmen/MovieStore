using AutoMapper;
using WebApi.DBOperations;

namespace WebApi.Application.OrderOperations.GetOrder
{
    public class GetDetailOrderQuery
    {
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;
        public GetDetailOrderQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<OrderViewModel> Handle()
        {
            var orders = _context.Directors.OrderBy(X => X.id);
            List<OrderViewModel> returnobj = _mapper.Map<List<OrderViewModel>>(orders);
            return returnobj;
        }
    }
    public class OrderViewModel
    {
        public int customerId { get; set; }
        public int movieId { get; set; }
      

    }

}