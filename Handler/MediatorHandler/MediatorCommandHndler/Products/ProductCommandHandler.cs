namespace Handler.MediatorHandler.MediatorCommandHndler.Products
{
    public class ProductCommandHandler : IRequestHandler<AddProductCommand, Product>,
        IRequestHandler<UpdateProductCommand, Product>, IRequestHandler<DeleteProductrCommand, Product>
    {
        private readonly IUnityOfWork _unityOfWork;
        private readonly IMapper _mapper;
        public ProductCommandHandler(IUnityOfWork unityOfWork, IMapper mapper)
        {
            _unityOfWork = unityOfWork;
            _mapper = mapper;
        }
        public async Task<Product> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<Product>(request);
            product.Images = await ImagesHandler.ImagesConverterAsync(request.Images);
            await _unityOfWork.Repository<Product>().AddAsync(product);
            await _unityOfWork.Complete();
            return product;
        }

        public async Task<Product> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var find = await _unityOfWork.Repository<Product>().GetByidAsync(request.Id);
            var product = _mapper.Map(request, find);
            product.Images = await ImagesHandler.ImagesConverterAsync(request.Images);
            await _unityOfWork.Repository<Product>().UpdateAsync(find);
            await _unityOfWork.Complete();
            return find;
        }
        public async Task<Product> Handle(DeleteProductrCommand request, CancellationToken cancellationToken)
        {
            var find = await _unityOfWork.Repository<Product>().GetByidAsync(request.Id);
            await _unityOfWork.Repository<Product>().DeleteAsync(request.Id);
            await _unityOfWork.Complete();
            return find;
        }
    }
}
