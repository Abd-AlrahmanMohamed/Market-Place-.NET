
namespace Handler.MediatorHandler.MediatorQueryHandler.Orders
{
    public class OrderQueryHandler : IRequestHandler<GetAllOrdersQuery, IEnumerable<Order>>,
        IRequestHandler<GetOrderByIdQuery, Order>
    {
        private readonly IUnityOfWork _unityOfWork;
        public OrderQueryHandler(IUnityOfWork unityOfWork)
        {
            _unityOfWork = unityOfWork;
        }
        public async Task<IEnumerable<Order>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
        {
            return await _unityOfWork.Repository<Order>().GetAllAsync();
        }

        public async Task<Order> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
        {
            return await _unityOfWork.Repository<Order>().GetByidAsync(request.Id);
        }
    }
}
