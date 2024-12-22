namespace Handler.MediatorHandler.MediatorCommandHndler.CustomProducts
{
    public class CustomProductCommandHandler : IRequestHandler<AddCustomProductCommand, CustomProduct>,
        IRequestHandler<UpdateCustomProductCommand, CustomProduct>, IRequestHandler<DeleteCustomProductCommand, CustomProduct>
    {

        private readonly IUnityOfWork _unityOfWork;
        private readonly IMapper _mapper;
        public CustomProductCommandHandler(IUnityOfWork unityOfWork, IMapper mapper)
        {
            _unityOfWork = unityOfWork;
            _mapper = mapper;
        }
        public async Task<CustomProduct> Handle(AddCustomProductCommand request, CancellationToken cancellationToken)
        {
            var customProduct = _mapper.Map<CustomProduct>(request);
            customProduct.Image = await ImageHandler.ImageConverterAsync(request.Image);
            await _unityOfWork.Repository<CustomProduct>().AddAsync(customProduct);
            await _unityOfWork.Complete();
            return customProduct;
        }

        public async Task<CustomProduct> Handle(UpdateCustomProductCommand request, CancellationToken cancellationToken)
        {
            var find = await _unityOfWork.Repository<CustomProduct>().GetByidAsync(request.Id);
            var customProduct = _mapper.Map(request, find);
            customProduct.Image = await ImageHandler.ImageConverterAsync(request.Image);
            await _unityOfWork.Repository<CustomProduct>().UpdateAsync(customProduct);
            await _unityOfWork.Complete();
            return customProduct;
        }

        public async Task<CustomProduct> Handle(DeleteCustomProductCommand request, CancellationToken cancellationToken)
        {
            var find = await _unityOfWork.Repository<CustomProduct>().GetByidAsync(request.Id);
            await _unityOfWork.Repository<CustomProduct>().DeleteAsync(request.Id);
            await _unityOfWork.Complete();
            return find;
        }
    }
}
