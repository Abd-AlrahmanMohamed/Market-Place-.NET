namespace Handler.MediatorHandler.MediatorQueryHandler.Carts
{
    public class CartQueryHandler : IRequestHandler<GetAllCartsQuery, IEnumerable<Cart>>,
        IRequestHandler<GetCartByIdQuery, Cart>
    {
        private readonly IUnityOfWork _unityOfWork;

        public CartQueryHandler(IUnityOfWork unityOfWork)
        {
            _unityOfWork = unityOfWork;
        }

        public async Task<IEnumerable<Cart>> Handle(GetAllCartsQuery request, CancellationToken cancellationToken)
        {
            return await _unityOfWork.Repository<Cart>().GetAllAsync();

        }

        public async Task<Cart> Handle(GetCartByIdQuery request, CancellationToken cancellationToken)
        {
            return await _unityOfWork.Repository<Cart>().GetByidAsync(request.Id);
        }
    }
}
