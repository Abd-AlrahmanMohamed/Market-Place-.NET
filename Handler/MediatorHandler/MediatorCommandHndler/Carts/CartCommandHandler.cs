using Domin.Models;

namespace Handler.MediatorHandler.MediatorCommandHndler.Carts
{
    public class CartValidatorHandler : IRequestHandler<AddCartCommand, Cart>,
        IRequestHandler<UpdateCartCommand, Cart>, IRequestHandler<DeleteCartCommand, Cart>
    {

        private readonly IUnityOfWork _unityOfWork;
        private readonly IMapper _mapper;

        public CartValidatorHandler(IUnityOfWork unityOfWork, IMapper mapper)
        {
            _unityOfWork = unityOfWork;
            _mapper = mapper;
        }

        public async Task<Cart> Handle(AddCartCommand request, CancellationToken cancellationToken)
        {
            var cart = _mapper.Map<Cart>(request);
            await _unityOfWork.Repository<Cart>().AddAsync(cart);
            await  _unityOfWork.Complete();
            return cart;
            
        }

        public async Task<Cart> Handle(UpdateCartCommand request, CancellationToken cancellationToken)
        {
            var find = await _unityOfWork.Repository<Cart>().GetByidAsync(request.Id);
            
            _mapper.Map(request, find);
            await _unityOfWork.Repository<Cart>().UpdateAsync(find);
            await _unityOfWork.Complete();
            return find;
        }

        public async Task<Cart> Handle(DeleteCartCommand request, CancellationToken cancellationToken)
        {
            var found = await _unityOfWork.Repository<Cart>().GetByidAsync(request.Id);
            await _unityOfWork.Repository<Cart>().DeleteAsync(request.Id);
            await _unityOfWork.Complete();
            return found;
        }
    }
}
