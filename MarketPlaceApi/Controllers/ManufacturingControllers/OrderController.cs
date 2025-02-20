namespace CQRSWebApi.Controllers.ManfacturingControllers
{
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //[Authorize(Roles = "Admin")]
        [HttpGet(Router.Order.GetOrderById)]
        public async ValueTask<Order> GetByIdAsync(int id)
        {
            var order = new GetOrderByIdQuery(id);
            return await _mediator.Send(order);
        }
        //[Authorize(Roles = "Admin")]
        [HttpGet(Router.Order.GetAllOrders)]
        public async ValueTask<IEnumerable<Order>> GetAllAsync()
        {
            var order = new GetAllOrdersQuery();
            return await _mediator.Send(order);
        }
        //[Authorize(Roles = "User")]
        [HttpPost(Router.Order.AddOrder)]

        public async ValueTask<Order> AddAsync(OrderDto orderDto)
        {
            var order = new AddOrderCommand(orderDto);
            return await _mediator.Send(order);
        }
        //[Authorize(Roles = "User")]
        [HttpPut(Router.Order.UpdateOrder)]

        public async ValueTask<Order> UpdateAsync(OrderDto ordeDto)
        {
            var order = new UpdateOrderCommand(ordeDto);
            return await _mediator.Send(order);
        }

        [HttpDelete(Router.Order.DeleteOrder)]

        public async ValueTask<Order> DeleteAsync(int id)
        {
            var order = new DeleteOrderCommand(id);
            return await _mediator.Send(order);
        }

    }
}
