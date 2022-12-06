using AutoMapper;
using WebApi.DBOperations;
using WebApi.Entities;

namespace WebApi.Application.UpdateCustomer{
    public class UpdateCustomer
    {
        public readonly IMovieStoreDbContext _context;
        public UpdateCustomerModel Model;
        public int customerId;
        public readonly IMapper _mapper;
        public UpdateCustomer(IMapper mapper, IMovieStoreDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public void Handle(){
            var customer = _context.Actors.SingleOrDefault(x=> x.id == customerId );
            if(customer is null)
                throw new InvalidOperationException("kayıt bulunamadı");
            _mapper.Map(Model ,customer);
            _context.SaveChanges();
        }

    }
    public class UpdateCustomerModel
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int favoriteGenreId { get; set; }
    }
}