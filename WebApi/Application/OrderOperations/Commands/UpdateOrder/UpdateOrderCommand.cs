using AutoMapper;
using WebApi.DBOperations;
using WebApi.Entities;

namespace WebApi.Application.OrderOperations.UpdateOrder{
    public class UpdateOrderCommand
    {
        public readonly IMovieStoreDbContext _context;
        public UpdateOrderModel Model;
        public int orderId;
        public readonly IMapper _mapper;
        public UpdateOrderCommand(IMapper mapper, IMovieStoreDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public void Handle(){
            var order = _context.Orders.SingleOrDefault(x=> x.id == orderId );
            if(order is null)
                throw new InvalidOperationException("kayıt bulunamadı");
            _mapper.Map(Model ,order);
            _context.SaveChanges();
        }

    }
    public class UpdateOrderModel
    {
        public int customerId { get; set; }
        public int movieId { get; set; }
    }
}