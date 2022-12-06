using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Webapi.Application.OrderOperations.GetDetailOrder;
using WebApi.Application.OrderOperations.GetDetailOrder;
using WebApi.DBOperations;
using WebApi.Application.OrderOperations.GetOrder;
using WebApi.Application.OrderOperations.CreateOrder;
using Webapi.Application.OrderOperations.CreateOrder;
using WebApi.Application.OrderOperations.UpdateOrder;
using Webapi.Application.OrderOperations.UpdateOrder;
using WebApi.Application.OrderOperations.DeleteOrder;
using Webapi.Application.OrderOperations.DeleteOrder;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class OrderController : ControllerBase
    {
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;
        public OrderController(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult GetOrders()
        {
            GetOrderQuery query = new GetOrderQuery(_context,_mapper);
            var obj = query.Handle();
            return Ok(obj);

        }
        [HttpGet("id")]
        public ActionResult GetOrderDetail(int id)
        {
            GetDetailOrderQuery query = new GetDetailOrderQuery(_context,_mapper);
            query.customerId = id;
            GetDetailOrderValidator validator = new GetDetailOrderValidator();
            validator.ValidateAndThrow(query);

            var obj = query.Handle();
            return Ok(obj);

        }
        [HttpPost]
        public IActionResult AddOrder([FromBody] CreateOrderModel newOrder)
        {
            CreateOrderCommand command = new CreateOrderCommand(_context,_mapper);
            command.Model = newOrder;
            CreateOrderValidator validator = new CreateOrderValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
            return Ok();

        }
        [HttpPut("id")]
        public IActionResult UpdateOrder(int id , [FromBody] UpdateOrderModel updateOrder)
        {
            UpdateOrderCommand command = new UpdateOrderCommand(_context,_mapper);
            command.orderId = id;
            command.Model = updateOrder;

            UpdateOrderValidator validator = new UpdateOrderValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
            return Ok();
        }
        [HttpDelete("id")]
        public IActionResult DeleteOrder(int id)
        {
            DeleteOrderCommand command = new DeleteOrderCommand(_context);
            command.orderId = id;
            DeleteOrderValidator validator = new DeleteOrderValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
            return Ok();
        }
        

    }
}