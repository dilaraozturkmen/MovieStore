using AutoMapper;
using WebApi.DBOperations;
using WebApi.Entities;

namespace WebApi.Application.OrderOperations.CreateOrder{
    public class CreateOrderCommand
    {
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;
        public CreateOrderModel Model;
        public CreateOrderCommand(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public void Handle()
        {
            var order = _context.Orders.SingleOrDefault(x => x.customerId == Model.customerId && x.movieId == Model.movieId );
      
            if(order is not null)
                throw new InvalidOperationException("bu ürün zaten önceden alınmış");
            order = _mapper.Map<Order>(Model);
            _context.Orders.Add(order);
            _context.SaveChanges();
        }
    }
    public class CreateOrderModel
{
        public int customerId { get; set; }
        public int movieId { get; set; }
  

    }

}