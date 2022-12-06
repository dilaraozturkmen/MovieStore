using AutoMapper;
using WebApi.DBOperations;

namespace WebApi.Application.OrderOperations.GetDetailOrder
{
    public class GetDetailOrderQuery
    {
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;
        public int orderId;
        public GetDetailOrderQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public OrderDetailViewModel Handle()
        {
            var order = _context.Orders.SingleOrDefault(x=> x.id == orderId);
            if (order is null)
                throw new InvalidOperationException(" Sipariş bulanamadı");
          
            OrderDetailViewModel vm =_mapper.Map<OrderDetailViewModel>(order);
            return vm;

        }
    }
    public class OrderDetailViewModel
    {
        public int customerId { get; set; }
        public int movieId { get; set; }
    }
}