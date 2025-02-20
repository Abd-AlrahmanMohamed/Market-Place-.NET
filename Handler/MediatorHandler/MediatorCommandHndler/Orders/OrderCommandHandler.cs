namespace Handler.MediatorHandler.MediatorCommandHndler.Orders
{
    public class OrderCommandHandler : IRequestHandler<AddOrderCommand, Order>,
        IRequestHandler<UpdateOrderCommand, Order>, IRequestHandler<DeleteOrderCommand, Order>
    {

        private readonly IUnityOfWork _unityOfWork;
        private readonly IMapper _mapper;
        public OrderCommandHandler(IUnityOfWork unityOfWork, IMapper mapper)
        {
            _unityOfWork = unityOfWork;
            _mapper = mapper;
        }
        public async Task<Order> Handle(AddOrderCommand request, CancellationToken cancellationToken)
        {
            var order = _mapper.Map<Order>(request);
            await _unityOfWork.Repository<Order>().AddAsync(order);
            await _unityOfWork.Complete();
            return order;
        }

        public async Task<Order> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
        {
            var find = await _unityOfWork.Repository<Order>().GetByidAsync(request.Id);
            var order = _mapper.Map(request, find);
            await _unityOfWork.Repository<Order>().UpdateAsync(order);
            await _unityOfWork.Complete();
            return order;
        }

        public async Task<Order> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
        {
            var find = await _unityOfWork.Repository<Order>().GetByidAsync(request.Id);
            await _unityOfWork.Repository<Order>().DeleteAsync(request.Id);
            await _unityOfWork.Complete();
            return find;
        }
    }
}
