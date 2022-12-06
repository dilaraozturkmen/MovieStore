using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApi.DBOperations;

namespace WebApi.Application.OrderOperations.GetDetailOrder
{
    public class GetDetailOrderQuery
    {
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;
        public int customerId;
        public GetDetailOrderQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<OrderDetailViewModel> Handle()
        {
            var order = _context.Orders.Include(x => x.Customer).Include(x => x.Movie).Where(x=> x.customerId == customerId );
            if (order is null)
                throw new InvalidOperationException(" Sipariş bulanamadı");
          
            List<OrderDetailViewModel> vm =_mapper.Map<List<OrderDetailViewModel>>(order);
            return vm;

        }
    }
    public class OrderDetailViewModel
    {
        public string Customer { get; set; }
        public string Movie { get; set; }
    }
}