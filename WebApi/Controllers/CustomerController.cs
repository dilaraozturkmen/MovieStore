using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Webapi.Application.CustomerOperations.CreateCustomer;
using Webapi.Application.CustomerOperations.DeleteCustomer;
using Webapi.Application.CustomerOperations.GetCustomerDetail;
using Webapi.Application.CustomerOperations.UpdateCustomer;
using WebApi.Application.CustomerOperations.CreateCustomer;
using WebApi.Application.CustomerOperations.DeleteCustomer;
using WebApi.Application.CustomerOperations.GetCustomer;
using WebApi.Application.CustomerOperations.GetCustomerDetail;
using WebApi.Application.CustomerOperations.UpdateCustomer;
using WebApi.DBOperations;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class CustomerController : ControllerBase
    {
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;
        public CustomerController(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult GetCustomers()
        {
            GetCustomerQuery query = new GetCustomerQuery(_context,_mapper);
            var obj = query.Handle();
            return Ok(obj);

        }
        [HttpGet("id")]
        public ActionResult GetCustomerDetail(int id)
        {
            GetCustomerDetailQuery query = new GetCustomerDetailQuery(_context,_mapper);
            query.customerId = id;
            GetCustomerDetailValidator validator = new GetCustomerDetailValidator();
            validator.ValidateAndThrow(query);

            var obj = query.Handle();
            return Ok(obj);

        }
        [HttpPost]
        public IActionResult AddCustomer([FromBody] CreateCustomerModel newCustomer)
        {
            CreateCustomerCommand command = new CreateCustomerCommand(_context,_mapper);
            command.Model = newCustomer;
            CreateCustomerValidator validator = new CreateCustomerValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
            return Ok();

        }
        [HttpPut("id")]
        public IActionResult UpdateCustomer(int id , [FromBody] UpdateCustomerModel updateCustomer)
        {
            UpdateCustomerCommand command = new UpdateCustomerCommand(_context,_mapper);
            command.customerId = id;
            command.Model = updateCustomer;

            UpdateCustomerValidator validator = new UpdateCustomerValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
            return Ok();
        }
        [HttpDelete("id")]
        public IActionResult DeleteCustomer(int id)
        {
            DeleteCustomerCommand command = new DeleteCustomerCommand(_context);
            command.customerId = id;
            DeleteCustomerValidator validator = new DeleteCustomerValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
            return Ok();
        }
        

    }
}