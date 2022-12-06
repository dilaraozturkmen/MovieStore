using AutoMapper;
using WebApi.DBOperations;
using WebApi.Entities;

namespace WebApi.Application.CustomerOperations.CreateCustomer{
    public class CreateCustomerCommand
    {
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;
        public CreateCustomerModel Model;
        public CreateCustomerCommand(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public void Handle()
        {
            var customer = _context.Customers.SingleOrDefault(x => x.name == Model.name && x.surname == Model.surname);
      
            if(customer is not null)
                throw new InvalidOperationException("customer zaten mevcut");
            customer = _mapper.Map<Customer>(Model);
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }
    }
    public class CreateCustomerModel
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int favoriteGenreId { get; set; }

    }

}